@ModelType IEnumerable(Of Proyecto_Analisis.EmpleadoDatosModel)


@Code
    Html.RenderPartial("Menu")
End Code


<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
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
