﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<Figura> figuras;
        public Form1()
        {
            figuras = new List<Figura>();
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            foreach (Figura r in figuras)
                r.Dibuja(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
