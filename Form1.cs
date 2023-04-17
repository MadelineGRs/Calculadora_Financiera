namespace Calculadora_Financiera
{
    public partial class Form1 : Form
    {
        Form2 Datos;
        public Form1()
        {
            InitializeComponent();
            Datos = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Realizar_Click(object sender, EventArgs e)
        {
            Datos.ShowDialog();
        }
    }
}