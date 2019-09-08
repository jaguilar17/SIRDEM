function ValidaNewCategoria(txtNombreCat) {
    var categoria = $('#' + txtNombreCat).val();//.html('aaa')
    var msj = '';
    if (categoria.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe ingresar en nombre de la categoria a crear';
    }

    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguente(s) motivo(s):\r' + msj);
        return false;
    } else return true;
}

function ValidaUpdateCategoria(txtNombreCat) {
    var categoria = $('#' + txtNombreCat).val();//.html('aaa')
    var msj = '';
    if (categoria.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe ingresar en nombre de la categoria a actualizar';
    }

    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguente(s) motivo(s):\r' + msj);
        return false;
    } else return true;
}