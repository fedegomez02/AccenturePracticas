using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad1 = Convert.ToInt32(edad.Text);
            CalcularEdad(edad1);
            
        }
        public void CalcularEdad(int edad)
        {
            if(edad == 0) { MessageBox.Show("Error,ingrese numero valido");}
            else if (edad < 18) { MessageBox.Show("Usted es menor de edad"); }
            else if (edad>= 18 && edad <60) { MessageBox.Show("Es una persona  mayor de edad"); }
            else { MessageBox.Show("ES una persona adulta mayor");}
        }
    }
}
