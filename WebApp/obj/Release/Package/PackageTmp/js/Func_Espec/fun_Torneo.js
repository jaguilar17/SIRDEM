function ValidaNewTorneo(txtNombreT, txtFechaIni,txtDias, ddlCateg, txtNumMax) {
    var nombreT = $('#' + txtNombreT).val();
    var fechaI = $('#' + txtFechaIni).val();
    var duracion = $('#' + txtDias).val();
    var categoria = $('#' + ddlCateg).val();
    var numero = $('#' + txtNumMax).val();

    var msj = '';
    if (nombreT.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de Torneo.';
    }
    if (fechaI.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una fecha de Inicio del Torneo.';
    }
    if (duracion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la duracion del torneo en dias.';
    }
    if (categoria == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar una categoria de torneo';
    }
    if (numero.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el número máximo de participantes del torneo.';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}

function ValidaUpdateTorneo(txtNombreT, txtFechaIni, txtDias, ddlCateg, txtNumMax) {
    var nombreT = $('#' + txtNombreT).val();
    var fechaI = $('#' + txtFechaIni).val();
    var duracion = $('#' + txtDias).val();
    var categoria = $('#' + ddlCateg).val();
    var numero = $('#' + txtNumMax).val();

    var msj = '';
    if (nombreT.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de Torneo a actualizar.';
    }
    if (fechaI.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una fecha de Inicio del Torneo a actualizar.';
    }
    if (duracion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la duracion del torneo en dias a actualizar.';
    }
    if (categoria == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar una categoria de torneo a actualizar';
    }
    if (numero.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el número máximo de participantes del torneo a actualizar.';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}

function GetTorneos(ddlCategoria, ddlTorneo) {
    var codCategoria = $('#' + ddlCategoria).val();

    ddlTor = ddlTorneo;

    $.ajax({
        type: "post",
        dataType: "json",
        contentType: "application/json;charset=utf-8",
        url: '../../WebServicesApp/WebMethods/ws_Torneo.aspx/CargarTorneos',
        data: '{"codCategoria": "' + codCategoria + '" }',

        success: CargarTorneosSucceed,
        error: CargarTorneosFailed,
    });
}

function CargarTorneosSucceed(response) {
    $('#' + ddlTor).find('option').remove();
    $('#' + ddlTor).html('');

    var result = jQuery.parseJSON(response.d);
    for (var i = 0; i < result.length; i++) {
        var opt = document.createElement("option");
        opt.value = result[i].codTorneo;
        opt.innerHTML = result[i].nombreTorneo;
        $('#' + ddlTor).append(opt);
    }
}

function CargarTorneosFailed(response) {
}

function SetHiddenValue(hdnId, ElmntId) {
    $('#' + hdnId).val($('#' + ElmntId).val());
}