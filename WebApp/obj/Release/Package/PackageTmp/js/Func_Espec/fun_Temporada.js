function ValidaNewTemporada(txtNombreT, txtFechaIni, txtDias) {
    var nombreT = $('#' + txtNombreT).val();
    var fechaI = $('#' + txtFechaIni).val();
    var duracion = $('#' + txtDias).val();

    var msj = '';
    if (nombreT.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de la Temporada.';
    }
    if (fechaI.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una fecha de Inicio de la Temporada.';
    }
    if (duracion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la duracion de la temporada.';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}

function ValidaUpdateTemporada(txtNombreT, txtFechaIni, txtDias) {
    var nombreT = $('#' + txtNombreT).val();
    var fechaI = $('#' + txtFechaIni).val();
    var duracion = $('#' + txtDias).val();

    var msj = '';
    if (nombreT.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de Temporada a actualizar.';
    }
    if (fechaI.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una fecha de Inicio de la Temporada a actualizar.';
    }
    if (duracion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la duracion de la temporada en dias a actualizar.';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}