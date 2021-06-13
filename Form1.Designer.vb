<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbOutput2 = New System.Windows.Forms.TextBox()
        Me.tbAverage2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbOutput3 = New System.Windows.Forms.TextBox()
        Me.tbAverage3 = New System.Windows.Forms.Label()
        Me.tbOverall = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbAverage1 = New System.Windows.Forms.Label()
        Me.tbOutput1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Location = New System.Drawing.Point(12, 9)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(26, 13)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Units:"
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(52, 26)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(47, 20)
        Me.tbInput.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbInput, "Type in the next value for the next day here.")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(130, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Employee 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbOutput2
        '
        Me.tbOutput2.Location = New System.Drawing.Point(130, 75)
        Me.tbOutput2.Multiline = True
        Me.tbOutput2.Name = "tbOutput2"
        Me.tbOutput2.ReadOnly = True
        Me.tbOutput2.Size = New System.Drawing.Size(100, 112)
        Me.tbOutput2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbOutput2, "This displays the units shipped each day of the week for employee 2.")
        '
        'tbAverage2
        '
        Me.tbAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbAverage2.Location = New System.Drawing.Point(130, 190)
        Me.tbAverage2.Name = "tbAverage2"
        Me.tbAverage2.Size = New System.Drawing.Size(100, 25)
        Me.tbAverage2.TabIndex = 8
        Me.tbAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.tbAverage2, "This displays the average units shipped each day for employee 2.")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(246, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Employee 3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbOutput3
        '
        Me.tbOutput3.Location = New System.Drawing.Point(246, 75)
        Me.tbOutput3.Multiline = True
        Me.tbOutput3.Name = "tbOutput3"
        Me.tbOutput3.ReadOnly = True
        Me.tbOutput3.Size = New System.Drawing.Size(100, 112)
        Me.tbOutput3.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.tbOutput3, "This displays the units shipped each day of the week for employee 3.")
        '
        'tbAverage3
        '
        Me.tbAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbAverage3.Location = New System.Drawing.Point(246, 190)
        Me.tbAverage3.Name = "tbAverage3"
        Me.tbAverage3.Size = New System.Drawing.Size(100, 25)
        Me.tbAverage3.TabIndex = 11
        Me.tbAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.tbAverage3, "This displays the average units shipped each day for employee 3.")
        '
        'tbOverall
        '
        Me.tbOverall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbOverall.Location = New System.Drawing.Point(12, 225)
        Me.tbOverall.Name = "tbOverall"
        Me.tbOverall.Size = New System.Drawing.Size(334, 23)
        Me.tbOverall.TabIndex = 12
        Me.tbOverall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.tbOverall, "This displays the average units shipped per day for the company overall.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 251)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(130, 251)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click here, or press the 'r'  or 'esc' button to reset the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here or press the 'x' button to exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbAverage1
        '
        Me.tbAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tbAverage1.Location = New System.Drawing.Point(12, 190)
        Me.tbAverage1.Name = "tbAverage1"
        Me.tbAverage1.Size = New System.Drawing.Size(100, 25)
        Me.tbAverage1.TabIndex = 5
        Me.tbAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.tbAverage1, "This displays the average units shipped each day for employee 1.")
        '
        'tbOutput1
        '
        Me.tbOutput1.Location = New System.Drawing.Point(12, 76)
        Me.tbOutput1.Multiline = True
        Me.tbOutput1.Name = "tbOutput1"
        Me.tbOutput1.ReadOnly = True
        Me.tbOutput1.Size = New System.Drawing.Size(100, 111)
        Me.tbOutput1.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.tbOutput1, "This displays the units shipped each day of the week for employee 1.")
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(364, 285)
        Me.Controls.Add(Me.tbOutput1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbOverall)
        Me.Controls.Add(Me.tbAverage3)
        Me.Controls.Add(Me.tbOutput3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbAverage2)
        Me.Controls.Add(Me.tbOutput2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAverage1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbOutput2 As TextBox
    Friend WithEvents tbAverage2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbOutput3 As TextBox
    Friend WithEvents tbAverage3 As Label
    Friend WithEvents tbOverall As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tbAverage1 As Label
    Friend WithEvents tbOutput1 As TextBox
End Class
