/*

Template:  dominno
Author: author name
Version: 1
Design and Developed by: Devitems

*/
/*================================================
[  Table of contents  ]
================================================
	01. Menu
	02. Owl Carousel
	03. ScrollUp jquery
	04. wow js active
	05. jQuery MeanMenu
	06. Counter Up
	07. Textilate Activation
	08. Price slider active
	09. Video Player
	10. Mail Chimp
	11. Testimonial Slick Carousel
 
======================================
[ End table content ]
======================================*/


(function($) {
    "use strict";
    
/*------------------------------------
    01. Menu
-------------------------------------- */  
/*------------------------------------
    Menu Active Class
-------------------------------------- */
    $("ul.main-menu li").click(function(){
        $(this).addClass("active");
    });
    
/*------------------------------------
    Menu Stick
-------------------------------------- */
	$(window).on('scroll',function() {    
		var scroll = $(window).scrollTop();
		if (scroll < 245) {
			$("#sticky-header").removeClass("sticky");
		}else{
			$("#sticky-header").addClass("sticky");
		}
	});
	
/*------------------------------------
    02. Owl Carousel
------------------------------------- */
/*------------------------------------
    Property Carousel
------------------------------------- */
	$('.property-carousel').owlCarousel({
		loop:true,
        autoPlay: false, 
        smartSpeed: 2000,
        fluidSpeed: true,
        items : 3,
        responsiveClass:true,
        nav:false,
        pagination:true,
        responsive:{
            0:{
                items:1
            },
            480:{
                items:1
            },
            768:{
                items:2
            }, 
            992:{
                items:2
            }, 
            1200:{
                items:3
            }
		}       
    }); 	
/*------------------------------------
    Blog Carousel
------------------------------------- */
	$('.blog-carousel').owlCarousel({
		loop:true,
        autoPlay: false, 
        smartSpeed: 2000,
        fluidSpeed: true,
		nav:false,
        pagination:true,
        responsiveClass:true,
        responsive:{
            0:{
                items:1 // from 0px up to 479px screen size 
            },
            480:{
                items:1, // from 480 to 677 
            },
            678:{
                items:2, // from this breakpoint 678 to 959
            },
            960:{
                items:2, // from this breakpoint 960 to 1199
            },
            1200:{
                items:3,
            }
        }        
    });
    
/* portfolio active  */ 
$('.properties-slider').owlCarousel({
    loop:true,
    items:1,
    dots:false,
    animateOut: 'fadeOut',
    animateIn: 'fadeIn',	
    nav:true,
    navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})
    
/* portfolio active  */ 
$('.properties-tab-slider').owlCarousel({
    loop:true,
    items:6,
    margin:20,
    dots:false,
    animateOut: 'fadeOut',
    animateIn: 'fadeIn',	
    nav:true,
    navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
    responsive:{
        0:{
            items:3
        },
        600:{
            items:6
        },
        1000:{
            items:6
        }
    }
})
    
    
/*------------------------------------
    Client Carousel
------------------------------------- */
	$('.client-carousel').owlCarousel({
		loop:true,
        autoPlay: false, 
        smartSpeed: 2000,
        fluidSpeed: true,
        items : 5,
        responsiveClass:true,
        nav:false,
        pagination:true,
        responsive:{
            0:{
                items:1
            },
            480:{
                items:2
            },
            768:{
                items:3
            }, 
            992:{
                items:4
            }, 
            1200:{
                items:5
            }
		}
    }); 	
	
/*-------------------------------------------
    03. ScrollUp jquery
--------------------------------------------- */
    $.scrollUp({
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });   
    
/*-------------------------------------------
    04. wow js active
--------------------------------------------- */
    new WOW().init();
    
/*-------------------------------------------
    05. jQuery MeanMenu
--------------------------------------------- */
	jQuery('nav#dropdown').meanmenu();
	
/*--------------------------
    06. Counter Up
---------------------------- */	
    $('.counter').counterUp({
        delay: 70,
        time: 5000
    }); 
    
/*------------------------------------
	07. Textilate Activation
--------------------------------------*/
    $('.tlt').textillate({
        loop: true,
        minDisplayTime: 2500
    });
	
/*------------------------------------
	08. Price slider active
--------------------------------------*/
    $( ".slider-range" ).slider({
        range: true,
        min: 80,
        max: 2500,
        values: [ 300, 2000 ],
        slide: function( event, ui ) {
		$( ".amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
        }
    });
    $( ".amount" ).val( "$" + $( ".slider-range" ).slider( "values", 0 ) +
	   " - $" + $( ".slider-range" ).slider( "values", 1 ) ); 
	
/*------------------------------------
	09. Video Player
--------------------------------------*/
    $(".player").YTPlayer({
        showControls: false
    });    
    
    $(".player-small").YTPlayer({
        showControls: true
    });
    
    $(".player-blog").YTPlayer({
        showControls: true
    });
    
/*------------------------------------
	10. Mail Chimp
--------------------------------------*/
    $('#mc-form').ajaxChimp({
        language: 'en',
        callback: mailChimpResponse,
        // ADD YOUR MAILCHIMP URL BELOW HERE!
        url: 'http://themeshaven.us8.list-manage.com/subscribe/post?u=759ce8a8f4f1037e021ba2922&amp;id=a2452237f8'
    });
    
    function mailChimpResponse(resp) {
        
        if (resp.result === 'success') {
            $('.mailchimp-success').html('' + resp.msg).fadeIn(900);
            $('.mailchimp-error').fadeOut(400);
            
        } else if(resp.result === 'error') {
            $('.mailchimp-error').html('' + resp.msg).fadeIn(900);
        }  
    }
	
/*------------------------------------
	11. Testimonial Slick Carousel 
--------------------------------------*/
    $('.testimonial-image-slider').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        dots: true,
        arrows: false,
        centerMode: true,
        focusOnSelect: true,
        centerPadding: '10px',
		responsive: [
			{
			  breakpoint: 992,
			  settings: {
				slidesToShow: 1,
				slidesToScroll: 3,
				infinite: true,
				dots: true
			  }
			},
			{
			  breakpoint: 600,
			  settings: {
				slidesToShow: 1,
				slidesToScroll: 1
			  }
			},
			{
			  breakpoint: 480,
			  settings: {
				slidesToShow: 1,
				slidesToScroll: 1
			  }
			}
		]
    });
	
    
})(jQuery);