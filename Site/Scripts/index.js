$(document).ready(function () {
    var slider = $('.index-top-banner > .top-banner').unslider({
        autoplay: true,
        delay: 115000,
        nav: true,
        arrows: false,
        infinite: true
    });

    slider.hover(function (e) {
        slider.unslider('stop');
        e.preventDefault();
    }, function (e) {
        slider.unslider('start');
        e.preventDefault();
    });

    var nav = $('.unslider-nav');
    if (nav.length > 0) {
        var width = nav.width() / -2;
        nav.css({ 'margin-left': width + 'px' });
    }

    $('.index-products-sale .sale-box > .tabs > .tab-item').hover(function (e) {
        e.preventDefault();
        if ($(this).hasClass('active')) return false;

        $(this)
        .addClass('active')
        .siblings()
        .removeClass('active');

        $(".index-products-sale .sale-box > .content > .content-item")
        .eq($(this).index())
        .addClass('active')
        .siblings()
        .removeClass('active');
    });

    $('.index-products-sale .content-item figcaption > p').dotdotdot({
        watch: 'window'
    });

    var solutionslider = $('.index-solutions-sale .solutions-banner').unslider({
        autoplay: false,
        nav: false,
        arrows: false,
        infinite: true
    });

    $('.slide-btn.left-btn').click(function () {
        solutionslider.unslider('next');
    });

    $('.slide-btn.right-btn').click(function () {
        solutionslider.unslider('prev');
    });

    $('.index-solutions-sale .slide-item').hover(function (e) {
        $(this).find("figure > figcaption").stop(true, false).animate({ 'top': '80px' }, 200);
        $(this).find("figure > figcaption > a").stop(true, false).animate({ 'margin-top': '24px' }, 80);
        e.preventDefault();
    }, function (e) {
        $(this).find("figure > figcaption").stop(true, false).animate({ 'top': '120px' }, 200);
        $(this).find("figure > figcaption > a").stop(true, false).animate({ 'margin-top': '124px' }, 80);
        e.preventDefault();
    });

    $('.index-solutions > .solutions-box .solutions-item').hover(function (e) {
        $(this).find("figure > figcaption").stop(true, false).animate({ 'top': '60px' }, 200);
        $(this).find("figure > figcaption > a").stop(true, false).animate({ 'margin-top': '24px' }, 80);
        e.preventDefault();
    }, function (e) {
        $(this).find("figure > figcaption").stop(true, false).animate({ 'top': '100px' }, 200);
        $(this).find("figure > figcaption > a").stop(true, false).animate({ 'margin-top': '100px' }, 80);
        e.preventDefault();
    });

    $('.index-solutions > .solutions-box > .solutions-content figure > figcaption > p').dotdotdot({
        watch: 'window',
        height: 50
    });
});