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
    public partial class FormArea : Form
    {
        public FormArea()
        {
            InitializeComponent();
        }

        private void VerArea_Click(object sender, EventArgs e)
        {
            CalcularArea();
        }

        public void CalcularArea()
        {
            double base1 = Convert.ToDouble(Base.Text);
            double altura = Convert.ToDouble(Altura.Text);
            double area = base1 * altura;

            MessageBox.Show("El area del rectangulo es " + area);
        }
    }
}
