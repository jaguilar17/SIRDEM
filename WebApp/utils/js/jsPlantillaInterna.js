$("document").ready(function () {
    var documento = $(this);
    $("#btnUser").toggle(function () {
    $("#wrapOpcionesUser").show(300);
    }, function () {
    $("#wrapOpcionesUser").hide(300);
    });
    
    $("#wrapOpciones > .wrapper > .itemList > .buttonItem").toggle(function () {
        $(this).parent().children(".modulos").slideDown(300);
    }, function () {
        $(this).parent().children(".modulos").slideUp(300);
    });

    $(".modulo").live("click", function () {
        var pathname = window.location.pathname;
        var url = pathname.split("/")[1] + $(this).attr("rel");
        $("#iFVentana").attr("src", url);
    });
});