Imports FontAwesome.Sharp
Public Class FormEmpleados

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleado_View5' Puede moverla o quitarla según sea necesario.
        Me.Empleado_View5TableAdapter.Fill(Me.LibreriaDataSet1.Empleado_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleado_View4' Puede moverla o quitarla según sea necesario.
        Me.Empleado_View4TableAdapter.Fill(Me.LibreriaDataSet1.Empleado_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleado_View3' Puede moverla o quitarla según sea necesario.
        Me.Empleado_View3TableAdapter.Fill(Me.LibreriaDataSet1.Empleado_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleado_View2' Puede moverla o quitarla según sea necesario.
        Me.Empleado_View2TableAdapter.Fill(Me.LibreriaDataSet1.Empleado_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleado_View1' Puede moverla o quitarla según sea necesario.
        Me.Empleado_View1TableAdapter.Fill(Me.LibreriaDataSet1.Empleado_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.IDEmpleado_Telefono_Emp' Puede moverla o quitarla según sea necesario.
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Fill(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet1.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.LibreriaDataSet1.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.IDEmpleado_Telefono_Emp' Puede moverla o quitarla según sea necesario.

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

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.LibreriaDataSet1)

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
        Me.EmpleadosTableAdapter.Insertar(IDEmpleadoTextBox2.Text, Nombre_EmpTextBox.Text, Apellido_EmpTextBox.Text, Direccion_EmpTextBox.Text, Empleado_ActivoTextBox1.Text)
        Me.EmpleadosTableAdapter.Fill(Me.LibreriaDataSet1.Empleados)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.EmpleadosTableAdapter.Modificar(IDEmpleadoTextBox2.Text, Empleado_ActivoTextBox1.Text)
        Me.EmpleadosTableAdapter.Fill(Me.LibreriaDataSet1.Empleados)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If (Nombre_EmpTextBox.Text = "") Then
            Me.EmpleadosTableAdapter.Fill(Me.LibreriaDataSet1.Empleados)
        Else
            Me.EmpleadosTableAdapter.FillBy(Me.LibreriaDataSet1.Empleados, Nombre_EmpTextBox.Text)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.EmpleadosTableAdapter.Eliminar(IDEmpleadoTextBox2.Text)
        Me.EmpleadosTableAdapter.Fill(Me.LibreriaDataSet1.Empleados)
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDEmpleadoTextBox2.Text = ""
        Nombre_EmpTextBox.Text = ""
        Apellido_EmpTextBox.Text = ""
        Direccion_EmpTextBox.Text = ""
        Empleado_ActivoTextBox1.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDEmpleadoTextBox1.Text = ""
        Telefono_EmpTextBox.Text = ""
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Insertar(IDEmpleadoTextBox1.Text, Telefono_EmpTextBox.Text)
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Fill(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Modificar(IDEmpleadoTextBox1.Text, Telefono_EmpTextBox.Text)
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Fill(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        If IsNumeric(Telefono_EmpTextBox.Text) Then
            Me.IDEmpleado_Telefono_EmpTableAdapter1.FillBy(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp, Telefono_EmpTextBox.Text)
        Else
            Me.IDEmpleado_Telefono_EmpTableAdapter1.Fill(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp)
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Eliminar(IDEmpleadoTextBox1.Text)
        Me.IDEmpleado_Telefono_EmpTableAdapter1.Fill(Me.LibreriaDataSet1.IDEmpleado_Telefono_Emp)
    End Sub
End Class