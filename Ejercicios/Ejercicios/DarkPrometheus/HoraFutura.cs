﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios.DarkPrometheus
{
    public partial class HoraFutura : Form
    {
        public HoraFutura()
        {
            InitializeComponent();
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
    }
}