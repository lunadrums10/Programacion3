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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string articulo = ProductotextBox1.Text;
            int precio = Convert.ToInt32(PreciotextBox2.Text);
            double descuento = 0;
            MessageBox.Show("El articulo que llevo fue: "+articulo+" Su total a pagar sera: " + await Calculardescuento(precio, descuento));

        }
        private async Task<double>Calculardescuento(int precio, double descuento)
        {
            var resultado = await Task.Run(() =>
             {
                 descuento = precio * 0.15;
                 return precio - descuento;
             });
                return resultado;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
           await Descuentoasync();
            label3.Text = "Tendra un descuento del 15% por su compra";
        }

        private Task Descuentoasync()
        {
            return Task.Delay(10000);
        }
    }
}
