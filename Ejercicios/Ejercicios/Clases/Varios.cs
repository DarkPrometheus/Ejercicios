using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ejercicios.Clases
{
    class Varios
    {
        public int CentrarUnoVerticalmente(int AltoDelControl, int AltoDelPdre)
        {
            int Posicion = (AltoDelPdre / 2) - (AltoDelControl / 2);

            return Posicion;
        }

        public int[] CentrarVariosVerticalmente(int AltoDelControl, int AltoDelPdre, int Cantidad, int Espacio)
        {
            int SumaAlto = AltoDelControl * Cantidad + Espacio * (Cantidad - 1);
            int[] Posiciones = new int[Cantidad];

            int PrimeraPosicon = (AltoDelPdre - SumaAlto) / 2;
            Posiciones[0] = PrimeraPosicon;
            for (int i = 1; i < Cantidad; i++)
            {
                PrimeraPosicon += AltoDelControl + Espacio;
                Posiciones[i] = PrimeraPosicon;
            }

            return Posiciones;
        }

        public int CentrarUnoHorizontalmente(int AnchoDelControl, int AnchoDelPdre)
        {
            int Posicion = (AnchoDelPdre / 2) - (AnchoDelControl / 2);

            return Posicion;
        }
    }
}
