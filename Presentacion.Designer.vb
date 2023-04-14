<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.ImagenPresentacion = New System.Windows.Forms.PictureBox()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        CType(Me.ImagenPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenPresentacion
        '
        Me.ImagenPresentacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagenPresentacion.Image = CType(resources.GetObject("ImagenPresentacion.Image"), System.Drawing.Image)
        Me.ImagenPresentacion.Location = New System.Drawing.Point(0, 0)
        Me.ImagenPresentacion.Name = "ImagenPresentacion"
        Me.ImagenPresentacion.Size = New System.Drawing.Size(496, 303)
        Me.ImagenPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPresentacion.TabIndex = 0
        Me.ImagenPresentacion.TabStop = False
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ApplicationTitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ApplicationTitle.Location = New System.Drawing.Point(107, 9)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ApplicationTitle.Size = New System.Drawing.Size(305, 34)
        Me.ApplicationTitle.TabIndex = 2
        Me.ApplicationTitle.Text = "Librería Pequeños Detalles"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ApplicationTitle.UseCompatibleTextRendering = True
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Version.Location = New System.Drawing.Point(381, 255)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(115, 20)
        Me.Version.TabIndex = 4
        Me.Version.Text = "Versión {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(381, 275)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(115, 20)
        Me.Copyright.TabIndex = 5
        Me.Copyright.Text = "Copyright"
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.ImagenPresentacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Presentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ImagenPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenPresentacion As PictureBox
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
End Class
