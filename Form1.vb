Public Class frm1
    Dim barcode As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        setFokusInput1()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub GunaLineTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaLineTextBox1.KeyPress
        If (e.KeyChar = Chr(13)) Then
            barcode = GunaLineTextBox1.Text
            GunaLineTextBox2.Text = Strings.Left(barcode, 5)
            GunaLineTextBox3.Text = Strings.Right(barcode, 5)
            GunaLineTextBox1.Text = ""
            setFokusInput1()
        End If
    End Sub

    Private Sub GunaImageButton2_Click(sender As Object, e As EventArgs) Handles GunaImageButton2.Click
        Clipboard.SetText(GunaLineTextBox2.Text)
        GunaLabel2.Text = "PKH disalin"
        setFokusInput1()
    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Clipboard.SetText(GunaLineTextBox3.Text)
        GunaLabel2.Text = "KIP disalin"
        setFokusInput1()
    End Sub

    Sub setFokusInput1()
        GunaLineTextBox1.Focus()
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaLineTextBox1.TextChanged
        GunaLabel2.Text = ""
    End Sub
End Class
