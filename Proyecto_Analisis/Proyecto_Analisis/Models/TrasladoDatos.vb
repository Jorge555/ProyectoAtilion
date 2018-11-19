Public Class TrasladoDatos

    Public Property tras_nombre As String
    Public Property Bodega_Entrada As String

    Public Property Bod_id As Integer



    Dim BD As New UsersDataDataContext
    Dim tras As New traslado

    Public Sub Ingresar_Traslado(ENTRADA As String, BOD_ID As Integer)

        tras.tra_bodegaEntrada = ENTRADA
        tras.bod_id = BOD_ID
        BD.traslado.InsertOnSubmit(tras)
        BD.SubmitChanges()
    End Sub


End Class
