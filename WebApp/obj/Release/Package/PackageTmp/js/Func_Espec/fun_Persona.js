function ValidaAddPersona(txtUser, txtUserClave, txtNombreUsuario, txtApePatUsu, txtApeMatUsu, txtCorreo, txtDire, txtDNI, txtTelf, txtFechaNac) {
    var user = $('#' + txtUser).val();
    var clave = $('#' + txtUserClave).val();
    var nombre = $('#' + txtNombreUsuario).val();
    var apePat = $('#' + txtApePatUsu).val();
    var apeMat = $('#' + txtApeMatUsu).val();
    var correo = $('#' + txtCorreo).val();
    var direccion = $('#' + txtDire).val();
    var dni = $('#' + txtDNI).val();
    var telefono = $('#' + txtTelf).val();
    var fechaNac = $('#' + txtFechaNac).val();

    var msj = '';
    if (user.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar un nombre de usuario.';
    }
    if (clave.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una clave para el usuario.';
    }
    if (nombre.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre del jugador.';
    }
    if (apePat.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el apellido paterno del jugador.';
    }
    if (apeMat.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el apellido materno del jugador.';
    }
    if (correo.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar un correo electronico.';
    }
    if (direccion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la direccion del jugador.';
    }
    if (dni.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el numero de DNI del jugador.';
    }
    if (telefono.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar celular del jugador.';
    }
    if (fechaNac.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe ingresar la fecha de nacimiento del jugador';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}