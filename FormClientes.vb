Imports FontAwesome.Sharp

Public Class FormClientes

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente_View5' Puede moverla o quitarla según sea necesario.
        Me.Cliente_View5TableAdapter.Fill(Me.LibreriaDataSet.Cliente_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente_View4' Puede moverla o quitarla según sea necesario.
        Me.Cliente_View4TableAdapter.Fill(Me.LibreriaDataSet.Cliente_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente_View3' Puede moverla o quitarla según sea necesario.
        Me.Cliente_View3TableAdapter.Fill(Me.LibreriaDataSet.Cliente_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente_View2' Puede moverla o quitarla según sea necesario.
        Me.Cliente_View2TableAdapter.Fill(Me.LibreriaDataSet.Cliente_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente_View1' Puede moverla o quitarla según sea necesario.
        Me.Cliente_View1TableAdapter.Fill(Me.LibreriaDataSet.Cliente_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.LibreriaDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDCliente_Telefonos' Puede moverla o quitarla según sea necesario.
        Me.IDCliente_TelefonosTableAdapter.Fill(Me.LibreriaDataSet.IDCliente_Telefonos)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDcliente_Clientemora' Puede moverla o quitarla según sea necesario.


        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False

        ActivateButton(BtnTbClientes, RGBColors.color3)
    End Sub

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 50)
        PanelBtnTB.Controls.Add(leftBorderBtn)
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = RGBColors.color1
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = RGBColors.color1
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub BtnV1_Click(sender As Object, e As EventArgs) Handles BtnV1.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = False
        PanelV1.Visible = True
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
        PanelV1.BringToFront()
    End Sub

    Private Sub BtnV2_Click(sender As Object, e As EventArgs) Handles BtnV2.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = False
        PanelV1.Visible = False
        PanelV2.Visible = True
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
        PanelV2.BringToFront()
    End Sub

    Private Sub BtnV3_Click(sender As Object, e As EventArgs) Handles BtnV3.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = False
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = True
        PanelV4.Visible = False
        PanelV5.Visible = False
        PanelV3.BringToFront()
    End Sub

    Private Sub BtnV4_Click(sender As Object, e As EventArgs) Handles BtnV4.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = False
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = True
        PanelV5.Visible = False
        PanelV4.BringToFront()
    End Sub

    Private Sub BtnV5_Click(sender As Object, e As EventArgs) Handles BtnV5.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = False
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = True
        PanelV5.BringToFront()
    End Sub

    Private Sub BtnTbAbonos_Click(sender As Object, e As EventArgs) Handles BtnTbClientes.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
        PanelTablas.BringToFront()
    End Sub

    Private Sub BtnAdd1_Click(sender As Object, e As EventArgs) Handles BtnAdd1.Click
        Me.ClienteTableAdapter.Insertar(IDClienteTextBox.Text, NombreTextBox.Text, ApellidosTextBox.Text, DireccionTextBox.Text, ClienteMoraTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.LibreriaDataSet.Cliente)
    End Sub

    Private Sub BtnSearch1_Click(sender As Object, e As EventArgs) Handles BtnSearch1.Click
        If (NombreTextBox.Text = "") Then
            Me.ClienteTableAdapter.Fill(Me.LibreriaDataSet.Cliente)
        Else
            Me.ClienteTableAdapter.FillBy(Me.LibreriaDataSet.Cliente, NombreTextBox.Text)
        End If
    End Sub

    Private Sub BtnUpdate1_Click(sender As Object, e As EventArgs) Handles BtnUpdate1.Click
        Me.ClienteTableAdapter.Modificar(IDClienteTextBox.Text, NombreTextBox.Text, ApellidosTextBox.Text, DireccionTextBox.Text, ClienteMoraTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.LibreriaDataSet.Cliente)
    End Sub

    Private Sub BtnDelete1_Click(sender As Object, e As EventArgs) Handles BtnDelete1.Click
        Me.ClienteTableAdapter.Eliminar(IDClienteTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.LibreriaDataSet.Cliente)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDClienteTextBox.Text = ""
        NombreTextBox.Text = ""
        ApellidosTextBox.Text = ""
        DireccionTextBox.Text = ""
        ClienteMoraTextBox.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        IDClienteTextBox1.Text = ""
        TelefonosTextBox.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.IDCliente_TelefonosTableAdapter.Insertar(IDClienteTextBox1.Text, TelefonosTextBox.Text)
        Me.IDCliente_TelefonosTableAdapter.Fill(Me.LibreriaDataSet.IDCliente_Telefonos)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If IsNumeric(IDClienteTextBox1.Text) Then
            Me.IDCliente_TelefonosTableAdapter.FillBy(Me.LibreriaDataSet.IDCliente_Telefonos, IDClienteTextBox1.Text)
        Else
            Me.IDCliente_TelefonosTableAdapter.Fill(Me.LibreriaDataSet.IDCliente_Telefonos)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.IDCliente_TelefonosTableAdapter.Modificar(IDClienteTextBox1.Text, TelefonosTextBox.Text, TelefonoNewTextBox.Text)
        Me.IDCliente_TelefonosTableAdapter.Fill(Me.LibreriaDataSet.IDCliente_Telefonos)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.IDCliente_TelefonosTableAdapter.Eliminar(IDClienteTextBox1.Text, TelefonosTextBox.Text)
        Me.IDCliente_TelefonosTableAdapter.Fill(Me.LibreriaDataSet.IDCliente_Telefonos)
    End Sub

End Class