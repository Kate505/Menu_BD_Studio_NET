Imports FontAwesome.Sharp

Public Class FormProductos
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View5' Puede moverla o quitarla según sea necesario.
        Me.Producto_View5TableAdapter.Fill(Me.LibreriaDataSet.Producto_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View4' Puede moverla o quitarla según sea necesario.
        Me.Producto_View4TableAdapter.Fill(Me.LibreriaDataSet.Producto_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View3' Puede moverla o quitarla según sea necesario.
        Me.Producto_View3TableAdapter.Fill(Me.LibreriaDataSet.Producto_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View2' Puede moverla o quitarla según sea necesario.
        Me.Producto_View2TableAdapter.Fill(Me.LibreriaDataSet.Producto_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View1' Puede moverla o quitarla según sea necesario.
        Me.Producto_View1TableAdapter.Fill(Me.LibreriaDataSet.Producto_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca' Puede moverla o quitarla según sea necesario.
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.LibreriaDataSet.Producto)
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
        Me.ProductoTableAdapter.Insertar(IDProductoTextBox.Text, Convert.ToDateTime(FechaCompraDateTimePicker), CantidadTextBox.Text, PucTextBox.Text, PuvTextBox.Text, Ct_Tot_CompraTextBox.Text, Ct_Tot_VentaTextBox.Text, GananciaTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.LibreriaDataSet.Producto)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.ProductoTableAdapter.Modificar(IDProductoTextBox.Text, CantidadTextBox.Text, Ct_Tot_CompraTextBox.Text, Ct_Tot_VentaTextBox.Text, GananciaTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.LibreriaDataSet.Producto)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.ProductoTableAdapter.Eliminar(IDProductoTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.LibreriaDataSet.Producto)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Insertar(IDProductoTextBox1.Text, IDProveedorTextBox.Text, NombreProductoTextBox.Text, MarcaTextBox.Text)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Modificar(IDProductoTextBox1.Text, IDProveedorTextBox.Text, NombreProductoTextBox.Text, MarcaTextBox.Text)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Eliminar(IDProductoTextBox1.Text)
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If IsNumeric(IDProductoTextBox1.Text) Then
            Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.FillBy(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca, IDProductoTextBox1.Text)
        Else
            Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDProductoTextBox1.Text = ""
        IDProveedorTextBox.Text = ""
        NombreProductoTextBox.Text = ""
        MarcaTextBox.Text = ""
    End Sub
End Class