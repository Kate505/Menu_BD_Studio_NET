<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbonos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView As System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Label7 As System.Windows.Forms.Label
        Dim IDClienteLabel As System.Windows.Forms.Label
        Dim Deuda_TotalLabel As System.Windows.Forms.Label
        Dim Saldo_PendienteLabel As System.Windows.Forms.Label
        Dim IDAbonoLabel As System.Windows.Forms.Label
        Dim IDClienteLabel1 As System.Windows.Forms.Label
        Dim Fecha_AbonoLabel As System.Windows.Forms.Label
        Dim Saldo_AbonoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbonos))
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.BtnTbAbonos = New FontAwesome.Sharp.IconButton()
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.IDAbonoTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDClienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Fecha_AbonoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Saldo_AbonoTextBox = New System.Windows.Forms.TextBox()
        Me.IDClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Deuda_TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Saldo_PendienteTextBox = New System.Windows.Forms.TextBox()
        Me.IDAbonoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd1 = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate1 = New System.Windows.Forms.PictureBox()
        Me.BtnDelete1 = New System.Windows.Forms.PictureBox()
        Me.BtnSearch1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClean = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate = New System.Windows.Forms.PictureBox()
        Me.BtnSearch = New System.Windows.Forms.PictureBox()
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter()
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter()
        Me.IDAbo_IDCli_Deuda_Saldo_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View1TableAdapter()
        Me.IDAbo_IDCli_Deuda_Saldo_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View2TableAdapter()
        Me.IDAbo_IDCli_Deuda_Saldo_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View3TableAdapter()
        Me.IDAbo_IDCli_Deuda_Saldo_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View4TableAdapter()
        Me.IDAbo_IDCli_Deuda_Saldo_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View5TableAdapter()
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter()
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter()
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView = New System.Windows.Forms.DataGridView()
        Label7 = New System.Windows.Forms.Label()
        IDClienteLabel = New System.Windows.Forms.Label()
        Deuda_TotalLabel = New System.Windows.Forms.Label()
        Saldo_PendienteLabel = New System.Windows.Forms.Label()
        IDAbonoLabel = New System.Windows.Forms.Label()
        IDClienteLabel1 = New System.Windows.Forms.Label()
        Fecha_AbonoLabel = New System.Windows.Forms.Label()
        Saldo_AbonoLabel = New System.Windows.Forms.Label()
        CType(IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTxtVistas.SuspendLayout()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTablas.SuspendLayout()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView
        '
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.AutoGenerateColumns = False
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.DataSource = Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.Location = New System.Drawing.Point(21, 22)
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.Name = "IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.RowHeadersVisible = False
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.Size = New System.Drawing.Size(417, 266)
        IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDAbono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDAbono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Deuda_Total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Deuda_Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource
        '
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource.DataMember = "IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente"
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource.DataSource = Me.LibreriaDataSet
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(469, 85)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(52, 13)
        Label7.TabIndex = 36
        Label7.Text = "IDAbono:"
        '
        'IDClienteLabel
        '
        IDClienteLabel.AutoSize = True
        IDClienteLabel.ForeColor = System.Drawing.Color.White
        IDClienteLabel.Location = New System.Drawing.Point(469, 111)
        IDClienteLabel.Name = "IDClienteLabel"
        IDClienteLabel.Size = New System.Drawing.Size(53, 13)
        IDClienteLabel.TabIndex = 38
        IDClienteLabel.Text = "IDCliente:"
        '
        'Deuda_TotalLabel
        '
        Deuda_TotalLabel.AutoSize = True
        Deuda_TotalLabel.ForeColor = System.Drawing.Color.White
        Deuda_TotalLabel.Location = New System.Drawing.Point(469, 137)
        Deuda_TotalLabel.Name = "Deuda_TotalLabel"
        Deuda_TotalLabel.Size = New System.Drawing.Size(69, 13)
        Deuda_TotalLabel.TabIndex = 40
        Deuda_TotalLabel.Text = "Deuda Total:"
        '
        'Saldo_PendienteLabel
        '
        Saldo_PendienteLabel.AutoSize = True
        Saldo_PendienteLabel.ForeColor = System.Drawing.Color.White
        Saldo_PendienteLabel.Location = New System.Drawing.Point(469, 163)
        Saldo_PendienteLabel.Name = "Saldo_PendienteLabel"
        Saldo_PendienteLabel.Size = New System.Drawing.Size(88, 13)
        Saldo_PendienteLabel.TabIndex = 42
        Saldo_PendienteLabel.Text = "Saldo Pendiente:"
        '
        'IDAbonoLabel
        '
        IDAbonoLabel.AutoSize = True
        IDAbonoLabel.ForeColor = System.Drawing.SystemColors.Control
        IDAbonoLabel.Location = New System.Drawing.Point(469, 362)
        IDAbonoLabel.Name = "IDAbonoLabel"
        IDAbonoLabel.Size = New System.Drawing.Size(52, 13)
        IDAbonoLabel.TabIndex = 43
        IDAbonoLabel.Text = "IDAbono:"
        '
        'IDClienteLabel1
        '
        IDClienteLabel1.AutoSize = True
        IDClienteLabel1.ForeColor = System.Drawing.SystemColors.Control
        IDClienteLabel1.Location = New System.Drawing.Point(469, 388)
        IDClienteLabel1.Name = "IDClienteLabel1"
        IDClienteLabel1.Size = New System.Drawing.Size(53, 13)
        IDClienteLabel1.TabIndex = 45
        IDClienteLabel1.Text = "IDCliente:"
        '
        'Fecha_AbonoLabel
        '
        Fecha_AbonoLabel.AutoSize = True
        Fecha_AbonoLabel.ForeColor = System.Drawing.SystemColors.Control
        Fecha_AbonoLabel.Location = New System.Drawing.Point(469, 415)
        Fecha_AbonoLabel.Name = "Fecha_AbonoLabel"
        Fecha_AbonoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_AbonoLabel.TabIndex = 47
        Fecha_AbonoLabel.Text = "Fecha Abono:"
        '
        'Saldo_AbonoLabel
        '
        Saldo_AbonoLabel.AutoSize = True
        Saldo_AbonoLabel.ForeColor = System.Drawing.SystemColors.Control
        Saldo_AbonoLabel.Location = New System.Drawing.Point(469, 440)
        Saldo_AbonoLabel.Name = "Saldo_AbonoLabel"
        Saldo_AbonoLabel.Size = New System.Drawing.Size(71, 13)
        Saldo_AbonoLabel.TabIndex = 49
        Saldo_AbonoLabel.Text = "Saldo Abono:"
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
        Me.PanelBtnTB.TabIndex = 0
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
        Me.BtnV5.Text = "Saldo Pendiente Mayores a C$200"
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
        Me.BtnV4.Text = "Deudas Mayores a C$500"
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
        Me.BtnV3.Text = "Clientes y Saldo Pendiente"
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
        Me.BtnV2.Text = "Clientes y Deuda Total"
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
        Me.BtnV1.Text = "Datos de Abonos"
        Me.BtnV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnV1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnV1.UseVisualStyleBackColor = True
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
        Me.PanelTablas.Controls.Add(IDAbonoLabel)
        Me.PanelTablas.Controls.Add(Me.IDAbonoTextBox1)
        Me.PanelTablas.Controls.Add(IDClienteLabel1)
        Me.PanelTablas.Controls.Add(Me.IDClienteTextBox1)
        Me.PanelTablas.Controls.Add(Fecha_AbonoLabel)
        Me.PanelTablas.Controls.Add(Me.Fecha_AbonoDateTimePicker)
        Me.PanelTablas.Controls.Add(Saldo_AbonoLabel)
        Me.PanelTablas.Controls.Add(Me.Saldo_AbonoTextBox)
        Me.PanelTablas.Controls.Add(Label7)
        Me.PanelTablas.Controls.Add(IDClienteLabel)
        Me.PanelTablas.Controls.Add(Me.IDClienteTextBox)
        Me.PanelTablas.Controls.Add(Deuda_TotalLabel)
        Me.PanelTablas.Controls.Add(Me.Deuda_TotalTextBox)
        Me.PanelTablas.Controls.Add(Saldo_PendienteLabel)
        Me.PanelTablas.Controls.Add(Me.Saldo_PendienteTextBox)
        Me.PanelTablas.Controls.Add(Me.IDAbonoTextBox)
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView)
        Me.PanelTablas.Controls.Add(IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(706, 522)
        Me.PanelTablas.TabIndex = 1
        '
        'IDAbonoTextBox1
        '
        Me.IDAbonoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, "IDAbono", True))
        Me.IDAbonoTextBox1.Location = New System.Drawing.Point(549, 359)
        Me.IDAbonoTextBox1.Name = "IDAbonoTextBox1"
        Me.IDAbonoTextBox1.Size = New System.Drawing.Size(114, 20)
        Me.IDAbonoTextBox1.TabIndex = 44
        '
        'IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource
        '
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource.DataMember = "FK__IDAbono_I__IDAbo__00DF2177"
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource.DataSource = Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource
        '
        'IDClienteTextBox1
        '
        Me.IDClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, "IDCliente", True))
        Me.IDClienteTextBox1.Location = New System.Drawing.Point(549, 385)
        Me.IDClienteTextBox1.Name = "IDClienteTextBox1"
        Me.IDClienteTextBox1.Size = New System.Drawing.Size(114, 20)
        Me.IDClienteTextBox1.TabIndex = 46
        '
        'Fecha_AbonoDateTimePicker
        '
        Me.Fecha_AbonoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, "Fecha_Abono", True))
        Me.Fecha_AbonoDateTimePicker.Location = New System.Drawing.Point(549, 411)
        Me.Fecha_AbonoDateTimePicker.Name = "Fecha_AbonoDateTimePicker"
        Me.Fecha_AbonoDateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.Fecha_AbonoDateTimePicker.TabIndex = 48
        '
        'Saldo_AbonoTextBox
        '
        Me.Saldo_AbonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, "Saldo_Abono", True))
        Me.Saldo_AbonoTextBox.Location = New System.Drawing.Point(549, 437)
        Me.Saldo_AbonoTextBox.Name = "Saldo_AbonoTextBox"
        Me.Saldo_AbonoTextBox.Size = New System.Drawing.Size(114, 20)
        Me.Saldo_AbonoTextBox.TabIndex = 50
        '
        'IDClienteTextBox
        '
        Me.IDClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, "IDCliente", True))
        Me.IDClienteTextBox.Location = New System.Drawing.Point(563, 108)
        Me.IDClienteTextBox.Name = "IDClienteTextBox"
        Me.IDClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDClienteTextBox.TabIndex = 39
        '
        'Deuda_TotalTextBox
        '
        Me.Deuda_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, "Deuda_Total", True))
        Me.Deuda_TotalTextBox.Location = New System.Drawing.Point(563, 134)
        Me.Deuda_TotalTextBox.Name = "Deuda_TotalTextBox"
        Me.Deuda_TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Deuda_TotalTextBox.TabIndex = 41
        '
        'Saldo_PendienteTextBox
        '
        Me.Saldo_PendienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, "Saldo_Pendiente", True))
        Me.Saldo_PendienteTextBox.Location = New System.Drawing.Point(563, 160)
        Me.Saldo_PendienteTextBox.Name = "Saldo_PendienteTextBox"
        Me.Saldo_PendienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Saldo_PendienteTextBox.TabIndex = 43
        '
        'IDAbonoTextBox
        '
        Me.IDAbonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, "IDAbono", True))
        Me.IDAbonoTextBox.Location = New System.Drawing.Point(563, 82)
        Me.IDAbonoTextBox.Name = "IDAbonoTextBox"
        Me.IDAbonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDAbonoTextBox.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnAdd1)
        Me.Panel1.Controls.Add(Me.BtnUpdate1)
        Me.Panel1.Controls.Add(Me.BtnDelete1)
        Me.Panel1.Controls.Add(Me.BtnSearch1)
        Me.Panel1.Location = New System.Drawing.Point(472, 475)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 35)
        Me.Panel1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Libreria.My.Resources.Resources.clean
        Me.PictureBox1.Location = New System.Drawing.Point(159, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'BtnAdd1
        '
        Me.BtnAdd1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd1.Image = Global.Libreria.My.Resources.Resources.agreg
        Me.BtnAdd1.Location = New System.Drawing.Point(3, 6)
        Me.BtnAdd1.Name = "BtnAdd1"
        Me.BtnAdd1.Size = New System.Drawing.Size(29, 23)
        Me.BtnAdd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnAdd1.TabIndex = 28
        Me.BtnAdd1.TabStop = False
        '
        'BtnUpdate1
        '
        Me.BtnUpdate1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate1.Image = Global.Libreria.My.Resources.Resources.actualizar
        Me.BtnUpdate1.Location = New System.Drawing.Point(61, 6)
        Me.BtnUpdate1.Name = "BtnUpdate1"
        Me.BtnUpdate1.Size = New System.Drawing.Size(29, 23)
        Me.BtnUpdate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnUpdate1.TabIndex = 29
        Me.BtnUpdate1.TabStop = False
        '
        'BtnDelete1
        '
        Me.BtnDelete1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete1.Image = Global.Libreria.My.Resources.Resources.eliminar
        Me.BtnDelete1.Location = New System.Drawing.Point(96, 6)
        Me.BtnDelete1.Name = "BtnDelete1"
        Me.BtnDelete1.Size = New System.Drawing.Size(29, 23)
        Me.BtnDelete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDelete1.TabIndex = 31
        Me.BtnDelete1.TabStop = False
        '
        'BtnSearch1
        '
        Me.BtnSearch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch1.Image = Global.Libreria.My.Resources.Resources.buscar
        Me.BtnSearch1.Location = New System.Drawing.Point(38, 9)
        Me.BtnSearch1.Name = "BtnSearch1"
        Me.BtnSearch1.Size = New System.Drawing.Size(17, 20)
        Me.BtnSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSearch1.TabIndex = 30
        Me.BtnSearch1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnClean)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnAdd)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Location = New System.Drawing.Point(472, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 35)
        Me.Panel2.TabIndex = 33
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
        'IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView
        '
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.AutoGenerateColumns = False
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.DataSource = Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.Location = New System.Drawing.Point(21, 325)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.Name = "IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.RowHeadersVisible = False
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.Size = New System.Drawing.Size(417, 185)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "IDAbono"
        Me.DataGridViewTextBoxColumn21.HeaderText = "IDAbono"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn22.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Fecha_Abono"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Fecha_Abono"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Saldo_Abono"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Saldo_Abono"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'PanelV1
        '
        Me.PanelV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV1.Controls.Add(Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 522)
        Me.PanelV1.TabIndex = 29
        '
        'IDAbo_IDCli_Deuda_Saldo_View1DataGridView
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.AutoGenerateColumns = False
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.DataSource = Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.Name = "IDAbo_IDCli_Deuda_Saldo_View1DataGridView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDAbono"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDAbono"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Deuda_Total"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Deuda_Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'IDAbo_IDCli_Deuda_Saldo_View1BindingSource
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource.DataMember = "IDAbo_IDCli_Deuda_Saldo_View1"
        Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV2.Controls.Add(Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 522)
        Me.PanelV2.TabIndex = 30
        '
        'IDAbo_IDCli_Deuda_Saldo_View2DataGridView
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.AutoGenerateColumns = False
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.DataSource = Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.DefaultCellStyle = DataGridViewCellStyle11
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.Name = "IDAbo_IDCli_Deuda_Saldo_View2DataGridView"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Deuda_Total"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Deuda_Total"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'IDAbo_IDCli_Deuda_Saldo_View2BindingSource
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource.DataMember = "IDAbo_IDCli_Deuda_Saldo_View2"
        Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV3.Controls.Add(Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 522)
        Me.PanelV3.TabIndex = 31
        '
        'IDAbo_IDCli_Deuda_Saldo_View3DataGridView
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.AutoGenerateColumns = False
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.DataSource = Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.Name = "IDAbo_IDCli_Deuda_Saldo_View3DataGridView"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'IDAbo_IDCli_Deuda_Saldo_View3BindingSource
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource.DataMember = "IDAbo_IDCli_Deuda_Saldo_View3"
        Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV4.Controls.Add(Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 522)
        Me.PanelV4.TabIndex = 32
        '
        'IDAbo_IDCli_Deuda_Saldo_View4DataGridView
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.AutoGenerateColumns = False
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.DataSource = Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.DefaultCellStyle = DataGridViewCellStyle17
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.Name = "IDAbo_IDCli_Deuda_Saldo_View4DataGridView"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IDAbono"
        Me.DataGridViewTextBoxColumn13.HeaderText = "IDAbono"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Deuda_Total"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Deuda_Total"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'IDAbo_IDCli_Deuda_Saldo_View4BindingSource
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource.DataMember = "IDAbo_IDCli_Deuda_Saldo_View4"
        Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV5
        '
        Me.PanelV5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelV5.Controls.Add(Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 522)
        Me.PanelV5.TabIndex = 33
        '
        'IDAbo_IDCli_Deuda_Saldo_View5DataGridView
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.AutoGenerateColumns = False
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.DataSource = Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.DefaultCellStyle = DataGridViewCellStyle20
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.Name = "IDAbo_IDCli_Deuda_Saldo_View5DataGridView"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "IDAbono"
        Me.DataGridViewTextBoxColumn17.HeaderText = "IDAbono"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn18.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Deuda_Total"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Deuda_Total"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Saldo_Pendiente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'IDAbo_IDCli_Deuda_Saldo_View5BindingSource
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource.DataMember = "IDAbo_IDCli_Deuda_Saldo_View5"
        Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.IDProveedor_Nombre_prov_Marca_DistTableAdapter = Nothing
        Me.TableAdapterManager.IDProveedor_Telefono_ProvTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Libreria.LibreriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter
        '
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.ClearBeforeFill = True
        '
        'IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter
        '
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Deuda_Saldo_View1TableAdapter
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View1TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Deuda_Saldo_View2TableAdapter
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View2TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Deuda_Saldo_View3TableAdapter
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View3TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Deuda_Saldo_View4TableAdapter
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View4TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Deuda_Saldo_View5TableAdapter
        '
        Me.IDAbo_IDCli_Deuda_Saldo_View5TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource
        '
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource.DataMember = "IDAbo_IDCli_Fecha_Saldo_Abo_View5"
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter
        '
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter.ClearBeforeFill = True
        '
        'IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource
        '
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource.DataMember = "IDAbo_IDCli_Fecha_Saldo_Abo_View4"
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter
        '
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter.ClearBeforeFill = True
        '
        'FormAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 522)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormAbonos"
        Me.Text = "Tabla Abonos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(IDAbono_IDCliente_Deuda_Total_Saldo_PendienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BtnClean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Deuda_Saldo_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource1 As BindingSource
    Friend WithEvents IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource As BindingSource
    Friend WithEvents IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter As LibreriaDataSetTableAdapters.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter
    Friend WithEvents IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoBindingSource As BindingSource
    Friend WithEvents IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter As LibreriaDataSetTableAdapters.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter
    Friend WithEvents BtnTbAbonos As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTxtVistas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelBtnTB As Panel
    Friend WithEvents BtnV5 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV4 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV3 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View1BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View1TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View1TableAdapter
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View2BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View2TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View2TableAdapter
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View3BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View3TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View3TableAdapter
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View4BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View4TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View4TableAdapter
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View5BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View5TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Deuda_Saldo_View5TableAdapter
    Friend WithEvents PanelTablas As Panel
    Friend WithEvents PanelV1 As Panel
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PanelV2 As Panel
    Friend WithEvents PanelV3 As Panel
    Friend WithEvents PanelV4 As Panel
    Friend WithEvents PanelV5 As Panel
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents IDAbo_IDCli_Fecha_Saldo_Abo_View5BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter
    Friend WithEvents IDAbo_IDCli_Fecha_Saldo_Abo_View4BindingSource As BindingSource
    Friend WithEvents IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter As LibreriaDataSetTableAdapters.IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter
    Friend WithEvents IDAbo_IDCli_Deuda_Saldo_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAdd As PictureBox
    Friend WithEvents BtnUpdate As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd1 As PictureBox
    Friend WithEvents BtnUpdate1 As PictureBox
    Friend WithEvents BtnDelete1 As PictureBox
    Friend WithEvents BtnSearch1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IDAbonoTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnSearch As PictureBox
    Friend WithEvents IDClienteTextBox As TextBox
    Friend WithEvents Deuda_TotalTextBox As TextBox
    Friend WithEvents Saldo_PendienteTextBox As TextBox
    Friend WithEvents IDAbonoTextBox1 As TextBox
    Friend WithEvents IDClienteTextBox1 As TextBox
    Friend WithEvents Fecha_AbonoDateTimePicker As DateTimePicker
    Friend WithEvents Saldo_AbonoTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClean As PictureBox
End Class
