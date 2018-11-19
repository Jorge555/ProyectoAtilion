Imports System.Web.Mvc

Public Class ListaDatos


    Public Property productoList As List(Of SelectListItem)
    Public Property id As Integer

    Public Property empresaList As List(Of SelectListItem)
    Public Property id_emp As Integer

    Public Property origenList As List(Of SelectListItem)
    Public Property id_ori As Integer

    Public Property bodegaList As List(Of SelectListItem)
    Public Property id_tipOr As Integer

    Public Property tipo_orden_List As List(Of SelectListItem)
    Public Property id_bod As Integer
    Public Property trasladoList As List(Of SelectListItem)
    Public Property id_tras As Integer

    'Lista de puesto
    Sub New()

        Dim ds As New UsersDataDataContext()
        productoList = New List(Of SelectListItem)
        Dim Query = From u In ds.productos Select u
        Dim listaData = Query.ToList()
        For Each Dato In listaData
            productoList.Add(New SelectListItem() With {
                  .Value = Dato.pro_id.ToString(),
                  .Text = Dato.pro_nombre
            })
        Next


        Dim ds1 As New UsersDataDataContext()
        empresaList = New List(Of SelectListItem)
        Dim Query1 = From u In ds1.empresa Select u
    Dim listaData1 = Query1.ToList()
        For Each Dato1 In listaData1
            empresaList.Add(New SelectListItem() With {
                  .Value = Dato1.emp_id.ToString(),
                  .Text = Dato1.emp_nombre
            })
        Next

        Dim ds3 As New UsersDataDataContext()
        bodegaList = New List(Of SelectListItem)
        Dim Query3 = From u In ds3.bodega Select u
        Dim listaData3 = Query3.ToList()
        For Each Dato3 In listaData3
            bodegaList.Add(New SelectListItem() With {
                  .Value = Dato3.bod_id.ToString(),
                  .Text = Dato3.bod_nombre
            })
        Next

        Dim ds4 As New UsersDataDataContext()
        origenList = New List(Of SelectListItem)
        Dim Query4 = From u In ds3.origen Select u
        Dim listaData4 = Query4.ToList()
        For Each Dato4 In listaData4
            origenList.Add(New SelectListItem() With {
                  .Value = Dato4.ori_id.ToString(),
                  .Text = Dato4.ori_nombre
            })
        Next



        Dim ds5 As New UsersDataDataContext()
        tipo_orden_List = New List(Of SelectListItem)
        Dim Query5 = From u In ds3.orden_compra Select u
        Dim listaData5 = Query5.ToList()
        For Each Dato5 In listaData5
            tipo_orden_List.Add(New SelectListItem() With {
                  .Value = Dato5.ord_id.ToString(),
                  .Text = Dato5.ord_nombre
            })
        Next




        Dim ds6 As New UsersDataDataContext()
        trasladoList = New List(Of SelectListItem)
        Dim Query6 = From u In ds6.traslado Select u
        Dim listaData6 = Query6.ToList()
        For Each Dato6 In listaData6
            trasladoList.Add(New SelectListItem() With {
                  .Value = Dato6.tra_id.ToString(),
                  .Text = Dato6.tra_bodegaEntrada
            })
        Next


    End Sub



End Class
