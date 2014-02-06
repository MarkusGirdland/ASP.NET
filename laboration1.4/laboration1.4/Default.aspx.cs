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
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
            }

            else
            {
                form1.DefaultButton = "SendButton";
                
                if (ViewState["PrevObject"] == null)
                {
                    SecretNumber secretNumber = new SecretNumber();
                    ViewState["PrevObject"] = secretNumber;
                }

                var prevObj = (SecretNumber)ViewState["PrevObject"];

                if (prevObj.CanMakeGuess)
                {


                    int theGuess = int.Parse(Guess.Text);

                    Outcome theOutcome = prevObj.MakeGuess(theGuess);

                    int result = (int)theOutcome;

                    IReadOnlyCollection<int> readOnlyGuesses = prevObj.PreviousGuesses();

                    string myString;
                    string message = "";

                    foreach (int guess in readOnlyGuesses)
                    {
                        myString = string.Format("{0}, ", guess);
                        message += myString;
                    }

                    if (result == 4) // No more guesses
                    {
                        prevObj.CanMakeGuess = false;

                        int? getSecretNumber = prevObj.Number();

                        message += String.Format("Du har inga gissningar kvar, det hemliga talet var {0}.", getSecretNumber);

                        Guess.Enabled = false;
                        SendButton.Visible = false;
                        Redo.Visible = true;
                        Guesses.Text = message;
                        message = "";
                    }

                    if (result == 5) // Previous guess
                    {
                        message += "Du har redan gissat på det talet.";
                        Guesses.Text = message;
                    }

                    if (result == 3) // Correct
                    {
                        message += String.Format("Grattis! Du klarade det på {0} försök!", prevObj.Count);

                        Guess.Enabled = false;
                        SendButton.Visible = false;
                        Redo.Visible = true;
                        Guesses.Text = message;
                        message = "";
                    }

                    if (result == 0)
                    {
                    }

                    if (result == 1) // Low
                    {
                        message += "Värdet är för lågt.";
                        Guesses.Text = message;
                    }

                    if (result == 2) // High
                    {
                        message += "Värdet är för högt.";
                        Guesses.Text = message;
                    }

                    
                    ViewState["PrevObject"] = prevObj;
                }

                else
                {
                }
                
            }
        }

        public void Redo_Click(object sender, EventArgs e)
        {
            this.form1.DefaultButton = "Redo";

            ViewState["PrevObject"] = null;

            Guess.Enabled = true;
            SendButton.Visible = true;
            Redo.Visible = false;
        }
    }
}