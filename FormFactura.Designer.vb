﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFactura
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim ImpuestoLabel As System.Windows.Forms.Label
        Dim DescuentoLabel As System.Windows.Forms.Label
        Dim Total_FacturaLabel As System.Windows.Forms.Label
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleadoTableAdapter()
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Libreria.LibreriaDataSetTableAdapters.FacturaTableAdapter()
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.Factura_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.Factura_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.Factura_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.Factura_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.Factura_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClean = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate = New System.Windows.Forms.PictureBox()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.IDFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.ImpuestoTextBox = New System.Windows.Forms.TextBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.Total_FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Factura_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Factura_View1TableAdapter()
        Me.Factura_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Factura_View2TableAdapter()
        Me.Factura_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Factura_View3TableAdapter()
        Me.Factura_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Factura_View4TableAdapter()
        Me.Factura_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Factura_View5TableAdapter()
        IDFacturaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        ImpuestoLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        Total_FacturaLabel = New System.Windows.Forms.Label()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.Factura_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.Factura_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.Factura_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.Factura_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.Factura_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTablas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDFacturaLabel
        '
        IDFacturaLabel.AutoSize = True
        IDFacturaLabel.ForeColor = System.Drawing.Color.White
        IDFacturaLabel.Location = New System.Drawing.Point(38, 346)
        IDFacturaLabel.Name = "IDFacturaLabel"
        IDFacturaLabel.Size = New System.Drawing.Size(57, 13)
        IDFacturaLabel.TabIndex = 1
        IDFacturaLabel.Text = "IDFactura:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.ForeColor = System.Drawing.Color.White
        FechaLabel.Location = New System.Drawing.Point(38, 373)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.ForeColor = System.Drawing.Color.White
        SubtotalLabel.Location = New System.Drawing.Point(38, 398)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(49, 13)
        SubtotalLabel.TabIndex = 5
        SubtotalLabel.Text = "Subtotal:"
        '
        'ImpuestoLabel
        '
        ImpuestoLabel.AutoSize = True
        ImpuestoLabel.ForeColor = System.Drawing.Color.White
        ImpuestoLabel.Location = New System.Drawing.Point(353, 346)
        ImpuestoLabel.Name = "ImpuestoLabel"
        ImpuestoLabel.Size = New System.Drawing.Size(53, 13)
        ImpuestoLabel.TabIndex = 7
        ImpuestoLabel.Text = "Impuesto:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.ForeColor = System.Drawing.Color.White
        DescuentoLabel.Location = New System.Drawing.Point(353, 372)
        DescuentoLabel.Name = "DescuentoLabel"
        DescuentoLabel.Size = New System.Drawing.Size(62, 13)
        DescuentoLabel.TabIndex = 9
        DescuentoLabel.Text = "Descuento:"
        '
        'Total_FacturaLabel
        '
        Total_FacturaLabel.AutoSize = True
        Total_FacturaLabel.ForeColor = System.Drawing.Color.White
        Total_FacturaLabel.Location = New System.Drawing.Point(353, 398)
        Total_FacturaLabel.Name = "Total_FacturaLabel"
        Total_FacturaLabel.Size = New System.Drawing.Size(73, 13)
        Total_FacturaLabel.TabIndex = 11
        Total_FacturaLabel.Text = "Total Factura:"
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.IDFactura_IDCliente_IDEmpleadoTableAdapter = Me.IDFactura_IDCliente_IDEmpleadoTableAdapter
        Me.TableAdapterManager.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter = Nothing
        Me.TableAdapterManager.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDFactura_IDCliente_IDEmpleadoTableAdapter
        '
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.LibreriaDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'IDFactura_IDCliente_IDEmpleadoBindingSource
        '
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource.DataMember = "FK__IDFactura__IDFac__22401542"
        Me.IDFactura_IDCliente_IDEmpleadoBindingSource.DataSource = Me.FacturaBindingSource
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.Factura_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 523)
        Me.PanelV5.TabIndex = 47
        '
        'Factura_View5DataGridView
        '
        Me.Factura_View5DataGridView.AutoGenerateColumns = False
        Me.Factura_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Factura_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Factura_View5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Factura_View5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Factura_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Factura_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Factura_View5DataGridView.DataSource = Me.Factura_View5BindingSource
        Me.Factura_View5DataGridView.Location = New System.Drawing.Point(55, 69)
        Me.Factura_View5DataGridView.Name = "Factura_View5DataGridView"
        Me.Factura_View5DataGridView.RowHeadersVisible = False
        Me.Factura_View5DataGridView.Size = New System.Drawing.Size(565, 297)
        Me.Factura_View5DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn21.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Total_Factura"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Total_Factura"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'Factura_View5BindingSource
        '
        Me.Factura_View5BindingSource.DataMember = "Factura_View5"
        Me.Factura_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.Factura_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 523)
        Me.PanelV4.TabIndex = 46
        '
        'Factura_View4DataGridView
        '
        Me.Factura_View4DataGridView.AutoGenerateColumns = False
        Me.Factura_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Factura_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Factura_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Factura_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Factura_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Factura_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.Factura_View4DataGridView.DataSource = Me.Factura_View4BindingSource
        Me.Factura_View4DataGridView.Location = New System.Drawing.Point(57, 75)
        Me.Factura_View4DataGridView.Name = "Factura_View4DataGridView"
        Me.Factura_View4DataGridView.RowHeadersVisible = False
        Me.Factura_View4DataGridView.Size = New System.Drawing.Size(591, 336)
        Me.Factura_View4DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn17.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Total_Factura"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Total_Factura"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Factura_View4BindingSource
        '
        Me.Factura_View4BindingSource.DataMember = "Factura_View4"
        Me.Factura_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.Factura_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 523)
        Me.PanelV3.TabIndex = 45
        '
        'Factura_View3DataGridView
        '
        Me.Factura_View3DataGridView.AutoGenerateColumns = False
        Me.Factura_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Factura_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Factura_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Factura_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Factura_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Factura_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Factura_View3DataGridView.DataSource = Me.Factura_View3BindingSource
        Me.Factura_View3DataGridView.Location = New System.Drawing.Point(213, 132)
        Me.Factura_View3DataGridView.Name = "Factura_View3DataGridView"
        Me.Factura_View3DataGridView.RowHeadersVisible = False
        Me.Factura_View3DataGridView.Size = New System.Drawing.Size(287, 205)
        Me.Factura_View3DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn15.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Total_Factura"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total_Factura"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Factura_View3BindingSource
        '
        Me.Factura_View3BindingSource.DataMember = "Factura_View3"
        Me.Factura_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.Factura_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 523)
        Me.PanelV2.TabIndex = 44
        '
        'Factura_View2DataGridView
        '
        Me.Factura_View2DataGridView.AutoGenerateColumns = False
        Me.Factura_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Factura_View2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Factura_View2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Factura_View2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Factura_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Factura_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Factura_View2DataGridView.DataSource = Me.Factura_View2BindingSource
        Me.Factura_View2DataGridView.Location = New System.Drawing.Point(144, 85)
        Me.Factura_View2DataGridView.Name = "Factura_View2DataGridView"
        Me.Factura_View2DataGridView.RowHeadersVisible = False
        Me.Factura_View2DataGridView.Size = New System.Drawing.Size(431, 285)
        Me.Factura_View2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Factura_View2BindingSource
        '
        Me.Factura_View2BindingSource.DataMember = "Factura_View2"
        Me.Factura_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.Factura_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 523)
        Me.PanelV1.TabIndex = 43
        '
        'Factura_View1DataGridView
        '
        Me.Factura_View1DataGridView.AutoGenerateColumns = False
        Me.Factura_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Factura_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Factura_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Factura_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Factura_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Factura_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Factura_View1DataGridView.DataSource = Me.Factura_View1BindingSource
        Me.Factura_View1DataGridView.Location = New System.Drawing.Point(41, 81)
        Me.Factura_View1DataGridView.Name = "Factura_View1DataGridView"
        Me.Factura_View1DataGridView.RowHeadersVisible = False
        Me.Factura_View1DataGridView.Size = New System.Drawing.Size(612, 314)
        Me.Factura_View1DataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total_Factura"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total_Factura"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Factura_View1BindingSource
        '
        Me.Factura_View1BindingSource.DataMember = "Factura_View1"
        Me.Factura_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(IDFacturaLabel)
        Me.PanelTablas.Controls.Add(Me.IDFacturaTextBox)
        Me.PanelTablas.Controls.Add(FechaLabel)
        Me.PanelTablas.Controls.Add(Me.FechaDateTimePicker)
        Me.PanelTablas.Controls.Add(SubtotalLabel)
        Me.PanelTablas.Controls.Add(Me.SubtotalTextBox)
        Me.PanelTablas.Controls.Add(ImpuestoLabel)
        Me.PanelTablas.Controls.Add(Me.ImpuestoTextBox)
        Me.PanelTablas.Controls.Add(DescuentoLabel)
        Me.PanelTablas.Controls.Add(Me.DescuentoTextBox)
        Me.PanelTablas.Controls.Add(Total_FacturaLabel)
        Me.PanelTablas.Controls.Add(Me.Total_FacturaTextBox)
        Me.PanelTablas.Controls.Add(Me.FacturaDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(706, 523)
        Me.PanelTablas.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnClean)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Location = New System.Drawing.Point(255, 444)
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
        'IDFacturaTextBox
        '
        Me.IDFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "IDFactura", True))
        Me.IDFacturaTextBox.Location = New System.Drawing.Point(117, 343)
        Me.IDFacturaTextBox.Name = "IDFacturaTextBox"
        Me.IDFacturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDFacturaTextBox.TabIndex = 2
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(117, 369)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Subtotal", True))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(117, 395)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SubtotalTextBox.TabIndex = 6
        '
        'ImpuestoTextBox
        '
        Me.ImpuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Impuesto", True))
        Me.ImpuestoTextBox.Location = New System.Drawing.Point(432, 343)
        Me.ImpuestoTextBox.Name = "ImpuestoTextBox"
        Me.ImpuestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ImpuestoTextBox.TabIndex = 8
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Descuento", True))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(432, 369)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescuentoTextBox.TabIndex = 10
        '
        'Total_FacturaTextBox
        '
        Me.Total_FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Total_Factura", True))
        Me.Total_FacturaTextBox.Location = New System.Drawing.Point(432, 395)
        Me.Total_FacturaTextBox.Name = "Total_FacturaTextBox"
        Me.Total_FacturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_FacturaTextBox.TabIndex = 12
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FacturaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FacturaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FacturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(25, 40)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.RowHeadersVisible = False
        Me.FacturaDataGridView.Size = New System.Drawing.Size(651, 232)
        Me.FacturaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDFactura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDFactura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Impuesto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Impuesto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total_Factura"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total_Factura"
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
        Me.PanelBtnTB.Size = New System.Drawing.Size(174, 523)
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
        Me.BtnV5.Text = "Facturas por Fecha"
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
        Me.BtnV4.Text = "Facturas con Descuento"
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
        Me.BtnV3.Text = "ID y Total de Facturas"
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
        Me.BtnV2.Text = "ID y Subtotal de Facturas"
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
        Me.BtnV1.Text = "Facturas"
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
        'Factura_View1TableAdapter
        '
        Me.Factura_View1TableAdapter.ClearBeforeFill = True
        '
        'Factura_View2TableAdapter
        '
        Me.Factura_View2TableAdapter.ClearBeforeFill = True
        '
        'Factura_View3TableAdapter
        '
        Me.Factura_View3TableAdapter.ClearBeforeFill = True
        '
        'Factura_View4TableAdapter
        '
        Me.Factura_View4TableAdapter.ClearBeforeFill = True
        '
        'Factura_View5TableAdapter
        '
        Me.Factura_View5TableAdapter.ClearBeforeFill = True
        '
        'FormFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 523)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Name = "FormFactura"
        Me.Text = "FormFactura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDFactura_IDCliente_IDEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.Factura_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.Factura_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.Factura_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.Factura_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.Factura_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoTableAdapter As LibreriaDataSetTableAdapters.IDFactura_IDCliente_IDEmpleadoTableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoBindingSource1 As BindingSource
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As LibreriaDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents IDFactura_IDCliente_IDEmpleadoBindingSource As BindingSource
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
    Friend WithEvents IDFacturaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents ImpuestoTextBox As TextBox
    Friend WithEvents DescuentoTextBox As TextBox
    Friend WithEvents Total_FacturaTextBox As TextBox
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClean As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents BtnUpdate As PictureBox
    Friend WithEvents BtnSearch As PictureBox
    Friend WithEvents Factura_View1BindingSource As BindingSource
    Friend WithEvents Factura_View1TableAdapter As LibreriaDataSetTableAdapters.Factura_View1TableAdapter
    Friend WithEvents Factura_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Factura_View2BindingSource As BindingSource
    Friend WithEvents Factura_View2TableAdapter As LibreriaDataSetTableAdapters.Factura_View2TableAdapter
    Friend WithEvents Factura_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Factura_View3BindingSource As BindingSource
    Friend WithEvents Factura_View3TableAdapter As LibreriaDataSetTableAdapters.Factura_View3TableAdapter
    Friend WithEvents Factura_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Factura_View4BindingSource As BindingSource
    Friend WithEvents Factura_View4TableAdapter As LibreriaDataSetTableAdapters.Factura_View4TableAdapter
    Friend WithEvents Factura_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents Factura_View5BindingSource As BindingSource
    Friend WithEvents Factura_View5TableAdapter As LibreriaDataSetTableAdapters.Factura_View5TableAdapter
    Friend WithEvents Factura_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
End Class
