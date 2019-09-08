$("document").ready(function () {
    $("#form1").validate({
        focusCleanup: true,
        rules: {
            txtidusuario: {
                required: true,
                minlength: 9
            },
            txtContraseña: {
                required: true,
                minlength: 6                
            },
            txtNombre: {
                required: true,
                minlength: 3
            },
            txtPaterno: {
                required: true,
                minlength: 3
            },
            txtMaterno: {
                required: true,
                minlength: 3
            },
            txtCorreo: {
                required: true,
                email: true
            }
        },
        messages: {
            txtidusuario: {
                required: "Ingrese un codigo",
                minlength: "Ingrese nueve 9 digitos"
            }, txtContraseña: {
                required: "Ingrese una contrase&ntilde;a",
                minlength: "Ingrese almenos 6 caracteres"
            },
            txtNombre: {
                required: "Ingrese un nombre",
                minlength: "Ingrese al menos 3 caracteres"
            },
            txtPaterno: {
                minlength: "Ingrese al menos 3 caracteres",
                required: "Ingrese un apellido paterno"
            },
            txtMaterno: {
                minlength: "Ingrese al menos 3 caracteres",
                required: "Ingrese un apellido materno"
            },
            txtCorreo: {
                required: "Ingrese un correo",
                email: "Ingrese un correo valido"
            }
        }
        ,
        errorPlacement: function (error, element) {
            element.next().empty().text(error.html());
        }, success: function (label) {
            label.parent().hide();
        }
    });
});