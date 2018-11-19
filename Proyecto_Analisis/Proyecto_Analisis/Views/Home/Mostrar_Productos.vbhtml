@ModelType IEnumerable(Of Proyecto_Analisis.ProductooDatosModel)


@Code
    Html.RenderPartial("Menu")
End Code

<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 ">Mostrar Productos</h5>
    </a>
</nav>

<form action="../Home/Mostrar_Productos" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>


    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>




<p>
    @Html.ActionLink("Atras", "Productos")
</p>


    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Nombre)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Stock)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Precio)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Descripcion)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Marca)
                </th>
                <th></th>
            </tr>
        </thead>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Nombre)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Stock)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Precio)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Descripcion)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Marca)
                    </td>
                    <td>
                        @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
                    </td>
                </tr>
            Next

</table>

@Code
    Html.RenderPartial("Fooder")
End Code
