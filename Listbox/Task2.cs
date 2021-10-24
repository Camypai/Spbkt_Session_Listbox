using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Listbox
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void fillRandomBtn_Click(object sender, EventArgs e)
        {
            numbersLb.Items.Clear();
            
            var random     = new Random(DateTime.Now.Millisecond);
            var numsString = new List<string>();

            for (var i = 0; i < int.Parse(maxTb.Text); i++)
            {
                numsString.Add(random.Next(-50, 51).ToString());
            }
            
            numbersLb.Items.AddRange(numsString.ToArray());
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var numbers = numbersLb.Items.Cast<string>().Select(int.Parse);
            positiveLbl.Text = numbers.Count(q => q > 0).ToString();
            negativeLbl.Text = numbers.Count(q => q < 0).ToString();
            zeroLbl.Text     = numbers.Count(q => q == 0).ToString();
        }
    }
}