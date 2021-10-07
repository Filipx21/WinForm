using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var value = text.Text;

            if (string.IsNullOrEmpty(value))
            {
                label1.Text = "Wartosc nie moze byc pusta";
            }
            if (!ValidString(value))
            {
                label1.Text = "Niedozwolone znaki";
            }
            else
            {
                if (AreBracketsOK(value))
                {
                    label1.Text = "Dobrze";
                }
            }
        }

        private bool ValidString(string value)
        {
            var allowLetters = "0123456789+-() ";
            foreach(var _char in value)
            {
                if(!allowLetters.Contains(_char.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private bool AreBracketsOK(string value)
        {
            var openBracket = 0;
            var closeBracket = 0;

            for(var i = 0; i < value.Length; i++)
            {
                if (value[i] == '(') openBracket++;
                if (value[i] == ')') closeBracket++;
            }
            if (openBracket > closeBracket)
            {
                label1.Text = "Brak nawiasu zamykajacego";
                return false;
            }
            else if (openBracket < closeBracket)
            {
                label1.Text = "Brak nawiasu otwierajacego";
                return false;
            } 
            else if (value.IndexOf('(') > value.IndexOf(')') && (openBracket == 1 && closeBracket == 1))
            {
                label1.Text = "Zle ustawienie znakow";
                return false;
            }
            return true;
        }

    }
}
