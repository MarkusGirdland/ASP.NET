using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboration1._2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                CompareValidator1.ErrorMessage = "Inte korrekt tal. Försök igen.";
            }

            else
            {
                Receipt myReceipt = new Receipt();

                double amount = double.Parse(Amount.Text);              // Double parsea värdet

                myReceipt.Calculate(amount);

                string header;
                string information;
                string footer;

                double readableDiscountRate = 0;

                readableDiscountRate = (myReceipt.DiscountRate * 100);      // gör om ex 0.05 till 5

                ReceiptHead.Text = "Kvitto <br>";

                header = String.Format("Tel: 0772-28 80 00 <br> Öpettider: 8-17<br> EV. FEL GER UNDERKÄNT <br> ------------------<br>");

                information = String.Format("Totalt:\t\t{0}<br>Rabattsats:\t\t{1}<br>Rabatt:\t\t{2}<br>Att betala:\t\t{3} <br>", amount, readableDiscountRate, myReceipt.MoneyOff, myReceipt.Total);

                footer = String.Format("-----------------<br> ORG.NR 202100-6271<br>VÄLKOMMEN ÅTER!");

                string superString = header + information + footer;

                ReceiptText.Text = superString;
            }
        }
    }
}