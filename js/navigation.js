
//NAVIGATION FIXED
$(window).scroll(function(){
    if($(window).scrollTop() > 50){
            $("#header_page").css("position","fixed")
            $("#header_page").css("width","100%")
            $("#header_page").css("z-index","1001")
            $("#header_page").css("top","0")
           
    }

})

// Select all links with hashes
$('.menu_general>ul>li>a[href*="#"]')
  // Remove links that don't actually link to anything
  .not('[href="#"]')
  .not('[href="#0"]')
  .click(function(event) {
    debugger;
    $(".menu_general").find('.menu_top_line').removeClass('menu_top_line');
    $(this).siblings().addClass('menu_top_line');
    //$nav.eq( pos ).addClass( 'nav-dot-current' );
    // On-page links
    if (
      location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') 
      && 
      location.hostname == this.hostname
    ) {
      // Figure out element to scroll to
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
      // Does a scroll target exist?
      if (target.length) {
        // Only prevent default if animation is actually gonna happen
        event.preventDefault();
        $('html, body').animate({
          scrollTop: target.offset().top + (-40)
        }, 1000, function() {
          // Callback after animation
          // Must change focus!
          //Change class css
       
          var $target = $(target);
          $target.focus();
          if ($target.is(":focus")) { // Checking if the target was focused
            return false;
          } else {
            $target.attr('tabindex','-1'); // Adding tabindex for elements not focusable
            $target.focus(); // Set focus again
          };
        });
      }
    }
  });