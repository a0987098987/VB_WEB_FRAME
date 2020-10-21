'------------------------------------------------------------------------------
' <auto-generated>
'    這個程式碼是由範本產生。
'
'    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
'    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Employees
    Public Property EmployeeID As Integer
    Public Property LastName As String
    Public Property FirstName As String
    Public Property Title As String
    Public Property TitleOfCourtesy As String
    Public Property BirthDate As Nullable(Of Date)
    Public Property HireDate As Nullable(Of Date)
    Public Property Address As String
    Public Property City As String
    Public Property Region As String
    Public Property PostalCode As String
    Public Property Country As String
    Public Property HomePhone As String
    Public Property Extension As String
    Public Property Photo As Byte()
    Public Property Notes As String
    Public Property ReportsTo As Nullable(Of Integer)
    Public Property PhotoPath As String

    Public Overridable Property Employees1 As ICollection(Of Employees) = New HashSet(Of Employees)
    Public Overridable Property Employees2 As Employees
    Public Overridable Property Orders As ICollection(Of Orders) = New HashSet(Of Orders)
    Public Overridable Property Territories As ICollection(Of Territories) = New HashSet(Of Territories)

End Class
