using numPares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numPares.View
{
    public partial class FormPares : Form
    {
        
        public FormPares()
        {
            InitializeComponent();
        }
         numeroPares pares = new numeroPares();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string v  = textBox1.Text;
            label1.Text = pares.Calcular(v).ToString();
        }
    }
}
