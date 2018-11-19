@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Productos">

        <h5 class="display-5 ">Productos</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    <li class="nav-item">
        <a class="nav-link" href="Registrar_Productos">Registrar Productos</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="Mostrar_Productos">Buscar Productos</a>
    </li>

</ul>






@Code
    Html.RenderPartial("Fooder")
End Code
