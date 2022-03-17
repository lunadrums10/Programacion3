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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 1;
            string nombre = "Ernesto";
            string apellido = "Avila";
            while (numero <= 100)
            {

                listBox1.Items.Add(numero);
                numero++;
            }
            for (int i = 0; i <= 100; i++)
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i+" "+nombre);
                }
            for (int i = 0; i <= 100; i++)
                if (i % 5 == 0)
                {
                    listBox3.Items.Add(i + " " + apellido);
                }
            for (int i = 0; i <= 100; i++)
                if (i % 3 == 0 || i % 5 == 0)
                {
                    listBox4.Items.Add(i + " " + nombre+ " "+apellido);
                }
        }
    }
}
