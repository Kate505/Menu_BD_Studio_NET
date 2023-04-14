<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleFactura
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
        Dim IDFacturaLabel As System.Windows.Forms.Label
        Dim IDProductoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PucLabel As System.Windows.Forms.Label
        Dim Tot_PucLabel As System.Windows.Forms.Label
        Dim PuvLabel As System.Windows.Forms.Label
        Dim Tot_PuvLabel As System.Windows.Forms.Label
        Dim IDFacturaLabel1 As System.Windows.Forms.Label
        Dim IDClienteLabel As System.Windows.Forms.Label
        Dim IDEmpleadoLabel As System.Windows.Forms.Label
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.FillToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.IDProductoToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.IDProductoToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.CantidadToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CantidadToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDFactura_IDCliente_IDEmpleado_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IDFacturaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IDFacturaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.IDProductoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IDProductoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CantidadToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CantidadToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PucToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PucToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Tot_PucToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Tot_PucToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PuvToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PuvToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Tot_PuvToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Tot_PuvToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDFactura_IDCliente_IDEmpleado_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.IDFacturaTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDClienteTextBox = New System.Windows.Forms.TextBox()
        Me.IDEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.IDFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IDProductoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PucTextBox = New System.Windows.Forms.TextBox()
        Me.Tot_PucTextBox = New System.Windows.Forms.TextBox()
        Me.PuvTextBox = New System.Windows.Forms.TextBox()
        Me.Tot_PuvTextBox = New System.Windows.Forms.TextBox()
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleadoTableAdapter()
        Me.IDFactura_IDCliente_IDEmpleado_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDFactura_IDCliente_IDEmpleado_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View1TableAdapter()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter()
        Me.IDFactura_IDCliente_IDEmpleado_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View2TableAdapter()
        Me.IDFactura_IDCliente_IDEmpleado_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View3TableAdapter()
        Me.IDFactura_IDCliente_IDEmpleado_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View4TableAdapter()
        Me.IDFactura_IDCliente_IDEmpleado_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View5TableAdapter()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter()
        IDFacturaLabel = New System.Windows.Forms.Label()
        IDProductoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PucLabel = New System.Windows.Forms.Label()
        Tot_PucLabel = New System.Windows.Forms.Label()
        PuvLabel = New System.Windows.Forms.Label()
        Tot_PuvLabel = New System.Windows.Forms.Label()
        IDFacturaLabel1 = New System.Windows.Forms.Label()
        IDClienteLabel = New System.Windows.Forms.Label()
        IDEmpleadoLabel = New System.Windows.Forms.Label()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        Me.FillToolStrip1.SuspendLayout()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDFacturaLabel
        '
        IDFacturaLabel.AutoSize = True
        IDFacturaLabel.ForeColor = System.Drawing.Color.White
        IDFacturaLabel.Location = New System.Drawing.Point(494, 36)
        IDFacturaLabel.Name = "IDFacturaLabel"
        IDFacturaLabel.Size = New System.Drawing.Size(57, 13)
        IDFacturaLabel.TabIndex = 2
        IDFacturaLabel.Text = "IDFactura:"
        '
        'IDProductoLabel
        '
        IDProductoLabel.AutoSize = True
        IDProductoLabel.ForeColor = System.Drawing.Color.White
        IDProductoLabel.Location = New System.Drawing.Point(494, 62)
        IDProductoLabel.Name = "IDProductoLabel"
        IDProductoLabel.Size = New System.Drawing.Size(64, 13)
        IDProductoLabel.TabIndex = 4
        IDProductoLabel.Text = "IDProducto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.ForeColor = System.Drawing.Color.White
        CantidadLabel.Location = New System.Drawing.Point(494, 88)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 6
        CantidadLabel.Text = "Cantidad:"
        '
        'PucLabel
        '
        PucLabel.AutoSize = True
        PucLabel.ForeColor = System.Drawing.Color.White
        PucLabel.Location = New System.Drawing.Point(494, 114)
        PucLabel.Name = "PucLabel"
        PucLabel.Size = New System.Drawing.Size(29, 13)
        PucLabel.TabIndex = 8
        PucLabel.Text = "Puc:"
        '
        'Tot_PucLabel
        '
        Tot_PucLabel.AutoSize = True
        Tot_PucLabel.ForeColor = System.Drawing.Color.White
        Tot_PucLabel.Location = New System.Drawing.Point(494, 140)
        Tot_PucLabel.Name = "Tot_PucLabel"
        Tot_PucLabel.Size = New System.Drawing.Size(48, 13)
        Tot_PucLabel.TabIndex = 10
        Tot_PucLabel.Text = "Tot Puc:"
        '
        'PuvLabel
        '
        PuvLabel.AutoSize = True
        PuvLabel.ForeColor = System.Drawing.Color.White
        PuvLabel.Location = New System.Drawing.Point(494, 166)
        PuvLabel.Name = "PuvLabel"
        PuvLabel.Size = New System.Drawing.Size(29, 13)
        PuvLabel.TabIndex = 12
        PuvLabel.Text = "Puv:"
        '
        'Tot_PuvLabel
        '
        Tot_PuvLabel.AutoSize = True
        Tot_PuvLabel.ForeColor = System.Drawing.Color.White
        Tot_PuvLabel.Location = New System.Drawing.Point(494, 192)
        Tot_PuvLabel.Name = "Tot_PuvLabel"
        Tot_PuvLabel.Size = New System.Drawing.Size(48, 13)
        Tot_PuvLabel.TabIndex = 14
        Tot_PuvLabel.Text = "Tot Puv:"
        '
        'IDFacturaLabel1
        '
        IDFacturaLabel1.AutoSize = True
        IDFacturaLabel1.ForeColor = System.Drawing.Color.White
        IDFacturaLabel1.Location = New System.Drawing.Point(494, 341)
        IDFacturaLabel1.Name = "IDFacturaLabel1"
        IDFacturaLabel1.Size = New System.Drawing.Size(57, 13)
        IDFacturaLabel1.TabIndex = 16
        IDFacturaLabel1.Text = "IDFactura:"
        '
        'IDClienteLabel
        '
        IDClienteLabel.AutoSize = True
        IDClienteLabel.ForeColor = System.Drawing.Color.White
        IDClienteLabel.Location = New System.Drawing.Point(494, 367)
        IDClienteLabel.Name = "IDClienteLabel"
        IDClienteLabel.Size = New System.Drawing.Size(53, 13)
        IDClienteLabel.TabIndex = 18
        IDClienteLabel.Text = "IDCliente:"
        '
        'IDEmpleadoLabel
        '
        IDEmpleadoLabel.AutoSize = True
        IDEmpleadoLabel.ForeColor = System.Drawing.Color.White
        IDEmpleadoLabel.Location = New System.Drawing.Point(494, 393)
        IDEmpleadoLabel.Name = "IDEmpleadoLabel"
        IDEmpleadoLabel.Size = New System.Drawing.Size(68, 13)
        IDEmpleadoLabel.TabIndex = 20
        IDEmpleadoLabel.Text = "IDEmpleado:"
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource.DataMember = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource.DataSource = Me.LibreriaDataSet
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter
        Me.TableAdapterManager.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.FillToolStrip1)
        Me.PanelV5.Controls.Add(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(707, 522)
        Me.PanelV5.TabIndex = 40
        '
        'FillToolStrip1
        '
        Me.FillToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FillToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDProductoToolStripLabel1, Me.IDProductoToolStripTextBox1, Me.CantidadToolStripLabel1, Me.CantidadToolStripTextBox1, Me.FillToolStripButton1})
        Me.FillToolStrip1.Location = New System.Drawing.Point(608, 0)
        Me.FillToolStrip1.Name = "FillToolStrip1"
        Me.FillToolStrip1.Size = New System.Drawing.Size(99, 522)
        Me.FillToolStrip1.TabIndex = 42
        Me.FillToolStrip1.Text = "FillToolStrip1"
        '
        'IDProductoToolStripLabel1
        '
        Me.IDProductoToolStripLabel1.Name = "IDProductoToolStripLabel1"
        Me.IDProductoToolStripLabel1.Size = New System.Drawing.Size(96, 15)
        Me.IDProductoToolStripLabel1.Text = "IDProducto:"
        '
        'IDProductoToolStripTextBox1
        '
        Me.IDProductoToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDProductoToolStripTextBox1.Name = "IDProductoToolStripTextBox1"
        Me.IDProductoToolStripTextBox1.Size = New System.Drawing.Size(94, 23)
        '
        'CantidadToolStripLabel1
        '
        Me.CantidadToolStripLabel1.Name = "CantidadToolStripLabel1"
        Me.CantidadToolStripLabel1.Size = New System.Drawing.Size(96, 15)
        Me.CantidadToolStripLabel1.Text = "Cantidad:"
        '
        'CantidadToolStripTextBox1
        '
        Me.CantidadToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CantidadToolStripTextBox1.Name = "CantidadToolStripTextBox1"
        Me.CantidadToolStripTextBox1.Size = New System.Drawing.Size(94, 23)
        '
        'FillToolStripButton1
        '
        Me.FillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton1.Name = "FillToolStripButton1"
        Me.FillToolStripButton1.Size = New System.Drawing.Size(96, 19)
        Me.FillToolStripButton1.Text = "Fill"
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24})
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.DataSource = Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.Location = New System.Drawing.Point(246, 140)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.Name = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.RowHeadersVisible = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.Size = New System.Drawing.Size(217, 150)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Column1"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource.DataMember = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDFactura_IDCliente_IDEmpleado_View5BindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleado_View5BindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado_View5"
        Me.IDFactura_IDCliente_IDEmpleado_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(707, 522)
        Me.PanelV4.TabIndex = 39
        '
        'IDFactura_IDCliente_IDEmpleado_View4DataGridView
        '
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.DataSource = Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.Location = New System.Drawing.Point(66, 68)
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.Name = "IDFactura_IDCliente_IDEmpleado_View4DataGridView"
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.RowHeadersVisible = False
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.Size = New System.Drawing.Size(558, 323)
        Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn22.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn23.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'IDFactura_IDCliente_IDEmpleado_View4BindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado_View4"
        Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(707, 522)
        Me.PanelV3.TabIndex = 38
        '
        'IDFactura_IDCliente_IDEmpleado_View3DataGridView
        '
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.DataSource = Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.Location = New System.Drawing.Point(42, 51)
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.Name = "IDFactura_IDCliente_IDEmpleado_View3DataGridView"
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.RowHeadersVisible = False
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.Size = New System.Drawing.Size(610, 383)
        Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn20.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn21.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'IDFactura_IDCliente_IDEmpleado_View3BindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado_View3"
        Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.FillToolStrip)
        Me.PanelV2.Controls.Add(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(707, 522)
        Me.PanelV2.TabIndex = 37
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Dock = System.Windows.Forms.DockStyle.Right
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDFacturaToolStripLabel, Me.IDFacturaToolStripTextBox, Me.IDProductoToolStripLabel, Me.IDProductoToolStripTextBox, Me.CantidadToolStripLabel, Me.CantidadToolStripTextBox, Me.PucToolStripLabel, Me.PucToolStripTextBox, Me.Tot_PucToolStripLabel, Me.Tot_PucToolStripTextBox, Me.PuvToolStripLabel, Me.PuvToolStripTextBox, Me.Tot_PuvToolStripLabel, Me.Tot_PuvToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(606, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(101, 522)
        Me.FillToolStrip.TabIndex = 42
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IDFacturaToolStripLabel
        '
        Me.IDFacturaToolStripLabel.Name = "IDFacturaToolStripLabel"
        Me.IDFacturaToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.IDFacturaToolStripLabel.Text = "IDFactura:"
        '
        'IDFacturaToolStripTextBox
        '
        Me.IDFacturaToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDFacturaToolStripTextBox.Name = "IDFacturaToolStripTextBox"
        Me.IDFacturaToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'IDProductoToolStripLabel
        '
        Me.IDProductoToolStripLabel.Name = "IDProductoToolStripLabel"
        Me.IDProductoToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.IDProductoToolStripLabel.Text = "IDProducto:"
        '
        'IDProductoToolStripTextBox
        '
        Me.IDProductoToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDProductoToolStripTextBox.Name = "IDProductoToolStripTextBox"
        Me.IDProductoToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'CantidadToolStripLabel
        '
        Me.CantidadToolStripLabel.Name = "CantidadToolStripLabel"
        Me.CantidadToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.CantidadToolStripLabel.Text = "Cantidad:"
        '
        'CantidadToolStripTextBox
        '
        Me.CantidadToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CantidadToolStripTextBox.Name = "CantidadToolStripTextBox"
        Me.CantidadToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'PucToolStripLabel
        '
        Me.PucToolStripLabel.Name = "PucToolStripLabel"
        Me.PucToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.PucToolStripLabel.Text = "Puc:"
        '
        'PucToolStripTextBox
        '
        Me.PucToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PucToolStripTextBox.Name = "PucToolStripTextBox"
        Me.PucToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'Tot_PucToolStripLabel
        '
        Me.Tot_PucToolStripLabel.Name = "Tot_PucToolStripLabel"
        Me.Tot_PucToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.Tot_PucToolStripLabel.Text = "Tot_Puc:"
        '
        'Tot_PucToolStripTextBox
        '
        Me.Tot_PucToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Tot_PucToolStripTextBox.Name = "Tot_PucToolStripTextBox"
        Me.Tot_PucToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'PuvToolStripLabel
        '
        Me.PuvToolStripLabel.Name = "PuvToolStripLabel"
        Me.PuvToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.PuvToolStripLabel.Text = "Puv:"
        '
        'PuvToolStripTextBox
        '
        Me.PuvToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PuvToolStripTextBox.Name = "PuvToolStripTextBox"
        Me.PuvToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'Tot_PuvToolStripLabel
        '
        Me.Tot_PuvToolStripLabel.Name = "Tot_PuvToolStripLabel"
        Me.Tot_PuvToolStripLabel.Size = New System.Drawing.Size(98, 15)
        Me.Tot_PuvToolStripLabel.Text = "Tot_Puv:"
        '
        'Tot_PuvToolStripTextBox
        '
        Me.Tot_PuvToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Tot_PuvToolStripTextBox.Name = "Tot_PuvToolStripTextBox"
        Me.Tot_PuvToolStripTextBox.Size = New System.Drawing.Size(96, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(98, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.DataSource = Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.Location = New System.Drawing.Point(21, 86)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.Name = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.RowHeadersVisible = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.Size = New System.Drawing.Size(570, 332)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn18.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 79
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 86
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 74
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Puc"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Puc"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 51
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Tot_Puc"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Tot_Puc"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 73
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Puv"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Puv"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 51
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Tot_Puv"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Tot_Puv"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 73
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource.DataMember = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDFactura_IDCliente_IDEmpleado_View2BindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleado_View2BindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado_View2"
        Me.IDFactura_IDCliente_IDEmpleado_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(707, 522)
        Me.PanelV1.TabIndex = 36
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.DataSource = Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.Location = New System.Drawing.Point(36, 86)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.Name = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.RowHeadersVisible = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.Size = New System.Drawing.Size(621, 323)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IDProducto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Puc"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Puc"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tot_Puc"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tot_Puc"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Puv"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Puv"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Tot_Puv"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tot_Puv"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource.DataMember = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(IDFacturaLabel1)
        Me.PanelTablas.Controls.Add(Me.IDFacturaTextBox1)
        Me.PanelTablas.Controls.Add(IDClienteLabel)
        Me.PanelTablas.Controls.Add(Me.IDClienteTextBox)
        Me.PanelTablas.Controls.Add(IDEmpleadoLabel)
        Me.PanelTablas.Controls.Add(Me.IDEmpleadoTextBox)
        Me.PanelTablas.Controls.Add(IDFacturaLabel)
        Me.PanelTablas.Controls.Add(Me.IDFacturaTextBox)
        Me.PanelTablas.Controls.Add(IDProductoLabel)
        Me.PanelTablas.Controls.Add(Me.IDProductoTextBox)
        Me.PanelTablas.Controls.Add(CantidadLabel)
        Me.PanelTablas.Controls.Add(Me.CantidadTextBox)
        Me.PanelTablas.Controls.Add(PucLabel)
        Me.PanelTablas.Controls.Add(Me.PucTextBox)
        Me.PanelTablas.Controls.Add(Tot_PucLabel)
        Me.PanelTablas.Controls.Add(Me.Tot_PucTextBox)
        Me.PanelTablas.Controls.Add(PuvLabel)
        Me.PanelTablas.Controls.Add(Me.PuvTextBox)
        Me.PanelTablas.Controls.Add(Tot_PuvLabel)
        Me.PanelTablas.Controls.Add(Me.Tot_PuvTextBox)
        Me.PanelTablas.Controls.Add(Me.IDFactura_IDCliente_IDEmpleadoDataGridView)
        Me.PanelTablas.Controls.Add(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(707, 522)
        Me.PanelTablas.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(484, 431)
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
        Me.Panel2.Location = New System.Drawing.Point(487, 218)
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
        'IDFacturaTextBox1
        '
        Me.IDFacturaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDCliente_IDEmpleadoBindingSource, "IDFactura", True))
        Me.IDFacturaTextBox1.Location = New System.Drawing.Point(568, 338)
        Me.IDFacturaTextBox1.Name = "IDFacturaTextBox1"
        Me.IDFacturaTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDFacturaTextBox1.TabIndex = 17
        '
        'IDFactura_IDCliente_IDEmpleadoBindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado"
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDClienteTextBox
        '
        Me.IDClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDCliente_IDEmpleadoBindingSource, "IDCliente", True))
        Me.IDClienteTextBox.Location = New System.Drawing.Point(568, 364)
        Me.IDClienteTextBox.Name = "IDClienteTextBox"
        Me.IDClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDClienteTextBox.TabIndex = 19
        '
        'IDEmpleadoTextBox
        '
        Me.IDEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDCliente_IDEmpleadoBindingSource, "IDEmpleado", True))
        Me.IDEmpleadoTextBox.Location = New System.Drawing.Point(568, 390)
        Me.IDEmpleadoTextBox.Name = "IDEmpleadoTextBox"
        Me.IDEmpleadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDEmpleadoTextBox.TabIndex = 21
        '
        'IDFacturaTextBox
        '
        Me.IDFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "IDFactura", True))
        Me.IDFacturaTextBox.Location = New System.Drawing.Point(564, 33)
        Me.IDFacturaTextBox.Name = "IDFacturaTextBox"
        Me.IDFacturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDFacturaTextBox.TabIndex = 3
        '
        'IDProductoTextBox
        '
        Me.IDProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "IDProducto", True))
        Me.IDProductoTextBox.Location = New System.Drawing.Point(564, 59)
        Me.IDProductoTextBox.Name = "IDProductoTextBox"
        Me.IDProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDProductoTextBox.TabIndex = 5
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(564, 85)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 7
        '
        'PucTextBox
        '
        Me.PucTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "Puc", True))
        Me.PucTextBox.Location = New System.Drawing.Point(564, 111)
        Me.PucTextBox.Name = "PucTextBox"
        Me.PucTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PucTextBox.TabIndex = 9
        '
        'Tot_PucTextBox
        '
        Me.Tot_PucTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "Tot_Puc", True))
        Me.Tot_PucTextBox.Location = New System.Drawing.Point(564, 137)
        Me.Tot_PucTextBox.Name = "Tot_PucTextBox"
        Me.Tot_PucTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tot_PucTextBox.TabIndex = 11
        '
        'PuvTextBox
        '
        Me.PuvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "Puv", True))
        Me.PuvTextBox.Location = New System.Drawing.Point(564, 163)
        Me.PuvTextBox.Name = "PuvTextBox"
        Me.PuvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PuvTextBox.TabIndex = 13
        '
        'Tot_PuvTextBox
        '
        Me.Tot_PuvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, "Tot_Puv", True))
        Me.Tot_PuvTextBox.Location = New System.Drawing.Point(564, 189)
        Me.Tot_PuvTextBox.Name = "Tot_PuvTextBox"
        Me.Tot_PuvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tot_PuvTextBox.TabIndex = 15
        '
        'IDFactura_IDCliente_IDEmpleadoDataGridView
        '
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.DataSource = Me.IDFactura_IDCliente_IDEmpleadoBindingSource
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.Location = New System.Drawing.Point(14, 329)
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.Name = "IDFactura_IDCliente_IDEmpleadoDataGridView"
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.RowHeadersVisible = False
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.Size = New System.Drawing.Size(445, 128)
        Me.IDFactura_IDCliente_IDEmpleadoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.AutoGenerateColumns = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.DataSource = Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.Location = New System.Drawing.Point(14, 31)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.Name = "IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView"
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.RowHeadersVisible = False
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDProducto"
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
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tot_Puc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tot_Puc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Puv"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Puv"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Tot_Puv"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tot_Puv"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
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
        Me.PanelBtnTB.TabIndex = 34
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
        Me.BtnV5.Text = "Unidades Vendidas de un Producto"
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
        Me.BtnV4.Text = "Facturas y Empleados"
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
        Me.BtnV3.Text = "Facturas y Clientes"
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
        Me.BtnV2.Text = "Productos en la Factura"
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
        Me.BtnV1.Text = "Datos de Todas las Facturas"
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
        'IDFactura_IDCliente_IDEmpleadoTableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleado_View1BindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleado_View1BindingSource.DataMember = "IDFactura_IDCliente_IDEmpleado_View1"
        Me.IDFactura_IDCliente_IDEmpleado_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDFactura_IDCliente_IDEmpleado_View1TableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleado_View1TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleado_View2TableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleado_View2TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleado_View3TableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleado_View3TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleado_View4TableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleado_View4TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleado_View5TableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleado_View5TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter
        '
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter.ClearBeforeFill = True
        '
        'FormDetalleFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 522)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormDetalleFactura"
        Me.Text = "Detalles de Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        Me.PanelV5.PerformLayout()
        Me.FillToolStrip1.ResumeLayout(False)
        Me.FillToolStrip1.PerformLayout()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.IDFactura_IDCliente_IDEmpleado_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.IDFactura_IDCliente_IDEmpleado_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        Me.PanelV2.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleado_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        CType(Me.IDFactura_IDCliente_IDEmpleado_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource As BindingSource
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoBindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoTableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleadoTableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents IDFacturaTextBox1 As TextBox
    Friend WithEvents IDClienteTextBox As TextBox
    Friend WithEvents IDEmpleadoTextBox As TextBox
    Friend WithEvents IDFacturaTextBox As TextBox
    Friend WithEvents IDProductoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents PucTextBox As TextBox
    Friend WithEvents Tot_PucTextBox As TextBox
    Friend WithEvents PuvTextBox As TextBox
    Friend WithEvents Tot_PuvTextBox As TextBox
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
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View1BindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View1TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View1TableAdapter
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1BindingSource As BindingSource
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View2BindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View2TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View2TableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View3BindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View3TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View3TableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View4BindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View4TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View4TableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View5BindingSource As BindingSource
    Friend WithEvents IDFactura_IDCliente_IDEmpleado_View5TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleado_View5TableAdapter
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4BindingSource As BindingSource
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents IDFacturaToolStripLabel As ToolStripLabel
    Friend WithEvents IDFacturaToolStripTextBox As ToolStripTextBox
    Friend WithEvents IDProductoToolStripLabel As ToolStripLabel
    Friend WithEvents IDProductoToolStripTextBox As ToolStripTextBox
    Friend WithEvents CantidadToolStripLabel As ToolStripLabel
    Friend WithEvents CantidadToolStripTextBox As ToolStripTextBox
    Friend WithEvents PucToolStripLabel As ToolStripLabel
    Friend WithEvents PucToolStripTextBox As ToolStripTextBox
    Friend WithEvents Tot_PucToolStripLabel As ToolStripLabel
    Friend WithEvents Tot_PucToolStripTextBox As ToolStripTextBox
    Friend WithEvents PuvToolStripLabel As ToolStripLabel
    Friend WithEvents PuvToolStripTextBox As ToolStripTextBox
    Friend WithEvents Tot_PuvToolStripLabel As ToolStripLabel
    Friend WithEvents Tot_PuvToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5BindingSource As BindingSource
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter
    Friend WithEvents FillToolStrip1 As ToolStrip
    Friend WithEvents IDProductoToolStripLabel1 As ToolStripLabel
    Friend WithEvents IDProductoToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents CantidadToolStripLabel1 As ToolStripLabel
    Friend WithEvents CantidadToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillToolStripButton1 As ToolStripButton
    Friend WithEvents IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
End Class
