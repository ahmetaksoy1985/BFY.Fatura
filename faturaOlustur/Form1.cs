using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BFY.Fatura;
using BFY.Fatura.Configuration;
using BFY.Fatura.Models;


namespace fatu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<InvoiceDetailsItemModel> itemList = new List<InvoiceDetailsItemModel>();
        private object response;

        private async void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{

            //    string itemName = "Deneme Ürün";
            //    int quantity = 1;

            //    InvoiceDetailsItemModel item = new InvoiceDetailsItemModel()
            //    {
            //        name = itemName,
            //        quantity = quantity,
            //        unitPrice = 1,
            //        price = 100,
            //        VATRate = 18,
            //        VATAmount = 18

            //    };

            //    itemList.Add(item);


            //    var configuration = FaturaServiceConfigurationFactory.Create();
            //    configuration.ServiceType = ServiceType.Prod;
            //    configuration.Username = "----";
            //    configuration.Password = "-------";
            //    FaturaService faturaService = new(configuration);

            //    await faturaService.GetToken();


            //    var nesne = new InvoiceDetailsModel()
            //    {

            //        date = DateTime.Now.ToString("dd/MM/yyyy").Replace(".", "/"),
            //        time = DateTime.Now.ToString("HH:mm:ss"),
            //        taxIDOrTRID = "1111111111",
            //        taxOffice = "Eskişehir V.D.B.",
            //        title = "",
            //        name = "ORÇUN",
            //        surname = "DİYARBAKIRLI",
            //        fullAddress = "75.Yıl Mah. Odunpazarı Eskişehir",
            //        items = itemList,
            //        totalVAT = 18,
            //        grandTotal = 100,
            //        grandTotalInclVAT = 118,
            //        paymentTotal = 118,
            //    };

            //    var response = faturaService.CreateInvoice(nesne, false);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView1.ColumnCount = 5;
            decimal tutar = decimal.Parse(TextBox3.Text);

            string[] satır = new string[] { TextBox1.Text, TextBox2.Text, ComboBox1.Text, tutar.ToString("N6"), ComboBox2.Text };
            DataGridView1.Rows.Add(satır);

            decimal toplamtutar = 0;
            decimal toplamkdv = 0;
            decimal vergilerdahil = 0;

            for (int i = 0; i < DataGridView1.RowCount; i++)
            {
                decimal hücre3Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[3].Value.ToString());
                decimal hücre1Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[1].Value.ToString());
                decimal hücre4Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[4].Value.ToString());

                toplamtutar += hücre3Degeri * hücre1Degeri;
                toplamkdv += (hücre3Degeri * hücre1Degeri) * (hücre4Degeri / 100);
                vergilerdahil += ((hücre3Degeri * hücre1Degeri) + ((hücre3Degeri * hücre1Degeri) * (hücre4Degeri / 100)));
            }

            toplamTutarLabel.Text = toplamtutar.ToString("N2");
            hesaplananKDVlabel.Text = toplamkdv.ToString("N2");
            vergilerDahilLabel.Text = vergilerdahil.ToString("N2");
            TextBox4.Text = vergilerDahilLabel.Text;

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DataGridView1.RowCount ; i++)
                {
                    string itemName = DataGridView1.Rows[i].Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(DataGridView1.Rows[i].Cells[1].Value.ToString());
                    string unit = DataGridView1.Rows[i].Cells[2].Value.ToString();
                    decimal unitPrice = Convert.ToDecimal(DataGridView1.Rows[i].Cells[3].Value.ToString());
                    decimal price = unitPrice * quantity;
                    int VATRate = Convert.ToInt32(DataGridView1.Rows[i].Cells[4].Value.ToString());
                    decimal VATAmount = price * VATRate / 100;

                    InvoiceDetailsItemModel item = new InvoiceDetailsItemModel()
                    {
                        name = itemName,
                        quantity = quantity,
                        unit = unit,
                        unitPrice = unitPrice,
                        price = price,
                        VATRate = VATRate,
                        VATAmount = VATAmount

                    };

                    itemList.Add(item);
                }

              


                var configuration = FaturaServiceConfigurationFactory.Create();
                configuration.ServiceType = ServiceType.Prod;
                configuration.Username = "------";
                configuration.Password = "-----";
                FaturaService faturaService = new(configuration);

                await faturaService.GetToken();

                DateTime tarihYaz = tarih.Value;

                var nesne = new InvoiceDetailsModel()
                {

                    date = tarihYaz.ToString("dd/MM/yyyy").Replace(".", "/"),
                    time = DateTime.Now.ToString("HH:mm:ss"),
                    taxIDOrTRID = vergikimlik.Text,
                    taxOffice = vergidairesi.Text,
                    title = unvan.Text,
                    name = adi.Text,
                    surname = soyadi.Text,
                    fullAddress = adres.Text,
                    items = itemList,
                    totalVAT = Convert.ToDecimal(hesaplananKDVlabel.Text),
                    grandTotal = Convert.ToDecimal(toplamTutarLabel.Text),
                    grandTotalInclVAT = Convert.ToDecimal(vergilerDahilLabel.Text),
                    paymentTotal = Convert.ToDecimal(TextBox4.Text),
                };
               
                var response = faturaService.CreateInvoiceAndGetHTML(nesne, false);


                using (var client = new WebClient())
                {
                    client.DownloadFile(faturaService.GetDownloadURL(response.Result.data, false), "a.html");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index);
            decimal toplamtutar = 0;
            decimal toplamkdv = 0;
            decimal vergilerdahil = 0;

            for (int i = 0; i < DataGridView1.RowCount; i++)
            {
                decimal hücre3Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[3].Value.ToString());
                decimal hücre1Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[1].Value.ToString());
                decimal hücre4Degeri = decimal.Parse(DataGridView1.Rows[i].Cells[4].Value.ToString());

                toplamtutar += hücre3Degeri * hücre1Degeri;
                toplamkdv += (hücre3Degeri * hücre1Degeri) * (hücre4Degeri / 100);
                vergilerdahil += ((hücre3Degeri * hücre1Degeri) + ((hücre3Degeri * hücre1Degeri) * (hücre4Degeri / 100)));
            }

            toplamTutarLabel.Text = toplamtutar.ToString("N2");
            hesaplananKDVlabel.Text = toplamkdv.ToString("N2");
            vergilerDahilLabel.Text = vergilerdahil.ToString("N2");
            TextBox4.Text = vergilerDahilLabel.Text;

        }

        private void TextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextBox2.Text == "" || TextBox2.Text == "0" || TextBox6.Text == "")
            {
                TextBox2.Text = "1";
            }

            decimal kdvharic = 0;
            if (!string.IsNullOrEmpty(TextBox6.Text))
            {
                decimal toplam, kdvorani, miktar;
                toplam = Convert.ToDecimal(TextBox6.Text);
                kdvorani = Convert.ToDecimal(ComboBox2.Text);
                miktar = Convert.ToDecimal(TextBox2.Text);

                if (kdvorani == 0)
                {
                    kdvharic = toplam / miktar;
                }
                if (kdvorani == 1)
                {
                    kdvharic = toplam / 1.01m / miktar;
                }
                if (kdvorani == 8)
                {
                    kdvharic = toplam / 1.08m / miktar;
                }
                if (kdvorani == 18)
                {
                    kdvharic = toplam / 1.18m / miktar;
                }
                TextBox3.Text = kdvharic.ToString();
            }
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextBox2.Text == "" || TextBox2.Text == "0")
            {
                TextBox2.Text = "1";
            }
            decimal toplam = 0;
            if (!string.IsNullOrEmpty(TextBox3.Text))
            {
                decimal  kdvharic, kdvorani, miktar;
                kdvharic = Convert.ToDecimal(TextBox3.Text);
                kdvorani = Convert.ToDecimal(ComboBox2.Text);
                miktar = Convert.ToDecimal(TextBox2.Text);

                if (kdvorani == 0)
                {
                    toplam = kdvharic * miktar;
                }
                if (kdvorani == 1)
                {
                    toplam = kdvharic * 1.01m * miktar;
                }
                if (kdvorani == 8)
                {
                    toplam = kdvharic * 1.08m * miktar;
                }
                if (kdvorani == 18)
                {
                    toplam = kdvharic * 1.18m * miktar;
                }
                TextBox6.Text = toplam.ToString();
            }

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal kdvharic = 0;
            if (!string.IsNullOrEmpty(TextBox6.Text) || TextBox6.Text == "0")
            {
                decimal toplam, kdvorani, miktar;
                toplam = Convert.ToDecimal(TextBox6.Text);
                kdvorani = Convert.ToDecimal(ComboBox2.Text);
                miktar = Convert.ToDecimal(TextBox2.Text);

                if (kdvorani == 0)
                {
                    kdvharic = toplam / miktar;
                }
                if (kdvorani == 1)
                {
                    kdvharic = toplam / 1.01m / miktar;
                }
                if (kdvorani == 8)
                {
                    kdvharic = toplam / 1.08m / miktar;
                }
                if (kdvorani == 18)
                {
                    kdvharic = toplam / 1.18m / miktar;
                }
                TextBox3.Text = kdvharic.ToString();
            }

        }

     

        private async void button2_Click(object sender, EventArgs e)
        {

            var configuration = FaturaServiceConfigurationFactory.Create();
            configuration.ServiceType = ServiceType.Prod;
            configuration.Username = "----";
            configuration.Password = "----";
            FaturaService faturaService = new(configuration);
            long taxId = long.Parse(vergikimlik.Text);
            await faturaService.GetToken();
            var response = await faturaService.GetRecipientDataByTaxIDOrTRID(taxId);
            if (response is GIBResponseModel)
            {
                RecipientModel recipient = response.data;
                var unvan = recipient.unvan;
                var adi = recipient.adi;
                var soyadi = recipient.soyadi;
                var vergiDairesi = recipient.vergiDairesi;
            }

          


            //if (response is GIBResponseModel)
            //{

            //    RecipientModel recipients = gibResponse.data;

            //    foreach (RecipientModel recipient in recipients)
            //    {
            //        var unvan = recipient.unvan;
            //        var adi = recipient.adi;
            //        var soyadi = recipient.soyadi;
            //        var vergiDairesi = recipient.vergiDairesi;
            //    }
            //}

            //var configuration = FaturaServiceConfigurationFactory.Create();
            //configuration.ServiceType = ServiceType.Prod;
            //configuration.Username = "-----";
            //configuration.Password = "-----";
            //FaturaService faturaService = new(configuration);
            //long taxId = long.Parse(vergikimlik.Text);
            //await faturaService.GetToken();



            //GIBResponseModel<List<RecipientModel>> response = await faturaService.GetRecipientDataByTaxIDOrTRID(taxId);

            //List<RecipientModel> recipients = response.data;

            //foreach (RecipientModel recipient in recipients)
            //{

            //    adi.Text = recipient.adi;
            //    soyadi.Text = recipient.soyadi;
            //    unvan.Text = recipient.unvan;
            //    vergidairesi.Text = recipient.vergiDairesi;

            //}

        }
    }
}
