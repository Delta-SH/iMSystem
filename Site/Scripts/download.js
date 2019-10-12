$(document).ready(function () {
    $('.download-content .download-box > .tabs > .tab-item').click(function (e) {
        e.preventDefault();
        e.stopPropagation();

        if ($(this).hasClass('active'))
            return false;

        $(this)
            .addClass('active')
            .siblings()
            .removeClass('active');

        $(".download-content .download-box > .content > .content-item")
            .eq($(this).index())
            .addClass('active')
            .siblings()
            .removeClass('active');
    });
});