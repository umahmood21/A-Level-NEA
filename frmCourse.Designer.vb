<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtHead = New System.Windows.Forms.TextBox()
        Me.butNew = New System.Windows.Forms.Button()
        Me.butSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCourseID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.butSave)
        Me.Panel1.Controls.Add(Me.butNew)
        Me.Panel1.Controls.Add(Me.txtHead)
        Me.Panel1.Controls.Add(Me.txtCourse)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Location = New System.Drawing.Point(36, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 269)
        Me.Panel1.TabIndex = 0
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(20, 53)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(43, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "Course:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Head of Course:"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(82, 50)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(190, 20)
        Me.txtCourse.TabIndex = 2
        '
        'txtHead
        '
        Me.txtHead.Location = New System.Drawing.Point(122, 97)
        Me.txtHead.Name = "txtHead"
        Me.txtHead.Size = New System.Drawing.Size(150, 20)
        Me.txtHead.TabIndex = 3
        '
        'butNew
        '
        Me.butNew.Location = New System.Drawing.Point(23, 212)
        Me.butNew.Name = "butNew"
        Me.butNew.Size = New System.Drawing.Size(75, 23)
        Me.butNew.TabIndex = 4
        Me.butNew.Text = "New"
        Me.butNew.UseVisualStyleBackColor = True
        '
        'butSave
        '
        Me.butSave.Location = New System.Drawing.Point(154, 212)
        Me.butSave.Name = "butSave"
        Me.butSave.Size = New System.Drawing.Size(75, 23)
        Me.butSave.TabIndex = 5
        Me.butSave.Text = "Save"
        Me.butSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Course ID:"
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Location = New System.Drawing.Point(102, 16)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(62, 13)
        Me.lblCourseID.TabIndex = 7
        Me.lblCourseID.Text = "placeholder"
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCourse"
        Me.Text = "frmCourse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents butSave As Button
    Friend WithEvents butNew As Button
    Friend WithEvents txtHead As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label As Label
    Friend WithEvents lblCourseID As Label
    Friend WithEvents Label1 As Label
End Class
