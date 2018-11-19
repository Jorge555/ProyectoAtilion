@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="Registrar_Productos">

        <h5 class="display-5 ">Registrar Productos</h5>
    </a>
</nav>


<form action="../Home/Agregar_Productos" method="post">

    <div class="form-row ">
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pro_nombre" placeholder="Nombre">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pro_stock" placeholder="Stock">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pro_precio" placeholder="Precio">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pro_descripcion" placeholder="Descripcion">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="pro_marca" placeholder="Marca">
        </div>


    </div>



    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>






@Code
    Html.RenderPartial("Fooder")
End Code
