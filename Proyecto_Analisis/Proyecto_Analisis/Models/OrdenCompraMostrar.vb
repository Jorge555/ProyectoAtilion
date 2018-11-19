Public Class OrdenCompraMostrar


    Dim userDC As New UsersDataDataContext
    Function Orden_Datos(buscar As String) As List(Of OrdenCompraDatosModel)

        Dim list As List(Of OrdenCompraDatosModel) = New List(Of OrdenCompraDatosModel)

        Dim query = From emp In userDC.empresa
                    Join bod In userDC.bodega On emp.emp_id Equals bod.emp_id
                    Join ori In userDC.origen On bod.ori_id Equals ori.ori_id
                    Join ord In userDC.orden_compra On bod.bod_id Equals ord.bod_id
                    Join det In userDC.detalle_orden On ord.ord_id Equals det.ord_id
                    Join pro In userDC.productos On det.pro_id Equals pro.pro_id

        If buscar = "" Then
            query = From emp In userDC.empresa
                    Join bod In userDC.bodega On emp.emp_id Equals bod.emp_id
                    Join ori In userDC.origen On bod.ori_id Equals ori.ori_id
                    Join ord In userDC.orden_compra On bod.bod_id Equals ord.bod_id
                    Join det In userDC.detalle_orden On ord.ord_id Equals det.ord_id
                    Join pro In userDC.productos On det.pro_id Equals pro.pro_id

        Else
            query = From emp In userDC.empresa
                    Join bod In userDC.bodega On emp.emp_id Equals bod.emp_id
                    Join ori In userDC.origen On bod.ori_id Equals ori.ori_id
                    Join ord In userDC.orden_compra On bod.bod_id Equals ord.bod_id
                    Join det In userDC.detalle_orden On ord.ord_id Equals det.ord_id
                    Join pro In userDC.productos On det.pro_id Equals pro.pro_id Where bod.bod_nombre = buscar Or ord.ord_nombre = buscar
        End If


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New OrdenCompraDatosModel() With {
                .Empresa = datos.emp.emp_nombre,
                .Origen = datos.ori.ori_nombre,
                .Bodega = datos.bod.bod_nombre,
                .Orden = datos.ord.ord_nombre,
                .Fecha = datos.ord.ord_fecha,
                .Producto = datos.pro.pro_nombre,
                .Precio = datos.pro.pro_precio,
                .Cantidad = datos.det.det_cantidad,
                .Total = datos.det.det_total
            })
        Next
        Return list
    End Function

End Class

Public Class OrdenCompraDatosModel

    Public Property Empresa As String
    Public Property Origen As String
    Public Property Bodega As String
    Public Property Orden As String
    Public Property Fecha As String
    Public Property Producto As String
    Public Property Precio As String
    Public Property Cantidad As String
    Public Property Total As String



End Class