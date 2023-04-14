<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedor
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
        Dim IDProveedorLabel As System.Windows.Forms.Label
        Dim Nombre_ProvLabel As System.Windows.Forms.Label
        Dim Direccion_ProvLabel As System.Windows.Forms.Label
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.IDProveedor_Nombre_prov_Marca_DistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDProveedor_Nombre_prov_Marca_DistTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProveedor_Nombre_prov_Marca_DistTableAdapter()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.IDProveedor_Telefono_ProvTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProveedor_Telefono_ProvTableAdapter()
        Me.ProveedorTableAdapter = New Libreria.LibreriaDataSetTableAdapters.ProveedorTableAdapter()
        Me.IDProveedor_Telefono_ProvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter()
        Me.IDProveedor_Telefono_ProvBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.IDProveedor_Nom_MarView5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProveedor_Nom_MarView5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.IDProveedor_Nom_MarView4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProveedor_Nom_MarView4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.IDProveedorTel_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDProveedorTel_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.Producto_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.Producto_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.IDProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProvTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_ProvTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClean = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate = New System.Windows.Forms.PictureBox()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.Producto_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View1TableAdapter()
        Me.Producto_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Producto_View2TableAdapter()
        Me.IDProveedorTel_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProveedorTel_View3TableAdapter()
        Me.IDProveedor_Nom_MarView4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProveedor_Nom_MarView4TableAdapter()
        Me.IDProveedor_Nom_MarView5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDProveedor_Nom_MarView5TableAdapter()
        IDProveedorLabel = New System.Windows.Forms.Label()
        Nombre_ProvLabel = New System.Windows.Forms.Label()
        Direccion_ProvLabel = New System.Windows.Forms.Label()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedor_Nombre_prov_Marca_DistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedor_Telefono_ProvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedor_Telefono_ProvBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.IDProveedor_Nom_MarView5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedor_Nom_MarView5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.IDProveedor_Nom_MarView4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedor_Nom_MarView4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.IDProveedorTel_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProveedorTel_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.Producto_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.Producto_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Producto_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTablas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDProveedorLabel
        '
        IDProveedorLabel.AutoSize = True
        IDProveedorLabel.ForeColor = System.Drawing.SystemColors.Control
        IDProveedorLabel.Location = New System.Drawing.Point(478, 120)
        IDProveedorLabel.Name = "IDProveedorLabel"
        IDProveedorLabel.Size = New System.Drawing.Size(70, 13)
        IDProveedorLabel.TabIndex = 35
        IDProveedorLabel.Text = "IDProveedor:"
        '
        'Nombre_ProvLabel
        '
        Nombre_ProvLabel.AutoSize = True
        Nombre_ProvLabel.ForeColor = System.Drawing.SystemColors.Control
        Nombre_ProvLabel.Location = New System.Drawing.Point(478, 146)
        Nombre_ProvLabel.Name = "Nombre_ProvLabel"
        Nombre_ProvLabel.Size = New System.Drawing.Size(72, 13)
        Nombre_ProvLabel.TabIndex = 37
        Nombre_ProvLabel.Text = "Nombre Prov:"
        '
        'Direccion_ProvLabel
        '
        Direccion_ProvLabel.AutoSize = True
        Direccion_ProvLabel.ForeColor = System.Drawing.SystemColors.Control
        Direccion_ProvLabel.Location = New System.Drawing.Point(478, 172)
        Direccion_ProvLabel.Name = "Direccion_ProvLabel"
        Direccion_ProvLabel.Size = New System.Drawing.Size(80, 13)
        Direccion_ProvLabel.TabIndex = 39
        Direccion_ProvLabel.Text = "Direccion Prov:"
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDProveedor_Nombre_prov_Marca_DistBindingSource
        '
        Me.IDProveedor_Nombre_prov_Marca_DistBindingSource.DataMember = "IDProveedor_Nombre_prov_Marca_Dist"
        Me.IDProveedor_Nombre_prov_Marca_DistBindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDProveedor_Nombre_prov_Marca_DistTableAdapter
        '
        Me.IDProveedor_Nombre_prov_Marca_DistTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Me.IDProveedor_Nombre_prov_Marca_DistTableAdapter
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Me.IDProveedor_Telefono_ProvTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDProveedor_Telefono_ProvTableAdapter
        '
        Me.IDProveedor_Telefono_ProvTableAdapter.ClearBeforeFill = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'IDProveedor_Telefono_ProvBindingSource
        '
        Me.IDProveedor_Telefono_ProvBindingSource.DataMember = "IDProveedor_Telefono_Prov"
        Me.IDProveedor_Telefono_ProvBindingSource.DataSource = Me.LibreriaDataSet
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDProducto_IDProveedor_NombreProducto_MarcaBindingSource
        '
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource.DataMember = "FK__IDProduct__IDPro__49C3F6B7"
        Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource.DataSource = Me.ProveedorBindingSource
        '
        'IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter
        '
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.ClearBeforeFill = True
        '
        'IDProveedor_Telefono_ProvBindingSource1
        '
        Me.IDProveedor_Telefono_ProvBindingSource1.DataMember = "FK__IDProveed__IDPro__2FCF1A8A"
        Me.IDProveedor_Telefono_ProvBindingSource1.DataSource = Me.ProveedorBindingSource
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.IDProveedor_Nom_MarView5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(714, 587)
        Me.PanelV5.TabIndex = 47
        '
        'IDProveedor_Nom_MarView5DataGridView
        '
        Me.IDProveedor_Nom_MarView5DataGridView.AutoGenerateColumns = False
        Me.IDProveedor_Nom_MarView5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDProveedor_Nom_MarView5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDProveedor_Nom_MarView5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDProveedor_Nom_MarView5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDProveedor_Nom_MarView5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDProveedor_Nom_MarView5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.IDProveedor_Nom_MarView5DataGridView.DataSource = Me.IDProveedor_Nom_MarView5BindingSource
        Me.IDProveedor_Nom_MarView5DataGridView.Location = New System.Drawing.Point(135, 71)
        Me.IDProveedor_Nom_MarView5DataGridView.Name = "IDProveedor_Nom_MarView5DataGridView"
        Me.IDProveedor_Nom_MarView5DataGridView.RowHeadersVisible = False
        Me.IDProveedor_Nom_MarView5DataGridView.Size = New System.Drawing.Size(407, 343)
        Me.IDProveedor_Nom_MarView5DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "IDProveedor"
        Me.DataGridViewTextBoxColumn20.HeaderText = "IDProveedor"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Marca_Dist"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Marca_Dist"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'IDProveedor_Nom_MarView5BindingSource
        '
        Me.IDProveedor_Nom_MarView5BindingSource.DataMember = "IDProveedor_Nom_MarView5"
        Me.IDProveedor_Nom_MarView5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.IDProveedor_Nom_MarView4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(714, 587)
        Me.PanelV4.TabIndex = 46
        '
        'IDProveedor_Nom_MarView4DataGridView
        '
        Me.IDProveedor_Nom_MarView4DataGridView.AutoGenerateColumns = False
        Me.IDProveedor_Nom_MarView4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDProveedor_Nom_MarView4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDProveedor_Nom_MarView4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDProveedor_Nom_MarView4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDProveedor_Nom_MarView4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDProveedor_Nom_MarView4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.IDProveedor_Nom_MarView4DataGridView.DataSource = Me.IDProveedor_Nom_MarView4BindingSource
        Me.IDProveedor_Nom_MarView4DataGridView.Location = New System.Drawing.Point(134, 71)
        Me.IDProveedor_Nom_MarView4DataGridView.Name = "IDProveedor_Nom_MarView4DataGridView"
        Me.IDProveedor_Nom_MarView4DataGridView.RowHeadersVisible = False
        Me.IDProveedor_Nom_MarView4DataGridView.Size = New System.Drawing.Size(406, 316)
        Me.IDProveedor_Nom_MarView4DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nombre_Prov"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nombre_Prov"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Marca_Dist"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Marca_Dist"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'IDProveedor_Nom_MarView4BindingSource
        '
        Me.IDProveedor_Nom_MarView4BindingSource.DataMember = "IDProveedor_Nom_MarView4"
        Me.IDProveedor_Nom_MarView4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.IDProveedorTel_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(714, 587)
        Me.PanelV3.TabIndex = 45
        '
        'IDProveedorTel_View3DataGridView
        '
        Me.IDProveedorTel_View3DataGridView.AutoGenerateColumns = False
        Me.IDProveedorTel_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDProveedorTel_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDProveedorTel_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDProveedorTel_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDProveedorTel_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDProveedorTel_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.IDProveedorTel_View3DataGridView.DataSource = Me.IDProveedorTel_View3BindingSource
        Me.IDProveedorTel_View3DataGridView.Location = New System.Drawing.Point(160, 68)
        Me.IDProveedorTel_View3DataGridView.Name = "IDProveedorTel_View3DataGridView"
        Me.IDProveedorTel_View3DataGridView.RowHeadersVisible = False
        Me.IDProveedorTel_View3DataGridView.Size = New System.Drawing.Size(393, 323)
        Me.IDProveedorTel_View3DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IDProveedor"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IDProveedor"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Telefono_Prov"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Telefono_Prov"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'IDProveedorTel_View3BindingSource
        '
        Me.IDProveedorTel_View3BindingSource.DataMember = "IDProveedorTel_View3"
        Me.IDProveedorTel_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.Producto_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(714, 587)
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
        Me.Producto_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Producto_View2DataGridView.DataSource = Me.Producto_View2BindingSource
        Me.Producto_View2DataGridView.Location = New System.Drawing.Point(43, 66)
        Me.Producto_View2DataGridView.Name = "Producto_View2DataGridView"
        Me.Producto_View2DataGridView.RowHeadersVisible = False
        Me.Producto_View2DataGridView.Size = New System.Drawing.Size(618, 353)
        Me.Producto_View2DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PUV"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PUV"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
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
        Me.PanelV1.Size = New System.Drawing.Size(714, 587)
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
        Me.Producto_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Producto_View1DataGridView.DataSource = Me.Producto_View1BindingSource
        Me.Producto_View1DataGridView.Location = New System.Drawing.Point(55, 66)
        Me.Producto_View1DataGridView.Name = "Producto_View1DataGridView"
        Me.Producto_View1DataGridView.RowHeadersVisible = False
        Me.Producto_View1DataGridView.Size = New System.Drawing.Size(592, 356)
        Me.Producto_View1DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaCompra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaCompra"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PUC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PUC"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PUV"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PUV"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Costo_Tot_Compra"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Costo_Tot_Venta"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Ganancia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ganancia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Producto_View1BindingSource
        '
        Me.Producto_View1BindingSource.DataMember = "Producto_View1"
        Me.Producto_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(IDProveedorLabel)
        Me.PanelTablas.Controls.Add(Me.IDProveedorTextBox)
        Me.PanelTablas.Controls.Add(Nombre_ProvLabel)
        Me.PanelTablas.Controls.Add(Me.Nombre_ProvTextBox)
        Me.PanelTablas.Controls.Add(Direccion_ProvLabel)
        Me.PanelTablas.Controls.Add(Me.Direccion_ProvTextBox)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(Me.ProveedorDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(714, 587)
        Me.PanelTablas.TabIndex = 42
        '
        'IDProveedorTextBox
        '
        Me.IDProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "IDProveedor", True))
        Me.IDProveedorTextBox.Location = New System.Drawing.Point(564, 117)
        Me.IDProveedorTextBox.Name = "IDProveedorTextBox"
        Me.IDProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDProveedorTextBox.TabIndex = 36
        '
        'Nombre_ProvTextBox
        '
        Me.Nombre_ProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nombre_Prov", True))
        Me.Nombre_ProvTextBox.Location = New System.Drawing.Point(564, 143)
        Me.Nombre_ProvTextBox.Name = "Nombre_ProvTextBox"
        Me.Nombre_ProvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_ProvTextBox.TabIndex = 38
        '
        'Direccion_ProvTextBox
        '
        Me.Direccion_ProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Direccion_Prov", True))
        Me.Direccion_ProvTextBox.Location = New System.Drawing.Point(564, 169)
        Me.Direccion_ProvTextBox.Name = "Direccion_ProvTextBox"
        Me.Direccion_ProvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Direccion_ProvTextBox.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnClean)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Location = New System.Drawing.Point(481, 212)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 35)
        Me.Panel2.TabIndex = 35
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
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProveedorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ProveedorDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ProveedorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(33, 51)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.RowHeadersVisible = False
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(388, 310)
        Me.ProveedorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDProveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDProveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Direccion_Prov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Direccion_Prov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        Me.PanelBtnTB.Size = New System.Drawing.Size(174, 587)
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
        Me.BtnV5.Text = "Proveedores Frecuentes"
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
        Me.BtnV4.Text = "Proveedores y ID"
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
        Me.BtnV3.Text = "Dirección de Porveedores"
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
        Me.BtnV2.Text = "Proveedores ordenados por Dirección"
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
        Me.BtnV1.Text = "Proveedores ordenados por Nombre"
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
        'Producto_View1TableAdapter
        '
        Me.Producto_View1TableAdapter.ClearBeforeFill = True
        '
        'Producto_View2TableAdapter
        '
        Me.Producto_View2TableAdapter.ClearBeforeFill = True
        '
        'IDProveedorTel_View3TableAdapter
        '
        Me.IDProveedorTel_View3TableAdapter.ClearBeforeFill = True
        '
        'IDProveedor_Nom_MarView4TableAdapter
        '
        Me.IDProveedor_Nom_MarView4TableAdapter.ClearBeforeFill = True
        '
        'IDProveedor_Nom_MarView5TableAdapter
        '
        Me.IDProveedor_Nom_MarView5TableAdapter.ClearBeforeFill = True
        '
        'FormProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(888, 587)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormProveedor"
        Me.Text = "FormProveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedor_Nombre_prov_Marca_DistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedor_Telefono_ProvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProducto_IDProveedor_NombreProducto_MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedor_Telefono_ProvBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.IDProveedor_Nom_MarView5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedor_Nom_MarView5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.IDProveedor_Nom_MarView4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedor_Nom_MarView4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.IDProveedorTel_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProveedorTel_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.Producto_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.Producto_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Producto_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents IDProveedor_Nombre_prov_Marca_DistBindingSource As BindingSource
    Friend WithEvents IDProveedor_Nombre_prov_Marca_DistTableAdapter As LibreriaDataSetTableAdapters.IDProveedor_Nombre_prov_Marca_DistTableAdapter
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDProveedor_Telefono_ProvTableAdapter As LibreriaDataSetTableAdapters.IDProveedor_Telefono_ProvTableAdapter
    Friend WithEvents IDProveedor_Telefono_ProvBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As LibreriaDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents IDProducto_IDProveedor_NombreProducto_MarcaBindingSource As BindingSource
    Friend WithEvents IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter As LibreriaDataSetTableAdapters.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter
    Friend WithEvents IDProveedor_Telefono_ProvBindingSource1 As BindingSource
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
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View1BindingSource As BindingSource
    Friend WithEvents Producto_View1TableAdapter As LibreriaDataSetTableAdapters.Producto_View1TableAdapter
    Friend WithEvents Producto_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_View2BindingSource As BindingSource
    Friend WithEvents Producto_View2TableAdapter As LibreriaDataSetTableAdapters.Producto_View2TableAdapter
    Friend WithEvents Producto_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents IDProveedorTel_View3BindingSource As BindingSource
    Friend WithEvents IDProveedorTel_View3TableAdapter As LibreriaDataSetTableAdapters.IDProveedorTel_View3TableAdapter
    Friend WithEvents IDProveedorTel_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents IDProveedor_Nom_MarView4BindingSource As BindingSource
    Friend WithEvents IDProveedor_Nom_MarView4TableAdapter As LibreriaDataSetTableAdapters.IDProveedor_Nom_MarView4TableAdapter
    Friend WithEvents IDProveedor_Nom_MarView4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents IDProveedor_Nom_MarView5BindingSource As BindingSource
    Friend WithEvents IDProveedor_Nom_MarView5TableAdapter As LibreriaDataSetTableAdapters.IDProveedor_Nom_MarView5TableAdapter
    Friend WithEvents IDProveedor_Nom_MarView5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClean As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents BtnUpdate As PictureBox
    Friend WithEvents BtnSearch As PictureBox
    Friend WithEvents IDProveedorTextBox As TextBox
    Friend WithEvents Nombre_ProvTextBox As TextBox
    Friend WithEvents Direccion_ProvTextBox As TextBox
End Class
