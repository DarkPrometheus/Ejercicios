using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.DarkPrometheus.Parte1
{
    public partial class frmHoraFutura : UserControl
    {
        Clases.Varios varios = new Clases.Varios();
        public frmHoraFutura()
        {
            InitializeComponent();
            Centrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int HoraActual = int.Parse(txthoraInicial.Text), HoraSumar = int.Parse(txthoraInicial.Text);
            int suma = HoraActual + HoraSumar;

            if (suma > 24)
            {
                if (suma == 24)
                    lblHorafinal.Text = "1:00";
                else
                    lblHorafinal.Text = (suma - 24).ToString();
            }
            else
                lblHorafinal.Text = suma.ToString();
        }

        void Centrar()
        {
            varios.CentrarLabelHorizontalmente(ref lblHoraInicial, this.Width);
            varios.CentrarLabelHorizontalmente(ref lblHorasSumar, Width);
            varios.CentrarLabelHorizontalmente(ref lblHorafinal, Width);

            varios.CentrarTexBoxHorizontalmente(ref txthoraInicial, Width);
            varios.CentrarTexBoxHorizontalmente(ref txtHoraASumar, Width);

            varios.CentrarButtonHorizontalmente(ref button1, Width);
        }

        private void HoraFutura_Resize(object sender, EventArgs e)
        {
            varios.CentrarLabelHorizontalmente(ref lblHoraInicial, Width);
            varios.CentrarLabelHorizontalmente(ref lblHorasSumar, Width);
            varios.CentrarLabelHorizontalmente(ref lblHorafinal, Width);

            varios.CentrarTexBoxHorizontalmente(ref txthoraInicial, Width);
            varios.CentrarTexBoxHorizontalmente(ref txtHoraASumar, Width);

            varios.CentrarButtonHorizontalmente(ref button1, Width);
        }
    }
}
