<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLineTextBox3 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(30, 64)
        Me.GunaLineTextBox1.MaxLength = 15
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(327, 39)
        Me.GunaLineTextBox1.TabIndex = 0
        Me.GunaLineTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.GunaImageButton2)
        Me.GunaGroupBox1.Controls.Add(Me.GunaLineTextBox2)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Location = New System.Drawing.Point(30, 124)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(160, 152)
        Me.GunaGroupBox1.TabIndex = 1
        Me.GunaGroupBox1.Text = "Nomor PKH"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = CType(resources.GetObject("GunaImageButton2.Image"), System.Drawing.Image)
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaImageButton2.Location = New System.Drawing.Point(108, 106)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(49, 43)
        Me.GunaImageButton2.TabIndex = 5
        '
        'GunaLineTextBox2
        '
        Me.GunaLineTextBox2.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox2.Location = New System.Drawing.Point(3, 58)
        Me.GunaLineTextBox2.Name = "GunaLineTextBox2"
        Me.GunaLineTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox2.Size = New System.Drawing.Size(154, 26)
        Me.GunaLineTextBox2.TabIndex = 0
        Me.GunaLineTextBox2.Text = "-"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Controls.Add(Me.GunaImageButton1)
        Me.GunaGroupBox2.Controls.Add(Me.GunaLineTextBox3)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox2.Location = New System.Drawing.Point(196, 124)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(161, 152)
        Me.GunaGroupBox2.TabIndex = 2
        Me.GunaGroupBox2.Text = "Nomor KIP"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = CType(resources.GetObject("GunaImageButton1.Image"), System.Drawing.Image)
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(32, 32)
        Me.GunaImageButton1.Location = New System.Drawing.Point(108, 106)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(49, 43)
        Me.GunaImageButton1.TabIndex = 4
        '
        'GunaLineTextBox3
        '
        Me.GunaLineTextBox3.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaLineTextBox3.Location = New System.Drawing.Point(3, 58)
        Me.GunaLineTextBox3.Name = "GunaLineTextBox3"
        Me.GunaLineTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox3.Size = New System.Drawing.Size(154, 26)
        Me.GunaLineTextBox3.TabIndex = 1
        Me.GunaLineTextBox3.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pindai Barcode"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(311, 292)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(0, 15)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(393, 339)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm1"
        Me.Text = "KIP Scanner"
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLineTextBox3 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
