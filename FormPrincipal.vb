Imports FontAwesome.Sharp

Public Class FormPrincipal

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Public Sub FormPrincipal_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormLogin.Show()
        Me.Visible = False
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormLogin.Show()'
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
    End Sub

    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 50)
        MenuIzq.Controls.Add(leftBorderBtn)
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


    'Metodo para abrir el formulario dentro de un panel'

    Private Sub AbrirFormenPanel(Of MiFormulario As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelPrincipal.Controls.OfType(Of MiFormulario)().FirstOrDefault() 'Busca el formulario'
        If Formulario Is Nothing Then
            Formulario = New MiFormulario()
            Formulario.TopLevel = False
            PanelPrincipal.Controls.Add(Formulario)
            PanelPrincipal.Tag = Formulario
            Formulario.Show()
        Else
            Formulario.BringToFront()
        End If
    End Sub


    Private Sub BtnTbClientes_Click(sender As Object, e As EventArgs) Handles BtnTbClientes.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormClientes.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormClientes)
        My.Forms.FormClientes.Show()
        'My.Forms.FormClientes.WindowState = MaximizeBox
        My.Forms.FormClientes.BringToFront()
        My.Forms.FormClientes.Focus()

    End Sub

    Private Sub BtnTbProductos_Click(sender As Object, e As EventArgs) Handles BtnTbProductos.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormProductos.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormProductos)
        My.Forms.FormProductos.Show()
        My.Forms.FormProductos.BringToFront()
        My.Forms.FormProductos.Focus()


    End Sub

    Private Sub BtnTbProveedor_Click(sender As Object, e As EventArgs) Handles BtnTbProveedor.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormProveedor.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormProveedor)
        My.Forms.FormProveedor.Show()
        My.Forms.FormProveedor.BringToFront()
        My.Forms.FormProveedor.Focus()
    End Sub

    Private Sub BtnTbAbonos_Click(sender As Object, e As EventArgs) Handles BtnTbAbonos.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormAbonos.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormAbonos)
        My.Forms.FormAbonos.Show()
        My.Forms.FormAbonos.BringToFront()
        My.Forms.FormAbonos.Focus()

    End Sub

    Private Sub BtnTbFacturas_Click(sender As Object, e As EventArgs) Handles BtnTbFacturas.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormFactura.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormFactura)
        My.Forms.FormFactura.Show()
        My.Forms.FormFactura.BringToFront()
        My.Forms.FormFactura.Focus()

    End Sub

    Private Sub BtnTbDetFactura_Click(sender As Object, e As EventArgs) Handles BtnTbDetFactura.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormDetalleFactura.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormDetalleFactura)
        My.Forms.FormDetalleFactura.Show()
        My.Forms.FormDetalleFactura.BringToFront()
        My.Forms.FormDetalleFactura.Focus()

    End Sub

    Private Sub BtnTbGanancias_Click(sender As Object, e As EventArgs) Handles BtnTbGanancias.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormGananciasDia.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormGananciasDia)
        My.Forms.FormGananciasDia.Show()
        My.Forms.FormGananciasDia.BringToFront()
        My.Forms.FormGananciasDia.Focus()

    End Sub

    Private Sub BtnTbEmpleados_Click(sender As Object, e As EventArgs) Handles BtnTbEmpleados.Click
        ActivateButton(sender, RGBColors.color3)
        My.Forms.FormEmpleados.MdiParent = Me
        PanelPrincipal.Controls.Add(My.Forms.FormEmpleados)
        My.Forms.FormEmpleados.Show()
        My.Forms.FormEmpleados.BringToFront()
        My.Forms.FormEmpleados.Focus()

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
    End Sub

End Class
