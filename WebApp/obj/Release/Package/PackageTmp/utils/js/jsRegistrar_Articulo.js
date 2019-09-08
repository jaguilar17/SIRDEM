﻿$("document").ready(function () {
    $("#form1").validate({
        focusCleanup: true,
        rules: {
            txtNombre: {
                required: true,
                minlength: 3,
                maxlength: 50
            },
            txtDescripcion: {
                required: true,
                minlength: 3,
                maxlength: 100
            }
        },
        messages: {
            txtNombre: {
                required: "Ingrese un nombre",
                minlength: "Ingrese almenos 3 caracteres",
                maxlength: "Solo 50 caracteres"
            }, txtDescripcion: {
                required: "Ingrese una descripcion",
                minlength: "Ingrese almenos 3 caracteres",
                maxlength: "Solo 100 caracteres"
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