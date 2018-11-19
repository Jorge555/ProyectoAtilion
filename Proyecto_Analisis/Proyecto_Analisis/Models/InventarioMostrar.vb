Public Class InventarioMostrar


    Dim userDC As New UsersDataDataContext
    Function Inventario_Datos(buscar As String) As List(Of InventarioDatosModel)

        Dim list As List(Of InventarioDatosModel) = New List(Of InventarioDatosModel)

        Dim query = From bod In userDC.bodega
                    Join inv In userDC.inventario On bod.bod_id Equals inv.bod_id
                    Join pro In userDC.productos On pro.pro_id Equals inv.pro_id

        If buscar = "" Then
            query = From bod In userDC.bodega
                    Join inv In userDC.inventario On bod.bod_id Equals inv.bod_id
                    Join pro In userDC.productos On pro.pro_id Equals inv.pro_id

        Else

            query = From bod In userDC.bodega
                    Join inv In userDC.inventario On bod.bod_id Equals inv.bod_id
                    Join pro In userDC.productos On pro.pro_id Equals inv.pro_id Where bod.bod_nombre = buscar Or pro.pro_nombre = buscar

        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New InventarioDatosModel() With {
                .Codigo = datos.inv.inv_id,
                .Bodega = datos.bod.bod_nombre,
                .Producto = datos.pro.pro_nombre,
                .Precio = datos.pro.pro_precio,
                .Cantidad = datos.inv.inv_cantidad,
                .Total = datos.inv.inv_costo_promedio
            })
        Next
        Return list
    End Function

End Class

Public Class InventarioDatosModel

    Public Property Codigo As String
    Public Property Bodega As String
    Public Property Producto As String

    Public Property Precio As String
    Public Property Cantidad As String
    Public Property Total As String



End Class