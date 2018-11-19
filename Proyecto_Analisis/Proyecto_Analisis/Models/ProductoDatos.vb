Public Class ProductoDatos

    Public Property Nombre As String
    Public Property Stock As Integer
    Public Property Precio As Double
    Public Property Descripcion As String
    Public Property Marca As String


    Dim BD As New UsersDataDataContext
    Dim pro As New productos

    Public Sub Ingresar_Producto(NOMBRE As String, STOCK As Integer, PRECIO As Double, DESCRIPCION As String, MARCA As String)

        pro.pro_nombre = NOMBRE
        pro.pro_stock = STOCK
        pro.pro_precio = PRECIO
        pro.pro_descripcion = DESCRIPCION
        pro.pro_marca = MARCA
        BD.productos.InsertOnSubmit(pro)
        BD.SubmitChanges()
    End Sub


End Class
