using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConvert : Form
    {
        public CurrencyConvert()
        {
            InitializeComponent();
        }

        private void CurrencyConvert_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.calculator.net/currency-calculator.html");
        }
    }
}
