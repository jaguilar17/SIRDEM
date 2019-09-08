function ValidaNewTorneoxEquipo(ddlTorEquipo) {
    var torneoEq = $('#' + ddlTorEquipo).val();
    var msj = '';
    if (torneoEq == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar el equipo a asignar';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguente(s) motivo(s):\r' + msj);
        return false;
    } else return true;
}

function ValidaUpdateTorneoxEquipo(ddlTorEquipo) {
    var torneoEq = $('#' + ddlTorEquipo).val();
    var msj = '';
    if (torneoEq == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar el equipo a actualizar';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguente(s) motivo(s):\r' + msj);
        return false;
    } else return true;
}