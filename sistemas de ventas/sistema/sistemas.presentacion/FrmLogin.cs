using sistema.negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemas.presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Login(TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                if (tabla.Rows.Count<=0)
                {
                    MessageBox.Show("El email o la clave es incorrecta.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(tabla.Rows[0][4])==false)
                    {
                        MessageBox.Show("El usuario esta inactivo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        Variables.IdUsuario= Convert.ToInt32(tabla.Rows[0][0]);
                        frm.IdUsuario = Convert.ToInt32(tabla.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(tabla.Rows[0][1]);
                        frm.Rol = Convert.ToString(tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(tabla.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
