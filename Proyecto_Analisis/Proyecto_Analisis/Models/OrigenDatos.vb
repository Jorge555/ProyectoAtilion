Public Class OrigenDatos

    Public Property Nombre As String
    Public Property Direccion As String



    Dim BD As New UsersDataDataContext
    Dim ori As New origen

    Public Sub Ingresar_Origen(NOMBRE As String, DIRECCION As String)

        ori.ori_nombre = NOMBRE
        ori.ori_direccion = DIRECCION
        BD.origen.InsertOnSubmit(ori)
        BD.SubmitChanges()
    End Sub




End Class
