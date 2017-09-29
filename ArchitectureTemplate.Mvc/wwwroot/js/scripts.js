function Atropos() {
    _topNav(), _animate(), _superslide(), _owl_carousel(), _popover(), _lightbox(), _scrollTo(), _parallax(), _masonry(), _toggle(), _globalSearch(), _quickCart(), _placeholder(), _htmlEditor(), jQuery("a[data-toggle=tooltip]").tooltip(), jQuery(".fullwidthbanner iframe").length < 1 && jQuery(".fullscreenbanner iframe").length < 1 && jQuery(".fullscreenvideo").length < 1 && jQuery("body").fitVids(), jQuery().slider && jQuery(".price-slider").length > 0 && jQuery("#Slider2").slider(slider_config), jQuery(document).bind("click", function () {
        jQuery("div.navbar-collapse").hasClass("in") && jQuery("button.btn-mobile").trigger("click");
    });
}

function _topNav() {
    function e() {
        jQuery("#topHead").length > 0 ? (window._headHeight = jQuery("header#topHead").outerHeight() + jQuery("header#topNav").outerHeight() - 10, window._headHeightSmall = 66, jQuery("#wrapper").css({
            "padding-top": window._headHeight + "px"
        }), jQuery("#topHead").removeClass("fixed").addClass("fixed"), jQuery("#header_shadow").length > 0 && jQuery("#header_shadow").css({
            top: window._headHeight + "px"
        })) : jQuery(window).width() < 1006 ? (jQuery("#wrapper").css({
            "margin-top": "-30px"
        }), jQuery("#header_shadow").css({
            top: "40px"
        })) : (jQuery("#wrapper").css({
            "margin-top": "0px"
        }), jQuery("#header_shadow").css(jQuery(window).scrollTop() > 3 ? {
            top: "60px"
        } : {
            top: "80px"
        }));
    }

    function t() {
        var e = jQuery(document).scrollTop();
        window.topNavSmall === !1 && e > 0 && (jQuery("header#topNav div.nav-main-collapse").addClass("topFix"),
        jQuery("#topNav").stop().animate({ height: "60px" }, 400),
        jQuery("header#topNav div.nav-main-collapse").stop().animate({ "margin-top": "6px" }, 400),
        jQuery("header#topNav button").stop().animate({ "margin-top": "0" }, 100),
        jQuery("header#topNav a.logo").stop().animate({ "margin-top": "-10px" }, 400),
        jQuery("#header_shadow").length > 0 &&
        jQuery("#header_shadow").stop().animate({ top: window._headHeightSmall + "px" }, 400), window.topNavSmall = !0),
        window.topNavSmall === !0 && 3 > e && (jQuery("header#topNav div.nav-main-collapse").removeClass("topFix"),
        jQuery("#topNav").stop().animate({ height: "81px" }, 400),
        jQuery("header#topNav div.nav-main-collapse").stop().animate({ "margin-top": "16px" }, 400),
        jQuery("header#topNav button").stop().animate({ "margin-top": "8px" }, 100),
        jQuery("header#topNav a.logo").stop().animate({ "line-height": "50px", "margin-top": "0" }, 400),
        jQuery("#header_shadow").length > 0 && jQuery("#header_shadow").stop().animate({ top: window._headHeight + "px" }, 400), window.topNavSmall = !1)
    }
    var a = !1;
    jQuery("#topMain li.dropdown > a, #topMain li.dropdown-submenu > a").bind("click", function (e) {
        "#" == jQuery(this).attr("href") && e.preventDefault(), e.stopPropagation(), jQuery(window).width() > 979 || (a = jQuery(this).parent().hasClass("resp-active"), jQuery("#topMain").find(".resp-active").removeClass("resp-active"), a || jQuery(this).parents("li").addClass("resp-active"))
    }), jQuery("#topHead .dropdown-menu, #topNav .mega-menu .dropdown-menu").bind("click", function (e) {
        e.stopPropagation()
    }), jQuery(window).scroll(function () {
        jQuery(window).width() > 1006 && t()
    }), jQuery(window).width() > 1006 && t(), window._headHeight = 81, window._headHeightSmall = 30, jQuery(window).resize(function () {
        e()
    }), e(), window.topNavSmall = !1
}

