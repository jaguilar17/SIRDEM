function ValidaAddEquipo(txtNombre, txtDescrip, ddlDirector, ddlAsistente, txtNumJug ,ddlTemporada) {
    var equipo = $('#' + txtNombre).val();
    var descripcion = $('#' + txtDescrip).val();
    var director = $('#' + ddlDirector).val();
    var asistente = $('#' + ddlAsistente).val();
    var jugadores = $('#' + txtNumJug).val();
    var temporada = $('#' + ddlTemporada).val();

    var msj = '';
    if (equipo.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre del equipo.';
    }
    if (descripcion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una descripcion.';
    }
    if (director == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar un Director Tecnico';
    }
    if (asistente == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar un Asistente Tecnico';
    }
    if (jugadores.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la cantidad de jugadores del equipo.';
    }
    if (temporada == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar una Temporada';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}

function ValidaUpdateEquipo(txtNombre, txtDescrip, ddlDirector, ddlAsistente, txtNumJug, ddlTemporada) {
    var equipo = $('#' + txtNombre).val();
    var descripcion = $('#' + txtDescrip).val();
    var director = $('#' + ddlDirector).val();
    var asistente = $('#' + ddlAsistente).val();
    var jugadores = $('#' + txtNumJug).val();
    var temporada = $('#' + ddlTemporada).val();

    var msj = '';
    if (equipo.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre del equipo a actualizar.';
    }
    if (descripcion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una descripcion a actualizar.';
    }
    if (director == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar un Director Tecnico a actualizar';
    }
    if (asistente == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar un Asistente Tecnico a actualizar';
    }
    if (jugadores.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la cantidad de jugadores del equipo a actualizar.';
    }
    if (temporada == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar una Temporada a actualizar';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}

function GetEquipos(HtmlSite,ddlTemporada, ddlEquipo) {
    var codTemporada = $('#' + ddlTemporada).val();
    $('#' + ddlEquipo).val('0');
    $('#' + ddlEquipo).select2("val", "0");
    ddlEquip = ddlEquipo;
    Html = HtmlSite;

    $.ajax({
        type: "post",
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        url: HtmlSite + 'WebServicesApp/WebMethods/ws_Equipo.aspx/CargarEquipos',
        data: '{"codTemporada": "' + codTemporada + '" }',

        success: CargarEquiposSucceed,
        error: CargarEquiposFailed,
    });
}

function CargarEquiposSucceed(response) {
    $('#' + ddlEquip).find('option').remove();
    $('#' + ddlEquip).html('');

    var result = jQuery.parseJSON(response.d);
    for (var i = 0; i < result.length; i++) {
        var opt = document.createElement("option");
        opt.value = result[i].codEquipo;
        opt.innerHTML = result[i].equipoNombre;
        $('#' + ddlEquip).append(opt);
    }
}

function CargarEquiposFailed(response) {
}

function SetHiddenValue(hdnId, ElmntId) {
    $('#' + hdnId).val($('#' + ElmntId).val());
}