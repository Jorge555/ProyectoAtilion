@ModelType IEnumerable(Of Proyecto_Analisis.ClienteDatosModel)


@Code
    Html.RenderPartial("Menu")
End Code

<form action="../Home/MostrarCliente" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="buscar" placeholder="Nombre">
        </div>
    

    </div>

    <button type="submit" class="btn btn-primary mt-5">Buscar</button>
</form>



   
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.Nombre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Apellido)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Direccion)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Telefono)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Apellido)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Telefono)
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
