<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEx
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblFullName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.RdoGenderUnknown = New System.Windows.Forms.RadioButton
        Me.RdoGenderMale = New System.Windows.Forms.RadioButton
        Me.RdoGenderFemale = New System.Windows.Forms.RadioButton
        Me.BtnQuery = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.PeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'LblFullName
        '
        Me.LblFullName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFullName.AutoSize = True
        Me.LblFullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PeopleBindingSource, "FullName", True))
        Me.LblFullName.Enabled = False
        Me.LblFullName.Location = New System.Drawing.Point(109, 34)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(77, 16)
        Me.LblFullName.TabIndex = 1
        Me.LblFullName.Text = "LblFullName"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Birth"
        '
        'DtpDOB
        '
        Me.DtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PeopleBindingSource, "DOB", True))
        Me.DtpDOB.Enabled = False
        Me.DtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDOB.Location = New System.Drawing.Point(112, 53)
        Me.DtpDOB.Name = "DtpDOB"
        Me.DtpDOB.Size = New System.Drawing.Size(103, 23)
        Me.DtpDOB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'RdoGenderUnknown
        '
        Me.RdoGenderUnknown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RdoGenderUnknown.AutoSize = True
        Me.RdoGenderUnknown.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PeopleBindingSource, "GenderIsUnknown", True))
        Me.RdoGenderUnknown.Enabled = False
        Me.RdoGenderUnknown.Location = New System.Drawing.Point(112, 82)
        Me.RdoGenderUnknown.Name = "RdoGenderUnknown"
        Me.RdoGenderUnknown.Size = New System.Drawing.Size(78, 20)
        Me.RdoGenderUnknown.TabIndex = 5
        Me.RdoGenderUnknown.TabStop = True
        Me.RdoGenderUnknown.Text = "Unknown"
        Me.RdoGenderUnknown.UseVisualStyleBackColor = True
        '
        'RdoGenderMale
        '
        Me.RdoGenderMale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RdoGenderMale.AutoSize = True
        Me.RdoGenderMale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PeopleBindingSource, "GenderIsMale", True))
        Me.RdoGenderMale.Enabled = False
        Me.RdoGenderMale.Location = New System.Drawing.Point(112, 108)
        Me.RdoGenderMale.Name = "RdoGenderMale"
        Me.RdoGenderMale.Size = New System.Drawing.Size(53, 20)
        Me.RdoGenderMale.TabIndex = 6
        Me.RdoGenderMale.TabStop = True
        Me.RdoGenderMale.Text = "Male"
        Me.RdoGenderMale.UseVisualStyleBackColor = True
        '
        'RdoGenderFemale
        '
        Me.RdoGenderFemale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RdoGenderFemale.AutoSize = True
        Me.RdoGenderFemale.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PeopleBindingSource, "GenderIsFemale", True))
        Me.RdoGenderFemale.Enabled = False
        Me.RdoGenderFemale.Location = New System.Drawing.Point(112, 134)
        Me.RdoGenderFemale.Name = "RdoGenderFemale"
        Me.RdoGenderFemale.Size = New System.Drawing.Size(68, 20)
        Me.RdoGenderFemale.TabIndex = 7
        Me.RdoGenderFemale.TabStop = True
        Me.RdoGenderFemale.Text = "Female"
        Me.RdoGenderFemale.UseVisualStyleBackColor = True
        '
        'BtnQuery
        '
        Me.BtnQuery.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnQuery.Location = New System.Drawing.Point(42, 160)
        Me.BtnQuery.Name = "BtnQuery"
        Me.BtnQuery.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuery.TabIndex = 8
        Me.BtnQuery.Text = "Query"
        Me.BtnQuery.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.Location = New System.Drawing.Point(123, 160)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'PeopleBindingSource
        '
        Me.PeopleBindingSource.DataSource = GetType(DesignPattern_Ex.People)
        '
        'FrmEx
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(242, 216)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnQuery)
        Me.Controls.Add(Me.RdoGenderFemale)
        Me.Controls.Add(Me.RdoGenderMale)
        Me.Controls.Add(Me.RdoGenderUnknown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpDOB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblFullName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MinimumSize = New System.Drawing.Size(250, 250)
        Me.Name = "FrmEx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Design Pattern"
        CType(Me.PeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblFullName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RdoGenderUnknown As System.Windows.Forms.RadioButton
    Friend WithEvents RdoGenderMale As System.Windows.Forms.RadioButton
    Friend WithEvents RdoGenderFemale As System.Windows.Forms.RadioButton
    Friend WithEvents BtnQuery As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents PeopleBindingSource As System.Windows.Forms.BindingSource

End Class
