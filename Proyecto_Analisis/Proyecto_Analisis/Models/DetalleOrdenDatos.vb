Public Class DetalleOrdenDatos



    Public Property Cantidad As Integer
    Public Property Precio As Double
    Public Property Total As Double
    Public Property Ord_id As Integer
    Public Property Pro_id As Integer



    Dim BD As New UsersDataDataContext
    Dim det As New detalle_orden
    Dim pro As New productos

    Public Sub Ingresar_DetalleO(CANTIDAD As Integer, ORD_ID As Integer, PRO_ID As Integer)
        Dim aux_precio, aux_total As Integer
        Dim query = From u In BD.productos Where u.pro_id = PRO_ID Select u

        If query.Count() > 0 Then

            Dim datos = query.ToList()

            For Each Dato In datos
                aux_precio = Dato.pro_precio
            Next

        End If
        aux_total = CANTIDAD * aux_precio

        det.det_cantidad = CANTIDAD
        det.det_precio = aux_precio
        det.det_total = aux_total
        det.ord_id = ORD_ID
        det.pro_id = PRO_ID

        BD.detalle_orden.InsertOnSubmit(det)
        BD.SubmitChanges()
    End Sub


End Class
