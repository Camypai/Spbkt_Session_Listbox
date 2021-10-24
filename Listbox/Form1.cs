using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Listbox
{
    public partial class Form1 : Form
    {
        private Task1 _task1;
        private Task2 _task2;
        private Task3 _task3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _task1 = new Task1();
            _task2 = new Task2();
            _task3 = new Task3();
        }

        private void task1Btn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_task1 is null)
            {
                _task1 = new Task1();
            }

            _task1.Show();
        }

        private void task2Btn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_task2 is null)
            {
                _task2 = new Task2();
            }

            _task2.Show();
        }

        private void task3Btn_Click(object sender, EventArgs e)
        {
            HideForms();
            if (_task3 is null)
            {
                _task3 = new Task3();
            }

            _task3.Show();
        }

        private void HideForms()
        {
            _task1.Hide();
            _task2.Hide();
            _task3.Hide();
        }
    }
}