using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboration1._4
{
    public partial class Default : System.Web.UI.Page
    {
        SecretNumber secretNumber = new SecretNumber();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
            }

            else
            {
                if (secretNumber.CanMakeGuess)
                {

                    int theGuess = int.Parse(Guess.Text);

                    Outcome theOutcome = secretNumber.MakeGuess(theGuess);

                    int result = (int)theOutcome;

                    IReadOnlyCollection<int> writeList = secretNumber.PreviousGuesses();
             

                    string writeNumbers;

                    for(int i = 0; i < writeList.Count; i++)
                    {
                        writeNumbers += String.Format("{0}, ", );
                    }

                    if (result == 0)
                    {
                    }

                    if (result == 1) // Low
                    {

                    }

                    if (result == 2) // High
                    {

                    }

                    if (result == 3) // Correct
                    {

                    }

                    if (result == 4) // No more guesses
                    {

                    }

                    if (result == 5) // Previous guess
                    {

                    }

                    Guesses.Text = String.Format("{0}", theOutcome);
                }

                else
                {
                }
                
            }
        }
    }
}