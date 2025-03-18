using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangulo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
             var ladoA = double.Parse(txtA.Text);
            var ladoB = double.Parse(txtB.Text);
            var retangulo = new Retangulo(ladoA,ladoB);
            var  valorArea = retangulo.CalcArea();
            var valorPeri= retangulo.CalcPerimetro();
            lblresultadoAl.Text=valorArea.ToString();
            lblResultaPe.Text=valorPeri.ToString();
            
        }
    }
}
