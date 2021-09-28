using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class ConsultaProceso : Form
    {
        controlador cn = new controlador();
        string emp = "usuarios";
        public ConsultaProceso()
        {
            InitializeComponent();
        }


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarProceso(emp);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }



        private void ConsultaProceso_Load(object sender, EventArgs e)
        {
         
        }

        private void asd_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
