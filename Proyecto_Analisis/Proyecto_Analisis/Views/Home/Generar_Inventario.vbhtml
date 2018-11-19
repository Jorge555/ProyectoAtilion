@Code
    Html.RenderPartial("Menu")
End Code
@ModelType Proyecto_Analisis.ListaDatos

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 ">Generar Inventario</h5>
    </a>
</nav>


<form action="../Home/Agregar_Inventario" method="post">




    <div class="form-row ">

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="inv_cantidad" placeholder="Cantidad">
        </div>

        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id", New SelectList(Model.productoList, "Value", "Text"), "Producto")
            </div>

        </div>

        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_bod", New SelectList(Model.bodegaList, "Value", "Text"), "Bodega")
            </div>

        </div>
    </div>



    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>






@Code
    Html.RenderPartial("Fooder")
End Code
