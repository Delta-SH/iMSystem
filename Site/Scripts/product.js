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