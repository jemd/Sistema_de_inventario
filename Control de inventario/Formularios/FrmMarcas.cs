using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvDataAccess;

namespace Control_de_inventario.Formularios
{
    public partial class FrmMarcas : Form
    {

        private InvEntitiesModel Entidad;

        public FrmMarcas()
        {
            InitializeComponent();
            Entidad = new InvEntitiesModel();
        }

        private void FrmMarcas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            Botones(false);
            CargarMarcas();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Botones(bool flag)
        {
            switch (flag)
            {
                case true:
                    BtnAgregar.Enabled = false;
                    BtnGuardar.Enabled = true;
                    TxtMarca.Enabled = true;
                    TxtMarca.Text = "";
                    break;
                case false:
                    BtnAgregar.Enabled = true;
                    BtnGuardar.Enabled = false;
                    TxtMarca.Enabled = false;
                    TxtMarca.Text = "";
                    break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Botones(true);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtMarca.TextLength > 1)
            {
                Marca mark = new Marca();
                mark.Marca1 = TxtMarca.Text;

                Entidad.Add(mark);
                Entidad.SaveChanges();

                Botones(false);
                CargarMarcas();
            }
            else
            {
                MessageBox.Show("Debe indicar el nombre de la marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtMarca.Focus();
            }
        }

        private void CargarMarcas()
        {
            var ListMarcas = from m in Entidad.Marcas
                             select new { Marca = m.Marca1 };

            DataGridMarcas.DataSource = ListMarcas.ToList();
            DataGridMarcas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
