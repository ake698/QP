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
                if (window.location.pathname == "/message") {
                    window.location.reload();
                } else {
                    $("#modal-seport").modal('hide');
                }
            },
            error: function (data) {
                //console.log(data.responseText);
                $("#verify_img").click();
                alert(data.responseText);
            }
        })
    });

    $("#verify_img").click(function () {
        $(this).attr("src", "/verify?" + Date.parse(new Date()));
    })

    SetFooter();
});



function SetFooter() {
    var footer_height = $("#footer").height(); 
    if ($("#footer")[0].offsetTop < window.screen.height - footer_height) {
        $("#footer").addClass("footer_active");
    } else {
        $("#footer").removeClass("footer_active");
    }
}

function Report(data) {
    $("#verify_img").click();
    $("#content").val(data);
    $("#modal-seport").modal('show');
}