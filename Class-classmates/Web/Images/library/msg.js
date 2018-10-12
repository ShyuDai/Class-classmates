//可以自动关闭的提示
function jsAutoMsg(msgtitle, url) {
    $("#btnSave").attr("disabled", "disabled");
    var str = "<div id=\"jsAutoMsg\" class=\"pcent correct\">" + msgtitle + "</div>";
    $("body").append(str);
    $("#jsAutoMsg").show();
    //3秒后清除提示
    setTimeout(function() {
        $("#jsAutoMsg").remove();
        if (url == "back") {
            history.back(-1);
        } else if (url != "") {
            location.href = url;
        }
    }, 3000);
}
//遮罩提示窗口
function jsLayMsg(w, h, options) {
    $("#jsLayMsg").remove();
    var cssname = "";
    //提示窗口的样式
    switch (options.mscss) {
        case "Success":
            cssname = "icon-01";
            break;
        case "Error":
            cssname = "icon-02";
            break;
        default:
            cssname = "icon-03";
            break;
    }
    //向页面插入标记
    var str = "<div id='jsLayMsg' title='" + options.title + "'><p class='" + cssname + "'>" + options.msbox + "</p></div>";
    $("body").append(str);
    $("#jsLayMsg").dialog({
        //title: null,
        //show: null,
        bgiframe: true,
        autoOpen: false,
        width: w,
        //height: h,
        resizable: false,
        closeOnEscape: false,
        draggable:false,
        buttons: { "确定": function() { $(this).dialog("close"); }},
        close: function() {
            if (options.url == "back") {
                history.back(-1);
            } else if (options.url != "") {
                location.href = options.url;
            }
        },
        modal: true
    });
    $("#jsLayMsg").dialog("open");
}