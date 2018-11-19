@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Orden_Compras">

        <h5 class="display-5 ">Orden de Compras</h5>
    </a>
</nav>

<ul class="nav justify-content-center">
    

    <li class="nav-item">
        <a class="nav-link" href="Empresa">Registrar Empresa</a>
    </li>

    <li class="nav-item">
        <a class="nav-link" href="Origen">Registrar Origen</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="Bodega">Registrar Bodega</a>
    </li>

    <li class="nav-item">
        <a class="nav-link" href="Tipo_Orden">Tipo de Orden</a>
    </li>

    <li class="nav-item">
        <a class="nav-link" href="Generar_Orden">Generar Orden</a>
    </li>
    

    <li class="nav-item">
        <a class="nav-link" href="Mostrar_Orden">Buscar Orden</a>
    </li>

</ul>






@Code
    Html.RenderPartial("Fooder")
End Code