function _animate() {
    jQuery("[data-animation]").each(function () {
        var e = jQuery(this);
        jQuery(window).width() > 767 ? e.appear(function () {
            var t = e.attr("data-animation-delay") ? e.attr("data-animation-delay") : 1;
            t > 1 && e.css("animation-delay", t + "ms"), e.addClass(e.attr("data-animation")), setTimeout(function () {
                e.addClass("animation-visible")
            }, t)
        }, {
            accX: 0,
            accY: -150
        }) : e.addClass("animation-visible")
    }), jQuery("[data-appear-progress-animation]").each(function () {
        var e = jQuery(this);
        jQuery(window).width() > 767 ? e.appear(function () {
            _delay = 1, e.attr("data-appear-progress-animation-delay") && (_delay = e.attr("data-appear-progress-animation-delay")), _delay > 1 && e.css("animation-delay", _delay + "ms"), e.addClass(e.attr("data-appear-progress-animation")), setTimeout(function () {
                e.addClass("animation-visible")
            }, _delay)
        }, {
            accX: 0,
            accY: -150
        }) : e.addClass("animation-visible")
    }), jQuery("[data-appear-progress-animation]").each(function () {
        var e = jQuery(this);
        e.appear(function () {
            var t = e.attr("data-appear-animation-delay") ? e.attr("data-appear-animation-delay") : 1;
            t > 1 && e.css("animation-delay", t + "ms"), e.addClass(e.attr("data-appear-animation")), setTimeout(function () {
                e.animate({
                    width: e.attr("data-appear-progress-animation")
                }, 1e3, "easeOutQuad", function () {
                    e.find(".progress-bar-tooltip").animate({
                        opacity: 1
                    }, 500, "easeOutQuad")
                })
            }, t)
        }, {
            accX: 0,
            accY: -50
        })
    }), jQuery(".countTo [data-to]").each(function () {
        var e = jQuery(this);
        e.appear(function () {
            e.countTo()
        }, {
            accX: 0,
            accY: -150
        })
    }), jQuery().knob && jQuery(".knob").knob(), jQuery(".animate_from_top").each(function () {
        jQuery(this).appear(function () {
            jQuery(this).delay(150).animate({
                opacity: 1,
                top: "0px"
            }, 1e3)
        })
    }), jQuery(".animate_from_bottom").each(function () {
        jQuery(this).appear(function () {
            jQuery(this).delay(150).animate({
                opacity: 1,
                bottom: "0px"
            }, 1e3)
        })
    }), jQuery(".animate_from_left").each(function () {
        jQuery(this).appear(function () {
            jQuery(this).delay(150).animate({
                opacity: 1,
                left: "0px"
            }, 1e3)
        })
    }), jQuery(".animate_from_right").each(function () {
        jQuery(this).appear(function () {
            jQuery(this).delay(150).animate({
                opacity: 1,
                right: "0px"
            }, 1e3)
        })
    }), jQuery(".animate_fade_in").each(function () {
        jQuery(this).appear(function () {
            jQuery(this).delay(350).animate({
                opacity: 1,
                right: "0px"
            }, 1e3)
        })
    })
}

function _superslide() {
    if (jQuery("#slider").length > 0) {
        var e = jQuery("#slider").attr("data-autoplay"),
            t = jQuery("#slider").attr("data-mouseover-stop");
        if (e)
            if ("" == e) var e = !1;
            else var e = parseInt(e);
        else var e = !1;
        e || (t = !1), jQuery("#slider").superslides({
            animation: "fade",
            pagination: !0,
            play: e,
            animation_speed: 600,
            elements: {
                preserve: ".preserve",
                nav: ".slides-navigation",
                container: ".slides-container",
                pagination: ".slides-pagination"
            }
        }), "true" == t && (jQuery("#slider").on("mouseenter", function () {
            jQuery(this).superslides("stop")
        }), jQuery("#slider").on("mouseleave", function () {
            jQuery(this).superslides("start")
        })), jQuery(window).load(function () {
            jQuery("#slider").css({
                background: "none"
            })
        })
    }
}

