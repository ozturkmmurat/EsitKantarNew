$(window).load(function () {

    $("#yukari").hide();
    var pathname = window.location.pathname;
    var kantar = pathname;
    //alert(kantar);
    $("#hipposerisimenu").addClass("active");


    var lastScrollTop = 0, delta = 5;

    $(window).scroll(function () {
        var uzunluk = $(document).scrollTop();

        if (uzunluk > 100) {
            $("#yukari").fadeIn(500);
            $("#btnpopupteklifal").fadeIn(500);
        }
        else {
            $("#yukari").fadeOut(500);
            $("#btnpopupteklifal").fadeOut(500);
        }

    })

    //$(document).prop('title', 'DINO | Esit Elektronik Taşıt Kantarı');

});

//$("#hozellikler").hide();
$("#hlopsiyonlar").hide();
//$("#dozellikler").hide();
//$("#dopsiyonlar").hide();

$("#yukari").click(function () {

    $("html,body").animate({ scrollTop: "0" }, 500);


});


$(function () {
    var lastScrollTop = 0, delta = 5;
    $(window).scroll(function () {
        var nowScrollTop = $(this).scrollTop();
        if (Math.abs(lastScrollTop - nowScrollTop) >= delta) {
            if (nowScrollTop > lastScrollTop) {
                // ACTION ON
                // SCROLLING DOWN
            } else {
                // ACTION ON
                // SCROLLING UP
            }
            lastScrollTop = nowScrollTop;
        }
    });
});

//hippol
$("#hlmal").click(function () {//pasif
    pasifet("hmal");
    $("#hmal").removeClass("opasite");
    $("#hmal").addClass("active2");
    $("#hozel").removeClass("active2");
    $("#hop").removeClass("active2");

    $("#hmalicon").removeAttr("class");
    $("#hozelicon").removeAttr("class");
    $("#hopicon").removeAttr("class");
    $("#hmalicon").addClass("fa fa-check-circle");
    $("#hozelicon").addClass("fa fa-minus-circle");
    $("#hopicon").addClass("fa fa-minus-circle");

    $("#hmalzemeler").fadeIn();

});

$("#hlozel").click(function () {
    pasifet("hlozel");
    $("#hlozel").removeClass("opasite");
    $("#hlmal").removeClass("active2");
    $("#hlozel").addClass("active2");
    $("#hlop").removeClass("active2");

    $("#hlmalicon").removeAttr("class");
    $("#hlozelicon").removeAttr("class");
    $("#hlopicon").removeAttr("class");
    $("#hlmalicon").addClass("fa fa-minus-circle");
    $("#hlozelicon").addClass("fa fa-check-circle");
    $("#hlopicon").addClass("fa fa-minus-circle");

    $("#hlozellikler").fadeIn();

    $('html, body').animate({
        scrollTop: $("#hippol-section").offset().top
    }, 500);
});

$("#hlop").click(function () {
    pasifet("hlop");
    $("#hlop").removeClass("opasite");
    $("#hlmal").removeClass("active2");
    $("#hlozel").removeClass("active2");
    $("#hlop").addClass("active2");

    $("#hlmalicon").removeAttr("class");
    $("#hlozelicon").removeAttr("class");
    $("#hlopicon").removeAttr("class");
    $("#hlmalicon").addClass("fa fa-minus-circle");
    $("#hlozelicon").addClass("fa fa-minus-circle");
    $("#hlopicon").addClass("fa fa-check-circle");

    $("#hlopsiyonlar").fadeIn();
    $('html, body').animate({
        scrollTop: $("#hippol-section").offset().top
    }, 500);
});

function pasifet(gelen) {
    $("#hlmal").addClass("opasite");
    $("#hlozel").addClass("opasite");
    $("#hlop").addClass("opasite");

    $("#hlmalzemeler").hide();
    $("#hlozellikler").hide();
    $("#hlopsiyonlar").hide();
}


     //dino