Imports System.Data.OleDb

Public Class CourseDetails
    Dim conaccess As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim adp As Odbc.OdbcDataAdapter
    Dim index As Integer
    Private Sub CourseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstitutionManagementDatabaseDataSet.COURSE_DETAILS' table. You can move, or remove it, as needed.
        Me.COURSE_DETAILSTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.COURSE_DETAILS)
        conaccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\InstitutionManagementDatabase.mdb"
        conaccess.Open()
        loadGrid()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if no textbox is empty
        If txtCourseCode.Text = "" Or txtCourseDuration.Text = "" Or txtCourseFee.Text = "" Or txtCourseName.Text = "" Or txtCourseTitle.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Add courses
            ' Connect to DB
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\InstitutionManagementDatabase.mdb"

            Try
                Dim sql As String = "INSERT INTO [COURSE DETAILS]([Course Title], [Course Name], [Course Code], [Course Fee], [Course Duration]) VALUES ('" & txtCourseTitle.Text & "','" & txtCourseName.Text & "','" & txtCourseCode.Text & "','" & txtCourseFee.Text & "','" & txtCourseDuration.Text & "')"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
                sqlCom.CommandType = CommandType.Text
                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                sqlCom.ExecuteNonQuery()

                MsgBox("Record inserted Succesfully.")

                Me.COURSE_DETAILSTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.COURSE_DETAILS)

                Me.InstitutionManagementDatabaseDataSet.COURSE_DETAILS.AcceptChanges()
                loadGrid()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub loadGrid()
        Dim access As String
        access = "select * from [COURSE DETAILS]"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, conaccess)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As DataGridViewAdvancedBorderStyle)
        Dim vSearch As String = InputBox("Enter Integer number to search name:")

        If vSearch <> "" Then

            cmdOLEDB.CommandText = "SELECT [Course ID],
            [Course Name] FROM [COURSE DETAILS] WHERE [Course ID]=" & CInt(vSearch)

            cmdOLEDB.Connection = conaccess

            Dim rdrOLEDB As OleDbDataReader = cmdOLEDB.ExecuteReader

            If rdrOLEDB.Read = True Then

                Label7.Visible = True
                Label7.Text = "Course ID: " & rdrOLEDB.Item(0).ToString & " . " & " Course Name: " &
                rdrOLEDB.Item(1).ToString

                rdrOLEDB.Close()

                Exit Sub

            Else
                rdrOLEDB.Close()

                MsgBox("Record not found")

                Exit Sub

            End If

        Else

            MsgBox("Enter search value.")

            Exit Sub

        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' the new row
        Dim newDataRow As DataGridViewRow

        newDataRow = DataGridView1.Rows(index)

        ' get data from textboxes to the row
        newDataRow.Cells(1).Value = txtCourseTitle.Text
        newDataRow.Cells(2).Value = txtCourseName.Text
        newDataRow.Cells(3).Value = txtCourseCode.Text
        newDataRow.Cells(4).Value = txtCourseFee.Text
        newDataRow.Cells(5).Value = txtCourseDuration.Text
        MsgBox("Update Succesful..")
        Me.InstitutionManagementDatabaseDataSet.AcceptChanges()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' get the index of the selected datagridview row
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow

        ' show data from the selected row to textboxes
        selectedRow = DataGridView1.Rows(index)
        txtCourseId.Text = selectedRow.Cells(0).Value.ToString()
        txtCourseTitle.Text = selectedRow.Cells(1).Value.ToString()
        txtCourseName.Text = selectedRow.Cells(2).Value.ToString()
        txtCourseCode.Text = selectedRow.Cells(3).Value.ToString()
        txtCourseFee.Text = selectedRow.Cells(4).Value.ToString()
        txtCourseDuration.Text = selectedRow.Cells(5).Value.ToString()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DataGridView1.Rows.RemoveAt(index)
        MsgBox("Delete Succesful..")
        Me.InstitutionManagementDatabaseDataSet.AcceptChanges()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCourseTitle.Clear()
        txtCourseName.Clear()
        txtCourseCode.Clear()
        txtCourseFee.Clear()
        txtCourseDuration.Clear()
    End Sub
End Class