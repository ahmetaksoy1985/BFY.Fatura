using BFY.Fatura.Configuration;
using BFY.Fatura.Exceptions;
using BFY.Fatura.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BFY.Fatura.Services
{
public class HttpServices<T> : IHttpServices<T>
{
    private IFaturaServiceConfiguration Configuration { get; set; }

    public HttpServices(IFaturaServiceConfiguration configuration)
    {
        Configuration = configuration;
        if(configuration.ServiceType == ServiceType.Prod)
            Configuration.BaseUrl = "https://earsivportal.efatura.gov.tr";
        else
            Configuration.BaseUrl = "https://earsivportaltest.efatura.gov.tr";
    }

    public async Task<T> Login()
    {
        using (HttpClient client = HttpClientFactory.Create())
        {
            string url = $"{Configuration.BaseUrl}/earsiv-services/assos-login";
            string referrer = $"{Configuration.BaseUrl}/intragiris.html";

            // set post fields
            string serviceType = (Configuration.ServiceType == ServiceType.Prod) ? "anologin" : "login";
            var postFields = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("assoscmd", serviceType),
                new KeyValuePair<string, string>("rtype", "json"),
                new KeyValuePair<string, string>("userid", Configuration.Username),
                new KeyValuePair<string, string>("sifre", Configuration.Password),
                new KeyValuePair<string, string>("sifre2", Configuration.Password),
                new KeyValuePair<string, string>("parola", "1"),
            });
           
            HttpResponseMessage response = await client
                .PostAsync(url, postFields)
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var responseStr = await response.Content.ReadAsStringAsync();

            // check for error message
            if (responseStr.Contains("error"))
            {
                var error = JsonConvert
                    .DeserializeObject<ErrorResponseModel>(responseStr);
                throw new FailedApiRequestException(error.messages[0].text);
            }
            return JsonConvert.DeserializeObject<T>(responseStr);
        }
        throw new FailedApiRequestException("Erişim token alınamıyor.");
    }

    public async Task<T> DispatchCommand(string command, string pageName)
    {
        return await DispatchCommand(command, pageName, null, false);
    }

    public async Task<T> DispatchCommand(string command, string pageName, object data)
    {
        return await DispatchCommand(command, pageName, data, false);
    }

    public async Task<T> DispatchCommand(string command, string pageName, object data, bool encodeUrl)
    {
        if (string.IsNullOrEmpty(Configuration.Token))
            throw new EmptyTokenException("token not provided");

        using (HttpClient client = new HttpClient())
        {
            string url = $"{Configuration.BaseUrl}/earsiv-services/dispatch";
            string referrer = $"{Configuration.BaseUrl}/login.jsp";

            var fields = new List<KeyValuePair<string, string>>
            {
                // todo: make sure we do not need time based UUID
                new KeyValuePair<string, string>("callid", Guid.NewGuid().ToString()),
                new KeyValuePair<string, string>("token", Configuration.Token),
                new KeyValuePair<string, string>("cmd", command),
                new KeyValuePair<string, string>("pageName", pageName),
                new KeyValuePair<string, string>("jp", null)
            };

            if (data != null)
            {
                var item = fields.RemoveAll(x => x.Key.CompareTo("jp") == 0);
                string serialized = JsonConvert.SerializeObject(data);
                serialized = (encodeUrl) ? System.Web.HttpUtility.UrlEncode(serialized) : serialized;
                fields.Add(new KeyValuePair<string, string>("jp", serialized));
            }

            var postFields = new FormUrlEncodedContent(fields);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            string body = $"cmd={command}" +
                $"&callid={Guid.NewGuid().ToString()}" +
                $"&pageName={pageName}" +
                $"&token={Configuration.Token }" +
                $"&jp=" + System.Net.WebUtility.UrlEncode(JsonConvert.SerializeObject(data));

            request.Content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.SendAsync(request);

            var responseStr = await response.Content.ReadAsStringAsync();

            return System.Text.Json.JsonSerializer.Deserialize<T>(responseStr);
        }

        throw new FailedApiRequestException("Komut gönderme işlemi tamamlanamıyor.");
    }
}
    public static class StringExtensions
    {
        public static string ToUTF8(this string text)
        {
            return Encoding.UTF8.GetString(Encoding.Default.GetBytes(text));
        }
    }
}
