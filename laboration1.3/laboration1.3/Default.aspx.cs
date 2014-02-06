using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboration1._3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Convert_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
            }

            else
            {
                int startTemp = int.Parse(StartTemp.Text);
                int endTemp = int.Parse(EndTemp.Text);
                int stepTemp = int.Parse(StepTemp.Text);




                // Hjälp från http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.tablerow(v=vs.110).aspx

                TableItemStyle tableStyle = new TableItemStyle();
                tableStyle.HorizontalAlign = HorizontalAlign.Center;
                tableStyle.VerticalAlign = VerticalAlign.Middle;
                tableStyle.Width = Unit.Pixel(100);



                for (int i = startTemp; i <= endTemp; i+=stepTemp)  // Byt ut mot antal rader som krävs
                {
                    TableRow tempRow = new TableRow();
                    for (int cellNum = 0; cellNum < 1; cellNum++)
                    {
                        TableCell tempCell = new TableCell();
                        tempCell.Text =
                            String.Format("{0}", i);        // Byt ut mot text i cell
                        tempRow.Cells.Add(tempCell);
                    }

                    for (int cellNum = 0; cellNum < 1; cellNum++)
                    {
                        int degrees = 0;
                        TableCell tempCell = new TableCell();

                        if(CtoF.Checked)
                        {
                            degrees = TemperatureConverter.CelsiusToFahrenheit(i);
                        }

                        else
                        {
                            degrees = TemperatureConverter.FahrenheitToCelsius(i);
                        }

                        tempCell.Text =
                            String.Format("{0}", degrees);        // Byt ut mot text i cell
                        tempRow.Cells.Add(tempCell);
                    }
                    Table1.Rows.Add(tempRow);
                }

                // Lägg till TableItemStyle till alla rader i table.
                foreach (TableRow rw in Table1.Rows)
                    foreach (TableCell cel in rw.Cells)
                        cel.ApplyStyle(tableStyle);

                // Skapa header
                TableHeaderCell header = new TableHeaderCell();
                TableHeaderCell header2 = new TableHeaderCell();

                if (CtoF.Checked)
                {
                    header.Text = "Celsius";
                    header2.Text = "Fahrenheit";
                }

                else
                {
                    header.Text = "Fahrentheit";
                    header2.Text = "Celsius";
                }
                
                header.Font.Bold = true;
                header2.Font.Bold = true;

                header.HorizontalAlign = HorizontalAlign.Center;
                header2.HorizontalAlign = HorizontalAlign.Center;

                header.VerticalAlign = VerticalAlign.Middle;
                header2.VerticalAlign = VerticalAlign.Middle;

                // Header i ny rad
                TableRow headerRow = new TableRow();
                headerRow.Cells.Add(header);
                

                // Rad till table
                Table1.Rows.AddAt(0, headerRow);

                headerRow.Cells.Add(header2);
                Table1.Rows.AddAt(1, headerRow);
            }
        }
    }
}