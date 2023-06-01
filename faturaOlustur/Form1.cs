using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BFY.Fatura;
using BFY.Fatura.Configuration;
using BFY.Fatura.Models;


namespace faturaOlustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<InvoiceDetailsItemModel> itemList = new List<InvoiceDetailsItemModel>();
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                string itemName = "Deneme Ürün";
                int quantity = 1;

                InvoiceDetailsItemModel item = new InvoiceDetailsItemModel()
                {
                    name = itemName,
                    quantity = quantity,
                    unitPrice = 1,
                    price = 100,
                    VATRate = 18,
                    VATAmount = 18

                };

                itemList.Add(item);


                 var configuration = FaturaServiceConfigurationFactory.Create();
                 configuration.ServiceType = ServiceType.Prod;
                configuration.Username = "";
                   configuration.Password = "";
                FaturaService faturaService = new(configuration);
          
                await faturaService.GetToken();


            var nesne = new InvoiceDetailsModel()
            {

                date = DateTime.Now.ToString("dd/MM/yyyy").Replace(".", "/"),
                time = DateTime.Now.ToString("HH:mm:ss"),
                taxIDOrTRID = "1111111111",
                taxOffice = "Eskişehir V.D.B.",
                title = "",
                name = "Orçun",
                surname = "Diyarbakırlı",
                fullAddress = "75.Yıl Mah. Odunpazarı Eskişehir",
                items = itemList,
                totalVAT = 18,
                grandTotal = 100,
                grandTotalInclVAT = 118,
                paymentTotal = 118,
            };

            var response = faturaService.CreateInvoice(nesne, false);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

}
    }
}