function _owl_carousel() {
    jQuery("div.owl-carousel").length;
    jQuery("div.owl-carousel").each(function () {
        var e = jQuery(this),
            t = e.attr("data-plugin-options"),
            a = {
                items: 5,
                itemsCustom: !1,
                itemsDesktop: [1199, 4],
                itemsDesktopSmall: [980, 3],
                itemsTablet: [768, 2],
                itemsTabletSmall: !1,
                itemsMobile: [479, 1],
                singleItem: !0,
                itemsScaleUp: !1,
                slideSpeed: 200,
                paginationSpeed: 800,
                rewindSpeed: 1e3,
                autoPlay: !1,
                stopOnHover: !1,
                navigation: !1,
                navigationText: ['<i class="fa fa-chevron-left"></i>', '<i class="fa fa-chevron-right"></i>'],
                rewindNav: !0,
                scrollPerPage: !1,
                pagination: !0,
                paginationNumbers: !1,
                responsive: !0,
                responsiveRefreshRate: 200,
                responsiveBaseWidth: window,
                baseClass: "owl-carousel",
                theme: "owl-theme",
                lazyLoad: !1,
                lazyFollow: !0,
                lazyEffect: "fade",
                autoHeight: !1,
                jsonPath: !1,
                jsonSuccess: !1,
                dragBeforeAnimFinish: !0,
                mouseDrag: !0,
                touchDrag: !0,
                transitionStyle: !1,
                addClassActive: !1,
                beforeUpdate: !1,
                afterUpdate: !1,
                beforeInit: !1,
                afterInit: !1,
                beforeMove: !1,
                afterMove: !1,
                afterAction: !1,
                startDragging: !1,
                afterLazyLoad: !1
            },
            o = jQuery.extend({}, a, t, e.data("plugin-options"));
        e.owlCarousel(o).addClass("owl-carousel-init")
    })
}

function _popover() {
    jQuery("a[data-toggle=popover]").bind("click", function (e) {
        jQuery(".popover-title .close").remove(), e.preventDefault()
    });
    var e = !1,
        t = !1;
    jQuery("a[data-toggle=popover], button[data-toggle=popover]").popover({
        html: !0,
        trigger: "manual"
    }).click(function (a) {
        jQuery(this).popover("show"), t = !1, e = !0, a.preventDefault()
    }), jQuery(document).click(function () {
        e & t ? (jQuery("a[data-toggle=popover], button[data-toggle=popover]").popover("hide"), e = t = !1) : t = !0
    }), jQuery("a[data-toggle=popover], button[data-toggle=popover]").popover({
        html: !0,
        trigger: "manual"
    }).click(function (e) {
        $(this).popover("show"), $(".popover-title").append('<button type="button" class="close">&times;</button>'), $(".close").click(function () {
            jQuery("a[data-toggle=popover], button[data-toggle=popover]").popover("hide")
        }), e.preventDefault()
    })
}

function _lightbox() {
    return "undefined" == typeof jQuery.magnificPopup ? !1 : (jQuery.extend(!0, jQuery.magnificPopup.defaults, {
        tClose: "Close",
        tLoading: "Loading...",
        gallery: {
            tPrev: "Previous",
            tNext: "Next",
            tCounter: "%curr% / %total%"
        },
        image: {
            tError: "Image not loaded!"
        },
        ajax: {
            tError: "Content not loaded!"
        }
    }), void jQuery(".lightbox").each(function () {
        var e = jQuery(this),
            t = e.attr("data-plugin-options"),
            a = {},
            o = {
                type: "image",
                fixedContentPos: !1,
                fixedBgPos: !1,
                mainClass: "mfp-no-margins mfp-with-zoom",
                image: {
                    verticalFit: !0
                },
                zoom: {
                    enabled: !1,
                    duration: 300
                },
                gallery: {
                    enabled: !1,
                    navigateByImgClick: !0,
                    preload: [0, 1],
                    arrowMarkup: '<button title="%title%" type="button" class="mfp-arrow mfp-arrow-%dir%"></button>',
                    tPrev: "Previou",
                    tNext: "Next",
                    tCounter: '<span class="mfp-counter">%curr% / %total%</span>'
                }
            };
        e.data("plugin-options") && (a = jQuery.extend({}, o, t, e.data("plugin-options"))), jQuery(this).magnificPopup(a)
    }))
}

