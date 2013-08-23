//遮罩提示窗口
function jsmsg(w, h, msgtitle, msgbox, url, msgcss) {
    $("#msgdialog").remove();
    var cssname = "";
    switch (msgcss) {
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
    var str = "<div id='msgdialog' title='" + msgtitle + "'><p class='" + cssname + "'>" + msgbox + "</p></div>";
    $("body").append(str);
    $("#msgdialog").dialog({
        //title: null,
        //show: null,
        bgiframe: true,
        autoOpen: false,
        width: w,
        //height: h,
        resizable: false,
        closeOnEscape: true,
        buttons: { "确定": function() { $(this).dialog("close"); } },
        modal: true
    });
    $("#msgdialog").dialog("open");
    if (url == "back") {
        sysMain.history.back(-1);
    } else if (url != "") {
        sysMain.location.href = url;
    }
}


//可以自动关闭的提示
function jsprint(msgtitle, url, msgcss) {
    $("#msgprint").remove();
    var cssname = "";
    switch (msgcss) {
        case "Success":
            cssname = "pcent correct";
            break;
        case "Error":
            cssname = "pcent disable";
            break;
        default:
            cssname = "pcent warning";
            break;
    }
    var str = "<div id=\"msgprint\" class=\"" + cssname + "\">" + msgtitle + "</div>";
    $("body").append(str);
    $("#msgprint").show();
    if (url == "back") {
        sysMain.history.back(-1);
    } else if (url != "") {
        sysMain.location.href = url;
    }
    //3秒后清除提示
    setTimeout(function() {
        $("#msgprint").fadeOut(500);
        //如果动画结束则删除节点
        if (!$("#msgprint").is(":animated")) {
            $("#msgprint").remove();
        }
    }, 3000);
}
