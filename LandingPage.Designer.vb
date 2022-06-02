<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeStructureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.SalaryDetailsToolStripMenuItem, Me.EmployeeInformationToolStripMenuItem, Me.FeeStructureToolStripMenuItem, Me.CourseDetailsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.OpenWindowToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'SalaryDetailsToolStripMenuItem
        '
        Me.SalaryDetailsToolStripMenuItem.Name = "SalaryDetailsToolStripMenuItem"
        Me.SalaryDetailsToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.SalaryDetailsToolStripMenuItem.Text = "Salary Details"
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.EmployeeInformationToolStripMenuItem.Text = "Employee Information"
        '
        'FeeStructureToolStripMenuItem
        '
        Me.FeeStructureToolStripMenuItem.Name = "FeeStructureToolStripMenuItem"
        Me.FeeStructureToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.FeeStructureToolStripMenuItem.Text = "Fee Structure"
        '
        'CourseDetailsToolStripMenuItem
        '
        Me.CourseDetailsToolStripMenuItem.Name = "CourseDetailsToolStripMenuItem"
        Me.CourseDetailsToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.CourseDetailsToolStripMenuItem.Text = "Course Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'OpenWindowToolStripMenuItem
        '
        Me.OpenWindowToolStripMenuItem.Name = "OpenWindowToolStripMenuItem"
        Me.OpenWindowToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.OpenWindowToolStripMenuItem.Text = "Users"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(137, 24)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'LandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LandingPage"
        Me.Text = "LandingPage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalaryDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeStructureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
End Class
