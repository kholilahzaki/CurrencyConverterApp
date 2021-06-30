using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conv_btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Dollar")
            {
                int conver = i / 103;
                display_txt.Text = "Converted Amount : " + conver + "\t Dollar";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 103;
                display_txt.Text = "Converted Amount : " + conver + "\t Rupees";
            }

            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 115;
                display_txt.Text = "Converted Amount : " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Rupees")
            {
                int conver = i * 115;
                display_txt.Text = "Converted Amount : " + conver + "\t Rupees";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 2;
                display_txt.Text = "Converted Amount : " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Dollar")
            {
                int conver = i * 2;
                display_txt.Text = "Converted Amount : " + conver + "\t Dollar";
            }
        }
    }
}
