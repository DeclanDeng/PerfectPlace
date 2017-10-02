jQuery(document).ready(function () {
    "use strict";

    jQuery('.anim .gallery_posts .follow').each(function () {
        jQuery(this).hoverdir();
    });
});


var curIsotopeFilter = '*';
var curIsotopePage = '';
jQuery(window).load(function () {
    "use strict";

    if (jQuery('.iso_items ').length !== 0) {
        gallery_iso_init();
        jQuery('.isotope_block .iso_filters.cats').on('click', 'li a', function () {
            var selector = jQuery(this).attr('data-filter');
            var block_id = jQuery(this).parents('.isotope_block').attr('id');
            curIsotopePage = selector;

            jQuery('#' + block_id + '  .iso_items.isotope').isotope({
                filter: getIsotopeFilter()
            });
            jQuery(this).parents('.iso_filters.cats').find('a').removeClass('current');
            jQuery(this).addClass('current');
            return false;
        });
    }
	
	if(jQuery('body').hasClass('boxed')){
		if (jQuery(window).width() > 1230) Gallery(4);
		if (jQuery(window).width() <= 1230) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
	else{
		if (jQuery(window).width() > 1170) Gallery(4);
		if (jQuery(window).width() <= 1170) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
	
    jQuery('.gallery_posts .isotope_single_item').click(function () {
		if(jQuery(window).width() > 440){
			var items = '';
			var index = jQuery(this).index() + 1;
			var count = jQuery('.gallery_posts .isotope_single_item').length + 1;

			for (var i = index; i < count; i++) {
				var image = jQuery('.isotope_single_item:nth-child(' + i + ')').find('.gallery_thumb').html();
				items = items + '<li>' + image + '</li>';
			}

			for (var i = 1; i < index; i++) {
				var image = jQuery('.isotope_single_item:nth-child(' + i + ')').find('.gallery_thumb').html();
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

			jQuery('.mask img').css('margin-left', 0);

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
	
	if(jQuery('body').hasClass('boxed')){
		if (jQuery(window).width() > 1230) Gallery(4);
		if (jQuery(window).width() <= 1230) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
	else{
		if (jQuery(window).width() > 1170) Gallery(4);
		if (jQuery(window).width() <= 1170) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
});

jQuery(window).resize(function () {
    "use strict";

	if(jQuery('body').hasClass('boxed')){
		if (jQuery(window).width() > 1230) Gallery(4);
		if (jQuery(window).width() <= 1230) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
	else{
		if (jQuery(window).width() > 1170) Gallery(4);
		if (jQuery(window).width() <= 1170) Gallery(3);
		if (jQuery(window).width() <= 984) Gallery(2);
		if (jQuery(window).width() <= 440) Gallery(1);
	}
});

function Gallery(x) {
  

    var containerWidth = jQuery(window).width() - 60;
	if(jQuery('body').hasClass('boxed')) containerWidth = jQuery('.box').width() - 60;
    var itemSize = containerWidth / x - 0.5;

    jQuery('.gallery_container').width(containerWidth);
    jQuery('.gallery_container .isotope_single_item').width(itemSize);
    jQuery('.gallery_container .isotope_single_item').height(itemSize);

    var imageWidth = jQuery('.gallery_container .isotope_single_item .gallery_thumb img').width();
    var left = (itemSize - imageWidth) / 2;
    jQuery('.gallery_container .isotope_single_item .gallery_thumb img').css('margin-left', left); 
	

    jQuery('.gallery_container .isotope_single_item .post_info').each(function () {

        var contentHeight = jQuery(this).find('.gallery_title').height() + jQuery(this).find('.post_cats').height();
        var x = (itemSize - contentHeight) / 2;
        jQuery(this).find('.gallery_title').css('margin-top', x);
    });

    setTimeout(function () {
        jQuery('.isotope_block .iso_filters li .current').click();
    }, 5);
}

var chart_flag = false;
var chart_invise = false;
var init_attempts = 0;

function gallery_iso_init() {
    "use strict";
    themerex_count = 0;

    jQuery('.iso_items .hentry img').each(function () {
        if (jQuery(this).get(0).complete) {
            themerex_count++;
        }
    });
    if (jQuery('.iso_items .hentry img').length === themerex_count || init_attempts >= 10) {
        jQuery('.iso_items .hentry').show();
        jQuery('.iso_items')
            .isotope({
                itemSelector: '.isotope_single_item',
                transformsEnabled: true,
                duration: 750,
                resizable: true,
                resizesContainer: true,
                layoutMode: 'masonry',
                masonry: {
                    gutterWidth: 10
                },
                filter: '*'
            });
    } else {
        init_attempts++;
        setTimeout(function () {
            gallery_iso_init();
        }, 100);
    }
}

function getIsotopeFilter() {
    "use strict";
    var flt = curIsotopeFilter != '*' ? curIsotopeFilter : '';
    flt += curIsotopePage != '' ? ((flt != '' ? '' : '') + curIsotopePage) : '';
    flt == '' ? '*' : '';
    return flt;
}


var themerex_count = 0;