@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 ">Iventario</h5>
    </a>
</nav>

<ul class="nav justify-content-center">


    <li class="nav-item">
        <a class="nav-link" href="Generar_Inventario">Generar Inventario</a>
    </li>

    <li class="nav-item">
        <a class="nav-link" href="Mostrar_Inventario">Buscar Inventario</a>
    </li>
   

</ul>






@Code
    Html.RenderPartial("Fooder")
End Code
