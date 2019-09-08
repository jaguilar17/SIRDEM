function ValidaUsuarioPersona(txtUsuario,txtContrasenia,ddlPerfil,txtNombre,txtApeP,txtApeM,
    txtDireccion,txtFecha,txtDNI,txtTelefono,txtCorreo) {
    var usuario = $('#' + txtUsuario).val();
    var contrasenia = $('#' + txtContrasenia).val();
    var ddlPer = $('#' + ddlPerfil).val();
    var nombre = $('#' + txtNombre).val();
    var apePaterno = $('#' + txtApeP).val();
    var apeMaterno = $('#' + txtApeM).val();
    var direccion = $('#' + txtDireccion).val();
    var fechaNac = $('#' + txtFecha).val();
    var dni = $('#' + txtDNI).val();
    var telefono = $('#' + txtTelefono).val();
    var correo = $('#' + txtCorreo).val();

    var msj = '';
    if (usuario.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de usuario.';
    }
    if (contrasenia.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar una contraseña.';
    }
    if (ddlPer == "0") {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   * Debe seleccionar un tipo de Perfil';
    }
    if (nombre.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el nombre de la persona.';
    }
    if (apePaterno.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el apellido Paterno de la persona.';
    }
    if (apeMaterno.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el apellido Materno de la persona.';
    }
    if (direccion.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar la direccion de la persona.';
    }
    if (fechaNac.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe seleccionar la fecha de nacimiento.';
    }
    if (dni.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar el numero de DNI.';
    }
    if (telefono.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar su numero de telefono.';
    }
    if (correo.trim().length <= 0) {
        msj += msj.length > 0 ? '\r' : '';
        msj += '   *Debe ingresar su correo electronico.';
    }
    if (msj.length > 0) {
        alert('No puede continuar por el(los) siguiente(s) motivo(s):\r' + msj);
        return false;
    }
    else {
        return true;
    }
}