using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Listbox
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            numbersLb.Items.Clear();
            
            var random     = new Random(DateTime.Now.Millisecond);
            var numsString = new List<string>();

            for (var i = 0; i < 10; i++)
            {
                numsString.Add(random.Next(-50, 51).ToString());
            }
            
            numbersLb.Items.AddRange(numsString.ToArray());
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var numbers = numbersLb.Items.Cast<string>().Select(int.Parse).ToList();

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 15)
                {
                    numbersLb.Items[i] = 15;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            numbersLb.Items.Clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var number = int.Parse(updateTb.Text);

            numbersLb.Items[numbersLb.SelectedIndex] = number;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            numbersLb.Items.RemoveAt(numbersLb.SelectedIndex);
        }
    }
}