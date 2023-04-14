Imports FontAwesome.Sharp

Public Class FormDetalleFactura

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel


    Private Sub IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormDetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View5' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleado_View5TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View4' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleado_View4TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View3' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleado_View3TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View2' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleado_View2TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View1' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleado_View1TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDCliente_IDEmpleado' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_Fecha' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv' Puede moverla o quitarla según sea necesario.
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)

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

    Private Sub IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

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
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Insertar(IDFacturaTextBox.Text, IDProductoTextBox.Text, CantidadTextBox.Text, PucTextBox.Text, Tot_PucTextBox.Text, PuvTextBox.Text, Tot_PuvTextBox.Text)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Modificar(IDFacturaTextBox.Text, IDProductoTextBox.Text, CantidadTextBox.Text, PucTextBox.Text, Tot_PucTextBox.Text, PuvTextBox.Text, Tot_PuvTextBox.Text)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(IDFacturaTextBox.Text) Then
            Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.FillBy(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv, IDFacturaTextBox.Text)
        Else
            Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Eliminar(IDFacturaTextBox.Text)
        Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_Puv)
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDFacturaTextBox.Text = ""
        IDProductoTextBox.Text = ""
        CantidadTextBox.Text = ""
        PucTextBox.Text = ""
        PuvTextBox.Text = ""
        Tot_PucTextBox.Text = ""
        Tot_PuvTextBox.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDFacturaTextBox1.Text = ""
        IDClienteTextBox.Text = ""
        IDEmpleadoTextBox.Text = ""
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Insertar(IDFacturaTextBox1.Text, IDClienteTextBox.Text, IDEmpleadoTextBox.Text)
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Modificar(IDFacturaTextBox1.Text, IDClienteTextBox.Text, IDEmpleadoTextBox.Text)
        Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If IsNumeric(IDEmpleadoTextBox.Text) Then
            Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.FillBy(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado, IDEmpleadoTextBox.Text)
        Else
            Me.IDFactura_IDCliente_IDEmpleadoTableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDCliente_IDEmpleado)
        End If
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSeleccionar_PA4, New System.Nullable(Of Integer)(CType(IDFacturaToolStripTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(IDProductoToolStripTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(CantidadToolStripTextBox.Text, Integer)), New System.Nullable(Of Decimal)(CType(PucToolStripTextBox.Text, Decimal)), New System.Nullable(Of Double)(CType(Tot_PucToolStripTextBox.Text, Double)), New System.Nullable(Of Decimal)(CType(PuvToolStripTextBox.Text, Decimal)), New System.Nullable(Of Double)(CType(Tot_PuvToolStripTextBox.Text, Double)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5TableAdapter.Fill(Me.LibreriaDataSet.IDFactura_IDproducto_Cantidad_Puc_Tot_puc_Puv_Tot_PuvSumar_PA5, New System.Nullable(Of Integer)(CType(IDProductoToolStripTextBox1.Text, Integer)), New System.Nullable(Of Integer)(CType(CantidadToolStripTextBox1.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class