function _scrollTo() {
    jQuery("a.scrollTo").bind("click", function (e) {
        e.preventDefault();
        var t = jQuery(this).attr("href");
        "#" != t && jQuery("html,body").animate({
            scrollTop: jQuery(t).offset().top - 60
        }, 1e3, "easeInOutExpo")
    }), jQuery("a.toTop").bind("click", function (e) {
        e.preventDefault(), jQuery("html,body").animate({
            scrollTop: 0
        }, 1e3, "easeInOutExpo")
    })
}

function _parallax() {
    return "undefined" == typeof jQuery.stellar ? (jQuery(".parallax").addClass("parallax-init"), !1) : void jQuery(window).load(function () {
        jQuery(".parallax").length > 0 && (Modernizr.touch ? jQuery(".parallax").addClass("disabled") : jQuery(window).stellar({
            responsive: !0,
            scrollProperty: "scroll",
            parallaxElements: !1,
            horizontalScrolling: !1,
            horizontalOffset: 0,
            verticalOffset: 0
        })), jQuery(".parallax").addClass("parallax-init"), jQuery(window).afterResize(function () {
            jQuery.stellar("refresh")
        })
    })
}

function _masonry() {
    jQuery(window).load(function () {
        jQuery("span.js_loader").remove(), jQuery("li.masonry-item").addClass("fadeIn"), jQuery(".masonry-list").each(function () {
            var e = jQuery(this);
            e.waitForImages(function () {
                e.masonry({
                    itemSelector: ".masonry-item"
                })
            })
        })
    }), jQuery("ul.isotope-filter").each(function () {
        var e = jQuery(this),
            t = jQuery("ul.sort-destination[data-sort-id=" + jQuery(this).attr("data-sort-id") + "]");
        t.get(0) && jQuery(window).load(function () {
            t.isotope({
                itemSelector: "li",
                layoutMode: "sloppyMasonry"
            }), e.find("a").click(function (a) {
                a.preventDefault();
                var o = jQuery(this),
                    r = o.parents(".sort-source").attr("data-sort-id"),
                    i = o.parent().attr("data-option-value");
                return e.find("li.active").removeClass("active"), o.parent().addClass("active"), t.isotope({
                    filter: i
                }), jQuery(".sort-source-title[data-sort-id=" + r + "] strong").html(o.html()), !1
            })
        })
    }), jQuery(window).load(function () {
        jQuery("ul.isotope").addClass("fadeIn")
    })
}

function _toggle() {
    var e = 25;
    jQuery("div.toggle.active > p").addClass("preview-active"), jQuery("div.toggle.active > div.toggle-content").slideDown(400), jQuery("div.toggle > label").click(function (t) {
        var a = jQuery(this).parent(),
            o = jQuery(this).parents("div.toogle"),
            r = !1,
            i = o.hasClass("toogle-accordion");
        if (i && "undefined" != typeof t.originalEvent && o.find("div.toggle.active > label").trigger("click"), a.toggleClass("active"), a.find("> p").get(0)) {
            r = a.find("> p");
            var n = r.css("height"),
                s = r.css("height");
            r.css("height", "auto"), r.css("height", n)
        }
        var l = a.find("> div.toggle-content");
        a.hasClass("active") ? (jQuery(r).animate({
            height: s
        }, 350, function () {
            jQuery(this).addClass("preview-active")
        }), l.slideDown(350)) : (jQuery(r).animate({
            height: e
        }, 350, function () {
            jQuery(this).removeClass("preview-active")
        }), l.slideUp(350))
    })
}

