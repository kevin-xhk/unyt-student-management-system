Imports System.Data.OleDb

Public Class StudentInfo
    Dim conaccess As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim adp As Odbc.OdbcDataAdapter
    Dim index As Integer
    Private Sub STUDENT_INFORMATIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.STUDENT_INFORMATIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InstitutionManagementDatabaseDataSet)

    End Sub

    Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InstitutionManagementDatabaseDataSet.STUDENT_INFORMATION' table. You can move, or remove it, as needed.
        Me.STUDENT_INFORMATIONTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.STUDENT_INFORMATION)
        conaccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\InstitutionManagementDatabase.mdb"
        conaccess.Open()
        loadGrid()
    End Sub
    Private Sub loadGrid()
        Dim access As String
        access = "select * from [STUDENT INFORMATION]"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, conaccess)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if no textbox is empty
        If txtFirstName.Text = "" Or txtMiddleName.Text = "" Or txtLastName.Text = "" Or txtLocalAddress.Text = "" Or txtPermAddress.Text = "" Or txtMother.Text = "" Or txtFather.Text = "" Or txtBond.Text = "" Or cmbGender.Text = "" Or txtCategory.Text = "" Or txtEmail.Text = "" Or txtContact.Text = "" Then
            MessageBox.Show("Please complete the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                Dim table As New DataTable("[STUDENT INFORMATION]")
                table.Rows.Add(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, DateTimePicker1.Value, txtLocalAddress.Text, txtPermAddress.Text, txtMother.Text, txtFather.Text, txtBond.Text, cmbGender.SelectedText.ToString(), txtCategory.Text, txtEmail.Text, txtContact.Text)

                DataGridView1.DataSource = table
                MsgBox("Record inserted Succesfully.")

                Me.STUDENT_INFORMATIONTableAdapter.Fill(Me.InstitutionManagementDatabaseDataSet.STUDENT_INFORMATION)

                Me.InstitutionManagementDatabaseDataSet.STUDENT_INFORMATION.AcceptChanges()
                loadGrid()
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class