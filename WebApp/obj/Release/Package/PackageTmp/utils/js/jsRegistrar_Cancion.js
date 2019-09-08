$("document").ready(function () {
    $("#form1").validate({
        focusCleanup: true,
        rules: {
            txtNombre: {
                required: true,
                minlength: 3,
                maxlength: 150
            },
            txtDescripcion: {
                required: true,
                minlength: 3,
                maxlength: 255
            }
        },
        messages: {
            txtNombre: {
                required: "Ingrese un nombre",
                minlength: "Ingrese almenos 3 caracteres",
                maxlength: "Solo 150 caracteres"
            }, txtDescripcion: {
                required: "Ingrese una descripcion",
                minlength: "Ingrese almenos 3 caracteres",
                maxlength: "Solo 255 caracteres"
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