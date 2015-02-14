namespace Control_de_inventario
{
    partial class InvRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public InvRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.InvGroupOperaciones = this.Factory.CreateRibbonGroup();
            this.InvGroupAlmacen = this.Factory.CreateRibbonGroup();
            this.InvGroupReportes = this.Factory.CreateRibbonGroup();
            this.InvGroupAgentes = this.Factory.CreateRibbonGroup();
            this.BtnCobrarVentas = this.Factory.CreateRibbonButton();
            this.BtnPagarCompra = this.Factory.CreateRibbonButton();
            this.BtnCotizacion = this.Factory.CreateRibbonButton();
            this.BtnVentas = this.Factory.CreateRibbonButton();
            this.BtnCompras = this.Factory.CreateRibbonButton();
            this.BtnProductos = this.Factory.CreateRibbonButton();
            this.BtnMarcas = this.Factory.CreateRibbonButton();
            this.BtnReporteCosto = this.Factory.CreateRibbonButton();
            this.BtnReporteCompras = this.Factory.CreateRibbonButton();
            this.BtnReporteVentas = this.Factory.CreateRibbonButton();
            this.BtnProveedores = this.Factory.CreateRibbonButton();
            this.BtnClientes = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.InvGroupOperaciones.SuspendLayout();
            this.InvGroupAlmacen.SuspendLayout();
            this.InvGroupReportes.SuspendLayout();
            this.InvGroupAgentes.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.InvGroupOperaciones);
            this.tab1.Groups.Add(this.InvGroupAlmacen);
            this.tab1.Groups.Add(this.InvGroupReportes);
            this.tab1.Groups.Add(this.InvGroupAgentes);
            this.tab1.Label = "Inventario";
            this.tab1.Name = "tab1";
            // 
            // InvGroupOperaciones
            // 
            this.InvGroupOperaciones.Items.Add(this.BtnCobrarVentas);
            this.InvGroupOperaciones.Items.Add(this.BtnPagarCompra);
            this.InvGroupOperaciones.Items.Add(this.BtnCotizacion);
            this.InvGroupOperaciones.Items.Add(this.BtnVentas);
            this.InvGroupOperaciones.Items.Add(this.BtnCompras);
            this.InvGroupOperaciones.Label = "Operaciones";
            this.InvGroupOperaciones.Name = "InvGroupOperaciones";
            // 
            // InvGroupAlmacen
            // 
            this.InvGroupAlmacen.Items.Add(this.BtnProductos);
            this.InvGroupAlmacen.Items.Add(this.BtnMarcas);
            this.InvGroupAlmacen.Label = "Almacen";
            this.InvGroupAlmacen.Name = "InvGroupAlmacen";
            // 
            // InvGroupReportes
            // 
            this.InvGroupReportes.Items.Add(this.BtnReporteCosto);
            this.InvGroupReportes.Items.Add(this.BtnReporteCompras);
            this.InvGroupReportes.Items.Add(this.BtnReporteVentas);
            this.InvGroupReportes.Label = "Reportes";
            this.InvGroupReportes.Name = "InvGroupReportes";
            // 
            // InvGroupAgentes
            // 
            this.InvGroupAgentes.Items.Add(this.BtnProveedores);
            this.InvGroupAgentes.Items.Add(this.BtnClientes);
            this.InvGroupAgentes.Label = "Agentes";
            this.InvGroupAgentes.Name = "InvGroupAgentes";
            // 
            // BtnCobrarVentas
            // 
            this.BtnCobrarVentas.Image = global::Control_de_inventario.Properties.Resources.save_money;
            this.BtnCobrarVentas.Label = "Cobrar ventas";
            this.BtnCobrarVentas.Name = "BtnCobrarVentas";
            this.BtnCobrarVentas.ShowImage = true;
            // 
            // BtnPagarCompra
            // 
            this.BtnPagarCompra.Image = global::Control_de_inventario.Properties.Resources.card_money;
            this.BtnPagarCompra.Label = "Pagar compras";
            this.BtnPagarCompra.Name = "BtnPagarCompra";
            this.BtnPagarCompra.ShowImage = true;
            // 
            // BtnCotizacion
            // 
            this.BtnCotizacion.Image = global::Control_de_inventario.Properties.Resources.to_do_list_cheked_all;
            this.BtnCotizacion.Label = "Cotizacion";
            this.BtnCotizacion.Name = "BtnCotizacion";
            this.BtnCotizacion.ShowImage = true;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Image = global::Control_de_inventario.Properties.Resources.cash_register_2;
            this.BtnVentas.Label = "Ventas";
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.ShowImage = true;
            // 
            // BtnCompras
            // 
            this.BtnCompras.Image = global::Control_de_inventario.Properties.Resources.basket_shopping;
            this.BtnCompras.Label = "Compras";
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.ShowImage = true;
            // 
            // BtnProductos
            // 
            this.BtnProductos.Image = global::Control_de_inventario.Properties.Resources.box_open;
            this.BtnProductos.Label = "Productos";
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.ShowImage = true;
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Image = global::Control_de_inventario.Properties.Resources.tag_red;
            this.BtnMarcas.Label = "Marcas";
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.ShowImage = true;
            this.BtnMarcas.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnMarcas_Click);
            // 
            // BtnReporteCosto
            // 
            this.BtnReporteCosto.Image = global::Control_de_inventario.Properties.Resources.total_plan_cost;
            this.BtnReporteCosto.Label = "Costo de venta";
            this.BtnReporteCosto.Name = "BtnReporteCosto";
            this.BtnReporteCosto.ShowImage = true;
            // 
            // BtnReporteCompras
            // 
            this.BtnReporteCompras.Image = global::Control_de_inventario.Properties.Resources.manage_sources;
            this.BtnReporteCompras.Label = "Compras efectuadas";
            this.BtnReporteCompras.Name = "BtnReporteCompras";
            this.BtnReporteCompras.ShowImage = true;
            // 
            // BtnReporteVentas
            // 
            this.BtnReporteVentas.Image = global::Control_de_inventario.Properties.Resources.application_parts;
            this.BtnReporteVentas.Label = "Ventas efectuadas";
            this.BtnReporteVentas.Name = "BtnReporteVentas";
            this.BtnReporteVentas.ShowImage = true;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Image = global::Control_de_inventario.Properties.Resources.baggage_cart_box;
            this.BtnProveedores.Label = "Proveedores";
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.ShowImage = true;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Image = global::Control_de_inventario.Properties.Resources.xfn;
            this.BtnClientes.Label = "Clientes";
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.ShowImage = true;
            // 
            // InvRibbon
            // 
            this.Name = "InvRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.InvRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.InvGroupOperaciones.ResumeLayout(false);
            this.InvGroupOperaciones.PerformLayout();
            this.InvGroupAlmacen.ResumeLayout(false);
            this.InvGroupAlmacen.PerformLayout();
            this.InvGroupReportes.ResumeLayout(false);
            this.InvGroupReportes.PerformLayout();
            this.InvGroupAgentes.ResumeLayout(false);
            this.InvGroupAgentes.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InvGroupOperaciones;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InvGroupAlmacen;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InvGroupReportes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnMarcas;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnProductos;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnVentas;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnCompras;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnCotizacion;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnPagarCompra;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnCobrarVentas;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnReporteVentas;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnReporteCompras;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnReporteCosto;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup InvGroupAgentes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnClientes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnProveedores;
    }

    partial class ThisRibbonCollection
    {
        internal InvRibbon InvRibbon
        {
            get { return this.GetRibbon<InvRibbon>(); }
        }
    }
}
