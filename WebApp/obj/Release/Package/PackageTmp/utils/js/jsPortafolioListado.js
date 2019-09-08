$("document").ready(function () {
    $("#txtSemestre").autocomplete({
        source: function (request, response) {
            var datos = { "cTitulo": request.term };
            datos = JSON.stringify(datos)
            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "/appServicios/serSemestre.svc/busquedaSugeridaSemestres",
                data: datos,
                dataType: "json",
                dataFilter: function (data) { return data; },
                success: function (data) {
                    response($.map(data.d, function (item) {
                        return {
                            label: item.cTitulo,
                            value: item.cTitulo,
                            idSemestre: item.idSemestre
                        }
                    }))
                },
                error: function (xhr, status, errorThrown) {
                    //alert(errorThrown + '\n' + status + '\n' + xhr.statusText);
                }
            })
        },
        minLength: 3,
        select: function (event, ui) {
            $("#hfIdSemestre").val(ui.item.idSemestre)
        }
    });

    $(".linea").live("click", function () {
        var id = $(this).attr("rel");
        var pathname = window.location.pathname + "/detalle/" + id;
        location.href = pathname;
    });
});