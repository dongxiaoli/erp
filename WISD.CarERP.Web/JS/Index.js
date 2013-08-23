$(function() {
    //关闭打开左栏目
    $("#sysBar").toggle(function() {
        $("#mainLeft").hide();
        $("#barImg").attr("src", "Image/butOpen.gif");
    }, function() {
        $("#mainLeft").show();
        $("#barImg").attr("src", "Image/butClose.gif");
    });
    //页面加载完毕，显示第一个子菜单
    $(".left_menu").hide();
    $(".left_menu:eq(0)").show();
});


//后台主菜单控制函数
function tabs(tabNum) {
    //设置点击后的切换样式
    $("#tabs ul li").removeClass("hover");
    $("#tabs ul li").eq(tabNum - 1).addClass("hover");
    //根据参数决定显示子菜单
    $(".left_menu").hide();
    $(".left_menu").eq(tabNum).show();
}