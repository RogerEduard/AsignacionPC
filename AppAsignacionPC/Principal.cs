using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistrarColaborador rc = new RegistrarColaborador();
            rc.MdiParent = this;
            rc.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //var asignar = new AsignarPC { MdiParent = this };
            AsignarPC ap = new AsignarPC();
            ap.MdiParent = this;
            ap.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PCsRegistrar pc = new PCsRegistrar();
            pc.MdiParent = this;
            pc.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SolicitarPC sp = new SolicitarPC();
            sp.MdiParent = this;
            sp.Show();
        }
    }
}
