'只有系统缩放在100%时才能打开，否则会报 System.NullReferenceException:“未将对象引用设置到对象的实例。”

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '启动时记录当前窗体大小并写入Tag
        x = Me.Width
        y = Me.Height
        SetTag(Me)

        Num = 55
        State.Text = "当前设定的最大数字：" & Num
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        Randomize
        If Num < 1 Then
            MsgBox("请设定大于0的数", vbOKOnly + vbCritical, "错误")
        Else '符合条件后开始timer是否启用的判定
            '停止另外两个Timer
            Timer2.Enabled = False
            Timer3.Enabled = False
            If Timer1.Enabled = True Then '若timer已启用，则点击按钮停止timer，否则点击按钮启用timer
                Timer1.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
                Timer1.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '生成任意范围随机数：int((上限-下限+1)*rnd +1)
        a = Int(Num * Rnd() + 1)
        Num1.Text = a
        Num2.Text = ""
        Num3.Text = ""
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        Randomize
        If Num < 2 Then
            MsgBox("请设定大于1的数", vbOKOnly + vbCritical, "错误")
            '判断是否大于1，否则报错
        Else
            Timer1.Enabled = False
            Timer3.Enabled = False
            If Timer2.Enabled = True Then
                Timer2.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Timer2.Enabled = True
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Do
            a = Int(Num * Rnd() + 1)
            b = Int(Num * Rnd() + 1)
        Loop Until a <> b
        Num1.Text = a
        Num2.Text = b
        Num3.Text = ""
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        Randomize
        If Num < 3 Then
            MsgBox("请设定大于2的数", vbOKOnly + vbCritical, "错误")
        Else
            Timer1.Enabled = False
            Timer2.Enabled = False
            If Timer3.Enabled = True Then
                Timer3.Enabled = False
                Num1.ForeColor = Color.Red
                Num2.ForeColor = Color.Red
                Num3.ForeColor = Color.Red
            Else
                Timer3.Enabled = True
                Num1.ForeColor = Color.Black
                Num2.ForeColor = Color.Black
                Num3.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Do
            a = Int(Num * Rnd() + 1)
            b = Int(Num * Rnd() + 1)
            c = Int(Num * Rnd() + 1)
        Loop Until a <> b And b <> c And a <> c
        Num1.Text = a
        Num2.Text = b
        Num3.Text = c
    End Sub

    Private Sub SetNum_Click(sender As Object, e As EventArgs) Handles SetNum.Click
        '停止三个timer
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        '重设数字选项，点击后开启form2
        Form2.ShowDialog() '以模态方式创建form2
    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        '停止三个timer
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        '清空文本
        Num1.Text = ""
        Num2.Text = ""
        Num3.Text = ""
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        State.Text = "当前设定的最大数字：" & Num
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim newx, newy As Single
        newx = Me.Width / x
        newy = Me.Height / y
        SetControls(newx, newy, Me)

        '一种古法自动缩放控件
        'GroupBox1.Width = Me.Width - 135
        'GroupBox2.Width = Me.Width - 135
        'GroupBox3.Width = Me.Width - 135
        'SetNum.Left = Me.Width - 182
        'Clear.Left = Me.Width - 182
        'Clear.Top = Me.Height - 136
        'c1.Top = Me.Height - 136
        'c2.Top = Me.Height - 136
        'c3.Top = Me.Height - 136
        'state.Font = New Font("Microsoft Yahei UI", Me.Height / 25)
        'Num1.Font = New Font("Arial", Me.Height / 11.2)
        'Num2.Font = New Font("Arial", Me.Height / 11.2)
        'Num3.Font = New Font("Arial", Me.Height / 11.2)
        'GroupBox1.Height = Num1.Font.Size * 1.85
        'GroupBox2.Height = Num2.Font.Size * 1.85
        'GroupBox3.Height = Num3.Font.Size * 1.85
        'GroupBox1.Top = Me.Height / 4.6
        'GroupBox2.Top = Me.Height / 2.6
        'GroupBox3.Top = Me.Height / 1.8

    End Sub

    '一种新的自动调整控件大小的方法

    '递归选取控件的原始大小和位置，用tag记录
    Private Sub SetTag(ByVal obj As Object)
        For Each con As Control In obj.controls
            con.Tag = con.Width & ":" & con.Height & ":" & con.Left & ":" & con.Top & ":" & con.Font.Size
        Next
    End Sub

    '递归重新设定控件的大小和位置
    Private Sub SetControls(ByVal newx As Single, ByVal newy As Single, ByVal obj As Object)
        For Each con As Control In obj.Controls
            con.AutoSize = False
            Dim mytag() As String = con.Tag.ToString.Split(":")
            con.Width = mytag(0) * newx
            con.Height = mytag(1) * newy
            con.Left = mytag(2) * newx
            con.Top = mytag(3) * newy

            Dim currentSize As Single = (mytag(1) * newy * mytag(4)) / mytag(1)

            con.Font = New Font(con.Font.Name, currentSize)
            'If con.Controls.Count > 0 Then
            '    setControls(newx, newy, con)
            'End If

        Next
    End Sub
End Class
