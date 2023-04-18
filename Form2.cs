using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Atrás_Click(object sender, EventArgs e)
        {
            this.Hide(); //Esconder esta ventana "Datos"
            Form1 Bienvenida = new Form1(); //Se crea una nueva ventana Bienvenida
            Bienvenida.Show(); //Se muestra
        }

        //Botón de SALIR, antes de programar no le cambié el nombre
        private void button1_Click(object sender, EventArgs e)
        {
            //Acá creamos un mensaje flotante para confirmar que queremos salir del app
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir de la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox_TipoPréstamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            float tasaInteres = 0;

            String opcionPrestamo = comboBox_TipoPréstamo.Text;
            {   // Establece la tasa de interés según la opción de préstamo seleccionada
                switch (opcionPrestamo)
                {
                    case "Personal Regular con Tasa de interés: 15%":
                        tasaInteres = (float)0.15;
                        break;
                    case "Personal Rápido con Tasa de interés: 18%":
                        tasaInteres = (float)0.18;
                        break;
                    case "Reparación y ampliación de vivienda con Tasa de interés: 12%":
                        tasaInteres = (float)0.12;
                        break;
                    case "Compra de Lote con Tasa de interés: 12%":
                        tasaInteres = (float)0.12;
                        break;
                    case "Compra de Vehículo Nuevo con Tasa de interés: 18%":
                        tasaInteres = (float)0.18;
                        break;
                }
            }

        }

        private void label_MontoT_Click(object sender, EventArgs e)
        {

        }

        private void label_CuotaMensual_Click(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {

        }


    }
}
