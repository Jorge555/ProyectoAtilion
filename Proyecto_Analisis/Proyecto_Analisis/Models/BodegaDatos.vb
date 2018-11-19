Public Class BodegaDatos

    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Emp_id As Integer
    Public Property Ori_id As Integer



    Dim BD As New UsersDataDataContext
    Dim bod As New bodega

    Public Sub Ingresar_Bodega(NOMBRE As String, DIRECCION As String, EMP_ID As Integer, ORI_ID As Integer)

        bod.bod_nombre = NOMBRE
        bod.bod_direccion = DIRECCION
        bod.emp_id = EMP_ID
        bod.ori_id = ORI_ID
        BD.bodega.InsertOnSubmit(bod)
        BD.SubmitChanges()
    End Sub


End Class
