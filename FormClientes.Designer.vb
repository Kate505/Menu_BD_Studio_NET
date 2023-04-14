<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim IDClienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ClienteMoraLabel As System.Windows.Forms.Label
        Dim IDClienteLabel1 As System.Windows.Forms.Label
        Dim TelefonosLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.IDCliente_TelefonosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDCliente_TelefonosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibreriaDataSet = New Libreria.LibreriaDataSet()
        Me.PanelBtnTB = New System.Windows.Forms.Panel()
        Me.BtnV5 = New FontAwesome.Sharp.IconButton()
        Me.BtnV4 = New FontAwesome.Sharp.IconButton()
        Me.BtnV3 = New FontAwesome.Sharp.IconButton()
        Me.BtnV2 = New FontAwesome.Sharp.IconButton()
        Me.BtnV1 = New FontAwesome.Sharp.IconButton()
        Me.PanelTxtVistas = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTbClientes = New FontAwesome.Sharp.IconButton()
        Me.PanelTablas = New System.Windows.Forms.Panel()
        Me.IDCliente_TelefonosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoNewTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAdd1 = New System.Windows.Forms.PictureBox()
        Me.BtnUpdate1 = New System.Windows.Forms.PictureBox()
        Me.BtnDelete1 = New System.Windows.Forms.PictureBox()
        Me.BtnSearch1 = New System.Windows.Forms.PictureBox()
        Me.IDClienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.TelefonosTextBox = New System.Windows.Forms.TextBox()
        Me.IDClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteMoraTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelV1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cliente_View1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cliente_View2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_View2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cliente_View3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_View3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cliente_View4DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_View4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelV5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cliente_View5DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente_View5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDCliente_TelefonosTableAdapter = New Libreria.LibreriaDataSetTableAdapters.IDCliente_TelefonosTableAdapter()
        Me.ClienteTableAdapter = New Libreria.LibreriaDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New Libreria.LibreriaDataSetTableAdapters.TableAdapterManager()
        Me.Cliente_View1TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Cliente_View1TableAdapter()
        Me.Cliente_View2TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Cliente_View2TableAdapter()
        Me.Cliente_View3TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Cliente_View3TableAdapter()
        Me.Cliente_View4TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Cliente_View4TableAdapter()
        Me.Cliente_View5TableAdapter = New Libreria.LibreriaDataSetTableAdapters.Cliente_View5TableAdapter()
        IDClienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ClienteMoraLabel = New System.Windows.Forms.Label()
        IDClienteLabel1 = New System.Windows.Forms.Label()
        TelefonosLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.IDCliente_TelefonosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDCliente_TelefonosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBtnTB.SuspendLayout()
        Me.PanelTxtVistas.SuspendLayout()
        Me.PanelTablas.SuspendLayout()
        CType(Me.IDCliente_TelefonosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUpdate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV1.SuspendLayout()
        CType(Me.Cliente_View1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV2.SuspendLayout()
        CType(Me.Cliente_View2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_View2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV3.SuspendLayout()
        CType(Me.Cliente_View3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_View3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV4.SuspendLayout()
        CType(Me.Cliente_View4DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_View4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelV5.SuspendLayout()
        CType(Me.Cliente_View5DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_View5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDClienteLabel
        '
        IDClienteLabel.AutoSize = True
        IDClienteLabel.ForeColor = System.Drawing.Color.White
        IDClienteLabel.Location = New System.Drawing.Point(478, 71)
        IDClienteLabel.Name = "IDClienteLabel"
        IDClienteLabel.Size = New System.Drawing.Size(53, 13)
        IDClienteLabel.TabIndex = 6
        IDClienteLabel.Text = "IDCliente:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(478, 97)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 8
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.ForeColor = System.Drawing.Color.White
        ApellidosLabel.Location = New System.Drawing.Point(478, 123)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 10
        ApellidosLabel.Text = "Apellidos:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.ForeColor = System.Drawing.Color.White
        DireccionLabel.Location = New System.Drawing.Point(478, 149)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "Direccion:"
        '
        'ClienteMoraLabel
        '
        ClienteMoraLabel.AutoSize = True
        ClienteMoraLabel.ForeColor = System.Drawing.Color.White
        ClienteMoraLabel.Location = New System.Drawing.Point(478, 175)
        ClienteMoraLabel.Name = "ClienteMoraLabel"
        ClienteMoraLabel.Size = New System.Drawing.Size(69, 13)
        ClienteMoraLabel.TabIndex = 14
        ClienteMoraLabel.Text = "Cliente Mora:"
        '
        'IDClienteLabel1
        '
        IDClienteLabel1.AutoSize = True
        IDClienteLabel1.ForeColor = System.Drawing.Color.White
        IDClienteLabel1.Location = New System.Drawing.Point(480, 383)
        IDClienteLabel1.Name = "IDClienteLabel1"
        IDClienteLabel1.Size = New System.Drawing.Size(53, 13)
        IDClienteLabel1.TabIndex = 15
        IDClienteLabel1.Text = "IDCliente:"
        '
        'TelefonosLabel
        '
        TelefonosLabel.AutoSize = True
        TelefonosLabel.ForeColor = System.Drawing.Color.White
        TelefonosLabel.Location = New System.Drawing.Point(480, 409)
        TelefonosLabel.Name = "TelefonosLabel"
        TelefonosLabel.Size = New System.Drawing.Size(57, 13)
        TelefonosLabel.TabIndex = 17
        TelefonosLabel.Text = "Telefonos:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(480, 456)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(84, 13)
        Label7.TabIndex = 37
        Label7.Text = "Telefono Nuevo"
        '
        'IDCliente_TelefonosBindingSource1
        '
        Me.IDCliente_TelefonosBindingSource1.DataMember = "FK__IDCliente__IDCli__7C1A6C5A"
        Me.IDCliente_TelefonosBindingSource1.DataSource = Me.ClienteBindingSource
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.LibreriaDataSet
        '
        'LibreriaDataSet
        '
        Me.LibreriaDataSet.DataSetName = "LibreriaDataSet"
        Me.LibreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.PanelBtnTB.Controls.Add(Me.BtnTbClientes)
        Me.PanelBtnTB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelBtnTB.Location = New System.Drawing.Point(0, 0)
        Me.PanelBtnTB.Name = "PanelBtnTB"
        Me.PanelBtnTB.Size = New System.Drawing.Size(174, 570)
        Me.PanelBtnTB.TabIndex = 2
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
        Me.BtnV5.Text = "Clientes ordenados por Dirección"
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
        Me.BtnV4.Text = "Clientes y Dirección"
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
        Me.BtnV3.Text = "Apellidos que terminan con A"
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
        Me.BtnV2.Text = "Datos de los Clientes"
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
        Me.BtnV1.Text = "Apellidos con A"
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
        'BtnTbClientes
        '
        Me.BtnTbClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTbClientes.FlatAppearance.BorderSize = 0
        Me.BtnTbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTbClientes.ForeColor = System.Drawing.Color.White
        Me.BtnTbClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.BtnTbClientes.IconColor = System.Drawing.Color.White
        Me.BtnTbClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnTbClientes.IconSize = 25
        Me.BtnTbClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbClientes.Location = New System.Drawing.Point(0, 0)
        Me.BtnTbClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTbClientes.Name = "BtnTbClientes"
        Me.BtnTbClientes.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnTbClientes.Size = New System.Drawing.Size(172, 50)
        Me.BtnTbClientes.TabIndex = 31
        Me.BtnTbClientes.Text = "Tablas"
        Me.BtnTbClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTbClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTbClientes.UseVisualStyleBackColor = True
        '
        'PanelTablas
        '
        Me.PanelTablas.Controls.Add(Me.IDCliente_TelefonosDataGridView)
        Me.PanelTablas.Controls.Add(Label7)
        Me.PanelTablas.Controls.Add(Me.TelefonoNewTextBox)
        Me.PanelTablas.Controls.Add(Me.Panel2)
        Me.PanelTablas.Controls.Add(Me.Panel1)
        Me.PanelTablas.Controls.Add(IDClienteLabel1)
        Me.PanelTablas.Controls.Add(Me.IDClienteTextBox1)
        Me.PanelTablas.Controls.Add(TelefonosLabel)
        Me.PanelTablas.Controls.Add(Me.TelefonosTextBox)
        Me.PanelTablas.Controls.Add(IDClienteLabel)
        Me.PanelTablas.Controls.Add(Me.IDClienteTextBox)
        Me.PanelTablas.Controls.Add(NombreLabel)
        Me.PanelTablas.Controls.Add(Me.NombreTextBox)
        Me.PanelTablas.Controls.Add(ApellidosLabel)
        Me.PanelTablas.Controls.Add(Me.ApellidosTextBox)
        Me.PanelTablas.Controls.Add(DireccionLabel)
        Me.PanelTablas.Controls.Add(Me.DireccionTextBox)
        Me.PanelTablas.Controls.Add(ClienteMoraLabel)
        Me.PanelTablas.Controls.Add(Me.ClienteMoraTextBox)
        Me.PanelTablas.Controls.Add(Me.ClienteDataGridView)
        Me.PanelTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTablas.Location = New System.Drawing.Point(174, 0)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(706, 570)
        Me.PanelTablas.TabIndex = 3
        '
        'IDCliente_TelefonosDataGridView
        '
        Me.IDCliente_TelefonosDataGridView.AutoGenerateColumns = False
        Me.IDCliente_TelefonosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDCliente_TelefonosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.IDCliente_TelefonosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IDCliente_TelefonosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDCliente_TelefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDCliente_TelefonosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.IDCliente_TelefonosDataGridView.DataSource = Me.IDCliente_TelefonosBindingSource1
        Me.IDCliente_TelefonosDataGridView.Location = New System.Drawing.Point(24, 370)
        Me.IDCliente_TelefonosDataGridView.Name = "IDCliente_TelefonosDataGridView"
        Me.IDCliente_TelefonosDataGridView.RowHeadersVisible = False
        Me.IDCliente_TelefonosDataGridView.Size = New System.Drawing.Size(344, 169)
        Me.IDCliente_TelefonosDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefonos"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefonos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'TelefonoNewTextBox
        '
        Me.TelefonoNewTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDCliente_TelefonosBindingSource1, "Telefonos", True))
        Me.TelefonoNewTextBox.Location = New System.Drawing.Point(569, 453)
        Me.TelefonoNewTextBox.Name = "TelefonoNewTextBox"
        Me.TelefonoNewTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoNewTextBox.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Location = New System.Drawing.Point(478, 479)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 35)
        Me.Panel2.TabIndex = 36
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Libreria.My.Resources.Resources.clean
        Me.PictureBox2.Location = New System.Drawing.Point(159, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Libreria.My.Resources.Resources.agreg
        Me.PictureBox3.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Libreria.My.Resources.Resources.actualizar
        Me.PictureBox4.Location = New System.Drawing.Point(61, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Libreria.My.Resources.Resources.eliminar
        Me.PictureBox5.Location = New System.Drawing.Point(96, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.Libreria.My.Resources.Resources.buscar
        Me.PictureBox6.Location = New System.Drawing.Point(38, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnAdd1)
        Me.Panel1.Controls.Add(Me.BtnUpdate1)
        Me.Panel1.Controls.Add(Me.BtnDelete1)
        Me.Panel1.Controls.Add(Me.BtnSearch1)
        Me.Panel1.Location = New System.Drawing.Point(478, 207)
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
        'IDClienteTextBox1
        '
        Me.IDClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDCliente_TelefonosBindingSource1, "IDCliente", True))
        Me.IDClienteTextBox1.Location = New System.Drawing.Point(569, 380)
        Me.IDClienteTextBox1.Name = "IDClienteTextBox1"
        Me.IDClienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDClienteTextBox1.TabIndex = 16
        '
        'TelefonosTextBox
        '
        Me.TelefonosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IDCliente_TelefonosBindingSource1, "Telefonos", True))
        Me.TelefonosTextBox.Location = New System.Drawing.Point(569, 406)
        Me.TelefonosTextBox.Name = "TelefonosTextBox"
        Me.TelefonosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonosTextBox.TabIndex = 18
        '
        'IDClienteTextBox
        '
        Me.IDClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "IDCliente", True))
        Me.IDClienteTextBox.Location = New System.Drawing.Point(569, 68)
        Me.IDClienteTextBox.Name = "IDClienteTextBox"
        Me.IDClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDClienteTextBox.TabIndex = 7
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(569, 94)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 9
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(569, 120)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidosTextBox.TabIndex = 11
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(569, 146)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 13
        '
        'ClienteMoraTextBox
        '
        Me.ClienteMoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ClienteMora", True))
        Me.ClienteMoraTextBox.Location = New System.Drawing.Point(569, 172)
        Me.ClienteMoraTextBox.Name = "ClienteMoraTextBox"
        Me.ClienteMoraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClienteMoraTextBox.TabIndex = 15
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClienteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(24, 23)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowHeadersVisible = False
        Me.ClienteDataGridView.Size = New System.Drawing.Size(429, 310)
        Me.ClienteDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ClienteMora"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ClienteMora"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PanelV1
        '
        Me.PanelV1.Controls.Add(Me.Label1)
        Me.PanelV1.Controls.Add(Me.Cliente_View1DataGridView)
        Me.PanelV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV1.Location = New System.Drawing.Point(174, 0)
        Me.PanelV1.Name = "PanelV1"
        Me.PanelV1.Size = New System.Drawing.Size(706, 570)
        Me.PanelV1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(47, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes con Apellidos que comienzan con 'A'"
        '
        'Cliente_View1DataGridView
        '
        Me.Cliente_View1DataGridView.AutoGenerateColumns = False
        Me.Cliente_View1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cliente_View1DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.Cliente_View1DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Cliente_View1DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cliente_View1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_View1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Cliente_View1DataGridView.DataSource = Me.Cliente_View1BindingSource
        Me.Cliente_View1DataGridView.Location = New System.Drawing.Point(50, 100)
        Me.Cliente_View1DataGridView.Name = "Cliente_View1DataGridView"
        Me.Cliente_View1DataGridView.RowHeadersVisible = False
        Me.Cliente_View1DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.Cliente_View1DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Cliente_View1BindingSource
        '
        Me.Cliente_View1BindingSource.DataMember = "Cliente_View1"
        Me.Cliente_View1BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV2
        '
        Me.PanelV2.Controls.Add(Me.Label2)
        Me.PanelV2.Controls.Add(Me.Cliente_View2DataGridView)
        Me.PanelV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV2.Location = New System.Drawing.Point(174, 0)
        Me.PanelV2.Name = "PanelV2"
        Me.PanelV2.Size = New System.Drawing.Size(706, 570)
        Me.PanelV2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(55, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Datos de los Clientes"
        '
        'Cliente_View2DataGridView
        '
        Me.Cliente_View2DataGridView.AutoGenerateColumns = False
        Me.Cliente_View2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cliente_View2DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Cliente_View2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Cliente_View2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cliente_View2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_View2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Cliente_View2DataGridView.DataSource = Me.Cliente_View2BindingSource
        Me.Cliente_View2DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.Cliente_View2DataGridView.Name = "Cliente_View2DataGridView"
        Me.Cliente_View2DataGridView.RowHeadersVisible = False
        Me.Cliente_View2DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.Cliente_View2DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'Cliente_View2BindingSource
        '
        Me.Cliente_View2BindingSource.DataMember = "Cliente_View2"
        Me.Cliente_View2BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV3
        '
        Me.PanelV3.Controls.Add(Me.Label4)
        Me.PanelV3.Controls.Add(Me.Cliente_View3DataGridView)
        Me.PanelV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV3.Location = New System.Drawing.Point(174, 0)
        Me.PanelV3.Name = "PanelV3"
        Me.PanelV3.Size = New System.Drawing.Size(706, 570)
        Me.PanelV3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(55, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Clientes con apellidos que terminan en 'A'"
        '
        'Cliente_View3DataGridView
        '
        Me.Cliente_View3DataGridView.AutoGenerateColumns = False
        Me.Cliente_View3DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cliente_View3DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Cliente_View3DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Cliente_View3DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cliente_View3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_View3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Cliente_View3DataGridView.DataSource = Me.Cliente_View3BindingSource
        Me.Cliente_View3DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.Cliente_View3DataGridView.Name = "Cliente_View3DataGridView"
        Me.Cliente_View3DataGridView.RowHeadersVisible = False
        Me.Cliente_View3DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.Cliente_View3DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn16.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Cliente_View3BindingSource
        '
        Me.Cliente_View3BindingSource.DataMember = "Cliente_View3"
        Me.Cliente_View3BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV4
        '
        Me.PanelV4.Controls.Add(Me.Label5)
        Me.PanelV4.Controls.Add(Me.Cliente_View4DataGridView)
        Me.PanelV4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV4.Location = New System.Drawing.Point(174, 0)
        Me.PanelV4.Name = "PanelV4"
        Me.PanelV4.Size = New System.Drawing.Size(706, 570)
        Me.PanelV4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(55, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dirección cerca del Barrio X"
        '
        'Cliente_View4DataGridView
        '
        Me.Cliente_View4DataGridView.AutoGenerateColumns = False
        Me.Cliente_View4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cliente_View4DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Cliente_View4DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Cliente_View4DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cliente_View4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_View4DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Cliente_View4DataGridView.DataSource = Me.Cliente_View4BindingSource
        Me.Cliente_View4DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.Cliente_View4DataGridView.Name = "Cliente_View4DataGridView"
        Me.Cliente_View4DataGridView.RowHeadersVisible = False
        Me.Cliente_View4DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.Cliente_View4DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn20.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'Cliente_View4BindingSource
        '
        Me.Cliente_View4BindingSource.DataMember = "Cliente_View4"
        Me.Cliente_View4BindingSource.DataSource = Me.LibreriaDataSet
        '
        'PanelV5
        '
        Me.PanelV5.Controls.Add(Me.Label6)
        Me.PanelV5.Controls.Add(Me.Cliente_View5DataGridView)
        Me.PanelV5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelV5.Location = New System.Drawing.Point(174, 0)
        Me.PanelV5.Name = "PanelV5"
        Me.PanelV5.Size = New System.Drawing.Size(706, 570)
        Me.PanelV5.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(52, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Clientes ordenados por Dirección"
        '
        'Cliente_View5DataGridView
        '
        Me.Cliente_View5DataGridView.AutoGenerateColumns = False
        Me.Cliente_View5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cliente_View5DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Cliente_View5DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Cliente_View5DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cliente_View5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cliente_View5DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.Cliente_View5DataGridView.DataSource = Me.Cliente_View5BindingSource
        Me.Cliente_View5DataGridView.Location = New System.Drawing.Point(55, 100)
        Me.Cliente_View5DataGridView.Name = "Cliente_View5DataGridView"
        Me.Cliente_View5DataGridView.RowHeadersVisible = False
        Me.Cliente_View5DataGridView.Size = New System.Drawing.Size(600, 300)
        Me.Cliente_View5DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "IDCliente"
        Me.DataGridViewTextBoxColumn24.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'Cliente_View5BindingSource
        '
        Me.Cliente_View5BindingSource.DataMember = "Cliente_View5"
        Me.Cliente_View5BindingSource.DataSource = Me.LibreriaDataSet
        '
        'IDCliente_TelefonosTableAdapter
        '
        Me.IDCliente_TelefonosTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter = Nothing
        Me.TableAdapterManager.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter = Nothing
        Me.TableAdapterManager.HistorialTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter = Nothing
        Me.TableAdapterManager.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter = Nothing
        Me.TableAdapterManager.IDCliente_TelefonosTableAdapter = Me.IDCliente_TelefonosTableAdapter
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
        'Cliente_View1TableAdapter
        '
        Me.Cliente_View1TableAdapter.ClearBeforeFill = True
        '
        'Cliente_View2TableAdapter
        '
        Me.Cliente_View2TableAdapter.ClearBeforeFill = True
        '
        'Cliente_View3TableAdapter
        '
        Me.Cliente_View3TableAdapter.ClearBeforeFill = True
        '
        'Cliente_View4TableAdapter
        '
        Me.Cliente_View4TableAdapter.ClearBeforeFill = True
        '
        'Cliente_View5TableAdapter
        '
        Me.Cliente_View5TableAdapter.ClearBeforeFill = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 570)
        Me.Controls.Add(Me.PanelTablas)
        Me.Controls.Add(Me.PanelV2)
        Me.Controls.Add(Me.PanelV3)
        Me.Controls.Add(Me.PanelV5)
        Me.Controls.Add(Me.PanelV4)
        Me.Controls.Add(Me.PanelV1)
        Me.Controls.Add(Me.PanelBtnTB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IDCliente_TelefonosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDCliente_TelefonosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibreriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBtnTB.ResumeLayout(False)
        Me.PanelTxtVistas.ResumeLayout(False)
        Me.PanelTablas.ResumeLayout(False)
        Me.PanelTablas.PerformLayout()
        CType(Me.IDCliente_TelefonosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUpdate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV1.ResumeLayout(False)
        Me.PanelV1.PerformLayout()
        CType(Me.Cliente_View1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV2.ResumeLayout(False)
        Me.PanelV2.PerformLayout()
        CType(Me.Cliente_View2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_View2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV3.ResumeLayout(False)
        Me.PanelV3.PerformLayout()
        CType(Me.Cliente_View3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_View3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV4.ResumeLayout(False)
        Me.PanelV4.PerformLayout()
        CType(Me.Cliente_View4DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_View4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelV5.ResumeLayout(False)
        Me.PanelV5.PerformLayout()
        CType(Me.Cliente_View5DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_View5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LibreriaDataSet As LibreriaDataSet
    Friend WithEvents IDCliente_TelefonosTableAdapter As LibreriaDataSetTableAdapters.IDCliente_TelefonosTableAdapter
    Friend WithEvents IDCliente_TelefonosBindingSource As BindingSource
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As LibreriaDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As LibreriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDCliente_TelefonosBindingSource1 As BindingSource
    Friend WithEvents PanelBtnTB As Panel
    Friend WithEvents BtnV5 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV4 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV3 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV2 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnV1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTxtVistas As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTbClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTablas As Panel
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PanelV1 As Panel
    Friend WithEvents PanelV2 As Panel
    Friend WithEvents PanelV3 As Panel
    Friend WithEvents PanelV4 As Panel
    Friend WithEvents PanelV5 As Panel
    Friend WithEvents Cliente_View1BindingSource As BindingSource
    Friend WithEvents Cliente_View1TableAdapter As LibreriaDataSetTableAdapters.Cliente_View1TableAdapter
    Friend WithEvents Cliente_View1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Cliente_View2BindingSource As BindingSource
    Friend WithEvents Cliente_View2TableAdapter As LibreriaDataSetTableAdapters.Cliente_View2TableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Cliente_View2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Cliente_View3BindingSource As BindingSource
    Friend WithEvents Cliente_View3TableAdapter As LibreriaDataSetTableAdapters.Cliente_View3TableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Cliente_View3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Cliente_View4BindingSource As BindingSource
    Friend WithEvents Cliente_View4TableAdapter As LibreriaDataSetTableAdapters.Cliente_View4TableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Cliente_View4DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Cliente_View5BindingSource As BindingSource
    Friend WithEvents Cliente_View5TableAdapter As LibreriaDataSetTableAdapters.Cliente_View5TableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Cliente_View5DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents IDClienteTextBox1 As TextBox
    Friend WithEvents TelefonosTextBox As TextBox
    Friend WithEvents IDClienteTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ClienteMoraTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAdd1 As PictureBox
    Friend WithEvents BtnUpdate1 As PictureBox
    Friend WithEvents BtnDelete1 As PictureBox
    Friend WithEvents BtnSearch1 As PictureBox
    Friend WithEvents TelefonoNewTextBox As TextBox
    Friend WithEvents IDCliente_TelefonosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
