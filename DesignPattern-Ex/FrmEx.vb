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
    End Sub

    Private Sub DtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDOB.ValueChanged
        pop.DOB = DtpDOB.Value
    End Sub

    Private Sub RdoGenderUnknown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoGenderUnknown.CheckedChanged
        If RdoGenderUnknown.Checked Then pop.Gender = People.GenderEnum.UNKNOWN
    End Sub

    Private Sub RdoGenderMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoGenderMale.CheckedChanged
        If RdoGenderMale.Checked Then pop.Gender = People.GenderEnum.MALE
    End Sub

    Private Sub RdoGenderFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoGenderFemale.CheckedChanged
        If RdoGenderFemale.Checked Then pop.Gender = People.GenderEnum.FEMALE
    End Sub

    Private Sub BtnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuery.Click
        If Not pop.Query(1234567890123) Then Return

        ShowPOP()
        EnableControl()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim popData As String = pop.Update()

        MessageBox.Show(popData)
    End Sub

    Private Sub ShowPOP()
        LblFullName.Text = pop.FullName
        DtpDOB.Value = pop.DOB

        Select Case pop.Gender
            Case People.GenderEnum.UNKNOWN : RdoGenderUnknown.Checked = True
            Case People.GenderEnum.MALE : RdoGenderMale.Checked = True
            Case People.GenderEnum.FEMALE : RdoGenderFemale.Checked = True
        End Select
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
