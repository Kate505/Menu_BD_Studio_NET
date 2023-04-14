Imports FontAwesome.Sharp

Public Class FormGananciasDia

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Private Sub FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibreriaDataSet)

    End Sub

    Private Sub FormGananciasDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5TableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View5)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4TableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View4)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3TableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View3)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2TableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View2)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1TableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias_View1)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta)
        'TODO: esta línea de código carga datos en la tabla 'LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias' Puede moverla o quitarla según sea necesario.
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias)

        PanelTablas.Visible = True
        PanelV1.Visible = False
        PanelV2.Visible = False
        PanelV3.Visible = False
        PanelV4.Visible = False
        PanelV5.Visible = False
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
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Insertar(Convert.ToDateTime(IDFechaRegDateTimePicker), Tot_Puc_DiaTextBox.Text, Tot_Puv_DiaTextBox.Text, Tot_pagos_DiasTextBox.Text)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Modificar(Convert.ToDateTime(IDFechaRegDateTimePicker), Tot_Puc_DiaTextBox.Text, Tot_Puv_DiaTextBox.Text, Tot_pagos_DiasTextBox.Text)
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Eiminar(Convert.ToDateTime(IDFechaRegDateTimePicker))
        Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(Tot_Puc_DiaTextBox.Text) Then
            Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.FillBy(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias, Tot_Puc_DiaTextBox.Text)
        Else
            Me.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_DiasTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_Tot_Puc_Dia_Tot_Puv_Dia_Tot_Pagos_Dias)
        End If
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        IDFechaRegDateTimePicker.ResetText()
        Tot_Puc_DiaTextBox.Text = ""
        Tot_Puv_DiaTextBox.Text = ""
        Tot_pagos_DiasTextBox.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IDFechaRegDateTimePicker1.ResetText()
        Utilidad_BrutaTextBox.Text = ""
        Utilidad_netaTextBox.Text = ""
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Insertar(Convert.ToDateTime(IDFechaRegDateTimePicker), Utilidad_BrutaTextBox.Text, Utilidad_netaTextBox.Text)
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Modificar(Convert.ToDateTime(IDFechaRegDateTimePicker), Utilidad_BrutaTextBox.Text, Utilidad_netaTextBox.Text)
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If IsNumeric(Utilidad_netaTextBox.Text) Then
            Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.FillBy(Me.LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta, Utilidad_netaTextBox.Text)
        Else
            Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Fill(Me.LibreriaDataSet.FechaReg_UtilidadBruta_Utilidad_Neta)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.FechaReg_UtilidadBruta_Utilidad_NetaTableAdapter.Eliminar(Convert.ToDateTime(IDFechaRegDateTimePicker))
    End Sub
End Class