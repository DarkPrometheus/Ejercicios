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
            CentrarHorizontalemten();
            CentrarVerticalmente();
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

        void CentrarHorizontalemten()
        {
            lblHoraInicial.Location = new Point(varios.CentrarUnoHorizontalmente(lblHoraInicial.Size.Width, Width), lblHoraInicial.Location.Y);
            lblHorasSumar.Location = new Point(varios.CentrarUnoHorizontalmente(lblHorasSumar.Size.Width, Width), lblHorasSumar.Location.Y);
            lblHorafinal.Location = new Point(varios.CentrarUnoHorizontalmente(lblHorafinal.Size.Width, Width), lblHorafinal.Location.Y);

            txthoraInicial.Location = new Point(varios.CentrarUnoHorizontalmente(txthoraInicial.Size.Width, Width), txthoraInicial.Location.Y);
            txtHoraASumar.Location = new Point(varios.CentrarUnoHorizontalmente(txtHoraASumar.Size.Width, Width), txtHoraASumar.Location.Y);

            button1.Location = new Point(varios.CentrarUnoHorizontalmente(button1.Size.Width, Width), button1.Location.Y);
        }

        void CentrarVerticalmente()
        {
            int[] Posiciones = varios.CentrarVariosVerticalmente(lblHoraInicial.Size.Height, Height, 6, 10);
            lblHoraInicial.Location = new Point(lblHoraInicial.Location.X, Posiciones[0]);
            txthoraInicial.Location = new Point(txthoraInicial.Location.Y, Posiciones[1]);

            lblHorasSumar.Location = new Point(lblHorasSumar.Location.X, Posiciones[2]);
            txtHoraASumar.Location = new Point(txtHoraASumar.Location.Y, Posiciones[3]);

            lblHorafinal.Location = new Point(lblHorafinal.Location.X, Posiciones[4]);
            button1.Location = new Point(button1.Location.X, Posiciones[5]);
        }

        private void HoraFutura_Resize(object sender, EventArgs e)
        {
            CentrarHorizontalemten();
            //Font font = new Font(button1.Font.FontFamily, button1.Font.Size + 1);
            //button1.Font = font;
        }
    }
}
