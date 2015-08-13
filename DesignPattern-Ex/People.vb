Imports System.ComponentModel

Public Class People
    Implements INotifyPropertyChanged

    Private _fullName As String
    Private _dob As Date
    Private _gender As GenderEnum

    Public Enum GenderEnum As Byte
        UNKNOWN
        MALE
        FEMALE
    End Enum

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

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

    Public Property GenderIsUnknown() As Boolean
        Get
            Return _gender = GenderEnum.Unknown
        End Get
        Set(ByVal value As Boolean)
            If value Then _gender = GenderEnum.Unknown
        End Set
    End Property

    Public Property GenderIsMale() As Boolean
        Get
            Return _gender = GenderEnum.Male
        End Get
        Set(ByVal value As Boolean)
            If value Then _gender = GenderEnum.Male
        End Set
    End Property

    Public Property GenderIsFemale() As Boolean
        Get
            Return _gender = GenderEnum.Female
        End Get
        Set(ByVal value As Boolean)
            If value Then _gender = GenderEnum.Female
        End Set
    End Property

    Public Function Query(ByVal PID As Long) As Boolean
        ' Mock query data
        _fullName = "สมชาย แซ่ตั้ง"
        _dob = New Date(2510 - 543, 8, 13)
        _gender = GenderEnum.MALE

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Nothing))

        Return True
    End Function

    Public Function Update() As String
        ' Mock update data
        Return String.Format("FullName = {1}{0}DOB = {2}{0}Gender = {3}", vbCrLf, _
                             _fullName, _dob.ToString("dd/MM/yyyy"), _gender.ToString())
    End Function
End Class
