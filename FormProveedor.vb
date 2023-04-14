Imports FontAwesome.Sharp

Public Class FormProveedor

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub IDProveedor_Nombre_prov_Marca_DistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IDProveedor_Nombre_prov_Marca_DistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProveedor_Nom_MarView5' Puede moverla o quitarla según sea necesario.
        Me.IDProveedor_Nom_MarView5TableAdapter.Fill(Me.LibreriaDataSet.IDProveedor_Nom_MarView5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProveedor_Nom_MarView4' Puede moverla o quitarla según sea necesario.
        Me.IDProveedor_Nom_MarView4TableAdapter.Fill(Me.LibreriaDataSet.IDProveedor_Nom_MarView4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProveedorTel_View3' Puede moverla o quitarla según sea necesario.
        Me.IDProveedorTel_View3TableAdapter.Fill(Me.LibreriaDataSet.IDProveedorTel_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View2' Puede moverla o quitarla según sea necesario.
        Me.Producto_View2TableAdapter.Fill(Me.LibreriaDataSet.Producto_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Producto_View1' Puede moverla o quitarla según sea necesario.
        Me.Producto_View1TableAdapter.Fill(Me.LibreriaDataSet.Producto_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca' Puede moverla o quitarla según sea necesario.
        Me.IDProducto_IDProveedor_NombreProducto_MarcaTableAdapter.Fill(Me.LibreriaDataSet.IDProducto_IDProveedor_NombreProducto_Marca)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.LibreriaDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProveedor_Telefono_Prov' Puede moverla o quitarla según sea necesario.
        Me.IDProveedor_Telefono_ProvTableAdapter.Fill(Me.LibreriaDataSet.IDProveedor_Telefono_Prov)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDProveedor_Nombre_prov_Marca_Dist' Puede moverla o quitarla según sea necesario.
        Me.IDProveedor_Nombre_prov_Marca_DistTableAdapter.Fill(Me.LibreriaDataSet.IDProveedor_Nombre_prov_Marca_Dist)

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
        Me.ProveedorTableAdapter.Insertar(IDProveedorTextBox.Text, Nombre_ProvTextBox.Text, Direccion_ProvTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.LibreriaDataSet.Proveedor)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.ProveedorTableAdapter.Modificar(IDProveedorTextBox.Text, Nombre_ProvTextBox.Text, Direccion_ProvTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.LibreriaDataSet.Proveedor)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.ProveedorTableAdapter.Eliminar(IDProveedorTextBox.Text)
        Me.ProveedorTableAdapter.Fill(Me.LibreriaDataSet.Proveedor)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If (Nombre_ProvTextBox.Text = "") Then
            Me.ProveedorTableAdapter.Fill(Me.LibreriaDataSet.Proveedor)
        Else
            Me.ProveedorTableAdapter.FillBy(Me.LibreriaDataSet.Proveedor, Nombre_ProvTextBox.Text)
        End If


    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDProveedorTextBox.Text = ""
        Nombre_ProvTextBox.Text = ""
        Direccion_ProvTextBox.Text = ""
    End Sub
End Class