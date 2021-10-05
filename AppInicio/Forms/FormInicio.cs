using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AppInicio.Forms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            
            pnFormHijo.Controls.Clear();
            pnFormHijo.Controls.Add(frm);

            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Seguro que desea salir de la aplicación S/N ?",
              "Salir de la applicación",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;

            pnFormHijo.Controls.Clear();
            pnFormHijo.Controls.Add(frm);

            frm.Show();
        }
        
    }
}