//function _bgimage() {
//    function e() {
//        var e = jQuery("body").attr("data-background");
//        e && (jQuery.backstretch(e), jQuery("body").addClass("transparent"))
//    }
//    jQuery("body").hasClass("boxed") && e()
//}

function _globalSearch() {
    jQuery("li.search, li.search input").bind("click", function (e) {
        e.stopPropagation()
    }), jQuery("li.search input").bind("click", function () {
        return !1
    }), jQuery("li.search").bind("click", function () {
        jQuery(this).hasClass("open") ? (disable_overlay(), enable_scroll(), jQuery(this).removeClass("open")) : (enable_overlay(), disable_scroll(), jQuery(this).addClass("open"), jQuery("li.quick-cart").removeClass("open"))
    }), jQuery(document).keydown(function (e) {
        var t = e.keyCode ? e.keyCode : e.which;
        27 == t && (jQuery("li.search, li.quick-cart").removeClass("open"), disable_overlay(), enable_scroll())
    }), jQuery(document).bind("click", function () {
        jQuery("li.search").hasClass("open") && (jQuery("li.search, li.quick-cart").removeClass("open"), disable_overlay(), enable_scroll())
    })
}

function _quickCart() {
    jQuery("li.quick-cart").bind("click", function () {
        return jQuery("li.quick-cart .quick-cart-content").bind("click", function (e) {
            e.stopPropagation()
        }), jQuery(this).hasClass("open") ? (disable_overlay(), enable_scroll(), jQuery(this).removeClass("open")) : (enable_overlay(), disable_scroll(), jQuery(this).addClass("open"), jQuery("li.search").removeClass("open")), !1
    }), jQuery(document).keydown(function (e) {
        var t = e.keyCode ? e.keyCode : e.which;
        27 == t && (jQuery("li.search, li.quick-cart").removeClass("open"), disable_overlay(), enable_scroll())
    }), jQuery(document).bind("click", function () {
        jQuery("li.quick-cart").hasClass("open") && (jQuery("li.search, li.quick-cart").removeClass("open"), disable_overlay(), enable_scroll())
    })
}

function _placeholder() {
    -1 != navigator.appVersion.indexOf("MSIE") && jQuery("[placeholder]").focus(function () {
        var e = jQuery(this);
        e.val() == e.attr("placeholder") && (e.val(""), e.removeClass("placeholder"))
    }).blur(function () {
        var e = jQuery(this);
        ("" == e.val() || e.val() == e.attr("placeholder")) && (e.addClass("placeholder"), e.val(e.attr("placeholder")))
    }).blur()
}

function _htmlEditor() {
    jQuery("textarea.summernote").length > 0 && jQuery().summernote && jQuery("textarea.summernote").each(function () {
        jQuery(this).summernote({
            height: jQuery(this).attr("data-height") || 200,
            toolbar: [
                ["fontsize", ["fontsize"]],
                ["style", ["bold", "italic", "underline", "strikethrough", "clear"]],
                ["para", ["ul", "ol", "paragraph"]],
                ["table", ["table"]],
                ["media", ["link", "picture", "video"]],
                ["misc", ["codeview"]]
            ]
        })
    })
}

function wheel(e) {
    e.preventDefault()
}

function disable_scroll() {
    window.addEventListener && window.addEventListener("DOMMouseScroll", wheel, !1), window.onmousewheel = document.onmousewheel = wheel
}

function enable_scroll() {
    window.removeEventListener && window.removeEventListener("DOMMouseScroll", wheel, !1), window.onmousewheel = document.onmousewheel = document.onkeydown = null
}

function enable_overlay() {
    jQuery("span.global-overlay").remove(), jQuery("body").append('<span class="global-overlay"></span>')
}

function disable_overlay() {
    jQuery("span.global-overlay").remove()
}

function eventClickTrigger() {
    jQuery("video").trigger("click")
}

