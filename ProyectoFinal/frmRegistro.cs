using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            Conexion con = new Conexion();
            dgvRegistros.DataSource = con.Query("select U.Nombre as Usuario,L.Nombre as Lenguaje,R.fecha as Fecha,R.salida as Salida from Registro as R,Usuario as U,Lenguaje as L where R.IdUsuario = U.Id and L.Id = R.IdLenguaje");
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            sfdExportar.DefaultExt = "txt";
            sfdExportar.ShowDialog();

            try
            {
                StreamWriter sw = new StreamWriter(sfdExportar.FileName);
                foreach (DataGridViewRow linea in dgvRegistros.Rows)
                {
                    sw.WriteLine(linea.Cells["Usuario"].Value + " " + linea.Cells["Lenguaje"].Value + " " + linea.Cells["Fecha"].Value + " " + linea.Cells["Salida"].Value);
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            sfdExportar.DefaultExt = "csv";
            sfdExportar.ShowDialog();

            try
            {
                StreamWriter sw = new StreamWriter(sfdExportar.FileName);
                foreach (DataGridViewRow linea in dgvRegistros.Rows)
                {
                    sw.WriteLine(linea.Cells["Usuario"].Value + "," + linea.Cells["Lenguaje"].Value + "," + linea.Cells["Fecha"].Value+ "," + linea.Cells["Salida"].Value);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnXlsx_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvRegistros);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string query = "select U.Nombre as Usuario,L.Nombre as Lenguaje,R.fecha as Fecha,R.salida as Salida from Registro as R,Usuario as U,Lenguaje as L where R.IdUsuario = U.Id and L.Id = R.IdLenguaje";
            Conexion con = new Conexion();
            if (cbUsuario.Checked) query += " and U.Nombre='" + tbUsuario.Text + "'";
            if (cbLenguaje.Checked) query += " and L.Nombre='" + tbLenguaje.Text + "'";
            if (cbFecha.Checked) query += " and Fecha between '" + dtpInicio.Value.ToString("yyyy/MM/dd") + "' and '" + dtpFinal.Value.ToString("yyyy/MM/dd") + "'";
            dgvRegistros.DataSource = con.Query(query);
            
        }
    }
}
