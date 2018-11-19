@Code
    Html.RenderPartial("Menu")
End Code


<nav class="navbar navbar-dark bg-primary justify-content-center ">
    <a class="navbar-brand" href="">

        <h5 class="display-5 ">Registrar Origen</h5>
    </a>
</nav>


<form action="../Home/Registrar_Origen" method="post">

    <div class="form-row ">
        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="ori_nombre" placeholder="Nombre">
        </div>

        <div class="form-group col-md-6">
            <input type="text" class="form-control" name="ori_direccion" placeholder="Direccion">
        </div>
    </div>


    <button type="submit" class="btn btn-primary mt-5">Registrar</button>
</form>



@Code
    Html.RenderPartial("Fooder")
End Code
