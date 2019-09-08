$("document").ready(function () {
    $("#menu li").hover(function () {
        $(this).children("ul").stop().slideDown(500);
    }, function () {
        $(this).children("ul").stop().slideUp(500);
    });

    $("#slide").bxSlider({
        mode: "fade",
        pager: "true",
        controls: false,
        auto: true,
        pause: 3000
    });

    $(".bx-pager").find("a").text("");

    $("#icon").toggle(function () {
        $("#icon").css("margin-right", "230px")
        $("#icon > img").attr("src", "utils/images/unLock.gif");

        $("#wrapperLogin").width("262px");
        $("#form").fadeIn();


    }, function () {
        $("#form").fadeOut(function () {
            $("#icon").css("margin-right", "0px")
            $("#icon > img").attr("src", "utils/images/lock.gif");
            $("#wrapperLogin").width("24px");
        });

    });
});


