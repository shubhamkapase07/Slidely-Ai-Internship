<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shubham Kapase, Slidely Task 2 - View Submissions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Github Link"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stopwatch time"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtName.Location = New System.Drawing.Point(189, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(289, 20)
        Me.txtName.TabIndex = 6
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPhoneNum.Location = New System.Drawing.Point(189, 189)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.ReadOnly = True
        Me.txtPhoneNum.Size = New System.Drawing.Size(289, 20)
        Me.txtPhoneNum.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtEmail.Location = New System.Drawing.Point(189, 139)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(289, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtGithubLink
        '
        Me.txtGithubLink.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtGithubLink.Location = New System.Drawing.Point(189, 242)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.ReadOnly = True
        Me.txtGithubLink.Size = New System.Drawing.Size(289, 20)
        Me.txtGithubLink.TabIndex = 9
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblStopwatch.Location = New System.Drawing.Point(189, 292)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.ReadOnly = True
        Me.lblStopwatch.Size = New System.Drawing.Size(289, 20)
        Me.lblStopwatch.TabIndex = 10
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Plum
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(60, 346)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(193, 38)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "PREVIOUS ( CTRL + P )"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Plum
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(280, 346)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(198, 38)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "NEXT ( CTRL + N )"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(532, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
