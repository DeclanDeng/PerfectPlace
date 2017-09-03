var windowWidth = jQuery(window).width();
var finish = -1 * ((windowWidth - jQuery('#scene_1').width()) / 2 + 1260);
var start = (windowWidth - (windowWidth - jQuery('#scene_1').width()) / 2) + 160;

jQuery(document).ready(function () {
	"use strict";
	
	if(jQuery.cookie('layout') == 'boxed')
	{
		jQuery('head').append('<link rel="stylesheet" type="text/css" href="css/responsiveboxed.css">');
		jQuery('body').addClass('boxed');
		jQuery('.panel #boxed').addClass('active');
		jQuery('.panel #wide').removeClass('active');
	}

});

jQuery(window).load(function () {
    "use strict";
	
    jQuery('body').animate({
        'opacity': '1'
    }, 400);

    setTimeout(function () { jQuery('#scene_1 #items div:nth-child(1) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 600);
    setTimeout(function () { jQuery('#scene_1 #items div:nth-child(2) img, #scene_1 #items div:nth-child(4) img').css({'transform': 'initial'}); }, 1200);
    setTimeout(function () { jQuery('#scene_1 #items div:nth-child(3) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial' });}, 900);
    setTimeout(function () { jQuery('#scene_1 #items div:nth-child(5) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial' });}, 1000);
    setTimeout(function () { jQuery('.headline a').css({'opacity': '1'});}, 1500);
	
	
    setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(1) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 600);
    setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(2) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 900);
    setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(3) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 1100);
    setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(4) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 1300);
    setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(5) img, #scene_1 #eco_items div:nth-child(11) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 900);
	setTimeout(function () { jQuery('#scene_1 #eco_items div:nth-child(11) img').css({'-webkit-transition':'all linear 15s','-moz-transition':'all linear 15s','-ms-transition':'all linear 15s','-o-transition':'all linear 15s','transition':'all linear 15s'});}, 1900);
	 
	setTimeout(function () { jQuery('#scene_1 #travel_items div:nth-child(1) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 600);
	setTimeout(function () { jQuery('#scene_1 #travel_items div:nth-child(2) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 900);
	setTimeout(function () { jQuery('#scene_1 #travel_items div:nth-child(3) img').css({'transform': 'initial','-webkit-transform': 'initial','-moz-transform': 'initial','-ms-transform': 'initial','-o-transform': 'initial'});}, 1100);
	
    var mill = 0;
    var millBool = true;
    jQuery('#eco_items div:nth-child(11) img').mouseover(function () {
        if (millBool == true) {
			
            millBool = false;
            mill = mill + 1800;
            jQuery(this).css({
                'transform': 'rotate(' + mill + 'deg)',
				'-webkit-transform': 'rotate(' + mill + 'deg)',
				'-moz-transform': 'rotate(' + mill + 'deg)',
				'-ms-transform': 'rotate(' + mill + 'deg)',
				'-o-transform': 'rotate(' + mill + 'deg)'
            });
            setTimeout(function () {
                millBool = true;
            }, 15000);
        }
    });
	
	MapBg();
	
	var mapbg = 0;
	function MapBg(){
		mapbg = mapbg - 20;
		var item = jQuery('#header.travel .bg');
		jQuery(item).animate({'background-position-x': mapbg }, 1000, "linear",
			function(){
				jQuery(item).clearQueue();
                jQuery(item).stop();
				MapBg(); 
			}
		);
	}
	
	jQuery('#travel_items .anim').each(function () {

        var time = jQuery(this).attr('data-time') * 1000;
        var direction = jQuery(this).attr('data-direction');
        if (direction == 'right' || direction == 'left')
            Clouds(this, time, direction);
    });
	
    jQuery('.clouds div').each(function () {

        var time = jQuery(this).attr('data-time') * 1000;
        var direction = jQuery(this).attr('data-direction');
        if (direction == 'right' || direction == 'left')
            Clouds(this, time, direction);
    });

	setTimeout(function () {
            Airplane();
    }, 10000);
		
    function Clouds(obj, time, direction) {
        if (direction == 'right') {
            jQuery(obj).animate({
                'right': start
            }, 1, function () {
                jQuery(obj).animate({
                    'right': finish
                }, time, "linear", function () {
                    jQuery(obj).clearQueue();
                    jQuery(obj).stop();
                    Clouds(obj, time, direction);
                    return false;
                });
            });
        } else if (direction == 'left') {
            jQuery(obj).animate({
                'left': start
            }, 1, function () {
                jQuery(obj).animate({
                    'left': finish
                }, time, "linear", function () {
                    jQuery(obj).clearQueue();
                    jQuery(obj).stop();
                    Clouds(obj, time, direction);
                    return false;
                });
            });
        }
    }

    function Airplane() {
		x = -120;
		if(jQuery('#header').hasClass('travel'))
		var x = 20;
		
        jQuery('#airplane').animate({
            'left': start,
            'top': '-70px'
        }, 1, function () {
            jQuery('#airplane').animate({
                'left': finish,
                'top': x
            }, 20000, "linear", function () {
                jQuery('#airplane').clearQueue();
                jQuery('#airplane').stop();
                setTimeout(function () {
                    Airplane();
                }, 25000);
                return false;
            });
        });
    }

    var middle = (jQuery('#framework').height() - 60) / 2;
    jQuery('#framework .left li').each(function () {

        var itemPos = jQuery(this).position();
        var diff = middle - itemPos.top;
        var itemHeight = jQuery(this).height();

        if (diff > itemHeight) jQuery(this).find('.line').css({
            'transform': 'rotate(20deg)',
			'-webkit-transform': 'rotate(20deg)',
			'-moz-transform': 'rotate(20deg)',
			'-ms-transform': 'rotate(20deg)',
			'-o-transform': 'rotate(20deg)',
            'top': '100%'
        });
        if (diff < (-1 * itemHeight)) jQuery(this).find('.line').css({
            'transform': 'rotate(-20deg)',
			'-webkit-transform': 'rotate(-20deg)',
			'-moz-transform': 'rotate(-20deg)',
			'-ms-transform': 'rotate(-20deg)',
			'-o-transform': 'rotate(-20deg)',
            'top': '0'
        });
    });

    jQuery('#framework .right li').each(function () {

        var itemPos = jQuery(this).position();
        var diff = middle - itemPos.top;
        var itemHeight = jQuery(this).height();

        if (diff > itemHeight) jQuery(this).find('.line').css({
            'transform': 'rotate(-20deg)',
			'-webkit-transform': 'rotate(-20deg)',
			'-moz-transform': 'rotate(-20deg)',
			'-ms-transform': 'rotate(-20deg)',
			'-o-transform': 'rotate(-20deg)',
            'top': '100%'
        });
        if (diff < (-1 * itemHeight)) jQuery(this).find('.line').css({
            'transform': 'rotate(20deg)',
			'-webkit-transform': 'rotate(20deg)',
			'-moz-transform': 'rotate(20deg)',
			'-ms-transform': 'rotate(20deg)',
			'-o-transform': 'rotate(20deg)',
            'top': '0'
        });
    });

    jQuery('.tabs_name li').click(function () {
        var index = jQuery(this).index() + 1;

        jQuery('.active').removeClass('active');
        jQuery(this).addClass('active');
        jQuery('.tabs .tab.active').removeClass('active');
        jQuery('.tabs').find('.tab:nth-child(' + index + ')').addClass('active');
    });

    jQuery('.video_thumb').each(function () {
        var frame_code = jQuery(this).attr('data-frame');
        jQuery(this).html('<iframe width="100%" height="100%" class="video_frame" src="' + frame_code + '"  frameborder="0" webkitAllowFullScreen="webkitAllowFullScreen" mozallowfullscreen="mozallowfullscreen" allowFullScreen="allowFullScreen"></iframe>');
    });

    jQuery('.open_more').click(function () {
        var x = jQuery(this).attr('data-cont');
        var container = '#' + x;
        var item = jQuery('.open_more[data-cont="' + x + '"]');

        if (jQuery(container).css('display') == 'none') {
            jQuery(item).find('div').addClass('icon-up-open');
            jQuery(item).find('div').removeClass('icon-down-open');
            jQuery(item).find('span').html('hide');
        } else if (jQuery(container).css('display') == 'block') {
            jQuery(item).find('div').removeClass('icon-up-open');
            jQuery(item).find('div').addClass('icon-down-open');
            jQuery(item).find('span').html('more');
        }
        jQuery(container).slideToggle(400, "linear");
    });

    if (jQuery('video').length) jQuery('video').mediaelementplayer( /* Options */ );
    if (jQuery('audio').length) jQuery('audio').mediaelementplayer( /* Options */ );

    jQuery('.gallery_images').each(function () {
        var items = jQuery(this).find('li').length;
        if (items == 1) jQuery(this).find('li').css({
            'width': '100%'
        });
        if (items == 2) jQuery(this).find('li').css({
            'width': '49%',
            'height': '100%'
        });
        if (items == 3) {
            jQuery(this).find('li').css({
                'width': '30%',
                'height': '49.5%'
            });
            jQuery(this).find('li:first-child').css({
                'width': '68%',
                'height': '100%'
            });
        }
    });

    jQuery('.gallery_images li').click(function () {
		if(jQuery(window).width() > 440)
		{
			var items = '';
			var index = jQuery(this).index() + 1;
			var count = jQuery(this).parent().find('li').length + 1;

			for (var i = index; i < count; i++) {
				var image = jQuery(this).parent().find('li:nth-child(' + i + ')').html();
				items = items + '<li>' + image + '</li>';
			}

			for (var i = 1; i < index; i++) {
				var image = jQuery(this).parent().find('li:nth-child(' + i + ')').html();
				items = items + '<li>' + image + '</li>';
			}

			var html = '<div class="mask"><div class="slider_container">' +
				'<div class="close_preview"></div>' +
				'<ul class="rslides">' +
				items +
				'</ul>' +
				'</div></div>';

			jQuery('body').append(html);
			jQuery('body').css('overflow', 'hidden');

			jQuery(".mask .slider_container .rslides").responsiveSlides({
				auto: true,
				pager: false,
				pause: true,
				nav: true,
				speed: 200,
				namespace: "callbacks",
				before: function () {},
				after: function () {
					jQuery(".mask .slider_container .rslides img").each(function () {
						var x = jQuery(this).height();
						var y = jQuery('.mask .slider_container').height();
						var z = (y - x) / 2;
						jQuery(this).css('margin-top', z);
					});
				}
			});

			jQuery(".mask .rslides img:first-child").css('margin-top', 0);

			jQuery('.mask .close_preview').click(function () {
				jQuery('.mask').remove();
				jQuery('body').css({
					'overflow-x': 'hidden',
					'overflow-y': 'auto'
				});
			});
		}
        return false;
    });

    jQuery('.diagram_list').each(function () {
        var elem = '#' + jQuery(this).attr('id') + ' li';

        jQuery(elem).each(function () {

            if (jQuery(this).attr('data-color')) {
                var color = jQuery(this).attr('data-color');
                var R = hexToR(color);
                var G = hexToG(color);
                var B = hexToB(color);

                var x = 'rgba(' + R + ',' + G + ',' + B + ', 0.7)';
                var y = jQuery(this).find('span:first-child').width();
                var z = jQuery(this).find('span:first-child').height();
                jQuery(this).find('span:first-child').css('background-color', color);
                jQuery(this).find('span:last-child').css({
                    'background-color': x,
                    'width': y,
                    'height': z
                });
            }
        });
    });

    jQuery('.accordion').each(function () {
        jQuery(this).find('.item .head').click(function () {

            if (jQuery(this).parents('.item').hasClass('close')) {
                jQuery(this).parents('.item').removeClass('close');
                jQuery(this).parents('.item').find('.body').slideDown('fast', 'linear', function () {
                    jQuery(this).parents('.item').find('.head .icon').removeClass('icon-plus').addClass('icon-minus');
                });
            } else {
                jQuery(this).parents('.item').addClass('close');
                jQuery(this).parents('.item').find('.body').slideUp('fast', 'linear', function () {
                    jQuery(this).parents('.item').find('.head .icon').removeClass('icon-minus').addClass('icon-plus');
                });
            }
        });
    });

    var shipN = true;
    var Sx = -5;
    var Sy = 5;
    var Sz = -70;
    jQuery('#scene_2').mouseover(function () {
        var x = jQuery(this).find('#ship');
        if (shipN == true)
            Ship(x);
    });

    function Ship(item) {
        shipN = false;
        var T = 1;
        for (var i = 0; i < 3; i++) {

            setTimeout(function () {
                Sx = Sx * (-1);
                Sy = Sy * (-1);
                jQuery({
                    deg: Sx
                }).animate({
                    deg: Sy
                }, {
                    duration: 1000,
                    step: function (now) {
                        jQuery(item).css({
                            transform: 'rotate(' + now + 'deg)'
                        });
                    }
                });
            }, T);
            T = T + 1000;
        }
        jQuery('#scene_2 .wave:nth-child(2)').animate({
            'background-position-x': Sz
        }, 3000, "linear");
        Sz = Sz * (-1);
        jQuery('#scene_2 .wave:nth-child(3)').animate({
            'background-position-x': Sz
        }, 3000, "linear");

        setTimeout(function () {
            jQuery(item).clearQueue();
            jQuery(item).stop();
            shipN = true;
        }, 3000);
    }

    jQuery('#scene_2').mouseover(function () {
        Wave(this);
    });

    function Wave(item) {
        if (jQuery(item).hasClass('left')) {
            jQuery(item).animate({
                'left': '40px'
            }, 2000, function () {
                jQuery(item).animate({
                    'left': '0px'
                }, 2000, function () {
                    jQuery(item).clearQueue();
                    jQuery(item).stop();
                    Wave(item);
                    return false;
                });
            });
        }
        if (jQuery(item).hasClass('right')) {
            jQuery(item).animate({
                'right': '40px'
            }, 2000, function () {
                jQuery(item).animate({
                    'right': '0px'
                }, 2000, function () {
                    jQuery(item).clearQueue();
                    jQuery(item).stop();
                    Wave(item);
                    return false;
                });
            });
        }
    }

    jQuery('.button.anim').mouseover(function () {
        var item = jQuery(this);
        setTimeout(function () {
            jQuery(item).css({
                'margin-left': '20px'
            });
        }, 1);
        setTimeout(function () {
            jQuery(item).css({
                'margin-left': '-20px'
            });
        }, 100);
        setTimeout(function () {
            jQuery(item).css({
                'margin-left': '20px'
            });
        }, 200);
        setTimeout(function () {
            jQuery(item).css({
                'margin-left': '0'
            });
        }, 300);
    });

    if (jQuery('.mask').length == 0) {
        jQuery(".slider_container .rslides").responsiveSlides({
            auto: true,
            pager: false,
            pause: true,
            nav: true,
            speed: 200,
            namespace: "callbacks",
            before: function () {},
            after: function () {
                jQuery(".rslides img").each(function () {
                    if (jQuery('.mask').length == 0) {
                        var x = jQuery(this).height();
                        var y = jQuery('.slider_container').height();
                        var z = (y - x) / 2;
                        jQuery(this).css('margin-top', z);
                    }
                });
            }
        });
        jQuery(".rslides img:first-child").css('margin-top', 0);
    }
	
	jQuery('.panelbutton').click(function(){ 
		jQuery('.panel').slideDown();
		jQuery('body').append('<div class="custom_overflow"></div>');
		jQuery('.custom_overflow').click(function(){ 
			jQuery('.panel').slideUp();
			jQuery('.custom_overflow').remove();
		});
	});
	
	jQuery('.panel .close').click(function(){ 
		jQuery('.panel').slideUp();
		jQuery('.custom_overflow').remove();
	});
	
	
	jQuery('.panel #boxed').click(function(){ 
		jQuery('body').addClass('boxed'); 
		jQuery('head').append('<link id="boxedstyle" rel="stylesheet" type="text/css" href="css/responsiveboxed.css">');
		jQuery.cookie('layout', 'boxed');
		jQuery('.panel #boxed').addClass('active');
		jQuery('.panel #wide').removeClass('active');
		
		if (jQuery('.box').width() > 1230) Gallery(4);
		if (jQuery('.box').width() <= 1230) Gallery(3);
		if (jQuery('.box').width() <= 984) Gallery(2);
		if (jQuery('.box').width() <= 440) Gallery(1);
	});
	
	jQuery('.panel #wide').click(function(){ 
		jQuery('body').removeClass('boxed'); jQuery('#boxedstyle').remove();
		jQuery.cookie('layout', 'wide');
		jQuery('.panel #boxed').removeClass('active');
		jQuery('.panel #wide').addClass('active');
				
		if (jQuery(window).width() > 1170) Gallery(4);
		if (jQuery(window).width() <= 1170) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	});
	
	
	jQuery('.panel .background div, .panel .patterns div').click(function(){
		var x = jQuery(this).attr('class');
		jQuery('.body_background').removeClass('pattern1 pattern2 pattern3 pattern4 pattern5 pattern6 background1 background2 background3 background4 background5 background6').addClass(x);
		jQuery.cookie('background', x);
	});
	
		if(jQuery.cookie('background') != null){
		var bg = jQuery.cookie('background');
		jQuery('.body_background').addClass(bg);
	}
	
	
});

jQuery(window).resize(function () {
    "use strict";

    windowWidth = jQuery(window).width();
    finish = -1 * ((windowWidth - jQuery('#scene_1').width()) / 2 + 760);
    start = (windowWidth - (windowWidth - jQuery('#scene_1').width()) / 2) + 160;

});

var menu = true;
var lastScrollTop = 0;
jQuery(window).scroll(function () {
    "use strict";

    post_show('vis');
    skills_show('vis');
    diagram_show('vis');


    var st = jQuery(this).scrollTop();

    if (st > lastScrollTop && st > 1000 && menu == true) {
        menu = false;
        jQuery('.scroll_menu').slideUp('slow', function () {
            menu = true;
        });
    } else if (st > 1000 && menu == true) {
        menu = false;
        jQuery('.scroll_menu').slideDown('slow', function () {
            menu = true;
        });
    } else if (st < 1000) {
        menu = false;
        jQuery('.scroll_menu').slideUp('slow', function () {
            menu = true;
        });
    }
    lastScrollTop = st;

});

function post_show(vis) {
	"use strict";
	
    var scroll_top = jQuery(window).scrollTop();
    var w_height = jQuery(window).height();
    var total = w_height + scroll_top;
    jQuery('.post-anim').each(function () {
        if (!jQuery(this).hasClass('vis')) {
            if (jQuery(this).offset().top <= total) {
                jQuery(this).addClass(vis);
            }
        }
    });
}

function skills_show(vis) {
	"use strict";
	
    var scroll_top = jQuery(window).scrollTop();
    var w_height = jQuery(window).height();
    var total = w_height + scroll_top;
    jQuery('.widget_skills').each(function () {
        if (!jQuery(this).hasClass('vis')) {
            if ((jQuery(this).offset().top) <= total) {
                jQuery(this).addClass(vis);
                var x = jQuery(this);
                setTimeout(function () {
                    Widgets(x);
                }, 300);
            }
        }
    });
}

function diagram_show(vis) {
	"use strict";
	
    var scroll_top = jQuery(window).scrollTop();
    var w_height = jQuery(window).height();
    var total = w_height + scroll_top;
    jQuery('.diagram_skills').each(function () {
        if (!jQuery(this).hasClass('vis')) {
            if ((jQuery(this).offset().top) <= total) {
                jQuery(this).addClass(vis);
                CircleDiagram();
            }
        }
    });
}

function hexToR(h) {
    return parseInt((cutHex(h)).substring(0, 2), 16)
}

function hexToG(h) {
    return parseInt((cutHex(h)).substring(2, 4), 16)
}

function hexToB(h) {
    return parseInt((cutHex(h)).substring(4, 6), 16)
}

function cutHex(h) {
    return (h.charAt(0) == "#") ? h.substring(1, 7) : h
}


function Widgets(item) {
	"use strict";
	
    if (jQuery(item).attr('id') == "widget_2") {
        jQuery(item).find('.skills_row').each(function () {
            var x = Math.floor((Math.random() * 1000) + 500);

            jQuery(this).animate({
                'bottom': 0
            }, x, function () {
                jQuery(this).find('.name').css('opacity', 1);
            });
        });
    } else {
        var maxHeight = jQuery(item).find('.skills_row .progress').css('height');

        jQuery(item).find('.skills_row').each(function () {
            var percent = jQuery(this).find('.progress').attr('data-process');
            percent = percent.replace('%', '');
            maxHeight = maxHeight.replace('px', '');
            var x = maxHeight * percent / 100;

            jQuery(this).css({
                'height': x
            });
            jQuery(this).find('.progress').css({
                'height': x
            });
            jQuery(this).find('.progressbar .shadow').animate({
                'border-bottom-width': '30px',
                'border-right-width': '1300px'
            }, 500);
            jQuery(this).find('.progress .before, .progress .after ').animate({
                'border-bottom-width': x
            }, 1000, function () {
                jQuery('.skills_row').find('.value, .caption').css('opacity', 1);
            });
        });
    }
}

function CircleDiagram() {
	
    var chart_flag = false;
    var chart_invise = false;
    var init_attempts = 0;
    var inner_cutout = 93;

    function chart_anim(id, doughnutData) {

        var id = id;
        var doughnutData = doughnutData;
        var oft = jQuery('#' + id).offset().top;
        var scrt = jQuery(window).scrollTop();
        var hgt = jQuery(window).height();
        if (chart_flag === false) {

            var options = {
                segmentShowStroke: 0,
                percentageInnerCutout: inner_cutout,
                segmentShowStroke: false
            };
            var myDoughnut = new Chart(document.getElementById('canvas_' + id).getContext("2d")).Doughnut(doughnutData, options);
            chart_flag = true;

        }
        chart_flag = false;
    }


    var i = -30;
    var S = 0;

    jQuery('.diagram_skills').each(function () {
        i = -30;

        var sl_width = jQuery(this).find('canvas').css('width');
        jQuery(this).css({
            'height': sl_width,
            'width': sl_width
        });

        if (jQuery(this).attr('data-cutout') != '' && jQuery(this).attr('data-cutout')) {
            inner_cutout = jQuery(this).attr('data-cutout');
        }

        jQuery(this).find('.sc_skills').each(function () {
            var dt_percent = jQuery(this).find('canvas').attr('data-percent');
            var dt_color = jQuery(this).find('canvas').attr('data-color');

            var R = hexToR(dt_color);
            var G = hexToG(dt_color);
            var B = hexToB(dt_color);

            dt_color = 'rgb(' + R + ',' + G + ',' + B + ')';
            dt_color_1 = 'rgba(' + R + ',' + G + ',' + B + ', 0.7)';

            var WH = 100 - dt_percent;
            var SA = 100 - WH;
            var FR = 0;
            var SC = 0;

            if (dt_percent <= 12) {
                FR = SA;
                SA = 0;
            }
            if (dt_percent > 12) {
                FR = 12;
                SA = SA - 12;
            }
            if (dt_percent > 50) {
                SC = SA - 50;
                SA = 50;
            }

            var doughnutData = [{
                value: FR,
                color: dt_color_1
            }, {
                value: SA,
                color: dt_color
            }, {
                value: SC,
                color: dt_color_1
            }, {
                value: WH,
                color: "transparent"
            }];
            i = i + 30;
            inner_cutout = inner_cutout - 2;

            var id = jQuery(this).attr('id');
            chart_anim(id, doughnutData);
            jQuery(this).css({
                'margin-top': i,
                'margin-left': i
            });

        });
    });

    setTimeout(function () {
        jQuery('.diagram_skills .title, .diagram_skills .item, .diagram_skills .line, .diagram_skills .name').css('opacity', 1);
    }, 1000);


    jQuery('.diagram_skills .sc_skills .item').each(function () {
        var percent = jQuery(this).parent().find('canvas').attr('data-percent');
        var height = jQuery(this).parent().find('canvas').height() / 2;

        if (percent < 25) var plots = (100 + percent) * 10 - 250;
        else var plots = percent * 10 - 250;

        var increase = Math.PI * 2 / 1000,
            angle = 0,
            x = 0,
            y = 0;
        for (var i = 1; i < plots; i++) {
            angle += increase;
        }

        x = (height + height * 0.35) * Math.cos(angle) + height;
        y = (height + height * 0.35) * Math.sin(angle) + height;

        if (percent == 50) x = x - jQuery(this).width() / 2;
        if (percent > 50) x = x - jQuery(this).width();
        if (percent > 50 || percent < 26) y = y - jQuery(this).height() / 2;
        jQuery(this).css({
            'left': x,
            'top': y
        });

        var position = jQuery(this).find('img').position();
        var T = position.top + jQuery(this).find('img').height() + 40;
        var L = position.left - 160 + jQuery(this).width() / 2;
        jQuery(this).find('.content').css({
            'top': T,
            'left': L
        });
    });

    var i = 1;
    var k = 0;
    jQuery('.diagram_skills .sc_skills .line').each(function () {
        var percent = jQuery(this).parent().find('canvas').attr('data-percent');
        var ItemHeight = jQuery(this).parent().find('canvas').height();
        var LineHeight = ItemHeight + ItemHeight * 0.35;
        plots = percent * 10 - 250;
        increase = Math.PI * 2 / 1000,
            angle = 0,
            x = 0,
            y = 0;
        var U = percent * 360 / 100;
        k = k + 30;
        if (percent > 50) x = x - jQuery(this).width();
        jQuery(this).css({
            'height': LineHeight,
            'transform': 'rotate(' + U + 'deg)',
            'left': (ItemHeight / 2),
            'top': ((ItemHeight - LineHeight) / 2)
        });
        var t = jQuery(this).parent().find('canvas').height() * 0.18 * i + 26;
        jQuery(this).find('.tail').css('height', t);
        // i = i + 0.32;
    });

    jQuery('.diagram_skills .item img').mouseover(function () {
        jQuery(this).parent().find('.content').show();
    });

    jQuery('.diagram_skills .item img').mouseout(function () {
        jQuery(this).parent().find('.content').hide();
    });
}

