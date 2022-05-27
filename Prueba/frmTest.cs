using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITSC\\ITSC 2022\\TSDS\\Base de datos\\Access\\toldito.mdb;User Id=admin;Password=;";
            OleDbConnection con = new OleDbConnection(cadena);

            try
            {
                con.Open();
                MessageBox.Show("Conexión Exitosa");
                btnSalir.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Conexión fallida");
            }
            con.Close();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            btnSalir.Visible = false;
        }
    }
}