function resizeToCover() {
    jQuery(".video-wrap").width(jQuery(window).width()), jQuery(".video-wrap").height(jQuery(window).height());
    var e = jQuery(window).width() / vid_w_orig,
        t = jQuery(window).height() / vid_h_orig,
        a = e > t ? e : t;
    min_w > a * vid_w_orig && (a = min_w / vid_w_orig), jQuery("video, source").width(a * vid_w_orig), jQuery("video, source").height(a * vid_h_orig), jQuery(".video-wrap").scrollLeft((jQuery("video").width() - jQuery(window).width()) / 2), jQuery(".video-wrap").scrollTop((jQuery("video").height() - jQuery(window).height()) / 2)
}

//function contactMap() {
//    var e = new google.maps.LatLng($googlemap_latitude, $googlemap_longitude),
//        t = {
//            zoom: $googlemap_zoom,
//            center: e,
//            disableDefaultUI: !1,
//            navigationControl: !1,
//            mapTypeControl: !1,
//            scrollwheel: !1,
//            mapTypeId: google.maps.MapTypeId.ROADMAP
//        },
//        a = new google.maps.Map(document.getElementById("gmap"), t);
//    google.maps.event.trigger(a, "resize"), a.setZoom(a.getZoom());
//    var o = new google.maps.Marker({
//        icon: "data:image/png;base64,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",
//        position: e,
//        map: a,
//        title: ""
//    });
//    o.setMap(a), google.maps.event.addListener(o, "click", function() {}), google.maps.event.addDomListener(window, "resize", function() {
//        a.setCenter(e)
//    })
//}

