<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.State = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SetNum = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'State
        '
        Me.State.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!)
        Me.State.Location = New System.Drawing.Point(46, 42)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(580, 35)
        Me.State.TabIndex = 3
        Me.State.Text = "当前设定的最大数字："
        '
        'C1
        '
        Me.C1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1.Location = New System.Drawing.Point(52, 443)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(100, 50)
        Me.C1.TabIndex = 1
        Me.C1.Text = "抽取一位"
        Me.C1.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C2.Location = New System.Drawing.Point(224, 443)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(100, 50)
        Me.C2.TabIndex = 2
        Me.C2.Text = "抽取两位"
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C3.Location = New System.Drawing.Point(399, 443)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(100, 50)
        Me.C3.TabIndex = 3
        Me.C3.Text = "抽取三位"
        Me.C3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'SetNum
        '
        Me.SetNum.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SetNum.Location = New System.Drawing.Point(632, 35)
        Me.SetNum.Name = "SetNum"
        Me.SetNum.Size = New System.Drawing.Size(100, 50)
        Me.SetNum.TabIndex = 5
        Me.SetNum.Text = "设定数字"
        Me.SetNum.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Clear.Location = New System.Drawing.Point(632, 443)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(100, 50)
        Me.Clear.TabIndex = 4
        Me.Clear.Text = "清零"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(50, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "第一位"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "第二位"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(50, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "第三位"
        '
        'Num1
        '
        Me.Num1.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Num1.Location = New System.Drawing.Point(50, 110)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(700, 90)
        Me.Num1.TabIndex = 15
        '
        'Num2
        '
        Me.Num2.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Num2.Location = New System.Drawing.Point(50, 220)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(700, 90)
        Me.Num2.TabIndex = 16
        '
        'Num3
        '
        Me.Num3.Font = New System.Drawing.Font("Arial", 60.0!)
        Me.Num3.Location = New System.Drawing.Point(50, 330)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(700, 90)
        Me.Num3.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(799, 540)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.SetNum)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.State)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(815, 579)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "随机点名工具"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents State As Label
    Friend WithEvents C1 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents SetNum As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Num3 As Label
End Class
