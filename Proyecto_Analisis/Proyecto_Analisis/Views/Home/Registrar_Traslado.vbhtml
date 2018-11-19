@Code
    Html.RenderPartial("Menu")
End Code
@ModelType Proyecto_Analisis.ListaDatos

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 "> Registrar Traslado</h5>
    </a>
</nav>


<form action="../Home/Agregar_Traslado" method="post">


    <div class="form-row ">

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="bod_entrada" placeholder="Bodega Entrada">
        </div>

        
        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_bod", New SelectList(Model.bodegaList, "Value", "Text"), "Bodega Salida")
            </div>

        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>



@Code
    Html.RenderPartial("Fooder")
End Code
