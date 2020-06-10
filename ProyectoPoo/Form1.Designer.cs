namespace ProyectoPoo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpFCaptura = new System.Windows.Forms.DateTimePicker();
            this.BoxProveedor = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonoMensual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxCliente = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostoAcarreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEncargadoC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BoxProducto = new System.Windows.Forms.GroupBox();
            this.dtpExpiracion = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ListaEmpresas = new System.Windows.Forms.DataGridView();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncargadoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncargadoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.groupArchivo = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.ckbPermitir = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbProveedor = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbTotal = new System.Windows.Forms.RadioButton();
            this.btnLlenarTexto = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnAbrirCompartir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.BoxProveedor.SuspendLayout();
            this.BoxCliente.SuspendLayout();
            this.BoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpresas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupArchivo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFCaptura
            // 
            this.dtpFCaptura.Enabled = false;
            this.dtpFCaptura.Location = new System.Drawing.Point(6, 131);
            this.dtpFCaptura.Name = "dtpFCaptura";
            this.dtpFCaptura.Size = new System.Drawing.Size(200, 20);
            this.dtpFCaptura.TabIndex = 0;
            // 
            // BoxProveedor
            // 
            this.BoxProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BoxProveedor.Controls.Add(this.label11);
            this.BoxProveedor.Controls.Add(this.txtDescuento);
            this.BoxProveedor.Controls.Add(this.label5);
            this.BoxProveedor.Controls.Add(this.txtBonoMensual);
            this.BoxProveedor.Controls.Add(this.label4);
            this.BoxProveedor.Controls.Add(this.txtEncargado);
            this.BoxProveedor.Controls.Add(this.label3);
            this.BoxProveedor.Controls.Add(this.txtDireccionP);
            this.BoxProveedor.Controls.Add(this.label2);
            this.BoxProveedor.Controls.Add(this.txtNombreP);
            this.BoxProveedor.Controls.Add(this.label1);
            this.BoxProveedor.Location = new System.Drawing.Point(13, 13);
            this.BoxProveedor.Name = "BoxProveedor";
            this.BoxProveedor.Size = new System.Drawing.Size(207, 163);
            this.BoxProveedor.TabIndex = 1;
            this.BoxProveedor.TabStop = false;
            this.BoxProveedor.Text = "Datos del proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "<-";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(72, 137);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 7;
            this.txtDescuento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AccionHabilitar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descuento";
            // 
            // txtBonoMensual
            // 
            this.txtBonoMensual.Location = new System.Drawing.Point(116, 110);
            this.txtBonoMensual.Name = "txtBonoMensual";
            this.txtBonoMensual.Size = new System.Drawing.Size(63, 20);
            this.txtBonoMensual.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bono por preferencia";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(72, 68);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encargado";
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.Location = new System.Drawing.Point(72, 42);
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(72, 16);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // BoxCliente
            // 
            this.BoxCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BoxCliente.Controls.Add(this.label16);
            this.BoxCliente.Controls.Add(this.label6);
            this.BoxCliente.Controls.Add(this.txtCostoAcarreo);
            this.BoxCliente.Controls.Add(this.label7);
            this.BoxCliente.Controls.Add(this.dtpFCaptura);
            this.BoxCliente.Controls.Add(this.txtEncargadoC);
            this.BoxCliente.Controls.Add(this.label8);
            this.BoxCliente.Controls.Add(this.txtDireccion);
            this.BoxCliente.Controls.Add(this.label9);
            this.BoxCliente.Controls.Add(this.txtNombreC);
            this.BoxCliente.Controls.Add(this.label10);
            this.BoxCliente.Enabled = false;
            this.BoxCliente.Location = new System.Drawing.Point(251, 18);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(219, 163);
            this.BoxCliente.TabIndex = 2;
            this.BoxCliente.TabStop = false;
            this.BoxCliente.Text = "Datos del Cliente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "<-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de capturacion";
            // 
            // txtCostoAcarreo
            // 
            this.txtCostoAcarreo.Location = new System.Drawing.Point(100, 91);
            this.txtCostoAcarreo.Name = "txtCostoAcarreo";
            this.txtCostoAcarreo.Size = new System.Drawing.Size(92, 20);
            this.txtCostoAcarreo.TabIndex = 5;
            this.txtCostoAcarreo.TextChanged += new System.EventHandler(this.txtCostoAcarreo_TextChanged);
            this.txtCostoAcarreo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HabilitarProducto);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Costo por acarreo";
            // 
            // txtEncargadoC
            // 
            this.txtEncargadoC.Location = new System.Drawing.Point(72, 68);
            this.txtEncargadoC.Name = "txtEncargadoC";
            this.txtEncargadoC.Size = new System.Drawing.Size(100, 20);
            this.txtEncargadoC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Encargado";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 42);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Direccion";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(72, 16);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // BoxProducto
            // 
            this.BoxProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BoxProducto.Controls.Add(this.dtpExpiracion);
            this.BoxProducto.Controls.Add(this.label12);
            this.BoxProducto.Controls.Add(this.txtImporte);
            this.BoxProducto.Controls.Add(this.label13);
            this.BoxProducto.Controls.Add(this.txtMarca);
            this.BoxProducto.Controls.Add(this.label14);
            this.BoxProducto.Controls.Add(this.txtNombreProd);
            this.BoxProducto.Controls.Add(this.label15);
            this.BoxProducto.Enabled = false;
            this.BoxProducto.Location = new System.Drawing.Point(518, 18);
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(238, 163);
            this.BoxProducto.TabIndex = 3;
            this.BoxProducto.TabStop = false;
            this.BoxProducto.Text = "Datos del producto";
            // 
            // dtpExpiracion
            // 
            this.dtpExpiracion.Location = new System.Drawing.Point(6, 115);
            this.dtpExpiracion.Name = "dtpExpiracion";
            this.dtpExpiracion.Size = new System.Drawing.Size(213, 20);
            this.dtpExpiracion.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Fecha de expiracion";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(72, 68);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Importe";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(72, 42);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Marca";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(72, 16);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProd.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nombre";
            // 
            // ListaEmpresas
            // 
            this.ListaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreP,
            this.DireccionP,
            this.EncargadoP,
            this.NombreC,
            this.DireccionC,
            this.EncargadoC,
            this.FFactura,
            this.NombrePr,
            this.Marca,
            this.Expiracion,
            this.ImporteN,
            this.Total});
            this.ListaEmpresas.Location = new System.Drawing.Point(20, 198);
            this.ListaEmpresas.Name = "ListaEmpresas";
            this.ListaEmpresas.Size = new System.Drawing.Size(777, 348);
            this.ListaEmpresas.TabIndex = 4;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre Proveedor";
            this.NombreP.Name = "NombreP";
            // 
            // DireccionP
            // 
            this.DireccionP.HeaderText = "Direccion del Proveedor";
            this.DireccionP.Name = "DireccionP";
            // 
            // EncargadoP
            // 
            this.EncargadoP.HeaderText = "Proveedor Encargado ";
            this.EncargadoP.Name = "EncargadoP";
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre del Cliente";
            this.NombreC.Name = "NombreC";
            // 
            // DireccionC
            // 
            this.DireccionC.HeaderText = "Direccion del Cliente";
            this.DireccionC.Name = "DireccionC";
            // 
            // EncargadoC
            // 
            this.EncargadoC.HeaderText = "Representante de la empresa";
            this.EncargadoC.Name = "EncargadoC";
            // 
            // FFactura
            // 
            this.FFactura.HeaderText = "Fecha de Facturacion";
            this.FFactura.Name = "FFactura";
            // 
            // NombrePr
            // 
            this.NombrePr.HeaderText = "Nombre del Producto";
            this.NombrePr.Name = "NombrePr";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca del Producto";
            this.Marca.Name = "Marca";
            // 
            // Expiracion
            // 
            this.Expiracion.HeaderText = "Fecha de expiracion";
            this.Expiracion.Name = "Expiracion";
            // 
            // ImporteN
            // 
            this.ImporteN.HeaderText = "Importe Neta";
            this.ImporteN.Name = "ImporteN";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(762, 29);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(82, 39);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(863, 28);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(81, 41);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Actualizar lista ";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(836, 115);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rdbDescendente);
            this.groupBox1.Controls.Add(this.rdbAscendente);
            this.groupBox1.Location = new System.Drawing.Point(815, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(7, 43);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rdbDescendente.TabIndex = 1;
            this.rdbDescendente.TabStop = true;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Location = new System.Drawing.Point(7, 20);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rdbAscendente.TabIndex = 0;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "Ascendente";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            // 
            // groupArchivo
            // 
            this.groupArchivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupArchivo.Controls.Add(this.btnCrear);
            this.groupArchivo.Controls.Add(this.btnExaminar);
            this.groupArchivo.Enabled = false;
            this.groupArchivo.Location = new System.Drawing.Point(815, 474);
            this.groupArchivo.Name = "groupArchivo";
            this.groupArchivo.Size = new System.Drawing.Size(132, 86);
            this.groupArchivo.TabIndex = 9;
            this.groupArchivo.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(21, 49);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(92, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // ckbPermitir
            // 
            this.ckbPermitir.AutoSize = true;
            this.ckbPermitir.Location = new System.Drawing.Point(815, 438);
            this.ckbPermitir.Name = "ckbPermitir";
            this.ckbPermitir.Size = new System.Drawing.Size(106, 30);
            this.ckbPermitir.TabIndex = 10;
            this.ckbPermitir.Text = "¿Desea cambiar \r\nde archivo?";
            this.ckbPermitir.UseVisualStyleBackColor = true;
            this.ckbPermitir.CheckedChanged += new System.EventHandler(this.ckbPermitir_CheckedChanged);
            this.ckbPermitir.CheckStateChanged += new System.EventHandler(this.PermitirCambio);
            this.ckbPermitir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pulsar);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(822, 78);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.rdbProducto);
            this.groupBox3.Controls.Add(this.rdbCliente);
            this.groupBox3.Controls.Add(this.rdbProveedor);
            this.groupBox3.Controls.Add(this.rdbFecha);
            this.groupBox3.Controls.Add(this.rdbTotal);
            this.groupBox3.Location = new System.Drawing.Point(815, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 151);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar por";
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(7, 115);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(68, 17);
            this.rdbProducto.TabIndex = 4;
            this.rdbProducto.TabStop = true;
            this.rdbProducto.Text = "Producto";
            this.rdbProducto.UseVisualStyleBackColor = true;
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(7, 91);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 3;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // rdbProveedor
            // 
            this.rdbProveedor.AutoSize = true;
            this.rdbProveedor.Location = new System.Drawing.Point(7, 67);
            this.rdbProveedor.Name = "rdbProveedor";
            this.rdbProveedor.Size = new System.Drawing.Size(74, 17);
            this.rdbProveedor.TabIndex = 2;
            this.rdbProveedor.TabStop = true;
            this.rdbProveedor.Text = "Proveedor";
            this.rdbProveedor.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(7, 44);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(109, 17);
            this.rdbFecha.TabIndex = 1;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha de captura";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbTotal
            // 
            this.rdbTotal.AutoSize = true;
            this.rdbTotal.Location = new System.Drawing.Point(7, 19);
            this.rdbTotal.Name = "rdbTotal";
            this.rdbTotal.Size = new System.Drawing.Size(49, 17);
            this.rdbTotal.TabIndex = 0;
            this.rdbTotal.TabStop = true;
            this.rdbTotal.Text = "Total";
            this.rdbTotal.UseVisualStyleBackColor = true;
            // 
            // btnLlenarTexto
            // 
            this.btnLlenarTexto.Location = new System.Drawing.Point(839, 0);
            this.btnLlenarTexto.Name = "btnLlenarTexto";
            this.btnLlenarTexto.Size = new System.Drawing.Size(25, 23);
            this.btnLlenarTexto.TabIndex = 5;
            this.btnLlenarTexto.Text = "?";
            this.btnLlenarTexto.UseVisualStyleBackColor = true;
            this.btnLlenarTexto.Click += new System.EventHandler(this.btnLlenarTexto_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.Filter = "Archivo .dat(*)|*.dat|Archivo .txt(*)|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo .dat(*)|*.dat|Archivo .txt(*)|*.txt";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnAbrirCompartir
            // 
            this.btnAbrirCompartir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirCompartir.BackgroundImage")));
            this.btnAbrirCompartir.Location = new System.Drawing.Point(762, 153);
            this.btnAbrirCompartir.Name = "btnAbrirCompartir";
            this.btnAbrirCompartir.Size = new System.Drawing.Size(47, 39);
            this.btnAbrirCompartir.TabIndex = 13;
            this.btnAbrirCompartir.UseVisualStyleBackColor = true;
            this.btnAbrirCompartir.Click += new System.EventHandler(this.btnAbrirCompartir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(21, 20);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(92, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 572);
            this.Controls.Add(this.btnAbrirCompartir);
            this.Controls.Add(this.btnLlenarTexto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ckbPermitir);
            this.Controls.Add(this.groupArchivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.ListaEmpresas);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.BoxProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CommersXRegister";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxProveedor.ResumeLayout(false);
            this.BoxProveedor.PerformLayout();
            this.BoxCliente.ResumeLayout(false);
            this.BoxCliente.PerformLayout();
            this.BoxProducto.ResumeLayout(false);
            this.BoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEmpresas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupArchivo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFCaptura;
        private System.Windows.Forms.GroupBox BoxProveedor;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBonoMensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccionP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox BoxCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCostoAcarreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEncargadoC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox BoxProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpExpiracion;
        private System.Windows.Forms.DataGridView ListaEmpresas;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.RadioButton rdbAscendente;
        private System.Windows.Forms.GroupBox groupArchivo;
        private System.Windows.Forms.CheckBox ckbPermitir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbTotal;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnLlenarTexto;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbProveedor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncargadoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncargadoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnAbrirCompartir;
        private System.Windows.Forms.Button btnCrear;
    }
}

