Imports System.Threading.Tasks
Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home


        Function Menu() As ActionResult
            Return View()
        End Function

        '======orden de compra

        Function Orden_Compras() As ActionResult
            Return View()
        End Function

        Function Tipo_Orden() As ActionResult
            Dim obj As New ListaDatos
            Return View(obj)
        End Function


        <HttpPost>
        <AllowAnonymous>
        Public Async Function Registrar_Tipo_Orden(tip_ord As ListaDatos) As Task(Of ActionResult)

            Dim ord As New OrdenCompraDatos

            ord.Nombre = Request.Form("ord_nombre").ToString()
            ord.Fecha = Request.Form("ord_fecha").ToString()
            ord.Bod_id = tip_ord.id_bod
            ord.Ingresar_Orden(ord.Nombre, ord.Fecha, ord.Bod_id)

            Return View()
        End Function

        '=======generar Orden
        Function Generar_Orden() As ActionResult
            Dim obj As New ListaDatos
            Return View(obj)
        End Function
        <HttpPost>
        <AllowAnonymous>
        Public Async Function Agregar_Orden(pro As ListaDatos) As Task(Of ActionResult)

            Dim det As New DetalleOrdenDatos

            det.Cantidad = Convert.ToInt32(Request.Form("det_cantidad"))
            det.Ord_id = pro.id_tipOr
            det.Pro_id = pro.id
            det.Ingresar_DetalleO(det.Cantidad, det.Ord_id, det.Pro_id)

            Return View()
        End Function

        Function Mostrar_Orden() As ActionResult

            Dim ord As New OrdenCompraMostrar
            Dim buscar As String

            If Request.Form("buscar") = "" Then
                Return View(ord.Orden_Datos(""))
            End If
            buscar = Request.Form("buscar").ToString()
            Return View(ord.Orden_Datos(buscar))


        End Function



        '============EMPRESA
        Function Empresa() As ActionResult

            Return View()
        End Function

        Function Registrar_Empresa() As ActionResult

            Dim emp As New EmpresaDatos

            emp.Nombre = Request.Form("emp_nombre").ToString()
            emp.Direccion = Request.Form("emp_direccion").ToString()
            emp.Telefono = Request.Form("emp_telefono").ToString()
            emp.Ingresar_Empresa(emp.Nombre, emp.Direccion, emp.Telefono)

            Return View()
        End Function

        '=============ORIGEN
        Function Origen() As ActionResult

            Return View()
        End Function

        Function Registrar_Origen() As ActionResult
            Dim ori As New OrigenDatos

            ori.Nombre = Request.Form("ori_nombre").ToString()
            ori.Direccion = Request.Form("ori_direccion").ToString()
            ori.Ingresar_Origen(ori.Nombre, ori.Direccion)


            Return View()
        End Function

        '=============BODEGA

        Function Bodega() As ActionResult

            Dim obj As New ListaDatos


            Return View(obj)

        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Registrar_Bodega(EmOr As ListaDatos) As Task(Of ActionResult)

            Dim bod As New BodegaDatos
            bod.Nombre = Request.Form("bod_nombre").ToString()
            bod.Direccion = Request.Form("bod_direccion").ToString()

            bod.Emp_id = EmOr.id_emp
            bod.Ori_id = EmOr.id_ori
            bod.Ingresar_Bodega(bod.Nombre, bod.Direccion, bod.Emp_id, bod.Ori_id)
            Return View()
        End Function



        '=======productos 

        Function Productos() As ActionResult
            Return View()
        End Function

        Function Registrar_Productos() As ActionResult
            Return View()

        End Function

        Function Agregar_Productos() As ActionResult

            Dim pro As New ProductoDatos
            pro.Nombre = Request.Form("pro_nombre").ToString()
            pro.Stock = Convert.ToInt32(Request.Form("pro_stock"))
            pro.Precio = Convert.ToDouble(Request.Form("pro_precio"))
            pro.Descripcion = Request.Form("pro_descripcion").ToString()
            pro.Marca = Request.Form("pro_marca").ToString()

            pro.Ingresar_Producto(pro.Nombre, pro.Stock, pro.Precio, pro.Descripcion, pro.Marca)

            Return View()

        End Function

        Function Mostrar_Productos() As ActionResult
            Dim prom As New ProductoMostrar
            Dim buscar As String

            If Request.Form("buscar") = "" Then
                Return View(prom.Productos_Datos(""))
            End If
            buscar = Request.Form("buscar").ToString()
            Return View(prom.Productos_Datos(buscar))

        End Function


        '=====traslado

        Function Traslado() As ActionResult
            Return View()

        End Function

        Function Registrar_Traslado() As ActionResult
            Dim obj As New ListaDatos


            Return View(obj)
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Agregar_Traslado(bod As ListaDatos) As Task(Of ActionResult)
            Dim tras As New TrasladoDatos

            tras.Bodega_Entrada = Request.Form("bod_entrada").ToString
            tras.Bod_id = bod.id_bod
            tras.Ingresar_Traslado(tras.Bodega_Entrada, tras.Bod_id)
            Return View()
        End Function

        Function Generar_Traslado() As ActionResult
            Dim obj As New ListaDatos


            Return View(obj)
        End Function


        <HttpPost>
        <AllowAnonymous>
        Public Async Function Agregar_Traslado_Generadoo(tra As ListaDatos) As Task(Of ActionResult)

            Dim tras As New DetalleTrasladoDatos

            tras.Cantidad = Convert.ToInt32(Request.Form("detras_cantidad"))
            tras.Pro_id = tra.id
            tras.Tra_id = tra.id_tras
            tras.Ingresar_Detalle_Traslado(tras.Cantidad, tras.Pro_id, tras.Tra_id)
            Return View()
        End Function


        Function Mostrar_Traslado() As ActionResult
            Dim tras As New TrasladoMostrar
            Dim buscar As String

            If Request.Form("buscar") = "" Then
                Return View(tras.Traslado_Datos(""))
            End If
            buscar = Request.Form("buscar").ToString()
            Return View(tras.Traslado_Datos(buscar))

        End Function





        '========inventario

        Function Inventario() As ActionResult



            Return View()
        End Function

        Function Generar_Inventario() As ActionResult
            Dim obj As New ListaDatos


            Return View(obj)
        End Function

        Public Async Function Agregar_Inventario(invta As ListaDatos) As Task(Of ActionResult)

            Dim inv As New InventarioDatos

            inv.Cantidad = Convert.ToInt32(Request.Form("inv_cantidad"))
            inv.Pro_id = invta.id
            inv.Bod_id = invta.id_bod

            inv.Ingresar_Inventario(inv.Cantidad, inv.Pro_id, inv.Bod_id)
            Return View()
        End Function

        Function Mostrar_Inventario() As ActionResult
            Dim inv_Mos As New InventarioMostrar
            Dim buscar As String

            If Request.Form("buscar") = "" Then
                Return View(inv_Mos.Inventario_Datos(""))
            End If
            buscar = Request.Form("buscar").ToString()
            Return View(inv_Mos.Inventario_Datos(buscar))

        End Function



    End Class
End Namespace