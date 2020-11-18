$(document).ready(function () {
    var pathName = window.location.pathname;

    $("#categories").children().each(function () {
        if ($(this).find("a").attr("href") == pathName) {
            $(this).addClass("active");
        }
    });

    if (pathName == "/index" || pathName == "/") {
        $("#index").removeClass("active").addClass("active");
    }
});