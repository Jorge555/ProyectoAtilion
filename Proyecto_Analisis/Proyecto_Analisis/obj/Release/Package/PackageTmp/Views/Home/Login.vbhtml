
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    @Styles.Render("~/Content/css")
</head>
<body>
    <div class="nav justify-content-center">

        <form action="../Home/Login" method="post">

            <div class="form-group">
                <label for="exampleInputEmail1">Email address</label>
                <input type="text" class="form-control" name="usuario" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input type="password" class="form-control" name="password" id="exampleInputPassword1" placeholder="Password">
            </div>
            <div class="form-group form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1">
                <label class="form-check-label" for="exampleCheck1">Check me out</label>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>

        </form>



    </div>
</body>
</html>
