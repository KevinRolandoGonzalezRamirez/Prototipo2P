using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.ConsultaCompras();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.IngresoCompras();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void realizarProcesoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.Form1();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void consultarElProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.ConsultaProceso();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.informe5();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void procesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAU = new CapaVista.informe6();
            frmAU.MdiParent = this;
            frmAU.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Help.ShowHelp(this, "ayuda.chm", "ayuda.html");

        }
    }
}
