$(document).ready(function () {
    'use strict';

    $('.menus-row > dl > dd').hover(function (e) {
        var me = $(this), width = me.width(), position = me.position();
        $('.menus-row > dl > dd.line').stop(true, false).animate({ left: position.left + 'px', width: width + 'px' }, 500);
        $(this).children(".dropdown-box").stop(true, false).fadeIn(150);
        e.preventDefault();
    }, function (e) {
        $('.menus-row > dl > dd.line').stop(true, true).animate({ width: 0 }, 500);
        $(this).children(".dropdown-box").stop(true, false).fadeOut(150);
        e.preventDefault();
    });

    $('.toolbar > .toolbar-item-contact, .toolbar > .toolbar-item-app').hover(function (e) {
        $(this).children(".toolbar-layer").stop(true, false).fadeIn(150);
        e.preventDefault();
    }, function (e) {
        $(this).children(".toolbar-layer").stop(true, false).fadeOut(150);
        e.preventDefault();
    });

    $(".toolbar > .toolbar-item-top").click(function (e) {
        $('body,html').animate({ scrollTop: 0 }, 300);
        e.preventDefault();
    });

    $('#weixincode').hover(function (e) {
        $(this).children(".weixin").stop(true, false).fadeIn(150);
        e.preventDefault();
    }, function (e) {
        $(this).children(".weixin").stop(true, false).fadeOut(150);
        e.preventDefault();
    });
});