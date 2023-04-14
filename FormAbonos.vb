Imports FontAwesome.Sharp

Public Class FormAbonos

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Fecha_Saldo_Abo_View4' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View4TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Fecha_Saldo_Abo_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Fecha_Saldo_Abo_View5' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Fecha_Saldo_Abo_View5TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Fecha_Saldo_Abo_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View5' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View5' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Deuda_Saldo_View5TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View4' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Deuda_Saldo_View4TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View3' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Deuda_Saldo_View3TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View2' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Deuda_Saldo_View2TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View1' Puede moverla o quitarla según sea necesario.
        Me.IDAbo_IDCli_Deuda_Saldo_View1TableAdapter.Fill(Me.LibreriaDataSet.IDAbo_IDCli_Deuda_Saldo_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente' Puede moverla o quitarla según sea necesario.

        ActivateButton(BtnTbAbonos, RGBColors.color3)
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


    Private Sub IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado' Puede moverla o quitarla según sea necesario.
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente' Puede moverla o quitarla según sea necesario.
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado' Puede moverla o quitarla según sea necesario.
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente' Puede moverla o quitarla según sea necesario.
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)
        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False

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

    Private Sub BtnTbAbonos_Click(sender As Object, e As EventArgs) Handles BtnTbAbonos.Click
        ActivateButton(sender, RGBColors.color3)
        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
        PanelTablas.BringToFront()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Insert(IDAbonoTextBox.Text, IDClienteTextBox.Text, Deuda_TotalTextBox.Text, Saldo_PendienteTextBox.Text)
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Modificar(IDAbonoTextBox.Text, IDClienteTextBox.Text, Deuda_TotalTextBox.Text, Saldo_PendienteTextBox.Text)
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(IDClienteTextBox.Text) Then
            Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.FillBy(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente, IDClienteTextBox.Text)
        Else
            Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)
        End If

    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDAbonoTextBox.Text = ""
        IDClienteTextBox.Text = ""
        Deuda_TotalTextBox.Text = ""
        Saldo_PendienteTextBox.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDAbonoTextBox1.Text = ""
        IDClienteTextBox1.Text = ""
        Fecha_AbonoDateTimePicker.ResetText()
        Saldo_AbonoTextBox.Text = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Eliminar(IDAbonoTextBox.Text)
        Me.IDAbono_IDCliente_Deuda_Total_Saldo_PendienteTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Deuda_Total_Saldo_Pendiente)
    End Sub

    Private Sub BtnAdd1_Click(sender As Object, e As EventArgs) Handles BtnAdd1.Click
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Insert(IDAbonoTextBox1.Text, IDClienteTextBox1.Text, Convert.ToDateTime(Fecha_AbonoDateTimePicker), Saldo_AbonoTextBox.Text)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
    End Sub

    Private Sub BtnSearch1_Click(sender As Object, e As EventArgs) Handles BtnSearch1.Click

        If IsNumeric(IDClienteTextBox.Text) Then
            Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.FillBy(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado, IDClienteTextBox.Text)
        Else
            Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
        End If
    End Sub

    Private Sub BtnUpdate1_Click(sender As Object, e As EventArgs) Handles BtnUpdate1.Click
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Modificar(IDAbonoTextBox1.Text, IDClienteTextBox1.Text, Convert.ToDateTime(Fecha_AbonoDateTimePicker), Saldo_AbonoTextBox.Text)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
    End Sub

    Private Sub BtnDelete1_Click(sender As Object, e As EventArgs) Handles BtnDelete1.Click
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Eliminar(IDAbonoTextBox.Text)
        Me.IDAbono_IDCliente_Fecha_Abono_Saldo_AbonadoTableAdapter.Fill(Me.LibreriaDataSet.IDAbono_IDCliente_Fecha_Abono_Saldo_Abonado)
    End Sub
End Class