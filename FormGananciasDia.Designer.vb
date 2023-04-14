<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGananciasDia
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
        Dim IDFechaRegLabel As System.Windows.Forms.Label
        Dim Tot_Puc_DiaLabel As System.Windows.Forms.Label
        Dim Tot_Puv_DiaLabel As System.Windows.Forms.Label
        Dim Tot_pagos_DiasLabel As System.Windows.Forms.Label
        Dim IDFechaRegLabel1 As System.Windows.Forms.Label
        Dim Utilidad_BrutaLabel As System.Windows.Forms.Label
        Dim Utilidad_netaLabel As System.Windows.Forms.Label
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter()
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
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
        Me.IDFechaRegDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Utilidad_BrutaTextBox = New System.Windows.Forms.TextBox()
        Me.Utilidad_netaTextBox = New System.Windows.Forms.TextBox()
        Me.IDFechaRegDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tot_Puc_DiaTextBox = New System.Windows.Forms.TextBox()
        Me.Tot_Puv_DiaTextBox = New System.Windows.Forms.TextBox()
        Me.Tot_pagos_DiasTextBox = New System.Windows.Forms.TextBox()
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter()
        IDFechaRegLabel = New System.Windows.Forms.Label()
        Tot_Puc_DiaLabel = New System.Windows.Forms.Label()
        Tot_Puv_DiaLabel = New System.Windows.Forms.Label()
        Tot_pagos_DiasLabel = New System.Windows.Forms.Label()
        IDFechaRegLabel1 = New System.Windows.Forms.Label()
        Utilidad_BrutaLabel = New System.Windows.Forms.Label()
        Utilidad_netaLabel = New System.Windows.Forms.Label()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
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
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDFechaRegLabel
        '
        IDFechaRegLabel.AutoSize = True
        IDFechaRegLabel.ForeColor = System.Drawing.Color.White
        IDFechaRegLabel.Location = New System.Drawing.Point(511, 101)
        IDFechaRegLabel.Name = "IDFechaRegLabel"
        IDFechaRegLabel.Size = New System.Drawing.Size(74, 13)
        IDFechaRegLabel.TabIndex = 2
        IDFechaRegLabel.Text = "IDFecha Reg:"
        '
        'Tot_Puc_DiaLabel
        '
        Tot_Puc_DiaLabel.AutoSize = True
        Tot_Puc_DiaLabel.ForeColor = System.Drawing.Color.White
        Tot_Puc_DiaLabel.Location = New System.Drawing.Point(511, 126)
        Tot_Puc_DiaLabel.Name = "Tot_Puc_DiaLabel"
        Tot_Puc_DiaLabel.Size = New System.Drawing.Size(67, 13)
        Tot_Puc_DiaLabel.TabIndex = 4
        Tot_Puc_DiaLabel.Text = "Tot Puc Dia:"
        '
        'Tot_Puv_DiaLabel
        '
        Tot_Puv_DiaLabel.AutoSize = True
        Tot_Puv_DiaLabel.ForeColor = System.Drawing.Color.White
        Tot_Puv_DiaLabel.Location = New System.Drawing.Point(511, 152)
        Tot_Puv_DiaLabel.Name = "Tot_Puv_DiaLabel"
        Tot_Puv_DiaLabel.Size = New System.Drawing.Size(67, 13)
        Tot_Puv_DiaLabel.TabIndex = 6
        Tot_Puv_DiaLabel.Text = "Tot Puv Dia:"
        '
        'Tot_pagos_DiasLabel
        '
        Tot_pagos_DiasLabel.AutoSize = True
        Tot_pagos_DiasLabel.ForeColor = System.Drawing.Color.White
        Tot_pagos_DiasLabel.Location = New System.Drawing.Point(511, 178)
        Tot_pagos_DiasLabel.Name = "Tot_pagos_DiasLabel"
        Tot_pagos_DiasLabel.Size = New System.Drawing.Size(82, 13)
        Tot_pagos_DiasLabel.TabIndex = 8
        Tot_pagos_DiasLabel.Text = "Tot pagos Dias:"
        '
        'IDFechaRegLabel1
        '
        IDFechaRegLabel1.AutoSize = True
        IDFechaRegLabel1.ForeColor = System.Drawing.Color.White
        IDFechaRegLabel1.Location = New System.Drawing.Point(519, 343)
        IDFechaRegLabel1.Name = "IDFechaRegLabel1"
        IDFechaRegLabel1.Size = New System.Drawing.Size(74, 13)
        IDFechaRegLabel1.TabIndex = 10
        IDFechaRegLabel1.Text = "IDFecha Reg:"
        '
        'Utilidad_BrutaLabel
        '
        Utilidad_BrutaLabel.AutoSize = True
        Utilidad_BrutaLabel.ForeColor = System.Drawing.Color.White
        Utilidad_BrutaLabel.Location = New System.Drawing.Point(519, 368)
        Utilidad_BrutaLabel.Name = "Utilidad_BrutaLabel"
        Utilidad_BrutaLabel.Size = New System.Drawing.Size(73, 13)
        Utilidad_BrutaLabel.TabIndex = 12
        Utilidad_BrutaLabel.Text = "Utilidad Bruta:"
        '
        'Utilidad_netaLabel
        '
        Utilidad_netaLabel.AutoSize = True
        Utilidad_netaLabel.ForeColor = System.Drawing.Color.White
        Utilidad_netaLabel.Location = New System.Drawing.Point(519, 394)
        Utilidad_netaLabel.Name = "Utilidad_netaLabel"
        Utilidad_netaLabel.Size = New System.Drawing.Size(69, 13)
        Utilidad_netaLabel.TabIndex = 14
        Utilidad_netaLabel.Text = "Utilidad neta:"
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource.DataSource = Me.LibreriaDataSet
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter
        Me.TableAdapterManager.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter = Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter = Nothing
        Me.TableAdapterManager.IDCliente_TelefonosTableAdapter = Nothing
        Me.TableAdapterManager.IDEmpleado_Telefono_EmpTableAdapter = Nothing
        Me.TableAdapterManager.IDFactura_IDCliente_IDEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = Nothing
        Me.TableAdapterManager.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter
        '
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.ClearBeforeFill = True
        '
        'FechaReg_UtilidadBruta_Utilidad_NetaBindingSource
        '
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource.DataMember = "FechaReg_UtilidadBruta_Utilidad_Neta"
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource.DataSource = Me.LibreriaDataSet
        '
        'FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1
        '
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1.DataMember = "FK__FechaReg___IDFec__47A6A41B"
        Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 522)
        Me.PanelV5.TabIndex = 47
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.Location = New System.Drawing.Point(57, 159)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.Size = New System.Drawing.Size(202, 136)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 522)
        Me.PanelV4.TabIndex = 46
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.Location = New System.Drawing.Point(274, 175)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.Size = New System.Drawing.Size(152, 117)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 522)
        Me.PanelV3.TabIndex = 45
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.Location = New System.Drawing.Point(251, 201)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.Size = New System.Drawing.Size(209, 142)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 522)
        Me.PanelV2.TabIndex = 44
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.Location = New System.Drawing.Point(256, 178)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.Size = New System.Drawing.Size(185, 132)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Expr1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 522)
        Me.PanelV1.TabIndex = 43
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.Location = New System.Drawing.Point(66, 142)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.Size = New System.Drawing.Size(554, 253)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDFechaReg"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDFechaReg"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tot_Puc_Dia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tot_Puc_Dia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Tot_Puv_Dia"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tot_Puv_Dia"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tot_pagos_Dias"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tot_pagos_Dias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource.DataMember = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource.DataSource = Me.LibreriaDataSet
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
        Me.BtnV5.Text = "Total de PUV al Mes"
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
        Me.BtnV4.Text = "Total de PUC al Mes"
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
        Me.BtnV3.Text = "Promedio de Pagos Mensuales"
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
        Me.BtnV2.Text = "Total de Pagos por Día"
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
        Me.BtnV1.Text = "Detalles de las Ganancias"
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
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(IDFechaRegLabel1)
        Me.PanelTablas.Controls.Add(Me.IDFechaRegDateTimePicker1)
        Me.PanelTablas.Controls.Add(Utilidad_BrutaLabel)
        Me.PanelTablas.Controls.Add(Me.Utilidad_BrutaTextBox)
        Me.PanelTablas.Controls.Add(Utilidad_netaLabel)
        Me.PanelTablas.Controls.Add(Me.Utilidad_netaTextBox)
        Me.PanelTablas.Controls.Add(IDFechaRegLabel)
        Me.PanelTablas.Controls.Add(Me.IDFechaRegDateTimePicker)
        Me.PanelTablas.Controls.Add(Tot_Puc_DiaLabel)
        Me.PanelTablas.Controls.Add(Me.Tot_Puc_DiaTextBox)
        Me.PanelTablas.Controls.Add(Tot_Puv_DiaLabel)
        Me.PanelTablas.Controls.Add(Me.Tot_Puv_DiaTextBox)
        Me.PanelTablas.Controls.Add(Tot_pagos_DiasLabel)
        Me.PanelTablas.Controls.Add(Me.Tot_pagos_DiasTextBox)
        Me.PanelTablas.Controls.Add(Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView)
        Me.PanelTablas.Controls.Add(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView)
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
        Me.Panel1.Location = New System.Drawing.Point(511, 421)
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
        Me.Panel2.Location = New System.Drawing.Point(511, 216)
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
        'IDFechaRegDateTimePicker1
        '
        Me.IDFechaRegDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1, "IDFechaReg", True))
        Me.IDFechaRegDateTimePicker1.Location = New System.Drawing.Point(599, 339)
        Me.IDFechaRegDateTimePicker1.Name = "IDFechaRegDateTimePicker1"
        Me.IDFechaRegDateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.IDFechaRegDateTimePicker1.TabIndex = 11
        '
        'Utilidad_BrutaTextBox
        '
        Me.Utilidad_BrutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1, "Utilidad_Bruta", True))
        Me.Utilidad_BrutaTextBox.Location = New System.Drawing.Point(599, 365)
        Me.Utilidad_BrutaTextBox.Name = "Utilidad_BrutaTextBox"
        Me.Utilidad_BrutaTextBox.Size = New System.Drawing.Size(91, 20)
        Me.Utilidad_BrutaTextBox.TabIndex = 13
        '
        'Utilidad_netaTextBox
        '
        Me.Utilidad_netaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1, "Utilidad_neta", True))
        Me.Utilidad_netaTextBox.Location = New System.Drawing.Point(599, 391)
        Me.Utilidad_netaTextBox.Name = "Utilidad_netaTextBox"
        Me.Utilidad_netaTextBox.Size = New System.Drawing.Size(91, 20)
        Me.Utilidad_netaTextBox.TabIndex = 15
        '
        'IDFechaRegDateTimePicker
        '
        Me.IDFechaRegDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, "IDFechaReg", True))
        Me.IDFechaRegDateTimePicker.Location = New System.Drawing.Point(599, 97)
        Me.IDFechaRegDateTimePicker.Name = "IDFechaRegDateTimePicker"
        Me.IDFechaRegDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.IDFechaRegDateTimePicker.TabIndex = 3
        '
        'Tot_Puc_DiaTextBox
        '
        Me.Tot_Puc_DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, "Tot_Puc_Dia", True))
        Me.Tot_Puc_DiaTextBox.Location = New System.Drawing.Point(599, 123)
        Me.Tot_Puc_DiaTextBox.Name = "Tot_Puc_DiaTextBox"
        Me.Tot_Puc_DiaTextBox.Size = New System.Drawing.Size(91, 20)
        Me.Tot_Puc_DiaTextBox.TabIndex = 5
        '
        'Tot_Puv_DiaTextBox
        '
        Me.Tot_Puv_DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, "Tot_Puv_Dia", True))
        Me.Tot_Puv_DiaTextBox.Location = New System.Drawing.Point(599, 149)
        Me.Tot_Puv_DiaTextBox.Name = "Tot_Puv_DiaTextBox"
        Me.Tot_Puv_DiaTextBox.Size = New System.Drawing.Size(91, 20)
        Me.Tot_Puv_DiaTextBox.TabIndex = 7
        '
        'Tot_pagos_DiasTextBox
        '
        Me.Tot_pagos_DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, "Tot_pagos_Dias", True))
        Me.Tot_pagos_DiasTextBox.Location = New System.Drawing.Point(599, 175)
        Me.Tot_pagos_DiasTextBox.Name = "Tot_pagos_DiasTextBox"
        Me.Tot_pagos_DiasTextBox.Size = New System.Drawing.Size(91, 20)
        Me.Tot_pagos_DiasTextBox.TabIndex = 9
        '
        'FechaReg_UtilidadBruta_Utilidad_NetaDataGridView
        '
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.AutoGenerateColumns = False
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.DataSource = Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.Location = New System.Drawing.Point(17, 301)
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.Name = "FechaReg_UtilidadBruta_Utilidad_NetaDataGridView"
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.RowHeadersVisible = False
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.Size = New System.Drawing.Size(488, 155)
        Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDFechaReg"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDFechaReg"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Utilidad_Bruta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Utilidad_Bruta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Utilidad_neta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Utilidad_neta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.AutoGenerateColumns = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.DataSource = Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.Location = New System.Drawing.Point(17, 23)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.Name = "FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView"
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.RowHeadersVisible = False
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.Size = New System.Drawing.Size(488, 238)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDFechaReg"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDFechaReg"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tot_Puc_Dia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tot_Puc_Dia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tot_Puv_Dia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tot_Puv_Dia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tot_pagos_Dias"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tot_pagos_Dias"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter.ClearBeforeFill = True
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter.ClearBeforeFill = True
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter.ClearBeforeFill = True
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter.ClearBeforeFill = True
        '
        'FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter
        '
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter.ClearBeforeFill = True
        '
        'FormGananciasDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 522)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormGananciasDia"
        Me.Text = "FormGananciasDia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
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
        CType(Me.FechaReg_UtilidadBruta_Utilidad_NetaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter As LibreriaDataSetTableAdapters.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter
    Friend WithEvents FechaReg_UtilidadBruta_Utilidad_NetaBindingSource As BindingSource
    Friend WithEvents FechaReg_UtilidadBruta_Utilidad_NetaBindingSource1 As BindingSource
    Friend WithEvents PanelV5 As Panel
    Friend WithEvents PanelV4 As Panel
    Friend WithEvents PanelV3 As Panel
    Friend WithEvents PanelV2 As Panel
    Friend WithEvents PanelV1 As Panel
    Friend WithEvents PanelBtnTB As Panel
    Friend WithEvents BtnV5 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV4 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV3 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTxtVistas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTbAbonos As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTablas As Panel
    Friend WithEvents IDFechaRegDateTimePicker1 As DateTimePicker
    Friend WithEvents Utilidad_BrutaTextBox As TextBox
    Friend WithEvents Utilidad_netaTextBox As TextBox
    Friend WithEvents IDFechaRegDateTimePicker As DateTimePicker
    Friend WithEvents Tot_Puc_DiaTextBox As TextBox
    Friend WithEvents Tot_Puv_DiaTextBox As TextBox
    Friend WithEvents Tot_pagos_DiasTextBox As TextBox
    Friend WithEvents FechaReg_UtilidadBruta_Utilidad_NetaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
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
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1BindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2BindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3BindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4BindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5BindingSource As BindingSource
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter As LibreriaDataSetTableAdapters.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter
    Friend WithEvents FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
End Class
