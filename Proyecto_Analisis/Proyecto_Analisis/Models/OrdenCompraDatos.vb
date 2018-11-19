Public Class OrdenCompraDatos
    Public Property Nombre As String
    Public Property Fecha As String
    Public Property Bod_id As Integer



    Dim BD As New UsersDataDataContext
    Dim ord As New orden_compra

    Public Sub Ingresar_Orden(NOMBRE As String, FECHA As String, BOD_ID As Integer)

        ord.ord_nombre = NOMBRE
        ord.ord_fecha = FECHA
        ord.bod_id = BOD_ID
        BD.orden_compra.InsertOnSubmit(ord)
        BD.SubmitChanges()
    End Sub

    Public Function Orden_Id(DATO_NOMBRE As String)

        Dim _id As Integer

        Dim Query = From u In BD.orden_compra Where u.ord_nombre = DATO_NOMBRE Select u

        If Query.Count() > 0 Then

            Dim datos = Query.ToList()

            For Each Dato In datos
                _id = Dato.ord_id
            Next

        End If
        Return _id
    End Function


End Class
