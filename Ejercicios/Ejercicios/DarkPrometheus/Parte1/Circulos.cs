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
    public partial class frmCirculos : UserControl
    {
        Clases.Varios varios = new Clases.Varios();
        public frmCirculos()
        {
            InitializeComponent();
            CentrarVerticalmente();
            CentrarHorizontalmente();
        }

        void CentrarHorizontalmente()
        {
            lblRadio.Location = new Point(varios.CentrarUnoHorizontalmente(lblRadio.Size.Width, Width), lblRadio.Location.Y);
            txtRadio.Location = new Point(varios.CentrarUnoHorizontalmente(txtRadio.Size.Width, Width), txtRadio.Location.Y);
            lblTituloPerimetro.Location = new Point(varios.CentrarUnoHorizontalmente(lblTituloPerimetro.Size.Width, Width), lblTituloPerimetro.Location.Y);
            lblResultadoPerimetro.Location = new Point(varios.CentrarUnoHorizontalmente(lblResultadoPerimetro.Size.Width, Width), lblResultadoPerimetro.Location.Y);
            lblTituloArea.Location = new Point(varios.CentrarUnoHorizontalmente(lblTituloArea.Size.Width, Width), lblTituloArea.Location.Y);
            lblResultadoArea.Location = new Point(varios.CentrarUnoHorizontalmente(lblResultadoArea.Size.Width, Width), lblResultadoArea.Location.Y);

            button1.Location = new Point(varios.CentrarUnoHorizontalmente(button1.Size.Width, Width), button1.Location.Y);
        }

        void CentrarVerticalmente()
        {
            int[] Posiciones = varios.CentrarVariosVerticalmente(button1.Size.Height, Height, 7, 10);
            lblRadio.Location = new Point(lblRadio.Location.X, Posiciones[0]);
            txtRadio.Location = new Point(txtRadio.Location.Y, Posiciones[1]);

            lblTituloPerimetro.Location = new Point(lblTituloPerimetro.Location.X, Posiciones[2]);
            lblResultadoPerimetro.Location = new Point(lblResultadoPerimetro.Location.Y, Posiciones[3]);

            lblTituloArea.Location = new Point(lblTituloArea.Location.X, Posiciones[4]);
            lblResultadoArea.Location = new Point(lblResultadoArea.Location.X, Posiciones[5]);

            button1.Location = new Point(button1.Location.X, Posiciones[6]);
        }
    }
}
