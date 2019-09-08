var listaAlumnos = [];
$("document").ready(function () {
    $("#txtCodUniversidad").autocomplete({
        source: function (request, response) {
            var datos = { "cCodUniversidad": request.term };
            datos = JSON.stringify(datos)
            $.ajax({
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "/appServicios/serUsuario.svc/busquedaSugeridaAlumnos",
                data: datos,
                dataType: "json",
                dataFilter: function (data) { return data; },
                success: function (data) {
                    response($.map(data.d, function (item) {
                        return {
                            label: item.cCodUniversidad,
                            value: item.cCodUniversidad,
                            idAlumno: item.objENT_Alumno.idAlumno,
                            idPerfil: item.idPerfil,
                            cNombres: item.cNombres,
                            cApellidoPaterno: item.cApellidoPaterno,
                            cApellidoMaterno: item.cApellidoMaterno,
                        }
                    }))
                },
                error: function (xhr, status, errorThrown) {
                    alert(errorThrown + '\n' + status + '\n' + xhr.statusText);
                }
            })
        },
        minLength: 4,
        select: function (event, ui) {
            if (existeAlumno(ui.item.idAlumno)) {
                alert("Este alumno ya esta en la lista");
            } else {
                var obj = {idUsuario : ui.item.idAlumno , idPerfil : ui.item.idPerfil};
                listaAlumnos[listaAlumnos.length] = JSON.stringify(obj);
                $("#hfIDsAlumnos").val(listaAlumnos);
                var html = "";
                html += "<div class='btn btn-success' rel='" + ui.item.idAlumno + "'>" + ui.item.value + " - " + ui.item.cNombres + ", " + ui.item.cApellidoPaterno + " " + ui.item.cApellidoMaterno + "<div class='icon-remove'></div></div>";
                $("#wrapGroup").append(html);
            }
        }
    });

    function existeAlumno(idAlumno) {
        for (i = 0; i < listaAlumnos.length; i++) {
            var temp = JSON.parse(listaAlumnos[i]);
            if (temp.idAlumno == idAlumno) {
                return true;
            }
        }
        return false;
    }

    $(".icon-remove").live("click", function () {
        var indice;
        for (i = 0; i < listaAlumnos.length; i++) {
            var temp = JSON.parse(listaAlumnos[i]);
            if (temp.idAlumno == $(this).parent().attr("rel")) {
                indice = i;
                break;
            }
        }
        listaAlumnos.splice(indice, 1);
        $("#hfIDsAlumnos").val(listaAlumnos);
        $(this).parent().remove();
        console.log(listaAlumnos);
    });
    /*
    function mostrarAlumnos() {
        $("#wrapGroup").empty();
        var html = "";
        for (i = 0; i < listaAlumnos.length; i++) {
            var temp = JSON.parse(listaAlumnos[i]);
            
        }
        $("#wrapGroup").append(html);
    }*/

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
            $("#wrapProyecto").empty();
            var html = "<div class='titulo'>" + ui.item.value + " - " + ui.item.cNombre + "</div><div class='cDescripcion'>" + ui.item.cDescripcion + "</div><div class='cAdjunto'><a href='/utils/repo/usuarios/" + ui.item.idUsuarioAutor + "/" + ui.item.cAdjunto + "'>" + ui.item.cAdjunto + "</a></div><div class='cCliente'><span>Cliente:</span>" + ui.item.cCliente + "</div>";
            $("#wrapProyecto").append(html);
            actualizarListaProyectos(ui.item.idProyecto)
        }
    });

    function actualizarListaProyectos(idProyecto) {
        $("#hfIdProyecto").val(idProyecto);
    }
});