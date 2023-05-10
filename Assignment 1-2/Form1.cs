using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            // Check if the same units are selected
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                outputBox.Text = value.ToString();
                return;
            }

            switch (listBox1.SelectedItem.ToString())
            {
                case "Inches":
                    switch (listBox2.SelectedItem.ToString())
                    {
                        case "Feet":
                            outputBox.Text = (value / 12).ToString();
                            break;
                        case "Yards":
                            outputBox.Text = (value / 36).ToString();
                            break;
                    }
                    break;
                case "Feet":
                    switch (listBox2.SelectedItem.ToString())
                    {
                        case "Inches":
                            outputBox.Text = (value * 12).ToString();
                            break;
                        case "Yards":
                            outputBox.Text = (value / 3).ToString();
                            break;
                    }
                    break;
                case "Yards":
                    switch (listBox2.SelectedItem.ToString())
                    {
                        case "Inches":
                            outputBox.Text = (value * 36).ToString();
                            break;
                        case "Feet":
                            outputBox.Text = (value * 3).ToString();
                            break;
                    }
                    break;
            }
        }
    }
}
