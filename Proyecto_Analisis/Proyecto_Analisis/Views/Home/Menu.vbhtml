<!doctype html>
<html>

@Imports System.Web.Optimization

<head>
    <title></title>
    @Styles.Render("~/Content/css")
</head>
<body>
    <nav class="navbar navbar-dark bg-dark ">
        <a class="navbar-brand" href="">
            <img src="~/Imagenes/Boostrap_logo.svg" width="30" height="30" class="d-inline-block align-top" alt="">
            Empresa EL tigre
        </a>
    </nav>

    <nav class="navbar navbar-expand-lg navbar-light bg-light">

        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse justify-content-center " id="navbarNavAltMarkup">
            <div class="navbar-nav ">
                <a class="nav-item nav-link" href="../Home/Menu">Inicio</a>
                <a class="nav-item nav-link" href="../Home/Orden_Compras">Orden de Compras</a>
                <a class="nav-item nav-link" href="../Home/Inventario">Iventario</a>
                <a class="nav-item nav-link" href="../Home/Traslado">Traslado</a>
                <a class="nav-item nav-link" href="../Home/Productos">Productos</a>
            </div>
        </div>
    </nav>

