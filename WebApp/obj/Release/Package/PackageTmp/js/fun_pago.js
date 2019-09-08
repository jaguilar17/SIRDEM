function CargarPago(codJugador, lblcodJugador, nombres, lblnombres, Apellidos, lblApellidos) {

    $('#' + lblcodJugador).html(''); 
    $('#' + lblcodJugador).html($('#' + codPagos).html());

    $('#' + lblnombres).html('');
    $('#' + lblnombres).html($('#' + nombres).html());

    $('#' + lblApellidos).html('');
    $('#' + lblApellidos).html($('#' + Apellidos).html());

}

function AceptarPago(codPago, hdnCodPago, btnAceptar) {

    $('#' + hdnCodPago).val(codPago);
    var btnName = $('#' + btnAceptar).attr("name");
    __doPostBack(btnName, "");
}
