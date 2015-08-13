Public Class FrmEx

    Private pop As People

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblFullName.Text = "-"
    End Sub

    Private Sub FrmEx_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pop = New People()
        PeopleBindingSource.DataSource = pop
    End Sub

    Private Sub BtnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuery.Click
        If Not pop.Query(1234567890123) Then Return

        EnableControl()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim popData As String = pop.Update()

        MessageBox.Show(popData)
    End Sub

    Private Sub EnableControl()
        LblFullName.Enabled = True
        DtpDOB.Enabled = True
        RdoGenderUnknown.Enabled = True
        RdoGenderMale.Enabled = True
        RdoGenderFemale.Enabled = True
        BtnUpdate.Enabled = True
    End Sub
End Class
