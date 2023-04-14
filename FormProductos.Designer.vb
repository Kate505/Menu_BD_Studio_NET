<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDProductoLabel As System.Windows.Forms.Label
        Dim FechaCompraLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PucLabel As System.Windows.Forms.Label
        Dim PuvLabel As System.Windows.Forms.Label
        Dim Ct_Tot_CompraLabel As System.Windows.Forms.Label
        Dim Ct_Tot_VentaLabel As System.Windows.Forms.Label
        Dim GananciaLabel As System.Windows.Forms.Label
        Dim IDProductoLabel1 As System.Windows.Forms.Label
        Dim IDProveedorLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.Producto_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.Producto_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.Producto_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.Producto_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.Producto_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClean = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate = New System.Windows.Forms.PictureBox()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.IDProductoTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProductoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.IDProductoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PucTextBox = New System.Windows.Forms.TextBox()
        Me.PuvTextBox = New System.Windows.Forms.TextBox()
        Me.Ct_Tot_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Ct_Tot_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.GananciaTextBox = New System.Windows.Forms.TextBox()
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.ProductoTableAdapter = New Libreria.LibreriaDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter()
        Me.Producto_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View1TableAdapter()
        Me.Producto_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View2TableAdapter()
        Me.Producto_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View3TableAdapter()
        Me.Producto_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View4TableAdapter()
        Me.Producto_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View5TableAdapter()
        IDProductoLabel = New System.Windows.Forms.Label()
        FechaCompraLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PucLabel = New System.Windows.Forms.Label()
        PuvLabel = New System.Windows.Forms.Label()
        Ct_Tot_CompraLabel = New System.Windows.Forms.Label()
        Ct_Tot_VentaLabel = New System.Windows.Forms.Label()
        GananciaLabel = New System.Windows.Forms.Label()
        IDProductoLabel1 = New System.Windows.Forms.Label()
        IDProveedorLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.Producto_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.Producto_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.Producto_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.Producto_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.Producto_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTablas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDProductoLabel
        '
        IDProductoLabel.AutoSize = True
        IDProductoLabel.ForeColor = System.Drawing.Color.White
        IDProductoLabel.Location = New System.Drawing.Point(522, 58)
        IDProductoLabel.Name = "IDProductoLabel"
        IDProductoLabel.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel.TabIndex = 2
        IDProductoLabel.Text = "IDProducto:"
        '
        'FechaCompraLabel
        '
        FechaCompraLabel.AutoSize = True
        FechaCompraLabel.ForeColor = System.Drawing.Color.White
        FechaCompraLabel.Location = New System.Drawing.Point(522, 85)
        FechaCompraLabel.Name = "FechaCompraLabel"
        FechaCompraLabel.Size = New System.Drawing.Size(79, 13)
        FechaCompraLabel.TabIndex = 4
        FechaCompraLabel.Text = "Fecha Compra:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.ForeColor = System.Drawing.Color.White
        CantidadLabel.Location = New System.Drawing.Point(522, 110)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 6
        CantidadLabel.Text = "Cantidad:"
        '
        'PucLabel
        '
        PucLabel.AutoSize = True
        PucLabel.ForeColor = System.Drawing.Color.White
        PucLabel.Location = New System.Drawing.Point(522, 136)
        PucLabel.Name = "PucLabel"
        PucLabel.Size = New System.Drawing.Size(29, 13)
        PucLabel.TabIndex = 8
        PucLabel.Text = "Puc:"
        '
        'PuvLabel
        '
        PuvLabel.AutoSize = True
        PuvLabel.ForeColor = System.Drawing.Color.White
        PuvLabel.Location = New System.Drawing.Point(522, 162)
        PuvLabel.Name = "PuvLabel"
        PuvLabel.Size = New System.Drawing.Size(29, 13)
        PuvLabel.TabIndex = 10
        PuvLabel.Text = "Puv:"
        '
        'Ct_Tot_CompraLabel
        '
        Ct_Tot_CompraLabel.AutoSize = True
        Ct_Tot_CompraLabel.ForeColor = System.Drawing.Color.White
        Ct_Tot_CompraLabel.Location = New System.Drawing.Point(522, 188)
        Ct_Tot_CompraLabel.Name = "Ct_Tot_CompraLabel"
        Ct_Tot_CompraLabel.Size = New System.Drawing.Size(78, 13)
        Ct_Tot_CompraLabel.TabIndex = 12
        Ct_Tot_CompraLabel.Text = "Ct Tot Compra:"
        '
        'Ct_Tot_VentaLabel
        '
        Ct_Tot_VentaLabel.AutoSize = True
        Ct_Tot_VentaLabel.ForeColor = System.Drawing.Color.White
        Ct_Tot_VentaLabel.Location = New System.Drawing.Point(522, 214)
        Ct_Tot_VentaLabel.Name = "Ct_Tot_VentaLabel"
        Ct_Tot_VentaLabel.Size = New System.Drawing.Size(70, 13)
        Ct_Tot_VentaLabel.TabIndex = 14
        Ct_Tot_VentaLabel.Text = "Ct Tot Venta:"
        '
        'GananciaLabel
        '
        GananciaLabel.AutoSize = True
        GananciaLabel.ForeColor = System.Drawing.Color.White
        GananciaLabel.Location = New System.Drawing.Point(522, 240)
        GananciaLabel.Name = "GananciaLabel"
        GananciaLabel.Size = New System.Drawing.Size(56, 13)
        GananciaLabel.TabIndex = 16
        GananciaLabel.Text = "Ganancia:"
        '
        'IDProductoLabel1
        '
        IDProductoLabel1.AutoSize = True
        IDProductoLabel1.ForeColor = System.Drawing.Color.White
        IDProductoLabel1.Location = New System.Drawing.Point(520, 356)
        IDProductoLabel1.Name = "IDProductoLabel1"
        IDProductoLabel1.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel1.TabIndex = 18
        IDProductoLabel1.Text = "IDProducto:"
        '
        'IDProveedorLabel
        '
        IDProveedorLabel.AutoSize = True
        IDProveedorLabel.ForeColor = System.Drawing.Color.White
        IDProveedorLabel.Location = New System.Drawing.Point(520, 382)
        IDProveedorLabel.Name = "IDProveedorLabel"
        IDProveedorLabel.Size = New System.Drawing.Size(70, 13)
        IDProveedorLabel.TabIndex = 20
        IDProveedorLabel.Text = "IDProveedor:"
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.ForeColor = System.Drawing.Color.White
        NombreProductoLabel.Location = New System.Drawing.Point(520, 408)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(93, 13)
        NombreProductoLabel.TabIndex = 22
        NombreProductoLabel.Text = "Nombre Producto:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.ForeColor = System.Drawing.Color.White
        MarcaLabel.Location = New System.Drawing.Point(520, 434)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 24
        MarcaLabel.Text = "Marca:"
        '
        'IDProducto_IDProveedor_NombreProducto_MarcaBindingSource
        '
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource.DataMember = "FK__IDProduct__IDPro__48CFD27E"
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource.DataSource = Me.ProductoBindingSource
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.LibreriaDataSet
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.Producto_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 522)
        Me.PanelV5.TabIndex = 47
        '
        'Producto_View5DataGridView
        '
        Me.Producto_View5DataGridView.AutoGenerateColumns = False
        Me.Producto_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Producto_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Producto_View5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Producto_View5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.Producto_View5DataGridView.DataSource = Me.Producto_View5BindingSource
        Me.Producto_View5DataGridView.Location = New System.Drawing.Point(19, 92)
        Me.Producto_View5DataGridView.Name = "Producto_View5DataGridView"
        Me.Producto_View5DataGridView.RowHeadersVisible = False
        Me.Producto_View5DataGridView.Size = New System.Drawing.Size(657, 354)
        Me.Producto_View5DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn31.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn33.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "PUV"
        Me.DataGridViewTextBoxColumn34.HeaderText = "PUV"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'Producto_View5BindingSource
        '
        Me.Producto_View5BindingSource.DataMember = "Producto_View5"
        Me.Producto_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.Producto_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 522)
        Me.PanelV4.TabIndex = 46
        '
        'Producto_View4DataGridView
        '
        Me.Producto_View4DataGridView.AutoGenerateColumns = False
        Me.Producto_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Producto_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Producto_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Producto_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30})
        Me.Producto_View4DataGridView.DataSource = Me.Producto_View4BindingSource
        Me.Producto_View4DataGridView.Location = New System.Drawing.Point(267, 175)
        Me.Producto_View4DataGridView.Name = "Producto_View4DataGridView"
        Me.Producto_View4DataGridView.RowHeadersVisible = False
        Me.Producto_View4DataGridView.Size = New System.Drawing.Size(175, 145)
        Me.Producto_View4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Sum_PUC"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Sum_PUC"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'Producto_View4BindingSource
        '
        Me.Producto_View4BindingSource.DataMember = "Producto_View4"
        Me.Producto_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.Producto_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 522)
        Me.PanelV3.TabIndex = 45
        '
        'Producto_View3DataGridView
        '
        Me.Producto_View3DataGridView.AutoGenerateColumns = False
        Me.Producto_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Producto_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Producto_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Producto_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.Producto_View3DataGridView.DataSource = Me.Producto_View3BindingSource
        Me.Producto_View3DataGridView.Location = New System.Drawing.Point(63, 64)
        Me.Producto_View3DataGridView.Name = "Producto_View3DataGridView"
        Me.Producto_View3DataGridView.RowHeadersVisible = False
        Me.Producto_View3DataGridView.Size = New System.Drawing.Size(582, 360)
        Me.Producto_View3DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn25.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FechaCompra"
        Me.DataGridViewTextBoxColumn26.HeaderText = "FechaCompra"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn28.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'Producto_View3BindingSource
        '
        Me.Producto_View3BindingSource.DataMember = "Producto_View3"
        Me.Producto_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.Producto_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 522)
        Me.PanelV2.TabIndex = 44
        '
        'Producto_View2DataGridView
        '
        Me.Producto_View2DataGridView.AutoGenerateColumns = False
        Me.Producto_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Producto_View2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Producto_View2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Producto_View2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Producto_View2DataGridView.DataSource = Me.Producto_View2BindingSource
        Me.Producto_View2DataGridView.Location = New System.Drawing.Point(72, 89)
        Me.Producto_View2DataGridView.Name = "Producto_View2DataGridView"
        Me.Producto_View2DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Producto_View2DataGridView.RowHeadersVisible = False
        Me.Producto_View2DataGridView.Size = New System.Drawing.Size(561, 288)
        Me.Producto_View2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn21.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn22.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PUV"
        Me.DataGridViewTextBoxColumn23.HeaderText = "PUV"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Producto_View2BindingSource
        '
        Me.Producto_View2BindingSource.DataMember = "Producto_View2"
        Me.Producto_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.Producto_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 522)
        Me.PanelV1.TabIndex = 43
        '
        'Producto_View1DataGridView
        '
        Me.Producto_View1DataGridView.AutoGenerateColumns = False
        Me.Producto_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Producto_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Producto_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Producto_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Producto_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.Producto_View1DataGridView.DataSource = Me.Producto_View1BindingSource
        Me.Producto_View1DataGridView.Location = New System.Drawing.Point(31, 51)
        Me.Producto_View1DataGridView.Name = "Producto_View1DataGridView"
        Me.Producto_View1DataGridView.RowHeadersVisible = False
        Me.Producto_View1DataGridView.Size = New System.Drawing.Size(645, 350)
        Me.Producto_View1DataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FechaCompra"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FechaCompra"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PUV"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PUV"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Producto_View1BindingSource
        '
        Me.Producto_View1BindingSource.DataMember = "Producto_View1"
        Me.Producto_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(IDProductoLabel1)
        Me.PanelTablas.Controls.Add(Me.IDProductoTextBox1)
        Me.PanelTablas.Controls.Add(IDProveedorLabel)
        Me.PanelTablas.Controls.Add(Me.IDProveedorTextBox)
        Me.PanelTablas.Controls.Add(NombreProductoLabel)
        Me.PanelTablas.Controls.Add(Me.NombreProductoTextBox)
        Me.PanelTablas.Controls.Add(MarcaLabel)
        Me.PanelTablas.Controls.Add(Me.MarcaTextBox)
        Me.PanelTablas.Controls.Add(IDProductoLabel)
        Me.PanelTablas.Controls.Add(Me.IDProductoTextBox)
        Me.PanelTablas.Controls.Add(FechaCompraLabel)
        Me.PanelTablas.Controls.Add(Me.FechaCompraDateTimePicker)
        Me.PanelTablas.Controls.Add(CantidadLabel)
        Me.PanelTablas.Controls.Add(Me.CantidadTextBox)
        Me.PanelTablas.Controls.Add(PucLabel)
        Me.PanelTablas.Controls.Add(Me.PucTextBox)
        Me.PanelTablas.Controls.Add(PuvLabel)
        Me.PanelTablas.Controls.Add(Me.PuvTextBox)
        Me.PanelTablas.Controls.Add(Ct_Tot_CompraLabel)
        Me.PanelTablas.Controls.Add(Me.Ct_Tot_CompraTextBox)
        Me.PanelTablas.Controls.Add(Ct_Tot_VentaLabel)
        Me.PanelTablas.Controls.Add(Me.Ct_Tot_VentaTextBox)
        Me.PanelTablas.Controls.Add(GananciaLabel)
        Me.PanelTablas.Controls.Add(Me.GananciaTextBox)
        Me.PanelTablas.Controls.Add(Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView)
        Me.PanelTablas.Controls.Add(Me.ProductoDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(706, 522)
        Me.PanelTablas.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(495, 475)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 35)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Libreria.My.Resources.Resources.clean
        Me.PictureBox1.Location = New System.Drawing.Point(159, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Libreria.My.Resources.Resources.eliminar
        Me.PictureBox2.Location = New System.Drawing.Point(96, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Libreria.My.Resources.Resources.agreg
        Me.PictureBox4.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Libreria.My.Resources.Resources.actualizar
        Me.PictureBox5.Location = New System.Drawing.Point(38, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.Libreria.My.Resources.Resources.buscar
        Me.PictureBox6.Location = New System.Drawing.Point(73, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnClean)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Location = New System.Drawing.Point(503, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 35)
        Me.Panel2.TabIndex = 34
        '
        'BtnClean
        '
        Me.BtnClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClean.Image = Global.Libreria.My.Resources.Resources.clean
        Me.BtnClean.Location = New System.Drawing.Point(159, 6)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(29, 23)
        Me.BtnClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnClean.TabIndex = 32
        Me.BtnClean.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Libreria.My.Resources.Resources.eliminar
        Me.PictureBox3.Location = New System.Drawing.Point(96, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Image = Global.Libreria.My.Resources.Resources.agreg
        Me.BtnAdd.Location = New System.Drawing.Point(3, 6)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(29, 23)
        Me.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnAdd.TabIndex = 28
        Me.BtnAdd.TabStop = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Image = Global.Libreria.My.Resources.Resources.actualizar
        Me.BtnUpdate.Location = New System.Drawing.Point(38, 6)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(29, 23)
        Me.BtnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnUpdate.TabIndex = 29
        Me.BtnUpdate.TabStop = False
        '
        'BtnSearch
        '
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.Image = Global.Libreria.My.Resources.Resources.buscar
        Me.BtnSearch.Location = New System.Drawing.Point(73, 6)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(17, 20)
        Me.BtnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSearch.TabIndex = 30
        Me.BtnSearch.TabStop = False
        '
        'IDProductoTextBox1
        '
        Me.IDProductoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, "IDProducto", True))
        Me.IDProductoTextBox1.Location = New System.Drawing.Point(619, 353)
        Me.IDProductoTextBox1.Name = "IDProductoTextBox1"
        Me.IDProductoTextBox1.Size = New System.Drawing.Size(67, 20)
        Me.IDProductoTextBox1.TabIndex = 19
        '
        'IDProveedorTextBox
        '
        Me.IDProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, "IDProveedor", True))
        Me.IDProveedorTextBox.Location = New System.Drawing.Point(619, 379)
        Me.IDProveedorTextBox.Name = "IDProveedorTextBox"
        Me.IDProveedorTextBox.Size = New System.Drawing.Size(67, 20)
        Me.IDProveedorTextBox.TabIndex = 21
        '
        'NombreProductoTextBox
        '
        Me.NombreProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, "NombreProducto", True))
        Me.NombreProductoTextBox.Location = New System.Drawing.Point(619, 405)
        Me.NombreProductoTextBox.Name = "NombreProductoTextBox"
        Me.NombreProductoTextBox.Size = New System.Drawing.Size(67, 20)
        Me.NombreProductoTextBox.TabIndex = 23
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(619, 431)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(67, 20)
        Me.MarcaTextBox.TabIndex = 25
        '
        'IDProductoTextBox
        '
        Me.IDProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "IDProducto", True))
        Me.IDProductoTextBox.Location = New System.Drawing.Point(607, 55)
        Me.IDProductoTextBox.Name = "IDProductoTextBox"
        Me.IDProductoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.IDProductoTextBox.TabIndex = 3
        '
        'FechaCompraDateTimePicker
        '
        Me.FechaCompraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductoBindingSource, "FechaCompra", True))
        Me.FechaCompraDateTimePicker.Location = New System.Drawing.Point(607, 81)
        Me.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker"
        Me.FechaCompraDateTimePicker.Size = New System.Drawing.Size(76, 20)
        Me.FechaCompraDateTimePicker.TabIndex = 5
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(607, 107)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CantidadTextBox.TabIndex = 7
        '
        'PucTextBox
        '
        Me.PucTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Puc", True))
        Me.PucTextBox.Location = New System.Drawing.Point(607, 133)
        Me.PucTextBox.Name = "PucTextBox"
        Me.PucTextBox.Size = New System.Drawing.Size(76, 20)
        Me.PucTextBox.TabIndex = 9
        '
        'PuvTextBox
        '
        Me.PuvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Puv", True))
        Me.PuvTextBox.Location = New System.Drawing.Point(607, 159)
        Me.PuvTextBox.Name = "PuvTextBox"
        Me.PuvTextBox.Size = New System.Drawing.Size(76, 20)
        Me.PuvTextBox.TabIndex = 11
        '
        'Ct_Tot_CompraTextBox
        '
        Me.Ct_Tot_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Ct_Tot_Compra", True))
        Me.Ct_Tot_CompraTextBox.Location = New System.Drawing.Point(607, 185)
        Me.Ct_Tot_CompraTextBox.Name = "Ct_Tot_CompraTextBox"
        Me.Ct_Tot_CompraTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Ct_Tot_CompraTextBox.TabIndex = 13
        '
        'Ct_Tot_VentaTextBox
        '
        Me.Ct_Tot_VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Ct_Tot_Venta", True))
        Me.Ct_Tot_VentaTextBox.Location = New System.Drawing.Point(607, 211)
        Me.Ct_Tot_VentaTextBox.Name = "Ct_Tot_VentaTextBox"
        Me.Ct_Tot_VentaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Ct_Tot_VentaTextBox.TabIndex = 15
        '
        'GananciaTextBox
        '
        Me.GananciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Ganancia", True))
        Me.GananciaTextBox.Location = New System.Drawing.Point(607, 237)
        Me.GananciaTextBox.Name = "GananciaTextBox"
        Me.GananciaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.GananciaTextBox.TabIndex = 17
        '
        'IDProducto_IDProveedor_NombreProducto_MarcaDataGridView
        '
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.AutoGenerateColumns = False
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.DataSource = Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.Location = New System.Drawing.Point(13, 290)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.Name = "IDProducto_IDProveedor_NombreProducto_MarcaDataGridView"
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.RowHeadersVisible = False
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.Size = New System.Drawing.Size(467, 220)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IDProveedor"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IDProveedor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NombreProducto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NombreProducto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ProductoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ProductoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(13, 49)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.RowHeadersVisible = False
        Me.ProductoDataGridView.Size = New System.Drawing.Size(467, 220)
        Me.ProductoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaCompra"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaCompra"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Puc"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Puc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Puv"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Puv"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ct_Tot_Compra"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ct_Tot_Compra"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ct_Tot_Venta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ct_Tot_Venta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'PanelBtnTB
        '
        Me.PanelBtnTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PanelBtnTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBtnTB.Controls.Add(Me.BtnV5)
        Me.PanelBtnTB.Controls.Add(Me.BtnV4)
        Me.PanelBtnTB.Controls.Add(Me.BtnV3)
        Me.PanelBtnTB.Controls.Add(Me.BtnV2)
        Me.PanelBtnTB.Controls.Add(Me.BtnV1)
        Me.PanelBtnTB.Controls.Add(Me.PanelTxtVistas)
        Me.PanelBtnTB.Controls.Add(Me.BtnTbAbonos)
        Me.PanelBtnTB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBtnTB.Location = New System.Drawing.Point(0, 0)
        Me.PanelBtnTB.Name = "PanelBtnTB"
        Me.PanelBtnTB.Size = New System.Drawing.Size(174, 522)
        Me.PanelBtnTB.TabIndex = 41
        '
        'BtnV5
        '
        Me.BtnV5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnV5.FlatAppearance.BorderSize = 0
        Me.BtnV5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV5.ForeColor = System.Drawing.Color.White
        Me.BtnV5.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.BtnV5.IconColor = System.Drawing.Color.White
        Me.BtnV5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnV5.IconSize = 25
        Me.BtnV5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV5.Location = New System.Drawing.Point(0, 300)
        Me.BtnV5.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnV5.Name = "BtnV5"
        Me.BtnV5.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnV5.Size = New System.Drawing.Size(172, 50)
        Me.BtnV5.TabIndex = 51
        Me.BtnV5.Text = "Productos con cantidad > 200"
        Me.BtnV5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV5.UseVisualStyleBackColor = True
        '
        'BtnV4
        '
        Me.BtnV4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnV4.FlatAppearance.BorderSize = 0
        Me.BtnV4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV4.ForeColor = System.Drawing.Color.White
        Me.BtnV4.IconChar = FontAwesome.Sharp.IconChar.ThList
        Me.BtnV4.IconColor = System.Drawing.Color.White
        Me.BtnV4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnV4.IconSize = 25
        Me.BtnV4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV4.Location = New System.Drawing.Point(0, 250)
        Me.BtnV4.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnV4.Name = "BtnV4"
        Me.BtnV4.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnV4.Size = New System.Drawing.Size(172, 50)
        Me.BtnV4.TabIndex = 50
        Me.BtnV4.Text = "Productos comprados en la misma Fecha"
        Me.BtnV4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV4.UseVisualStyleBackColor = True
        '
        'BtnV3
        '
        Me.BtnV3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnV3.FlatAppearance.BorderSize = 0
        Me.BtnV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV3.ForeColor = System.Drawing.Color.White
        Me.BtnV3.IconChar = FontAwesome.Sharp.IconChar.Poll
        Me.BtnV3.IconColor = System.Drawing.Color.White
        Me.BtnV3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnV3.IconSize = 25
        Me.BtnV3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV3.Location = New System.Drawing.Point(0, 200)
        Me.BtnV3.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnV3.Name = "BtnV3"
        Me.BtnV3.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnV3.Size = New System.Drawing.Size(172, 50)
        Me.BtnV3.TabIndex = 49
        Me.BtnV3.Text = "Productos ordenados por fecha"
        Me.BtnV3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV3.UseVisualStyleBackColor = True
        '
        'BtnV2
        '
        Me.BtnV2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnV2.FlatAppearance.BorderSize = 0
        Me.BtnV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV2.ForeColor = System.Drawing.Color.White
        Me.BtnV2.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        Me.BtnV2.IconColor = System.Drawing.Color.White
        Me.BtnV2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnV2.IconSize = 25
        Me.BtnV2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV2.Location = New System.Drawing.Point(0, 150)
        Me.BtnV2.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnV2.Name = "BtnV2"
        Me.BtnV2.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnV2.Size = New System.Drawing.Size(172, 50)
        Me.BtnV2.TabIndex = 48
        Me.BtnV2.Text = "Productos con PUV > 100"
        Me.BtnV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV2.UseVisualStyleBackColor = True
        '
        'BtnV1
        '
        Me.BtnV1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnV1.FlatAppearance.BorderSize = 0
        Me.BtnV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnV1.ForeColor = System.Drawing.Color.White
        Me.BtnV1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.BtnV1.IconColor = System.Drawing.Color.White
        Me.BtnV1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnV1.IconSize = 25
        Me.BtnV1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV1.Location = New System.Drawing.Point(0, 100)
        Me.BtnV1.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnV1.Name = "BtnV1"
        Me.BtnV1.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnV1.Size = New System.Drawing.Size(172, 50)
        Me.BtnV1.TabIndex = 47
        Me.BtnV1.Text = "Datos de los Productos"
        Me.BtnV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV1.UseVisualStyleBackColor = True
        '
        'PanelTxtVistas
        '
        Me.PanelTxtVistas.Controls.Add(Me.Label3)
        Me.PanelTxtVistas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTxtVistas.Location = New System.Drawing.Point(0, 50)
        Me.PanelTxtVistas.Name = "PanelTxtVistas"
        Me.PanelTxtVistas.Size = New System.Drawing.Size(172, 50)
        Me.PanelTxtVistas.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 50)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vistas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTbAbonos
        '
        Me.BtnTbAbonos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbAbonos.FlatAppearance.BorderSize = 0
        Me.BtnTbAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbAbonos.ForeColor = System.Drawing.Color.White
        Me.BtnTbAbonos.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.BtnTbAbonos.IconColor = System.Drawing.Color.White
        Me.BtnTbAbonos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbAbonos.IconSize = 25
        Me.BtnTbAbonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbAbonos.Location = New System.Drawing.Point(0, 0)
        Me.BtnTbAbonos.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbAbonos.Name = "BtnTbAbonos"
        Me.BtnTbAbonos.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbAbonos.Size = New System.Drawing.Size(172, 50)
        Me.BtnTbAbonos.TabIndex = 31
        Me.BtnTbAbonos.Text = "Tablas"
        Me.BtnTbAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbAbonos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbAbonos.UseVisualStyleBackColor = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter = Nothing
        Me.TableAdapterManager.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter = Nothing
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter = Nothing
        Me.TableAdapterManager.IDCliente_TelefonosTableAdapter = Nothing
        Me.TableAdapterManager.IDEmpleado_Telefono_EmpTableAdapter = Nothing
        Me.TableAdapterManager.IDFactura_IDCliente_IDEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = Nothing
        Me.TableAdapterManager.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter
        '
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.ClearBeforeFill = True
        '
        'Producto_View1TableAdapter
        '
        Me.Producto_View1TableAdapter.ClearBeforeFill = True
        '
        'Producto_View2TableAdapter
        '
        Me.Producto_View2TableAdapter.ClearBeforeFill = True
        '
        'Producto_View3TableAdapter
        '
        Me.Producto_View3TableAdapter.ClearBeforeFill = True
        '
        'Producto_View4TableAdapter
        '
        Me.Producto_View4TableAdapter.ClearBeforeFill = True
        '
        'Producto_View5TableAdapter
        '
        Me.Producto_View5TableAdapter.ClearBeforeFill = True
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 522)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormProductos"
        Me.Text = "FormProductos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.Producto_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.Producto_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.Producto_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.Producto_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.Producto_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As LibreriaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter As LibreriaDataSetTableAdapters.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter
    Friend WithEvents IDProducto_IDProveedor_NombreProducto_MarcaBindingSource As BindingSource
    Friend WithEvents PanelV5 As Panel
    Friend WithEvents PanelV4 As Panel
    Friend WithEvents PanelV3 As Panel
    Friend WithEvents PanelV2 As Panel
    Friend WithEvents PanelV1 As Panel
    Friend WithEvents PanelTablas As Panel
    Friend WithEvents PanelBtnTB As Panel
    Friend WithEvents BtnV5 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV4 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV3 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTxtVistas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTbAbonos As FontAwesome.Sharp.IconButton
    Friend WithEvents IDProductoTextBox1 As TextBox
    Friend WithEvents IDProveedorTextBox As TextBox
    Friend WithEvents NombreProductoTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents IDProductoTextBox As TextBox
    Friend WithEvents FechaCompraDateTimePicker As DateTimePicker
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents PucTextBox As TextBox
    Friend WithEvents PuvTextBox As TextBox
    Friend WithEvents Ct_Tot_CompraTextBox As TextBox
    Friend WithEvents Ct_Tot_VentaTextBox As TextBox
    Friend WithEvents GananciaTextBox As TextBox
    Friend WithEvents IDProducto_IDProveedor_NombreProducto_MarcaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClean As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents BtnUpdate As PictureBox
    Friend WithEvents BtnSearch As PictureBox
    Friend WithEvents Producto_View1BindingSource As BindingSource
    Friend WithEvents Producto_View1TableAdapter As LibreriaDataSetTableAdapters.Producto_View1TableAdapter
    Friend WithEvents Producto_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View2BindingSource As BindingSource
    Friend WithEvents Producto_View2TableAdapter As LibreriaDataSetTableAdapters.Producto_View2TableAdapter
    Friend WithEvents Producto_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View3BindingSource As BindingSource
    Friend WithEvents Producto_View3TableAdapter As LibreriaDataSetTableAdapters.Producto_View3TableAdapter
    Friend WithEvents Producto_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View4BindingSource As BindingSource
    Friend WithEvents Producto_View4TableAdapter As LibreriaDataSetTableAdapters.Producto_View4TableAdapter
    Friend WithEvents Producto_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View5BindingSource As BindingSource
    Friend WithEvents Producto_View5TableAdapter As LibreriaDataSetTableAdapters.Producto_View5TableAdapter
    Friend WithEvents Producto_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
End Class
