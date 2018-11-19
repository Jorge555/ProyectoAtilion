@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="index.html">

        <h5 class="display-5 ">Empleado</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="MostrarEmpleado">Buscar</a>
    </li>

</ul>



<form action="../Home/AgregarEmpleado" method="post">

    <div class="form-row mt-5 ">
        <div class="col">
            <input type="text" class="form-control" name="nombre" placeholder="Nombre">
        </div>
        <div class="col">
            <input type="text" class="form-control" name="apellido" placeholder="Apellido">
        </div>
        <div class="col">
            <input type="text" class="form-control" name="direccion" placeholder="Direccion">
        </div>
        <div class="col">
            <input type="text" class="form-control" name="telefono" placeholder="Telefono">
        </div>

    </div>

    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>












@Code
    Html.RenderPartial("Fooder")
End Code
