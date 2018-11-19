Public Class TrasladoMostrar



    Dim userDC As New UsersDataDataContext
    Function Traslado_Datos(buscar As String) As List(Of TrasladoDatosModel)

        Dim list As List(Of TrasladoDatosModel) = New List(Of TrasladoDatosModel)

        Dim query = From bod In userDC.bodega
                    Join tra In userDC.traslado On bod.bod_id Equals tra.bod_id
                    Join det In userDC.detalle_traslado On tra.tra_id Equals det.tra_id
                    Join pro In userDC.productos On pro.pro_id Equals det.pro_id

        If buscar = "" Then
            query = From bod In userDC.bodega
                    Join tra In userDC.traslado On bod.bod_id Equals tra.bod_id
                    Join det In userDC.detalle_traslado On tra.tra_id Equals det.tra_id
                    Join pro In userDC.productos On pro.pro_id Equals det.pro_id

        Else

            query = From bod In userDC.bodega
                    Join tra In userDC.traslado On bod.bod_id Equals tra.bod_id
                    Join det In userDC.detalle_traslado On tra.tra_id Equals det.tra_id
                    Join pro In userDC.productos On pro.pro_id Equals det.pro_id Where bod.bod_nombre = buscar Or pro.pro_nombre = buscar
        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New TrasladoDatosModel() With {
               .Codigo = datos.bod.bod_id,
               .Bodega_Salida = datos.bod.bod_nombre,
               .Bodega_Entrada = datos.tra.tra_bodegaEntrada,
               .Cantidad = datos.det.detras_cantidad,
               .Producto = datos.pro.pro_nombre,
               .Precio = datos.pro.pro_precio,
               .Descripcion = datos.pro.pro_descripcion
            })
        Next
        Return list
    End Function

End Class

Public Class TrasladoDatosModel

    Public Property Codigo As String
    Public Property Bodega_Salida As String
    Public Property Bodega_Entrada As String
    Public Property Cantidad As String
    Public Property Producto As String
    Public Property Precio As String
    Public Property Descripcion As String



End Class