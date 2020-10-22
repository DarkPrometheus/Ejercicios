using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DarkPrometheus.main main = new DarkPrometheus.main();
            Hide();
            main.Show();
        }

        private void btnMenufregg_Click(object sender, EventArgs e)
        {
            freeg99.main main = new freeg99.main();
            Hide();
            main.Show();
        }
    }
}
