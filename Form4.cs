using System;
using System.Windows.Forms;


namespace WindowsPracticas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Calcular()
        {
            if(ElegirFigura.Text == "rectangulo"){ Rectangulo(); }
            else if (ElegirFigura.Text == "circulo") { Circulo(); }
            else if (ElegirFigura.Text == "trapecio") { Trapecio(); }
            else { MessageBox.Show("ingrese figura valida");}
        }
        public void Rectangulo()
        {
            double base1 = Convert.ToDouble(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);
            double area = base1 * altura;

            MessageBox.Show("El area del rectangulo es " + area);
        }
        public void Circulo()
        {
            
            double  area;
            double pi = 3.1416;
            double radio = Convert.ToDouble(textBox3.Text);
            area = pi * Math.Pow(radio, 2);

            MessageBox.Show("el area es " + area);



        }
        public void Trapecio()
        {
            double base1 = Convert.ToDouble(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);
            double area = (altura * ((base1 + base1) / 2));
            MessageBox.Show("El area del trapecio es " + area);
        }


    }
}
