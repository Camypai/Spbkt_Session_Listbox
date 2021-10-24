using System;
using System.Windows.Forms;


namespace Listbox
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Task1_Load(object sender, EventArgs e)
        {
            resultsLb.Items.Add($"{"x",5}{"y",20}");
            resultsLb.Items.Add("---------------------------");
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (resultsLb.Items.Count > 2)
            {
                resultsLb.Items.Clear();
                Task1_Load(sender, e);
            }
            
            for (var x = 1d; x <= 2; x+=0.2d)
            {
                var y = Math.Sin(x);
                resultsLb.Items.Add($"{x,-5:F1}{y,20:F2}");
            }
        }
    }
}