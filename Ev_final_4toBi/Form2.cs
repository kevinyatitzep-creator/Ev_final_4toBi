using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("el resultado de la suma es" + suma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int num3 = 1;
            int Potencia = 1;

            while (num3 != num2)
            {
                Potencia = Potencia * num1;
                num3++;
            }
            MessageBox.Show("el resultado de la Potencia es " + Potencia);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TextVar1.Text);
            float num2 = float.Parse(TextVar2.Text);
            if (num2 > 0)
            {
                float divicion = num1 / num2;
                MessageBox.Show("el resultado es" + divicion);
            }
            else
            {
                MessageBox.Show("la divicion es definitiva");
            }
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado del producto es" + producto);
        }
    }
}
