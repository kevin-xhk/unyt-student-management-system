<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COURSEDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InstitutionManagementDatabaseDataSet = New StudentManagementSystem.InstitutionManagementDatabaseDataSet()
        Me.InstitutionManagementDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COURSE_DETAILSTableAdapter = New StudentManagementSystem.InstitutionManagementDatabaseDataSetTableAdapters.COURSE_DETAILSTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtCourseDuration = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCourseTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCourseFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourseId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COURSEDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstitutionManagementDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstitutionManagementDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.CourseCodeDataGridViewTextBoxColumn, Me.CourseFeeDataGridViewTextBoxColumn, Me.CourseDurationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.COURSEDETAILSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(108, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(849, 172)
        Me.DataGridView1.TabIndex = 0
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "Course ID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "Course ID"
        Me.CourseIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseIDDataGridViewTextBoxColumn.Width = 125
        '
        'CourseTitleDataGridViewTextBoxColumn
        '
        Me.CourseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course Title"
        Me.CourseTitleDataGridViewTextBoxColumn.HeaderText = "Course Title"
        Me.CourseTitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseTitleDataGridViewTextBoxColumn.Name = "CourseTitleDataGridViewTextBoxColumn"
        Me.CourseTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseTitleDataGridViewTextBoxColumn.Width = 125
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseNameDataGridViewTextBoxColumn.Width = 125
        '
        'CourseCodeDataGridViewTextBoxColumn
        '
        Me.CourseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course Code"
        Me.CourseCodeDataGridViewTextBoxColumn.HeaderText = "Course Code"
        Me.CourseCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseCodeDataGridViewTextBoxColumn.Name = "CourseCodeDataGridViewTextBoxColumn"
        Me.CourseCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseCodeDataGridViewTextBoxColumn.Width = 125
        '
        'CourseFeeDataGridViewTextBoxColumn
        '
        Me.CourseFeeDataGridViewTextBoxColumn.DataPropertyName = "Course Fee"
        Me.CourseFeeDataGridViewTextBoxColumn.HeaderText = "Course Fee"
        Me.CourseFeeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseFeeDataGridViewTextBoxColumn.Name = "CourseFeeDataGridViewTextBoxColumn"
        Me.CourseFeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseFeeDataGridViewTextBoxColumn.Width = 125
        '
        'CourseDurationDataGridViewTextBoxColumn
        '
        Me.CourseDurationDataGridViewTextBoxColumn.DataPropertyName = "Course Duration"
        Me.CourseDurationDataGridViewTextBoxColumn.HeaderText = "Course Duration"
        Me.CourseDurationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CourseDurationDataGridViewTextBoxColumn.Name = "CourseDurationDataGridViewTextBoxColumn"
        Me.CourseDurationDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseDurationDataGridViewTextBoxColumn.Width = 125
        '
        'COURSEDETAILSBindingSource
        '
        Me.COURSEDETAILSBindingSource.DataMember = "COURSE DETAILS"
        Me.COURSEDETAILSBindingSource.DataSource = Me.InstitutionManagementDatabaseDataSet
        '
        'InstitutionManagementDatabaseDataSet
        '
        Me.InstitutionManagementDatabaseDataSet.DataSetName = "InstitutionManagementDatabaseDataSet"
        Me.InstitutionManagementDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InstitutionManagementDatabaseDataSetBindingSource
        '
        Me.InstitutionManagementDatabaseDataSetBindingSource.DataSource = Me.InstitutionManagementDatabaseDataSet
        Me.InstitutionManagementDatabaseDataSetBindingSource.Position = 0
        '
        'COURSE_DETAILSTableAdapter
        '
        Me.COURSE_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtCourseDuration)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCourseCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCourseTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCourseFee)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCourseName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCourseId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 259)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COURSE DETAILS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Location = New System.Drawing.Point(50, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 65)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(626, 21)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(466, 21)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(324, 21)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 38)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(173, 21)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(117, 38)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(21, 21)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 38)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtCourseDuration
        '
        Me.txtCourseDuration.Location = New System.Drawing.Point(580, 135)
        Me.txtCourseDuration.Name = "txtCourseDuration"
        Me.txtCourseDuration.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseDuration.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Course Duration"
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(580, 91)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseCode.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Course Code"
        '
        'txtCourseTitle
        '
        Me.txtCourseTitle.Location = New System.Drawing.Point(580, 47)
        Me.txtCourseTitle.Name = "txtCourseTitle"
        Me.txtCourseTitle.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseTitle.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Course Title"
        '
        'txtCourseFee
        '
        Me.txtCourseFee.Location = New System.Drawing.Point(147, 132)
        Me.txtCourseFee.Name = "txtCourseFee"
        Me.txtCourseFee.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseFee.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Course Fee"
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(147, 91)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Name"
        '
        'txtCourseId
        '
        Me.txtCourseId.Enabled = False
        Me.txtCourseId.Location = New System.Drawing.Point(147, 47)
        Me.txtCourseId.Name = "txtCourseId"
        Me.txtCourseId.Size = New System.Drawing.Size(219, 22)
        Me.txtCourseId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'CourseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 530)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CourseDetails"
        Me.Text = "CourseDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COURSEDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstitutionManagementDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstitutionManagementDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InstitutionManagementDatabaseDataSetBindingSource As BindingSource
    Friend WithEvents InstitutionManagementDatabaseDataSet As InstitutionManagementDatabaseDataSet
    Friend WithEvents COURSEDETAILSBindingSource As BindingSource
    Friend WithEvents COURSE_DETAILSTableAdapter As InstitutionManagementDatabaseDataSetTableAdapters.COURSE_DETAILSTableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseFeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCourseDuration As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCourseTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCourseFee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCourseId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
End Class
