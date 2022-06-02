Imports System.Data.OleDb

Public Class UserManagement
    Dim conaccess As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim adp As Odbc.OdbcDataAdapter
    Dim index As Integer
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstitutionManagementDatabaseDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.Users)
        conaccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\InstitutionManagementDatabase.mdb"
        conaccess.Open()
        loadGrid()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if no textbox is empty
        If txtUserName.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim table As New DataTable("Users")
                table.Columns.Add("UserName", GetType(String))
                table.Columns.Add("Password", GetType(String))
                table.Columns.Add("Role", GetType(String))
                table.Rows.Add(txtUserName.Text, txtPassword.Text, "Student")

                DataGridView1.DataSource = table
                MsgBox("Record inserted Succesfully.")

                Me.UsersTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.Users)
                Me.UsersTableAdapter.GetData()
                Me.InstitutionManagementDatabaseDataSet.Users.AcceptChanges()
                loadGrid()
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub loadGrid()
        Dim access As String
        access = "select * from Users"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, conaccess)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub
End Class