﻿@ModelType IEnumerable(Of Proyecto_Analisis.InventarioDatosModel)


@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 ">Mostrar Inventario</h5>
    </a>
</nav>

<form action="../Home/Mostrar_Inventario" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>




<p>
    @Html.ActionLink("Atras", "Inventario")
</p>



    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Codigo)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Bodega)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Producto)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Precio)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Cantidad)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Total)
                </th>
                <th></th>
            </tr>

        </thead>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Codigo)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Bodega)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Producto)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Precio)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Cantidad)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Total)
                    </td>
                    <td>
                        @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
                    </td>
                </tr>
            Next

</table>
</body>
</html>