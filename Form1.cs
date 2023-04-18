namespace Calculadora_Financiera
{
    public partial class Form1 : Form
    {
        
        Form2 Datos; //Es para inializar una nueva ventana llamada "Datos"
        public Form1()
        {
            InitializeComponent();
            Datos = new Form2(); //El nombre "Datos" es igual a decir crear una nueva ventana. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Realizar_Click(object sender, EventArgs e)
        {
            Datos.ShowDialog(); //Al presionarlo se muestra esa ventana de "Datos"
        }

        private void comboBox_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este c�digo es para leer la opci�n para descuento o no. Establece el descuento seg�n el tipo de cliente seleccionado
  
           
                double descuento = 0;
                String tipoCliente = "";

                tipoCliente = comboBox_TipoCliente.SelectedItem.ToString().ToUpper();

                switch (tipoCliente)
                {
                    case "A1":
                    case "A2":
                        descuento = 0.02;
                        break;
                    case "C":
                        MessageBox.Show("Cr�dito denegado.");
                        return;
                }
   
        }
    }
}