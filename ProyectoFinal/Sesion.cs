using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;

namespace ProyectoFinal
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion cone = new Conexion();
                string contra = Encriptar(tbContraS.Text);
                string query = "insert into Usuario(Nombre,Correo,Contrasenia,Telefono) values ('" + tbUsuarioS.Text + "','" + tbCorreo.Text + "','" + contra + "','" + tbTelefono.Text + "')";
                DataTable usuario = cone.Query("select * from Usuario where Nombre='" + tbUsuarioS.Text + "' or Correo='" + tbCorreo.Text+"'");

                if (usuario.Rows.Count != 0)
                    MessageBox.Show("Ya existe un usuario con ese Nombre/Correo");
                else
                {
                    cone.Query(query);
                    MessageBox.Show("Usuario creado");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }

        private string Encriptar(string contra)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(contra));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion cone = new Conexion();
                string contra = Encriptar(tbContraL.Text);
                DataTable usuario = cone.Query("select Id from Usuario where Nombre='" + tbUsuarioL.Text + "' and Contrasenia='" + contra + "'");

                if (usuario.Rows.Count != 0)
                {
                    frmLenguaje len = new frmLenguaje(usuario.Rows[0]["Id"].ToString(),tbUsuarioL.Text);
                    len.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("No existe un usuario con ese Nombre/Contraseña");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesion");
            }
        }
    }
}
