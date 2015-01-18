jQuery(function ($) {

    'use strict';

    var AZ = window.AZ || {};

    AZ.pageLoader = function () {
        var $elements = $('body').find('img[src]');
        $('body [style]').each(function () {
            var src = $(this).css('background-image').replace(/^url\(["']?/, '').replace(/["']?\)$/, '');
            if (src && src != 'none') {
                $elements = $elements.add($('<img src="' + src + '"/>'));
            }
        });

        var $loading = $('#loader-container');
        var $loadPercentageLine = $('#loader-percentage-line');
        var $loadPercentageText = $('#loader-percentage');
        var elementsLoaded = 0;
        var speed = 1000;

        function animatePercentage(e) {
            $loadPercentageText.text(parseInt(e));
        }

        function loading() {
            var percentage = 0;
            if ($elements.length) {
                percentage = parseInt((elementsLoaded / $elements.length) * 100);
            }

            $loadPercentageLine.stop().animate({
                height: percentage + '%'
            }, speed);

            $loading.stop().animate({
                percentage: percentage
            }, {
                duration: speed,
                step: animatePercentage
            });
        }

        function loadingFinish() {
            var percentage = 100;

            $loadPercentageLine.stop().animate({
                height: percentage + '%'
            }, (speed / 2));

            $loading.stop().animate({
                percentage: percentage
            }, {
                duration: (speed / 2),
                step: animatePercentage
            })
            .css({ opacity: 1 }).animate({
                opacity: 0
            }, function () {
                $loading.css({ display: 'none' });
                $('.wrap_all').css({
                    opacity: 0,
                    visibility: 'visible'
                }).animate({ opacity: 1 });

                if ($('body.page-template-template-portfolio-php').length > 0) {
                    AZ.scrollLeft();
                    if ($('#projects').length > 0) {
                        AZ.workThumbs();
                    }
                }
            });
        }

        if ($elements.length) {
            loading();

            $elements.load(function () {
                $(this).off('load');
                elementsLoaded++;
                loading();
            });
        }

        $(window).load(function () {
            loadingFinish();
        });
    };

    AZ.scrollLeft = function () {
        if ($('body.page-template-template-portfolio-php').length > 0) {
            var windowWidth = $(window).width();

            if (windowWidth >= 1199) {
                if ($('body').hasClass('mobile-view')) {
                    $('body').removeClass('mobile-view');
                }
                $('body').addClass('desktop-view');

                $("body, html").on('mousewheel', function (event, delta) {
                    if ($('body.opera').hasClass('osx')) {
                        this.scrollLeft -= (delta * 3);
                    }
                    else if ($('body.opera').hasClass('windows')) {
                        this.scrollLeft -= (delta * 120);
                    } else {
                        this.scrollLeft -= (delta * event.deltaFactor);
                    }
                    event.preventDefault();
                });
            } else {
                if ($('body').hasClass('desktop-view')) {
                    $('body').removeClass('desktop-view');
                }
                $('body').addClass('mobile-view');

                $("body, html").unmousewheel();
            }
        }
    };

    AZ.ulWidthSize = function () {
        var ul = $('#projects');
        var ulWidth = 0;
        $('.item-projects').each(function () {
            ulWidth = ulWidth + $(this).width();
        });
        $('#projects').css({ 'width': ulWidth + 'px' });
    };

    AZ.projectHeight = function () {
        var windowWidth = $(window).width();
        if (windowWidth >= 992) {
            $('.item-projects').each(function () {
                var elem = $(this);
                var winH = window.innerHeight ? window.innerHeight : $(window).height();
                elem.css({ 'height': winH + 'px' });
            });
        }

        if (windowWidth >= 768 && windowWidth <= 991) {
            $('.item-projects').each(function () {
                var elem = $(this);
                var winH = window.innerHeight ? window.innerHeight : $(window).height();
                elem.css({ 'height': winH / 2 + 'px' });
            });
        }

        if (windowWidth >= 320 && windowWidth <= 767) {
            $('.item-projects').each(function () {
                var elem = $(this);
                var winH = window.innerHeight ? window.innerHeight : $(window).height();
                elem.css({ 'height': winH + 'px' });
            });
        }
    };

    AZ.singleProjectHeight = function () {
        $('.fullimage-container').each(function () {
            var elem = $(this);
            var winH = window.innerHeight ? window.innerHeight : $(window).height();
            elem.css({ 'height': winH + 'px' });
        });
    };

    AZ.aboutHeight = function () {
        $('.fullimage-container-about').each(function () {
            var elem = $(this);
            var winH = window.innerHeight ? window.innerHeight : $(window).height();
            elem.css({ 'height': winH + 'px' });
        });
    };

    AZ.postHeight = function () {
        var windowWidth = $(window).width();
        $('.post-thumb').each(function () {
            var elem = $(this);
            var winH = window.innerHeight ? window.innerHeight : $(window).height();
            if (windowWidth <= 767) {
                elem.css({ 'height': winH + 'px' });
            } else {
                elem.css('height', "");
            }
        });
    };

    AZ.listenerMenu = function () {
        $('#mobile-nav').on('click', function (e) {
            $(this).toggleClass('open');

            $('#menu-pr').stop().toggleClass('animate');
            e.preventDefault();
        });
    };

    AZ.menuDis = function () {
        var windowWidth = $(window).width();
        if (windowWidth >= 768) {
            if ($('#mobile-nav, #menu-pr').hasClass('mobile-view')) {
                $('#mobile-nav, #menu-pr').removeClass('mobile-view');
            }
            $('#mobile-nav, #menu-pr').addClass('desktop-view');

        } else {
            if ($('#mobile-nav, #menu-pr').hasClass('desktop-view')) {
                $('#mobile-nav, #menu-pr').removeClass('desktop-view');
            }
            $('#mobile-nav, #menu-pr').addClass('mobile-view');

            $('#menu-pr.mobile-view li a').on('click', function (e) {
                if ($('#mobile-nav.mobile-view').hasClass('open')) {
                    $('#mobile-nav.mobile-view').removeClass('open');
                }

                if ($('#menu-pr.mobile-view').hasClass('animate')) {
                    $('#menu-pr.mobile-view').removeClass('animate');
                }
            });
        }
    }

    AZ.workThumbs = function () {
        if ($('body.page-template-template-portfolio-php').length > 0) {
            var windowWidth = $(window).width();
            if (windowWidth >= 1199) {
                var delay_thumbs = 0;
                var projectThumb = $('.item-projects.flip-container');

                projectThumb.each(function () {
                    delay_thumbs += 200;
                    $(this).delay(delay_thumbs).queue(function () {
                        $(this).addClass('animate-helix');
                    });
                });
            } else {
                var projectThumb = $('.item-projects.flip-container');
                projectThumb.each(function () {
                    $(this).addClass('animate-helix-off');
                });
            }
        }
    };

    AZ.leavePage = function () {
        $('a.logo').click(function (event) {
            event.preventDefault();
            var linkLocation = this.href;
            $('body').fadeOut(500, 'easeOutExpo', function () {
                window.location = linkLocation;
            });
        });
    };

    AZ.reloader = function () {
        window.onpageshow = function (event) {
            if (event.persisted) {
                window.location.reload();
            }
        };
    };

    AZ.naviNone = function () {
        var f = $('.navi-portfolio');
        var n = $('li.next');
        var m = $('li.prev');
        if (n.length && n.html() == '') {
            f.addClass('mod-col');
            n.addClass('none');
        }
        if (m.length && m.html() == '') {
            f.addClass('mod-col');
            m.addClass('none');
        }
    };

    AZ.scrllBTN = function () {
        if ($('body.single-portfolio').length > 0) {
            $('.scroll-btn').on('click', function (e) {
                e.preventDefault();
                var aTag = $("#portfolio-details");
                $('html,body').animate({ scrollTop: aTag.offset().top }, 1000, 'easeOutExpo');
            });
        }

        if ($('body.page-template-template-about-php').length > 0) {
            $('.scroll-btn').on('click', function (e) {
                e.preventDefault();
                var aTag = $("#about-details");
                $('html,body').animate({ scrollTop: aTag.offset().top }, 1000, 'easeOutExpo');
            });
        }
    };

    AZ.adjustModal = function () {
        $('.modal').each(function () {

            if ($(this).hasClass('in') == false) {
                $(this).show();
            };
            var contentHeight = window.innerHeight ? window.innerHeight : $(window).height() - 60;
            var headerHeight = $(this).find('.modal-header').outerHeight() || 0;
            var footerHeight = $(this).find('.modal-footer').outerHeight() || 0;

            $(this).find('.modal-content').css({
                'max-height': function () {
                    return contentHeight;
                }
            });

            $(this).find('.modal-body').css({
                'max-height': function () {
                    return (contentHeight - (headerHeight + footerHeight));
                }
            });

            $(this).find('.modal-dialog').css({
                'margin-top': function () {
                    return -($(this).outerHeight() / 2);
                },
                'margin-left': function () {
                    return -($(this).outerWidth() / 2);
                }
            });
            if ($(this).hasClass('in') == false) {
                $(this).hide();
            };
        });
    };

    AZ.dropDown = function () {
        $('.dropmenu').on('click', function (e) {
            $(this).toggleClass('open');

            $('.dropmenu-active').stop().slideToggle(350, 'easeOutExpo');

            e.preventDefault();
        });

        // Dropdown
        $('.dropmenu-active a').on('click', function (e) {
            var dropdown = $(this).parents('.dropdown');
            var selected = dropdown.find('.dropmenu .selected');
            var newSelect = $(this).html();

            $('.dropmenu').removeClass('open');
            $('.dropmenu-active').slideUp(350, 'easeOutExpo');

            selected.html(newSelect);

            e.preventDefault();
        });
    };

    AZ.filterCat = function () {
        if ($('#content-blog-front').length > 0) {
            var $container = $('#blog');

            $container.imagesLoaded(function () {
                $container.isotope({
                    // options
                    animationEngine: 'best-available',
                    layoutMode: 'sloppyMasonry',
                    itemSelector: '.item-blog-front'
                });
            });

            $(window).smartresize(function () {
                $('#blog').isotope('reLayout');
            });


            // filter items when filter link is clicked
            var $optionSets = $('#cat-filter .option-set'),
                $optionLinks = $optionSets.find('a');

            $optionLinks.click(function () {
                var $this = $(this);
                // don't proceed if already selected
                if ($this.hasClass('selected')) {
                    return false;
                }
                var $optionSet = $this.parents('.option-set');
                $optionSet.find('.selected').removeClass('selected');
                $this.addClass('selected');

                // make option object dynamically, i.e. { filter: '.my-filter-class' }
                var options = {},
                    key = $optionSet.attr('data-option-key'),
                    value = $this.attr('data-option-value');
                // parse 'false' as false boolean
                value = value === 'false' ? false : value;
                options[key] = value;
                if (key === 'layoutMode' && typeof changeLayoutMode === 'function') {
                    // changes in layout modes need extra logic
                    changeLayoutMode($this, options);
                } else {
                    // otherwise, apply new options
                    $container.isotope(options);
                }

                return false;
            });
        }
    };

    AZ.socialShare = function () {
        function sharePopup(url) {
            var width = 600;
            var height = 400;

            var leftPosition, topPosition;
            leftPosition = (window.screen.width / 2) - ((width / 2) + 10);
            topPosition = (window.screen.height / 2) - ((height / 2) + 50);

            var windowFeatures = "status=no,height=" + height + ",width=" + width + ",resizable=yes,left=" + leftPosition + ",top=" + topPosition + ",screenX=" + leftPosition + ",screenY=" + topPosition + ",toolbar=no,menubar=no,scrollbars=no,location=no,directories=no";

            window.open(url, 'Social Share', windowFeatures);
        }

        $('#share-facebook').on('click', function () {
            var u = location.href;
            var t = document.title;
            sharePopup('http://www.facebook.com/sharer.php?u=' + encodeURIComponent(u) + '&t=' + encodeURIComponent(t));
            return false;
        });


        $('#share-twitter').on('click', function () {
            var u = location.href;
            var t = document.title + ' - ';
            sharePopup('http://twitter.com/share?url=' + encodeURIComponent(u) + '&text=' + encodeURIComponent(t) + '&via=Bluxart');
            return false;
        });

        $('#share-google').on('click', function () {
            var u = location.href;
            var t = document.title;
            sharePopup('https://plus.google.com/share?url=' + encodeURIComponent(u) + '&text=' + encodeURIComponent(t));
            return false;
        });

        $('#share-pinterest').on('click', function () {
            var u = location.href;
            var t = document.title;
            var bg_url = $('.post-thumb').css('background-image');
            var bg_url = /^url\((['"]?)(.*)\1\)$/.exec(bg_url);
            var bg_url = bg_url ? bg_url[2] : "";
            sharePopup('http://www.pinterest.com/pin/create/button/?url=' + encodeURIComponent(u) + '&description=' + encodeURIComponent(t) + '&media=' + encodeURIComponent(bg_url));
            return false;
        });
    }

    AZ.placeholder = function () {
        $('input, textarea').placeholder();
    };

    AZ.animationWay = function () {
        var windowWidth = $(window).width();
        $.fn.waypoint.defaults = {
            context: window,
            continuous: true,
            enabled: true,
            horizontal: false,
            offset: '80%',
            triggerOnce: false
        };
        if (windowWidth > 1199) {
            $('.fade-animation').waypoint(function (a) {
                var currentObj = $(this);
                var delayIn = currentObj.data('delayIn');
                var delayOut = currentObj.data('delayOut');

                if (a == 'down') {
                    currentObj.delay(delayIn).queue(function () {
                        currentObj.removeClass('fade_out animate').addClass('fade_in animate');
                        currentObj.dequeue();
                    });
                } else {
                    currentObj.delay(delayOut).queue(function () {
                        currentObj.removeClass('fade_in animate').addClass('fade_out animate');
                        currentObj.dequeue();
                    });
                }
            });

            $('.move-left-animation').waypoint(function (a) {
                var currentObj = $(this);
                var delayIn = currentObj.data('delayIn');
                var delayOut = currentObj.data('delayOut');

                if (a == 'down') {
                    currentObj.delay(delayIn).queue(function () {
                        currentObj.removeClass('move_left_out animate').addClass('move_left animate');
                        currentObj.dequeue();
                    });
                } else {
                    currentObj.delay(delayOut).queue(function () {
                        currentObj.removeClass('move_left animate').addClass('move_left_out animate');
                        currentObj.dequeue();
                    });
                }
            });

            $('.move-right-animation').waypoint(function (a) {
                var currentObj = $(this);
                var delayIn = currentObj.data('delayIn');
                var delayOut = currentObj.data('delayOut');

                if (a == 'down') {
                    currentObj.delay(delayIn).queue(function () {
                        currentObj.removeClass('move_right_out animate').addClass('move_right animate');
                        currentObj.dequeue();
                    });
                } else {
                    currentObj.delay(delayOut).queue(function () {
                        currentObj.removeClass('move_right animate').addClass('move_right_out animate');
                        currentObj.dequeue();
                    });
                }
            });
        } else {
            $('#portfolio-details').addClass('showize');
        }
    };

    AZ.windowsPhoneFix = function () {
        if (navigator.userAgent.match(/IEMobile\/10\.0/)) {
            var msViewportStyle = document.createElement('style')
            msViewportStyle.appendChild(
                document.createTextNode(
                    '@-ms-viewport{width:auto!important}'
                )
            )
            document.querySelector('head').appendChild(msViewportStyle)
        }
    };

    AZ.fixSameUrl = function () {
        $('a.same-url').on('click', function (e) {
            window.open($(this).attr('href'));
            location.reload();
            return false;
        });
    };

    AZ.scrollAds = function () {
        var windowWidth = $(window).width();
        if ($('#content-blog-single').length > 0) {
            if (windowWidth > 1199) {
                var $sidebar = $(".ads"),
                    $window = $(window),
                    offset = $sidebar.offset(),
                    topPadding = 15;

                $window.scroll(function () {
                    if ($window.scrollTop() > offset.top) {
                        $sidebar.stop().animate({
                            marginTop: $window.scrollTop() - offset.top + topPadding
                        });
                    } else {
                        $sidebar.stop().animate({
                            marginTop: 0
                        });
                    }
                });
            }
        }
    };

    AZ.ajaxComplete = function () {
        if ($('#main.ajaxable').length > 0) {
            var transition = function ($newEl) {
                var $oldEl = this;
                $oldEl.fadeToggle(500, 'easeOutExpo', function () {
                    $oldEl.after($newEl);
                    $newEl.hide();
                    $newEl.fadeIn(100, 'easeOutExpo');
                    $oldEl.remove();

                    $('document').trigger('change');

                    if ($('body.page-template-template-portfolio-php').length > 0) {
                        $('body').addClass('DJAX_HOME_ENABLED');
                        $('.page-bg').fadeOut(500);
                        $('.page-loader').fadeOut(500, 'easeOutExpo');
                        AZ.windowsPhoneFix();
                        AZ.scrollLeft();
                        AZ.workThumbs();
                        AZ.ulWidthSize();
                        AZ.projectHeight();
                    } else {
                        $('body').addClass('DJAX_ENABLED');
                        $('body, html').unmousewheel();
                        AZ.scrllBTN();
                        if ($('body.single-portfolio').length > 0) {
                            $('.page-bg').fadeOut(500);
                            $('.page-loader').fadeOut(500, 'easeOutExpo');
                            AZ.leavePage();
                            AZ.reloader();
                            AZ.windowsPhoneFix();
                            AZ.singleProjectHeight();
                            AZ.naviNone();
                            AZ.adjustModal();
                            AZ.animationWay();
                            AZ.fixSameUrl();
                        } else {
                            // Normal Pages
                            $('html').removeClass('colorize');
                            $('.page-bg').fadeOut(500);
                            $('.page-loader').fadeOut(500, 'easeOutExpo');
                            AZ.leavePage();
                            AZ.reloader();
                            AZ.windowsPhoneFix();
                            AZ.aboutHeight();
                            AZ.postHeight();
                            AZ.dropDown();
                            AZ.filterCat();
                            AZ.fixSameUrl();
                            AZ.naviNone();
                            AZ.placeholder();
                            AZ.socialShare();
                            AZ.scrollAds();
                        }
                    }
                });
            };

            $('body, html').djax('.ajaxable, #menu-pr, .logo', ['#'], transition);

            $(window).bind('djaxLoad', function (e, data) {
                data = data.response.replace(/(<\/?)body( .+?)?>/gi, '$1NOTBODY$2>', data);
                var nobodyClass = $(data).filter('notbody').attr("class");
                $('body').attr("class", nobodyClass);
                $('document').trigger('change');
                _gaq.push(['_trackPageview']);
            });
        }
    };

    /* ==================================================
        Init
    ================================================== */

    $(window).load(function () {
        AZ.leavePage();
        AZ.ulWidthSize();
    });

    $(document).ready(function () {
        $(window).bind('djaxClick', function (e, data) {
            $('.page-bg').fadeIn(500, 'easeOutExpo', function () {
                $('.page-loader').fadeIn(500, 'easeOutExpo', function () {
                    var bodyelem = ($.browser.safari) ? bodyelem = $("body") : bodyelem = $("html,body");
                    bodyelem.scrollTop(0);
                });
            });
        });
        AZ.windowsPhoneFix();
        AZ.adjustModal();
        AZ.reloader();
        AZ.aboutHeight();
        AZ.postHeight();
        AZ.placeholder();
        if ($('body.page-template-template-portfolio-php').length > 0) {
            AZ.pageLoader();
            if ($('body.ie').length > 0) {
                AZ.scrollLeft();
            }
            AZ.ulWidthSize();
            AZ.projectHeight();
        }
        if ($('body.single-portfolio').length > 0) {
            AZ.singleProjectHeight();
            AZ.animationWay();
        }
        AZ.fixSameUrl();
        AZ.ajaxComplete();
        AZ.scrllBTN();
        AZ.listenerMenu();
        AZ.menuDis();
        AZ.dropDown();
        AZ.filterCat();
        AZ.naviNone();
        AZ.socialShare();
        AZ.scrollAds();
    });

    $(window).resize(function () {
        AZ.adjustModal();
        AZ.scrollLeft();
        AZ.ulWidthSize();
        AZ.projectHeight();
        AZ.singleProjectHeight();
        AZ.aboutHeight();
        AZ.postHeight();
        AZ.menuDis();
    });

});