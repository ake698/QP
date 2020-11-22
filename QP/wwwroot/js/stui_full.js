$(document).ready(function () {
    var pathName = window.location.pathname;

    $("#index").siblings().each(function () {
        if ($(this).find("a").attr("href") == pathName) {
            $(this).addClass("active");
        }
    });

    if (pathName == "/index" || pathName == "/") {
        $("#index").removeClass("active").addClass("active");
    }

    $(".message_submit").click(function () {
        var content = $("textarea[name='content']").val();
        var verifycode = $("input[name='verifycode']").val();
        $.ajax({
            type: "post",
            url: "/message",
            dataType: 'text',
            data: { "content": content, "verifycode": verifycode },
            success: function (data) {
                alert(data);
                window.location.reload();
            },
            error: function (data) {
                //console.log(data.responseText);
                alert(data.responseText);
            }
        })
    });
});

