// $(window).scroll(function() {
//     $(".arrow").css("opacity", 1 - $(window).scrollTop() / 250);
//     //250 is fade pixels
// });
// When the user clicks on the button, scroll to the top of the document
// function topFunction() {
//     document.body.scrollTop = 500;
//     document.documentElement.scrollTop = 500;
// }

// AOS effect

AOS.init({
    easing: 'ease-in-out-sine'
});

// window.scroll({
//     top: 0,
//     left: 0,
//     behavior: 'smooth'
// });

/* NAv Active and scroll js */
/*var nav = $('.content-nav');
if (nav.length) {
  var contentNav = nav.offset().top;
  ...continue to set up the menu
}*/
/*$('.nav-item a').on('click', function() {

    var scrollAnchor = $(this).attr('data-scroll'),
        scrollPoint = $('section[data-anchor="' + scrollAnchor + '"]').offset().top - 28;

    $('body,html').animate({
        scrollTop: scrollPoint
    }, 500);

    return false;

})
*/
$('.carousel').carousel({
    interval: 3000 * 1
});
$(window).scroll(function() {
    var windscroll = $(window).scrollTop();
    if (windscroll >= 50) {

        $('.main-wrapper section').each(function(i) {
            if ($(this).position().top <= windscroll - 20) {
                $('.nav-item a.active').removeClass('active');
                $('.nav-item a').eq(i).addClass('active');
            }
        });

    } else {


        $('.nav-item a.active').removeClass('active');
        $('.nav-item a:first').addClass('active');
    }

}).scroll();