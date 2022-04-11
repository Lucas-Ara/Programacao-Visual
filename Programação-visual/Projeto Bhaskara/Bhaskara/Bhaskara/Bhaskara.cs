using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Bhaskara : Form
    {
        public Bhaskara()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            c = int.Parse(txtC.Text);
            
            if (a == 0)
            {
                MessageBox.Show("o valor do a não pode ser zero!!");
                return;
            }

            double delta;
            delta = (b * b) - 4 * a * c;

            if (delta<0)
            {
                lbDelta.Text = "O delta é negativo: " + delta;
                lbXP.Text = "Não é possivel calcular as raízes: ";
                return;
            }

            double xP, xN;
            xP = ((-b) + Math.Sqrt(delta)) / (2 * a);
            xN = ((-b) - Math.Sqrt(delta)) / (2 * a);

            if (xP == xN)
            {
                lbXP.Text = lbXP.Text = "X' = X\" = " + xP;
            }
            else
            {
                lbDelta.Text = "Delta = " + delta;
                lbXP.Text = "X' = " + xP;
                lbXN.Text = "X\" = " + xN;
            }
        }
    }
}
