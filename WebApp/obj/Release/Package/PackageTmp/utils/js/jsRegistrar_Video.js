$("document").ready(function () {
    $("#form1").validate({
        focusCleanup: true,
        rules: {
            txtLink: {
                required: true,
                minlength: 3
            },
            txtDescripcion: {
                required: true,
                minlength: 3,
                maxlength: 50
            },
            txtNombre: {
                required: true,
                minlength: 3,
                maxlength: 150
            }
        },
        messages: {
            txtLink: {
                required: "Ingrese un link de video",
                minlength: "Ingrese almenos 9 caracteres"
            }, txtDescripcion: {
                required: "Ingrese una descripcion",
                minlength: "Ingrese almenos 6 caracteres",
                maxlength: "Solo 50 caracteres"
            },
            txtNombre: {
                required: "Ingrese un nombre",
                minlength: "Ingrese al menos 3 caracteres",
                maxlength: "Solo 150 caracteres"
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