$("document").ready(function () {
    $(".btnRemove").live("click", function () {
        $(this).parent().remove();
        actualizarID();
    });

    $("#txtProyecto").autocomplete({
        source: function (request, response) {
            var datos2 = { "cNombreCorto": request.term };
            datos2 = JSON.stringify(datos2)
            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "/appServicios/serProyecto.svc/busquedaSugeridaProyecto",
                data: datos2,
                dataType: "json",
                dataFilter: function (data) { return data; },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.cNombreCorto,
                            value: item.cNombreCorto,
                            idUsuarioAutor: item.idUsuarioAutor,
                            idProyecto: item.idProyecto,
                            idSemestre: item.idSemestre,
                            cNombre: item.cNombre,
                            cDescripcion: item.cDescripcion,
                            cCliente: item.cCliente,
                            dFechaRegisto: item.dFechaRegistro,
                            cAdjunto: item.cAdjunto,
                            nEstadoNatural: item.nEstadoNatural,
                            nEstado: item.nEstado,
                            cCorreo: item.cCorreo
                        }
                    }))
                },
                error: function (xhr, status, errorThrown) {
                    alert(errorThrown + '\n' + status + '\n' + xhr.statusText);
                }
            })
        },
        minLength: 2,
        select: function (event, ui) {
            $(".wrapContenido").append("<div class='linea' rel='" + ui.item.idProyecto + "'><div class='cNombreCorto'>" + ui.item.value + "</div><div class='cCliente'>" + ui.item.cCliente + "</div><div class='cAdjunto'><a href='/uitls/repo/usuarios/" + ui.item.idUsuarioAutor + "/" + ui.item.cAdjunto + "'>" + ui.item.cAdjunto + "</a></div><div class='btnRemove icon-trash'></div></div>");
            actualizarID();
        }
    });
});

function actualizarID() {
    var listaLinea = $(".linea");
    var mensaje = "";
    for (i = 0; i < listaLinea.length; i++) {
        mensaje += (i == length - 1) ? listaLinea.eq(i).attr("rel") : listaLinea.eq(i).attr("rel") + ",";
    }
    mensaje = mensaje.substring(0, mensaje.length - 1);
    $("#hfdIDproyectos").val(mensaje);
}