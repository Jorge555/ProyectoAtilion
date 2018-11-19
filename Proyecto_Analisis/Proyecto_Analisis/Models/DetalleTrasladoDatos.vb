Public Class DetalleTrasladoDatos


    Public Property Cantidad As Integer
    Public Property Pro_id As Integer
    Public Property Tra_id As Integer


    Dim BD As New UsersDataDataContext
    Dim detras As New detalle_traslado

    Public Sub Ingresar_Detalle_Traslado(CANTIDAD As Integer, PRO_ID As Integer, TRA_ID As Integer)

        detras.detras_cantidad = CANTIDAD
        detras.pro_id = PRO_ID
        detras.tra_id = TRA_ID
        BD.detalle_traslado.InsertOnSubmit(detras)
        BD.SubmitChanges()
    End Sub

End Class
