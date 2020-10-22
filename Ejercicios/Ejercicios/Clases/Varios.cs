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
        public void CentrarLabelHorizontalmente(ref Label label, int parent)
        {
            parent = (parent / 2) - (label.Size.Width / 2);
            label.Location = new Point(parent, label.Location.Y);
        }

        public void CentrarTexBoxHorizontalmente(ref TextBox textBox, int parent)
        {
            parent = (parent / 2) - (textBox.Size.Width / 2);
            textBox.Location = new Point(parent, textBox.Location.Y);
        }

        public void CentrarButtonHorizontalmente(ref Button button, int parent)
        {
            parent = (parent / 2) - (button.Size.Width / 2);
            button.Location = new Point(parent, button.Location.Y);
        }


    }
}
