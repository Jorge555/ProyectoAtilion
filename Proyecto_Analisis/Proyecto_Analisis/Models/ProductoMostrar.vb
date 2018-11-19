Public Class ProductoMostrar


    Dim userDC As New UsersDataDataContext
    Function Productos_Datos(buscar As String) As List(Of ProductooDatosModel)

        Dim list As List(Of ProductooDatosModel) = New List(Of ProductooDatosModel)

        Dim query = From u In userDC.productos

        If buscar = "" Then
            query = From u In userDC.productos

        Else
            query = From u In userDC.productos Where u.pro_nombre = buscar Or u.pro_marca = buscar

        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New ProductooDatosModel() With {
                .Nombre = datos.pro_nombre,
                .Stock = datos.pro_stock,
                .Precio = datos.pro_precio,
                .Descripcion = datos.pro_descripcion,
                .Marca = datos.pro_marca
            })
        Next
        Return list
    End Function

End Class

Public Class ProductooDatosModel

    Public Property Nombre As String
    Public Property Stock As Integer
    Public Property Precio As Double
    Public Property Descripcion As String
    Public Property Marca As String


End Class