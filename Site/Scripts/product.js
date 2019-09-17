$(".sidebar > ul > li .title").click(function (e) {
    var parent = $(this).parent('li');
    //var actived = parent.siblings('.active');
    //actived.children('ul').slideUp(150, function () {
    //    actived.removeClass('active');
    //});

    parent.toggleClass('active');
    if (parent.hasClass('active'))
        parent.children('ul').slideDown(150);
    else
        parent.children('ul').slideUp(150);

    e.preventDefault();
});

var introduceslider = $('.introduce-box .slide-body').unslider({
    autoplay: true,
    delay: 15000,
    nav: false,
    arrows: false,
    infinite: true
});

$('.introduce-box .slide-btn.left-btn').click(function () {
    introduceslider.unslider('next');
});

$('.introduce-box .slide-btn.right-btn').click(function () {
    introduceslider.unslider('prev');
});

$('.main-content > .product figcaption p').dotdotdot({
    watch: 'window',
    height: 130
});