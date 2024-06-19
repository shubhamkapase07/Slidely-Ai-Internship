<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(183, 256)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(288, 20)
        Me.txtGithubLink.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(183, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(288, 20)
        Me.txtEmail.TabIndex = 17
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(183, 203)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(288, 20)
        Me.txtPhoneNum.TabIndex = 16
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(183, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(288, 20)
        Me.txtName.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(51, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Github Link"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(51, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Shubham Kapase, Slidely Task 2 - View Submissions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Plum
        Me.btnToggleStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(54, 306)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(273, 37)
        Me.btnToggleStopwatch.TabIndex = 19
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH ( CTRL + T )"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(375, 318)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(55, 16)
        Me.lblStopwatch.TabIndex = 20
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Plum
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(54, 362)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(417, 40)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "SUBMIT ( CTRL + S )"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(524, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
End Class
