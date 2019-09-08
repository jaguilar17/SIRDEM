$("document").ready(function () {
    $(".linea").live("click", function () {
        var id = $(this).attr("rel");
        var pathname = window.location.pathname + "/detalle/" + id;
        location.href = pathname;
    });
});