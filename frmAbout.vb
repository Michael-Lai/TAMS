Public NotInheritable Class frmAbout
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Time Attendance Management System"
        'Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString

        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCopyright.Text = "Copyright Protected By MIS Department"
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.LabelCompanyName.Text = "Power Office Solution"
        'Me.TextBoxDescription.Text = My.Application.Info.Description
        Me.TextBoxDescription.Text = "Times Attendance Management System Develop By MIS Department. It is the monitoring of employee work hours for the entire organization and the calculation of various important figures (such as accrued benefits) that are derived from employee work hours. The objective is to determine, without much hassle and time wastage, the attendance and time spent at work by each employee."
    End Sub
End Class
