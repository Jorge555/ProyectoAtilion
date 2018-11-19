Public Class InventarioDatos
    Public Property Cantidad As Integer
    Public Property Total As Double
    Public Property Pro_id As Integer
    Public Property Bod_id As Integer


    Dim BD As New UsersDataDataContext
    Dim inv As New inventario
    Dim pro As New productos

    Public Sub Ingresar_Inventario(CANTIDAD As Integer, PRO_ID As Integer, BOD_ID As Integer)
        Dim aux_precio, aux_total As Integer

        Dim query = From u In BD.productos Where u.pro_id = PRO_ID Select u

        If query.Count() > 0 Then

            Dim datos = query.ToList()

            For Each Dato In datos
                aux_precio = Dato.pro_precio
            Next

        End If
        aux_total = CANTIDAD * aux_precio

        inv.inv_cantidad = CANTIDAD
        inv.inv_costo_promedio = aux_total
        inv.pro_id = PRO_ID
        inv.bod_id = PRO_ID


        BD.inventario.InsertOnSubmit(inv)
        BD.SubmitChanges()
    End Sub


End Class
