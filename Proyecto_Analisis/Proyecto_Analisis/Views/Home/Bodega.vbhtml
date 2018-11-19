@Code
    Html.RenderPartial("Menu")
End Code
@ModelType Proyecto_Analisis.ListaDatos

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 "> Registrar Bodega</h5>
    </a>
</nav>


<form action="../Home/Registrar_Bodega" method="post">

  
    <div class="form-row ">
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="bod_nombre" placeholder="Nombre">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="bod_direccion" placeholder="Direccion">
        </div>
        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_emp", New SelectList(Model.empresaList, "Value", "Text"), "Empresa")
            </div>

        </div>

        <div Class="col-md-4 mb-3">

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div Class="col-md-4 mb-3">
                @Html.DropDownList("id_ori", New SelectList(Model.origenList, "Value", "Text"), "Origen")
            </div>

        </div>

    </div>

    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>



@Code
    Html.RenderPartial("Fooder")
End Code
