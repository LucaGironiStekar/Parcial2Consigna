using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Entidades;
//No me deja agregar las referencias de la clase, no se por qué no me funciona.

namespace Parcial2Consigna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tboxDNI_Leave(object sender, EventArgs e)
        {
            if (tboxDNI.Text.Length < 7 || tboxDNI.Text.Length > 8 || tboxDNI.Text.Any(x => !char.IsNumber(x)))
            {
                MessageBox.Show("Error! El DNI debe tener al menos 8 NÚMEROS");
            }

            // Aca otra forma de validar que sea texto por si quiero dos message box diferentes, aún no me decidí
            //int ejem = 0;
            //if (int.TryParse(tboxDNI.Text, out ejem))
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Error, el DNI no puede tener letras");
            //}

        }


        
        private void btCalcularEdad_Click(object sender, EventArgs e)
        {
            //aca debería ir la conexión con la clase usuario e ir conectando todo con los botones y lbl, pero no puedo conectarlo
            
        }


    }
}
