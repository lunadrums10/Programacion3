using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErnestoAvila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            int C =300000;
            double i= 0.025;
            int t= 12;
            double monto;
            for (int j=1; j<=t; j++)
            {
                monto=( C * i * j);

                listBox1.Items.Add(j+ " El interes generado es de:  " + monto);
            }

           

        }



    }
}