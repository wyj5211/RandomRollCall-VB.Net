Public Class Form2

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim NewNum As Long
        NewNum = Val(TextBox1.Text)

        '当输入的数字不符合要求时报错
        If NewNum < 1 Then
            MsgBox("请设定大于0的数", vbOKOnly + vbCritical, "错误")
            TextBox1.Text = ""
        Else
            Num = NewNum
            '卸载form2，打开form1，并更改label1显示值
            Me.Close()
            Form1.Show()
            Form1.State.Text = "当前设定的最大数字：" & Num
            Form1.Num1.Text = ""
            Form1.Num2.Text = ""
            Form1.Num3.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Me.ActiveControl = Me.TextBox1
    End Sub

End Class