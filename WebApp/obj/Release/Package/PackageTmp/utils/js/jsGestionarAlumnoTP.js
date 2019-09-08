$("document").ready(function () {
    $("#form1").validate({
        focusCleanup: true,
        rules: {
            txtCodigoAlumno: {
                required: true,
                minlength: 9,
                digits: true
            },
            txtNombre: {
                required: true,
                minlength: 3
            },
            txtApPaterno: {
                required: true,
                minlength: 3
            },
            txtApMaterno: {
                required: true,
                minlength: 3
            },
        },
        messages: {
            txtCodigoAlumno: {
                required: "Ingrese un codigo",
                minlength: "Ingrese nueve 9 digitos",
                digits: "Solo digitos"
            },
            txtNombre: {
                required: "Ingrese un nombre",
                minlength: "Ingrese al menos 3 caracteres"
            },
            txtApPaterno: {
                minlength: "Ingrese al menos 3 caracteres",
                required: "Ingrese un apellido paterno"
            },
            txtApMaterno: {
                minlength: "Ingrese al menos 3 caracteres",
                required: "Ingrese un apellido materno"
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