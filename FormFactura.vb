Imports FontAwesome.Sharp

Public Class FormFactura

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View5' Puede moverla o quitarla según sea necesario.
        Me.Factura_View5TableAdapter.Fill(Me.LibreriaDataSet.Factura_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View4' Puede moverla o quitarla según sea necesario.
        Me.Factura_View4TableAdapter.Fill(Me.LibreriaDataSet.Factura_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View3' Puede moverla o quitarla según sea necesario.
        Me.Factura_View3TableAdapter.Fill(Me.LibreriaDataSet.Factura_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View2' Puede moverla o quitarla según sea necesario.
        Me.Factura_View2TableAdapter.Fill(Me.LibreriaDataSet.Factura_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura_View1' Puede moverla o quitarla según sea necesario.
        Me.Factura_View1TableAdapter.Fill(Me.LibreriaDataSet.Factura_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)

        ActivateButton(BtnTbAbonos, RGBColors.color3)
        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
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
        Me.FacturaTableAdapter.Insertar(IDFacturaTextBox.Text, Convert.ToDateTime(FechaDateTimePicker), SubtotalTextBox.Text, ImpuestoTextBox.Text, DescuentoTextBox.Text, Total_FacturaTextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.FacturaTableAdapter.Modificar(IDFacturaTextBox.Text, Convert.ToDateTime(FechaDateTimePicker), SubtotalTextBox.Text, ImpuestoTextBox.Text, DescuentoTextBox.Text, Total_FacturaTextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(SubtotalTextBox.Text) Then
            Me.FacturaTableAdapter.FillBy(Me.LibreriaDataSet.Factura, SubtotalTextBox.Text)
        Else
            Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.FacturaTableAdapter.Eliminar(IDFacturaTextBox.Text)
        Me.FacturaTableAdapter.Fill(Me.LibreriaDataSet.Factura)
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDFacturaTextBox.Text = ""
        FechaDateTimePicker.ResetText()
        SubtotalTextBox.Text = ""
        ImpuestoTextBox.Text = ""
        DescuentoTextBox.Text = ""
        Total_FacturaTextBox.Text = ""
    End Sub
End Class