﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAsignacionPC
{
    public partial class SolicitarPC : Form
    {
        public SolicitarPC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma solicitud?", "Solicitud de PC",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                MessageBox.Show("Solicitud enviada");
                this.Close();
                //Application.Exit();
            }
        }
    }
}
