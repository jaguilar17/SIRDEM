function MostrarMensaje(msg, controlid) {
    alert(msg);
    var ctrl = document.getElementById(controlid);
    ctrl.click();
}

$("document").ready(function () {
    $("#loading_layer").delay(600).fadeOut();
    var subVentana = $(this);
    var altura = subVentana.height();
    parent.$("#iFVentana").height(altura);
    $("#loading_layer").height(altura);
});