Public Class People
    Private _fullName As String
    Private _dob As Date
    Private _gender As GenderEnum

    Public Enum GenderEnum As Byte
        UNKNOWN
        MALE
        FEMALE
    End Enum

    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal value As String)
            _fullName = value
        End Set
    End Property

    Public Property DOB() As Date
        Get
            Return _dob
        End Get
        Set(ByVal value As Date)
            _dob = value
        End Set
    End Property

    Public Property Gender() As GenderEnum
        Get
            Return _gender
        End Get
        Set(ByVal value As GenderEnum)
            _gender = value
        End Set
    End Property

    Public Function Query(ByVal PID As Long) As Boolean
        ' Mock query data
        _fullName = "สมชาย แซ่ตั้ง"
        _dob = New Date(2510 - 543, 8, 13)
        _gender = GenderEnum.MALE

        Return True
    End Function

    Public Function Update() As String
        ' Mock update data
        Return String.Format("FullName = {1}{0}DOB = {2}{0}Gender = {3}", vbCrLf, _
                             _fullName, _dob.ToString("dd/MM/yyyy"), _gender.ToString())
    End Function
End Class
