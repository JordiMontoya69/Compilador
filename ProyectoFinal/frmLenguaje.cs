using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmLenguaje : Form
    {
        private string id, usr;

        public frmLenguaje(string id, string usr)
        {
            InitializeComponent();
            cbLenguaje.SelectedIndex = 0;
            this.id = id;
            this.usr = usr;
        }

        private void frmLenguaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmCompilador com = new frmCompilador(id, usr, (cbLenguaje.SelectedIndex + 1).ToString(), cbLenguaje.Text);
            com.Visible = true;
            this.Visible = false;
        }
    }
}
