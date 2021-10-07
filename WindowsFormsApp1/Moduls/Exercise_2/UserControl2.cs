using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inputs = tx_Input.Text.Split(';');
            var words = inputs.ToList();
            var palindrome = new List<string>();

            foreach(var word in words)
            {
                var chars = word.ToCharArray();
                var result = from ch in chars
                             group ch by ch into chGroup
                             select new
                             {
                                 Key = chGroup.Key,
                                 Count = chGroup.Count()
                             };
                var sumNoEven = 0;
                foreach (var countedChars in result)
                {
                    if(countedChars.Count % 2 == 1)
                    {
                        ++sumNoEven;
                    }
                }
               
                if((sumNoEven == 1 || sumNoEven == 0) && !word.Equals(""))
                {
                    palindrome.Add(word);
                }
            }
            if(palindrome.Count > 0)
            {
                l_Check.Text = "Wynik: " + palindrome.Aggregate("", (curr, next) => curr + ", " + next) + ", Ilosc: " + palindrome.Count();
            } 
            else
            {
                l_Check.Text = "Zaden wyraz nie jest palindromem";
            }
            
            
        }
    }
}
