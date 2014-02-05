using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboration1._1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {

            SendButton.Visible = false;
            ReturnButton.Visible = true;
            TextBox.Enabled = false;

            int capitals = TextAnalyzer.GetNumberOfCapitals(TextBox.Text);

            CapitalLabel.Text += "Antal versaler är: " + capitals;
        }

        protected void ReturnButton_Click(object sender, EventArgs e)
        {
        }
    }
}