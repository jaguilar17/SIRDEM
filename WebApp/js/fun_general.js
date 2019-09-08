function MobileNavigator() {
    if (navigator.userAgent.toLowerCase().indexOf("mobile") > 0) return true;
    else return false;
}

function Notificacion(msj) {
    if (mdj.length > 0) {
        alert(msj);
        return false;
    } else return true;
}

function NumeroInt(ev) {
    var tecla = (document.all) ? ev.keyCode : ev.which;
    if (tecla == 8 || tecla == 13 || tecla == 0) return true;
    var regEx = /^[0-9]+$/i;
    return regEx.test(String.fromCharCode(tecla));
}
function ValidateInts(txt) {
    var regEx = /^[0-9]+$/i;
    var doc = document.getElementById(txt.id).value;
    var docfinal = '';
    try {
        for (var i = 0; i < doc.length; i++)
            if (regEx.test(doc[i])) docfinal += doc[i];
    } catch (e) { }
    document.getElementById(txt.id).value = docfinal;
}
function LetrasInt(ev) {
    var tecla = (document.all) ? ev.keyCode : ev.which;
    if (tecla == 8 || tecla == 13 || tecla == 0) return true;
    var regEx = /^[a-zA-Z]+$/;
    return regEx.test(String.fromCharCode(tecla));
}
function CorreoInt(ev) {
    var tecla = (document.all) ? ev.keyCode : ev.which;
    if (tecla == 8 || tecla == 13 || tecla == 0) return true;
    var regEx = /[A-Z0-9a-z._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,6}/;
    return regEx.test(String.fromCharCode(tecla));
}

function CorreoInt2(str) {
    //var regEx = /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$/;
    var regEx = /\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*/;
    if (!regEx.test(str)) {
        alert("Formato incorrecto de correo.");
        return false;
    }
}
function BlockChars(ev) {
    var tecla = (document.all) ? ev.keyCode : ev.which;
    if (tecla == 8 || tecla == 13 || tecla == 0) return true;
    if (tecla >= 8226 && tecla <= 10175) { return false; }
    var regEx = /[\~`!#$%^&§¥£│øƒ×®¿¬¡©¢┐└┴┬├─┼ãÃ╚╔╩╦╠═╬¤ðÐÊËÈıÍÎÏ┘┌█▬¦▬▀­­­±­¶@_*\+\=\-\[\]\\\';\/{}|\":<>?()]/;
    return !regEx.test(String.fromCharCode(tecla));
}
function BlockEmoji(ev) {
    var tecla = (document.all) ? ev.keyCode : ev.which;
    if (tecla == 8 || tecla == 13 || tecla == 0) return true;
    var regex = /uD83C[\uDF00-\uDFFF]|\uD83D[\uDC00-\uDEFF]|[\u2600-\u26FF]/;
    return !regex.test(String.fromCharCode(tecla));
}