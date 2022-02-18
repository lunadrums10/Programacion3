namespace tarea_de_arreglos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nombre = { NombretextBox1.Text };
            int[] edad = { Convert.ToInt32(EdadtextBox2.Text) };


            for (int i = 0; i < nombre.Length; i++)
            {
                for (int j = 0; j < edad.Length; j++)
                {
                    listBox1.Items.Add("El nombre es " + nombre[i] + " y la edad es " + edad[j]);
                }

            }
        }
    }
}