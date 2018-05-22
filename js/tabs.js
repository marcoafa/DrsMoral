
$('.tabgroup > section').hide();
$('.tabgroup > section:first-of-type').show();
$('.tabs>li>a').click(function(e){
  e.preventDefault();
    var $this = $(this),
        tabgroup = '#'+$this.parents('.tabs').data('tabgroup'),
        others = $this.closest('li').siblings().children('a'),
        target = $this.attr('href');
    others.removeClass('active');
    $this.addClass('active');
    $(tabgroup).children('section').hide();
    $(target).show();
  
})
    