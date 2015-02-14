using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Control_de_inventario.Formularios;

namespace Control_de_inventario
{
    public partial class InvRibbon
    {
        private void InvRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void BtnMarcas_Click(object sender, RibbonControlEventArgs e)
        {
            FrmMarcas ventana = new FrmMarcas();
            ventana.ShowDialog();
        }
    }
}
