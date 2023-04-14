<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpleados
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
        Dim IDEmpleadoLabel As System.Windows.Forms.Label
        Dim Telefono_EmpLabel As System.Windows.Forms.Label
        Dim IDEmpleadoLabel1 As System.Windows.Forms.Label
        Dim Nombre_EmpLabel As System.Windows.Forms.Label
        Dim Apellido_EmpLabel As System.Windows.Forms.Label
        Dim Direccion_EmpLabel As System.Windows.Forms.Label
        Dim Empleado_ActivoLabel As System.Windows.Forms.Label
        Me.LibreriaDataSet1 = New Libreria.LibreriaDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New Libreria.LibreriaDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager1 = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.IDEmpleado_Telefono_EmpTableAdapter1 = New Libreria.LibreriaDataSetTableAdapters.IDEmpleado_Telefono_EmpTableAdapter()
        Me.IDEmpleado_Telefono_EmpBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDEmpleado_Telefono_EmpBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.Empleado_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.Empleado_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.Empleado_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.Empleado_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.Empleado_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.IDEmpleadoTextBox2 = New System.Windows.Forms.TextBox()
        Me.Nombre_EmpTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_EmpTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_EmpTextBox = New System.Windows.Forms.TextBox()
        Me.Empleado_ActivoTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDEmpleadoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Telefono_EmpTextBox = New System.Windows.Forms.TextBox()
        Me.IDEmpleado_Telefono_EmpDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClean = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate = New System.Windows.Forms.PictureBox()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.Empleado_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Empleado_View1TableAdapter()
        Me.Empleado_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Empleado_View2TableAdapter()
        Me.Empleado_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Empleado_View3TableAdapter()
        Me.Empleado_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Empleado_View4TableAdapter()
        Me.Empleado_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Empleado_View5TableAdapter()
        IDEmpleadoLabel = New System.Windows.Forms.Label()
        Telefono_EmpLabel = New System.Windows.Forms.Label()
        IDEmpleadoLabel1 = New System.Windows.Forms.Label()
        Nombre_EmpLabel = New System.Windows.Forms.Label()
        Apellido_EmpLabel = New System.Windows.Forms.Label()
        Direccion_EmpLabel = New System.Windows.Forms.Label()
        Empleado_ActivoLabel = New System.Windows.Forms.Label()
        CType(Me.LibreriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDEmpleado_Telefono_EmpBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDEmpleado_Telefono_EmpBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.Empleado_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.Empleado_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.Empleado_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.Empleado_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.Empleado_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleado_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTablas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDEmpleado_Telefono_EmpDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDEmpleadoLabel
        '
        IDEmpleadoLabel.AutoSize = True
        IDEmpleadoLabel.ForeColor = System.Drawing.Color.White
        IDEmpleadoLabel.Location = New System.Drawing.Point(507, 343)
        IDEmpleadoLabel.Name = "IDEmpleadoLabel"
        IDEmpleadoLabel.Size = New System.Drawing.Size(68, 13)
        IDEmpleadoLabel.TabIndex = 35
        IDEmpleadoLabel.Text = "IDEmpleado:"
        '
        'Telefono_EmpLabel
        '
        Telefono_EmpLabel.AutoSize = True
        Telefono_EmpLabel.ForeColor = System.Drawing.Color.White
        Telefono_EmpLabel.Location = New System.Drawing.Point(507, 369)
        Telefono_EmpLabel.Name = "Telefono_EmpLabel"
        Telefono_EmpLabel.Size = New System.Drawing.Size(76, 13)
        Telefono_EmpLabel.TabIndex = 37
        Telefono_EmpLabel.Text = "Telefono Emp:"
        '
        'IDEmpleadoLabel1
        '
        IDEmpleadoLabel1.AutoSize = True
        IDEmpleadoLabel1.ForeColor = System.Drawing.Color.White
        IDEmpleadoLabel1.Location = New System.Drawing.Point(495, 51)
        IDEmpleadoLabel1.Name = "IDEmpleadoLabel1"
        IDEmpleadoLabel1.Size = New System.Drawing.Size(68, 13)
        IDEmpleadoLabel1.TabIndex = 38
        IDEmpleadoLabel1.Text = "IDEmpleado:"
        '
        'Nombre_EmpLabel
        '
        Nombre_EmpLabel.AutoSize = True
        Nombre_EmpLabel.ForeColor = System.Drawing.Color.White
        Nombre_EmpLabel.Location = New System.Drawing.Point(495, 77)
        Nombre_EmpLabel.Name = "Nombre_EmpLabel"
        Nombre_EmpLabel.Size = New System.Drawing.Size(71, 13)
        Nombre_EmpLabel.TabIndex = 40
        Nombre_EmpLabel.Text = "Nombre Emp:"
        '
        'Apellido_EmpLabel
        '
        Apellido_EmpLabel.AutoSize = True
        Apellido_EmpLabel.ForeColor = System.Drawing.Color.White
        Apellido_EmpLabel.Location = New System.Drawing.Point(495, 103)
        Apellido_EmpLabel.Name = "Apellido_EmpLabel"
        Apellido_EmpLabel.Size = New System.Drawing.Size(71, 13)
        Apellido_EmpLabel.TabIndex = 42
        Apellido_EmpLabel.Text = "Apellido Emp:"
        '
        'Direccion_EmpLabel
        '
        Direccion_EmpLabel.AutoSize = True
        Direccion_EmpLabel.ForeColor = System.Drawing.Color.White
        Direccion_EmpLabel.Location = New System.Drawing.Point(495, 129)
        Direccion_EmpLabel.Name = "Direccion_EmpLabel"
        Direccion_EmpLabel.Size = New System.Drawing.Size(79, 13)
        Direccion_EmpLabel.TabIndex = 44
        Direccion_EmpLabel.Text = "Direccion Emp:"
        '
        'Empleado_ActivoLabel
        '
        Empleado_ActivoLabel.AutoSize = True
        Empleado_ActivoLabel.ForeColor = System.Drawing.Color.White
        Empleado_ActivoLabel.Location = New System.Drawing.Point(495, 155)
        Empleado_ActivoLabel.Name = "Empleado_ActivoLabel"
        Empleado_ActivoLabel.Size = New System.Drawing.Size(90, 13)
        Empleado_ActivoLabel.TabIndex = 46
        Empleado_ActivoLabel.Text = "Empleado Activo:"
        '
        'LibreriaDataSet1
        '
        Me.LibreriaDataSet1.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.LibreriaDataSet1
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClienteTableAdapter = Nothing
        Me.TableAdapterManager1.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager1.FacturaTableAdapter = Nothing
        Me.TableAdapterManager1.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter = Nothing
        Me.TableAdapterManager1.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter = Nothing
        Me.TableAdapterManager1.HistorialTableAdapter = Nothing
        Me.TableAdapterManager1.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter = Nothing
        Me.TableAdapterManager1.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter = Nothing
        Me.TableAdapterManager1.IDCliente_TelefonosTableAdapter = Nothing
        Me.TableAdapterManager1.IDEmpleado_Telefono_EmpTableAdapter = Me.IDEmpleado_Telefono_EmpTableAdapter1
        Me.TableAdapterManager1.IDFactura_IDCliente_IDEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager1.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = Nothing
        Me.TableAdapterManager1.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Nothing
        Me.TableAdapterManager1.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager1.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager1.ProductoTableAdapter = Nothing
        Me.TableAdapterManager1.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDEmpleado_Telefono_EmpTableAdapter1
        '
        Me.IDEmpleado_Telefono_EmpTableAdapter1.ClearBeforeFill = True
        '
        'IDEmpleado_Telefono_EmpBindingSource1
        '
        Me.IDEmpleado_Telefono_EmpBindingSource1.DataMember = "IDEmpleado_Telefono_Emp"
        Me.IDEmpleado_Telefono_EmpBindingSource1.DataSource = Me.LibreriaDataSet1
        '
        'IDEmpleado_Telefono_EmpBindingSource2
        '
        Me.IDEmpleado_Telefono_EmpBindingSource2.DataMember = "FK__IDEmplead__IDEmp__5224328E"
        Me.IDEmpleado_Telefono_EmpBindingSource2.DataSource = Me.EmpleadosBindingSource
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.Empleado_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 522)
        Me.PanelV5.TabIndex = 47
        '
        'Empleado_View5DataGridView
        '
        Me.Empleado_View5DataGridView.AutoGenerateColumns = False
        Me.Empleado_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Empleado_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Empleado_View5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Empleado_View5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Empleado_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleado_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26})
        Me.Empleado_View5DataGridView.DataSource = Me.Empleado_View5BindingSource
        Me.Empleado_View5DataGridView.Location = New System.Drawing.Point(245, 181)
        Me.Empleado_View5DataGridView.Name = "Empleado_View5DataGridView"
        Me.Empleado_View5DataGridView.RowHeadersVisible = False
        Me.Empleado_View5DataGridView.Size = New System.Drawing.Size(201, 98)
        Me.Empleado_View5DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'Empleado_View5BindingSource
        '
        Me.Empleado_View5BindingSource.DataMember = "Empleado_View5"
        Me.Empleado_View5BindingSource.DataSource = Me.LibreriaDataSet1
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.Empleado_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 522)
        Me.PanelV4.TabIndex = 46
        '
        'Empleado_View4DataGridView
        '
        Me.Empleado_View4DataGridView.AutoGenerateColumns = False
        Me.Empleado_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Empleado_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Empleado_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Empleado_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Empleado_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleado_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25})
        Me.Empleado_View4DataGridView.DataSource = Me.Empleado_View4BindingSource
        Me.Empleado_View4DataGridView.Location = New System.Drawing.Point(260, 163)
        Me.Empleado_View4DataGridView.Name = "Empleado_View4DataGridView"
        Me.Empleado_View4DataGridView.RowHeadersVisible = False
        Me.Empleado_View4DataGridView.Size = New System.Drawing.Size(198, 113)
        Me.Empleado_View4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'Empleado_View4BindingSource
        '
        Me.Empleado_View4BindingSource.DataMember = "Empleado_View4"
        Me.Empleado_View4BindingSource.DataSource = Me.LibreriaDataSet1
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.Empleado_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 522)
        Me.PanelV3.TabIndex = 45
        '
        'Empleado_View3DataGridView
        '
        Me.Empleado_View3DataGridView.AutoGenerateColumns = False
        Me.Empleado_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Empleado_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Empleado_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Empleado_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Empleado_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleado_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Empleado_View3DataGridView.DataSource = Me.Empleado_View3BindingSource
        Me.Empleado_View3DataGridView.Location = New System.Drawing.Point(45, 71)
        Me.Empleado_View3DataGridView.Name = "Empleado_View3DataGridView"
        Me.Empleado_View3DataGridView.RowHeadersVisible = False
        Me.Empleado_View3DataGridView.Size = New System.Drawing.Size(597, 348)
        Me.Empleado_View3DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn22.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Empleado_View3BindingSource
        '
        Me.Empleado_View3BindingSource.DataMember = "Empleado_View3"
        Me.Empleado_View3BindingSource.DataSource = Me.LibreriaDataSet1
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.Empleado_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 522)
        Me.PanelV2.TabIndex = 44
        '
        'Empleado_View2DataGridView
        '
        Me.Empleado_View2DataGridView.AutoGenerateColumns = False
        Me.Empleado_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Empleado_View2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Empleado_View2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Empleado_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleado_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.Empleado_View2DataGridView.DataSource = Me.Empleado_View2BindingSource
        Me.Empleado_View2DataGridView.Location = New System.Drawing.Point(52, 51)
        Me.Empleado_View2DataGridView.Name = "Empleado_View2DataGridView"
        Me.Empleado_View2DataGridView.RowHeadersVisible = False
        Me.Empleado_View2DataGridView.Size = New System.Drawing.Size(600, 352)
        Me.Empleado_View2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Empleado_View2BindingSource
        '
        Me.Empleado_View2BindingSource.DataMember = "Empleado_View2"
        Me.Empleado_View2BindingSource.DataSource = Me.LibreriaDataSet1
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.Empleado_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 522)
        Me.PanelV1.TabIndex = 43
        '
        'Empleado_View1DataGridView
        '
        Me.Empleado_View1DataGridView.AutoGenerateColumns = False
        Me.Empleado_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Empleado_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Empleado_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Empleado_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Empleado_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleado_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.Empleado_View1DataGridView.DataSource = Me.Empleado_View1BindingSource
        Me.Empleado_View1DataGridView.Location = New System.Drawing.Point(43, 51)
        Me.Empleado_View1DataGridView.Name = "Empleado_View1DataGridView"
        Me.Empleado_View1DataGridView.RowHeadersVisible = False
        Me.Empleado_View1DataGridView.Size = New System.Drawing.Size(609, 362)
        Me.Empleado_View1DataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Direccion_Emp"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Direccion_Emp"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Empleado_View1BindingSource
        '
        Me.Empleado_View1BindingSource.DataMember = "Empleado_View1"
        Me.Empleado_View1BindingSource.DataSource = Me.LibreriaDataSet1
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(IDEmpleadoLabel1)
        Me.PanelTablas.Controls.Add(Me.IDEmpleadoTextBox2)
        Me.PanelTablas.Controls.Add(Nombre_EmpLabel)
        Me.PanelTablas.Controls.Add(Me.Nombre_EmpTextBox)
        Me.PanelTablas.Controls.Add(Apellido_EmpLabel)
        Me.PanelTablas.Controls.Add(Me.Apellido_EmpTextBox)
        Me.PanelTablas.Controls.Add(Direccion_EmpLabel)
        Me.PanelTablas.Controls.Add(Me.Direccion_EmpTextBox)
        Me.PanelTablas.Controls.Add(Empleado_ActivoLabel)
        Me.PanelTablas.Controls.Add(Me.Empleado_ActivoTextBox1)
        Me.PanelTablas.Controls.Add(IDEmpleadoLabel)
        Me.PanelTablas.Controls.Add(Me.IDEmpleadoTextBox1)
        Me.PanelTablas.Controls.Add(Telefono_EmpLabel)
        Me.PanelTablas.Controls.Add(Me.Telefono_EmpTextBox)
        Me.PanelTablas.Controls.Add(Me.IDEmpleado_Telefono_EmpDataGridView1)
        Me.PanelTablas.Controls.Add(Me.EmpleadosDataGridView)
        Me.PanelTablas.Controls.Add(Me.Panel2)
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
        Me.Panel1.Location = New System.Drawing.Point(503, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 35)
        Me.Panel1.TabIndex = 36
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
        'IDEmpleadoTextBox2
        '
        Me.IDEmpleadoTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IDEmpleado", True))
        Me.IDEmpleadoTextBox2.Location = New System.Drawing.Point(591, 48)
        Me.IDEmpleadoTextBox2.Name = "IDEmpleadoTextBox2"
        Me.IDEmpleadoTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.IDEmpleadoTextBox2.TabIndex = 39
        '
        'Nombre_EmpTextBox
        '
        Me.Nombre_EmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre_Emp", True))
        Me.Nombre_EmpTextBox.Location = New System.Drawing.Point(591, 74)
        Me.Nombre_EmpTextBox.Name = "Nombre_EmpTextBox"
        Me.Nombre_EmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_EmpTextBox.TabIndex = 41
        '
        'Apellido_EmpTextBox
        '
        Me.Apellido_EmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido_Emp", True))
        Me.Apellido_EmpTextBox.Location = New System.Drawing.Point(591, 100)
        Me.Apellido_EmpTextBox.Name = "Apellido_EmpTextBox"
        Me.Apellido_EmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apellido_EmpTextBox.TabIndex = 43
        '
        'Direccion_EmpTextBox
        '
        Me.Direccion_EmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Direccion_Emp", True))
        Me.Direccion_EmpTextBox.Location = New System.Drawing.Point(591, 126)
        Me.Direccion_EmpTextBox.Name = "Direccion_EmpTextBox"
        Me.Direccion_EmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Direccion_EmpTextBox.TabIndex = 45
        '
        'Empleado_ActivoTextBox1
        '
        Me.Empleado_ActivoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Empleado_Activo", True))
        Me.Empleado_ActivoTextBox1.Location = New System.Drawing.Point(591, 152)
        Me.Empleado_ActivoTextBox1.Name = "Empleado_ActivoTextBox1"
        Me.Empleado_ActivoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Empleado_ActivoTextBox1.TabIndex = 47
        '
        'IDEmpleadoTextBox1
        '
        Me.IDEmpleadoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDEmpleado_Telefono_EmpBindingSource2, "IDEmpleado", True))
        Me.IDEmpleadoTextBox1.Location = New System.Drawing.Point(589, 340)
        Me.IDEmpleadoTextBox1.Name = "IDEmpleadoTextBox1"
        Me.IDEmpleadoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDEmpleadoTextBox1.TabIndex = 36
        '
        'Telefono_EmpTextBox
        '
        Me.Telefono_EmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDEmpleado_Telefono_EmpBindingSource2, "Telefono_Emp", True))
        Me.Telefono_EmpTextBox.Location = New System.Drawing.Point(589, 366)
        Me.Telefono_EmpTextBox.Name = "Telefono_EmpTextBox"
        Me.Telefono_EmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono_EmpTextBox.TabIndex = 38
        '
        'IDEmpleado_Telefono_EmpDataGridView1
        '
        Me.IDEmpleado_Telefono_EmpDataGridView1.AutoGenerateColumns = False
        Me.IDEmpleado_Telefono_EmpDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDEmpleado_Telefono_EmpDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDEmpleado_Telefono_EmpDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDEmpleado_Telefono_EmpDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDEmpleado_Telefono_EmpDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDEmpleado_Telefono_EmpDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.IDEmpleado_Telefono_EmpDataGridView1.DataSource = Me.IDEmpleado_Telefono_EmpBindingSource2
        Me.IDEmpleado_Telefono_EmpDataGridView1.Location = New System.Drawing.Point(10, 301)
        Me.IDEmpleado_Telefono_EmpDataGridView1.Name = "IDEmpleado_Telefono_EmpDataGridView1"
        Me.IDEmpleado_Telefono_EmpDataGridView1.RowHeadersVisible = False
        Me.IDEmpleado_Telefono_EmpDataGridView1.Size = New System.Drawing.Size(308, 153)
        Me.IDEmpleado_Telefono_EmpDataGridView1.TabIndex = 35
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Telefono_Emp"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Telefono_Emp"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmpleadosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EmpleadosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(10, 35)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersVisible = False
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(465, 234)
        Me.EmpleadosDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IDEmpleado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IDEmpleado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre_Emp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Apellido_Emp"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Direccion_Emp"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Direccion_Emp"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Empleado_Activo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnClean)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Location = New System.Drawing.Point(503, 190)
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
        Me.BtnV5.Text = "Cantidad de Empleados Inactivos"
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
        Me.BtnV4.Text = "Cantidad de Empleados Activos"
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
        Me.BtnV3.Text = "ID y Nombre Empleado"
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
        Me.BtnV2.Text = "Datos Personales de Empleados"
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
        Me.BtnV1.Text = "Datos de los Empleados"
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
        'Empleado_View1TableAdapter
        '
        Me.Empleado_View1TableAdapter.ClearBeforeFill = True
        '
        'Empleado_View2TableAdapter
        '
        Me.Empleado_View2TableAdapter.ClearBeforeFill = True
        '
        'Empleado_View3TableAdapter
        '
        Me.Empleado_View3TableAdapter.ClearBeforeFill = True
        '
        'Empleado_View4TableAdapter
        '
        Me.Empleado_View4TableAdapter.ClearBeforeFill = True
        '
        'Empleado_View5TableAdapter
        '
        Me.Empleado_View5TableAdapter.ClearBeforeFill = True
        '
        'FormEmpleados
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 522)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormEmpleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibreriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDEmpleado_Telefono_EmpBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDEmpleado_Telefono_EmpBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.Empleado_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.Empleado_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.Empleado_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.Empleado_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.Empleado_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleado_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDEmpleado_Telefono_EmpDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmpleadoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpleado_Empleado_ActivoBindingSource As BindingSource
    Friend WithEvents IDEmpleado_Telefono_EmpTableAdapter As LibreriaDataSetTableAdapters.IDEmpleado_Telefono_EmpTableAdapter
    Friend WithEvents IDEmpleadoTextBox As TextBox
    Friend WithEvents Empleado_ActivoTextBox As TextBox
    Friend WithEvents IDEmpleado_Telefono_EmpBindingSource As BindingSource
    Friend WithEvents IDEmpleado_Telefono_EmpDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents LibreriaDataSet1 As LibreriaDataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As LibreriaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager1 As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDEmpleado_Telefono_EmpTableAdapter1 As LibreriaDataSetTableAdapters.IDEmpleado_Telefono_EmpTableAdapter
    Friend WithEvents IDEmpleado_Telefono_EmpBindingSource1 As BindingSource
    Friend WithEvents IDEmpleado_Telefono_EmpBindingSource2 As BindingSource
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClean As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents BtnUpdate As PictureBox
    Friend WithEvents BtnSearch As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents IDEmpleadoTextBox2 As TextBox
    Friend WithEvents Nombre_EmpTextBox As TextBox
    Friend WithEvents Apellido_EmpTextBox As TextBox
    Friend WithEvents Direccion_EmpTextBox As TextBox
    Friend WithEvents Empleado_ActivoTextBox1 As TextBox
    Friend WithEvents IDEmpleadoTextBox1 As TextBox
    Friend WithEvents Telefono_EmpTextBox As TextBox
    Friend WithEvents IDEmpleado_Telefono_EmpDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Empleado_View1BindingSource As BindingSource
    Friend WithEvents Empleado_View1TableAdapter As LibreriaDataSetTableAdapters.Empleado_View1TableAdapter
    Friend WithEvents Empleado_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Empleado_View2BindingSource As BindingSource
    Friend WithEvents Empleado_View2TableAdapter As LibreriaDataSetTableAdapters.Empleado_View2TableAdapter
    Friend WithEvents Empleado_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Empleado_View3BindingSource As BindingSource
    Friend WithEvents Empleado_View3TableAdapter As LibreriaDataSetTableAdapters.Empleado_View3TableAdapter
    Friend WithEvents Empleado_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents Empleado_View4BindingSource As BindingSource
    Friend WithEvents Empleado_View4TableAdapter As LibreriaDataSetTableAdapters.Empleado_View4TableAdapter
    Friend WithEvents Empleado_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Empleado_View5BindingSource As BindingSource
    Friend WithEvents Empleado_View5TableAdapter As LibreriaDataSetTableAdapters.Empleado_View5TableAdapter
    Friend WithEvents Empleado_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
End Class
