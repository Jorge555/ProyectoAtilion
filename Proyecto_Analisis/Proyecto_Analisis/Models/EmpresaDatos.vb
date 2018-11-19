Public Class EmpresaDatos

    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Telefono As String


    Dim BD As New UsersDataDataContext
    Dim emp As New empresa

    Public Sub Ingresar_Empresa(NOMBRE As String, DIRECCION As String, TELEFONO As String)

        emp.emp_nombre = NOMBRE
        emp.emp_direccion = DIRECCION
        emp.emp_telefono = TELEFONO
        BD.empresa.InsertOnSubmit(emp)
        BD.SubmitChanges()
    End Sub


End Class