function showMap(e) {
    var t = document.createElement("script");
    t.type = "text/javascript", t.src = "https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=true&callback=" + e, document.body.appendChild(t)
}
if (jQuery(window).ready(function () {
        Atropos()
}), jQuery().mediaelementplayer && jQuery("video").length > 0 && jQuery(".fullscreenbanner video").length < 1 && jQuery(".fullwidthbanner video").length < 1) {
    jQuery("video").mediaelementplayer({
        defaultVideoWidth: 480,
        defaultVideoHeight: 270,
        videoWidth: "100%",
        videoHeight: "100%",
        audioWidth: 400,
        audioHeight: 30,
        startVolume: .8,
        loop: !0,
        enableAutosize: !0,
        features: ["playpause", "progress", "current", "duration", "tracks", "volume", "fullscreen"],
        alwaysShowControls: !1,
        iPadUseNativeControls: !1,
        iPhoneUseNativeControls: !1,
        AndroidUseNativeControls: !1,
        alwaysShowHours: !1,
        showTimecodeFrameCount: !1,
        framesPerSecond: 25,
        enableKeyboard: !0,
        pauseOtherPlayers: !0,
        keyActions: []
    }), setTimeout("eventClickTrigger()", 1e3);
    var min_w = 300,
        vid_w_orig, vid_h_orig;
    jQuery(function () {
        vid_w_orig = parseInt(jQuery("video, source").attr("width")), vid_h_orig = parseInt(jQuery("video, source").attr("height")), jQuery(window).resize(function () {
            resizeToCover()
        })
    })
}
jQuery("#gmap").length > 0 && showMap("contactMap"), jQuery("div.fb-like").length > 0 && (jQuery("body").append('<div id="fb-root"></div>'), function (e, t, a) {
    var o, r = e.getElementsByTagName(t)[0];
    e.getElementById(a) || (o = e.createElement(t), o.id = a, o.src = "//connect.facebook.net/en_US/all.js#xfbml=1", r.parentNode.insertBefore(o, r))
}(document, "script", "facebook-jssdk")), jQuery("div.g-plusone").length > 0 && ! function () {
    var e = document.createElement("script");
    e.type = "text/javascript", e.async = !0, e.src = "https://apis.google.com/js/platform.js";
    var t = document.getElementsByTagName("script")[0];
    t.parentNode.insertBefore(e, t)
}(), jQuery("a.twitter-share-button").length > 0 && ! function (e, t, a) {
    var o, r = e.getElementsByTagName(t)[0];
    e.getElementById(a) || (o = e.createElement(t), o.id = a, o.src = "https://platform.twitter.com/widgets.js", r.parentNode.insertBefore(o, r))
}(),
    function (e) {
        "use strict";
        var t, a = {
            action: function () { },
            runOnLoad: !1,
            duration: 500
        },
            o = a,
            r = !1,
            i = {};
        i.init = function () {
            for (var e = 0; e <= arguments.length; e++) {
                var t = arguments[e];
                switch (typeof t) {
                    case "function":
                        o.action = t;
                        break;
                    case "boolean":
                        o.runOnLoad = t;
                        break;
                    case "number":
                        o.duration = t
                }
            }
            return this.each(function () {
                o.runOnLoad && o.action(), jQuery(this).resize(function () {
                    i.timedAction.call(this)
                })
            })
        }, i.timedAction = function (e, a) {
            var i = function () {
                var e = o.duration;
                if (r) {
                    var a = new Date - t;
                    if (e = o.duration - a, 0 >= e) return clearTimeout(r), r = !1, void o.action()
                }
                n(e)
            },
                n = function (e) {
                    r = setTimeout(i, e)
                };
            t = new Date, "number" == typeof a && (o.duration = a), "function" == typeof e && (o.action = e), r || i()
        }, e.fn.afterResize = function (e) {
            return i[e] ? i[e].apply(this, Array.prototype.slice.call(arguments, 1)) : i.init.apply(this, arguments)
        }
    }(jQuery),
    function (e) {
        function t(e, t) {
            return e.toFixed(t.decimals)
        }
        e.fn.countTo = function (t) {
            return t = t || {}, jQuery(this).each(function () {
                function a() {
                    d += n, u++, o(d), "function" == typeof r.onUpdate && r.onUpdate.call(s, d), u >= i && (l.removeData("countTo"), clearInterval(c.interval), d = r.to, "function" == typeof r.onComplete && r.onComplete.call(s, d))
                }

                function o(e) {
                    var t = r.formatter.call(s, e, r);
                    l.html(t)
                }
                var r = jQuery.extend({}, e.fn.countTo.defaults, {
                    from: jQuery(this).data("from"),
                    to: jQuery(this).data("to"),
                    speed: jQuery(this).data("speed"),
                    refreshInterval: jQuery(this).data("refresh-interval"),
                    decimals: jQuery(this).data("decimals")
                }, t),
                    i = Math.ceil(r.speed / r.refreshInterval),
                    n = (r.to - r.from) / i,
                    s = this,
                    l = jQuery(this),
                    u = 0,
                    d = r.from,
                    c = l.data("countTo") || {};
                l.data("countTo", c), c.interval && clearInterval(c.interval), c.interval = setInterval(a, r.refreshInterval), o(d)
            })
        }, e.fn.countTo.defaults = {
            from: 0,
            to: 0,
            speed: 1e3,
            refreshInterval: 100,
            decimals: 0,
            formatter: t,
            onUpdate: null,
            onComplete: null
        }
    }(jQuery),
    function (e) {
        "use strict";
        e.fn.fitVids = function (e) {
            var t = {
                customSelector: null
            };
            if (!document.getElementById("fit-vids-style")) {
                var a = document.createElement("div"),
                    o = document.getElementsByTagName("base")[0] || document.getElementsByTagName("script")[0];
                a.className = "fit-vids-style", a.id = "fit-vids-style", a.style.display = "none", a.innerHTML = "&shy;<style>                 .fluid-width-video-wrapper {                   width: 100%;                                position: relative;                         padding: 0;                              }                                                                                       .fluid-width-video-wrapper iframe,          .fluid-width-video-wrapper object,          .fluid-width-video-wrapper embed {             position: absolute;                         top: 0;                                     left: 0;                                    width: 100%;                                height: 100%;                            }                                         </style>", o.parentNode.insertBefore(a, o)
            }
            return e && jQuery.extend(t, e), this.each(function () {
                var e = ["iframe[src*='player.vimeo.com']", "iframe[src*='youtube.com']", "iframe[src*='youtube-nocookie.com']", "iframe[src*='kickstarter.com'][src*='video.html']", "object", "embed"];
                t.customSelector && e.push(t.customSelector);
                var a = jQuery(this).find(e.join(","));
                a = a.not("object object"), a.each(function () {
                    var e = jQuery(this);
                    if (!("embed" === this.tagName.toLowerCase() && e.parent("object").length || e.parent(".fluid-width-video-wrapper").length)) {
                        var t = "object" === this.tagName.toLowerCase() || e.attr("height") && !isNaN(parseInt(e.attr("height"), 10)) ? parseInt(e.attr("height"), 10) : e.height(),
                            a = isNaN(parseInt(e.attr("width"), 10)) ? e.width() : parseInt(e.attr("width"), 10),
                            o = t / a;
                        if (!e.attr("id")) {
                            var r = "fitvid" + Math.floor(999999 * Math.random());
                            e.attr("id", r)
                        }
                        e.wrap('<div class="fluid-width-video-wrapper"></div>').parent(".fluid-width-video-wrapper").css("padding-top", 100 * o + "%"), e.removeAttr("height").removeAttr("width")
                    }
                })
            })
        }
    }(jQuery), jQuery.fn.unFitVids = function () {
        var e = jQuery(this).attr("id"),
            t = jQuery("#" + e + " .fluid-width-video-wrapper").children().clone();
        jQuery("#" + e + " .fluid-width-video-wrapper").remove(), jQuery("#" + e).append(t)
    },
    function (e) {
        var t = "waitForImages";
        e.waitForImages = {
            hasImageProperties: ["backgroundImage", "listStyleImage", "borderImage", "borderCornerImage", "cursor"]
        }, e.expr[":"].uncached = function (t) {
            if (!e(t).is('img[src!=""]')) return !1;
            var a = new Image;
            return a.src = t.src, !a.complete
        }, e.fn.waitForImages = function (a, o, r) {
            var i = 0,
                n = 0;
            if (e.isPlainObject(arguments[0]) && (r = arguments[0].waitForAll, o = arguments[0].each, a = arguments[0].finished), a = a || e.noop, o = o || e.noop, r = !!r, !e.isFunction(a) || !e.isFunction(o)) throw new TypeError("An invalid callback was supplied.");
            return this.each(function () {
                var s = e(this),
                    l = [],
                    u = e.waitForImages.hasImageProperties || [],
                    d = /url\(\s*(['"]?)(.*?)\1\s*\)/g;
                r ? s.find("*").addBack().each(function () {
                    var t = e(this);
                    t.is("img:uncached") && l.push({
                        src: t.attr("src"),
                        element: t[0]
                    }), e.each(u, function (e, a) {
                        var o, r = t.css(a);
                        if (!r) return !0;
                        for (; o = d.exec(r) ;) l.push({
                            src: o[2],
                            element: t[0]
                        })
                    })
                }) : s.find("img:uncached").each(function () {
                    l.push({
                        src: this.src,
                        element: this
                    })
                }), i = l.length, n = 0, 0 === i && a.call(s[0]), e.each(l, function (r, l) {
                    var u = new Image;
                    e(u).on("load." + t + " error." + t, function (e) {
                        return n++, o.call(l.element, n, i, "load" == e.type), n == i ? (a.call(s[0]), !1) : void 0
                    }), u.src = l.src
                })
            })
        }
    }(jQuery);

$(window).on('mouseover', (function () {
    window.onbeforeunload = null;
}));
$(window).on('mouseout', (function () {
    window.onbeforeunload = ConfirmLeave;
}));

//var prevKey = "";
//$(document).keydown(function (e) {

//    e = e || window.event;

//    if ((e.key == "W" || e.key == "w") && prevKey == "CONTROL") {
//        window.onbeforeunload = ConfirmLeave;
//    } else if ((e.key == "R" || e.key == "r") && prevKey == "CONTROL") {
//        window.onbeforeunload = ConfirmLeave;
//    } else if (e.key == "F4" && (prevKey == "ALT" || prevKey == "CONTROL")) {
//        window.onbeforeunload = ConfirmLeave;
//    }
//    else if (e.key == "F4" && (e.altKey || e.ctrlKey)) {
//        window.onbeforeunload = ConfirmLeave;
//    }

//    prevKey = e.key;
//});
