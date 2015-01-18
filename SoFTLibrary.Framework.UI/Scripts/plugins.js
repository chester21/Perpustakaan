/* bootstrap.js v3.0.0 */
if (!jQuery) throw new Error("Bootstrap requires jQuery"); +function (a) { "use strict"; function b() { var a = document.createElement("bootstrap"), b = { WebkitTransition: "webkitTransitionEnd", MozTransition: "transitionend", OTransition: "oTransitionEnd otransitionend", transition: "transitionend" }; for (var c in b) if (void 0 !== a.style[c]) return { end: b[c] } } a.fn.emulateTransitionEnd = function (b) { var c = !1, d = this; a(this).one(a.support.transition.end, function () { c = !0 }); var e = function () { c || a(d).trigger(a.support.transition.end) }; return setTimeout(e, b), this }, a(function () { a.support.transition = b() }) }(window.jQuery), +function (a) { "use strict"; var b = '[data-dismiss="alert"]', c = function (c) { a(c).on("click", b, this.close) }; c.prototype.close = function (b) { function c() { f.trigger("closed.bs.alert").remove() } var d = a(this), e = d.attr("data-target"); e || (e = d.attr("href"), e = e && e.replace(/.*(?=#[^\s]*$)/, "")); var f = a(e); b && b.preventDefault(), f.length || (f = d.hasClass("alert") ? d : d.parent()), f.trigger(b = a.Event("close.bs.alert")), b.isDefaultPrevented() || (f.removeClass("in"), a.support.transition && f.hasClass("fade") ? f.one(a.support.transition.end, c).emulateTransitionEnd(150) : c()) }; var d = a.fn.alert; a.fn.alert = function (b) { return this.each(function () { var d = a(this), e = d.data("bs.alert"); e || d.data("bs.alert", e = new c(this)), "string" == typeof b && e[b].call(d) }) }, a.fn.alert.Constructor = c, a.fn.alert.noConflict = function () { return a.fn.alert = d, this }, a(document).on("click.bs.alert.data-api", b, c.prototype.close) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.$element = a(c), this.options = a.extend({}, b.DEFAULTS, d) }; b.DEFAULTS = { loadingText: "loading..." }, b.prototype.setState = function (a) { var b = "disabled", c = this.$element, d = c.is("input") ? "val" : "html", e = c.data(); a += "Text", e.resetText || c.data("resetText", c[d]()), c[d](e[a] || this.options[a]), setTimeout(function () { "loadingText" == a ? c.addClass(b).attr(b, b) : c.removeClass(b).removeAttr(b) }, 0) }, b.prototype.toggle = function () { var a = this.$element.closest('[data-toggle="buttons"]'); if (a.length) { var b = this.$element.find("input").prop("checked", !this.$element.hasClass("active")).trigger("change"); "radio" === b.prop("type") && a.find(".active").removeClass("active") } this.$element.toggleClass("active") }; var c = a.fn.button; a.fn.button = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.button"), f = "object" == typeof c && c; e || d.data("bs.button", e = new b(this, f)), "toggle" == c ? e.toggle() : c && e.setState(c) }) }, a.fn.button.Constructor = b, a.fn.button.noConflict = function () { return a.fn.button = c, this }, a(document).on("click.bs.button.data-api", "[data-toggle^=button]", function (b) { var c = a(b.target); c.hasClass("btn") || (c = c.closest(".btn")), c.button("toggle"), b.preventDefault() }) }(window.jQuery), +function (a) { "use strict"; var b = function (b, c) { this.$element = a(b), this.$indicators = this.$element.find(".carousel-indicators"), this.options = c, this.paused = this.sliding = this.interval = this.$active = this.$items = null, "hover" == this.options.pause && this.$element.on("mouseenter", a.proxy(this.pause, this)).on("mouseleave", a.proxy(this.cycle, this)) }; b.DEFAULTS = { interval: 5e3, pause: "hover", wrap: !0 }, b.prototype.cycle = function (b) { return b || (this.paused = !1), this.interval && clearInterval(this.interval), this.options.interval && !this.paused && (this.interval = setInterval(a.proxy(this.next, this), this.options.interval)), this }, b.prototype.getActiveIndex = function () { return this.$active = this.$element.find(".item.active"), this.$items = this.$active.parent().children(), this.$items.index(this.$active) }, b.prototype.to = function (b) { var c = this, d = this.getActiveIndex(); return b > this.$items.length - 1 || 0 > b ? void 0 : this.sliding ? this.$element.one("slid", function () { c.to(b) }) : d == b ? this.pause().cycle() : this.slide(b > d ? "next" : "prev", a(this.$items[b])) }, b.prototype.pause = function (b) { return b || (this.paused = !0), this.$element.find(".next, .prev").length && a.support.transition.end && (this.$element.trigger(a.support.transition.end), this.cycle(!0)), this.interval = clearInterval(this.interval), this }, b.prototype.next = function () { return this.sliding ? void 0 : this.slide("next") }, b.prototype.prev = function () { return this.sliding ? void 0 : this.slide("prev") }, b.prototype.slide = function (b, c) { var d = this.$element.find(".item.active"), e = c || d[b](), f = this.interval, g = "next" == b ? "left" : "right", h = "next" == b ? "first" : "last", i = this; if (!e.length) { if (!this.options.wrap) return; e = this.$element.find(".item")[h]() } this.sliding = !0, f && this.pause(); var j = a.Event("slide.bs.carousel", { relatedTarget: e[0], direction: g }); if (!e.hasClass("active")) { if (this.$indicators.length && (this.$indicators.find(".active").removeClass("active"), this.$element.one("slid", function () { var b = a(i.$indicators.children()[i.getActiveIndex()]); b && b.addClass("active") })), a.support.transition && this.$element.hasClass("slide")) { if (this.$element.trigger(j), j.isDefaultPrevented()) return; e.addClass(b), e[0].offsetWidth, d.addClass(g), e.addClass(g), d.one(a.support.transition.end, function () { e.removeClass([b, g].join(" ")).addClass("active"), d.removeClass(["active", g].join(" ")), i.sliding = !1, setTimeout(function () { i.$element.trigger("slid") }, 0) }).emulateTransitionEnd(600) } else { if (this.$element.trigger(j), j.isDefaultPrevented()) return; d.removeClass("active"), e.addClass("active"), this.sliding = !1, this.$element.trigger("slid") } return f && this.cycle(), this } }; var c = a.fn.carousel; a.fn.carousel = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.carousel"), f = a.extend({}, b.DEFAULTS, d.data(), "object" == typeof c && c), g = "string" == typeof c ? c : f.slide; e || d.data("bs.carousel", e = new b(this, f)), "number" == typeof c ? e.to(c) : g ? e[g]() : f.interval && e.pause().cycle() }) }, a.fn.carousel.Constructor = b, a.fn.carousel.noConflict = function () { return a.fn.carousel = c, this }, a(document).on("click.bs.carousel.data-api", "[data-slide], [data-slide-to]", function (b) { var c, d = a(this), e = a(d.attr("data-target") || (c = d.attr("href")) && c.replace(/.*(?=#[^\s]+$)/, "")), f = a.extend({}, e.data(), d.data()), g = d.attr("data-slide-to"); g && (f.interval = !1), e.carousel(f), (g = d.attr("data-slide-to")) && e.data("bs.carousel").to(g), b.preventDefault() }), a(window).on("load", function () { a('[data-ride="carousel"]').each(function () { var b = a(this); b.carousel(b.data()) }) }) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.$element = a(c), this.options = a.extend({}, b.DEFAULTS, d), this.transitioning = null, this.options.parent && (this.$parent = a(this.options.parent)), this.options.toggle && this.toggle() }; b.DEFAULTS = { toggle: !0 }, b.prototype.dimension = function () { var a = this.$element.hasClass("width"); return a ? "width" : "height" }, b.prototype.show = function () { if (!this.transitioning && !this.$element.hasClass("in")) { var b = a.Event("show.bs.collapse"); if (this.$element.trigger(b), !b.isDefaultPrevented()) { var c = this.$parent && this.$parent.find("> .panel > .in"); if (c && c.length) { var d = c.data("bs.collapse"); if (d && d.transitioning) return; c.collapse("hide"), d || c.data("bs.collapse", null) } var e = this.dimension(); this.$element.removeClass("collapse").addClass("collapsing")[e](0), this.transitioning = 1; var f = function () { this.$element.removeClass("collapsing").addClass("in")[e]("auto"), this.transitioning = 0, this.$element.trigger("shown.bs.collapse") }; if (!a.support.transition) return f.call(this); var g = a.camelCase(["scroll", e].join("-")); this.$element.one(a.support.transition.end, a.proxy(f, this)).emulateTransitionEnd(350)[e](this.$element[0][g]) } } }, b.prototype.hide = function () { if (!this.transitioning && this.$element.hasClass("in")) { var b = a.Event("hide.bs.collapse"); if (this.$element.trigger(b), !b.isDefaultPrevented()) { var c = this.dimension(); this.$element[c](this.$element[c]())[0].offsetHeight, this.$element.addClass("collapsing").removeClass("collapse").removeClass("in"), this.transitioning = 1; var d = function () { this.transitioning = 0, this.$element.trigger("hidden.bs.collapse").removeClass("collapsing").addClass("collapse") }; return a.support.transition ? (this.$element[c](0).one(a.support.transition.end, a.proxy(d, this)).emulateTransitionEnd(350), void 0) : d.call(this) } } }, b.prototype.toggle = function () { this[this.$element.hasClass("in") ? "hide" : "show"]() }; var c = a.fn.collapse; a.fn.collapse = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.collapse"), f = a.extend({}, b.DEFAULTS, d.data(), "object" == typeof c && c); e || d.data("bs.collapse", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.collapse.Constructor = b, a.fn.collapse.noConflict = function () { return a.fn.collapse = c, this }, a(document).on("click.bs.collapse.data-api", "[data-toggle=collapse]", function (b) { var c, d = a(this), e = d.attr("data-target") || b.preventDefault() || (c = d.attr("href")) && c.replace(/.*(?=#[^\s]+$)/, ""), f = a(e), g = f.data("bs.collapse"), h = g ? "toggle" : d.data(), i = d.attr("data-parent"), j = i && a(i); g && g.transitioning || (j && j.find('[data-toggle=collapse][data-parent="' + i + '"]').not(d).addClass("collapsed"), d[f.hasClass("in") ? "addClass" : "removeClass"]("collapsed")), f.collapse(h) }) }(window.jQuery), +function (a) { "use strict"; function b() { a(d).remove(), a(e).each(function (b) { var d = c(a(this)); d.hasClass("open") && (d.trigger(b = a.Event("hide.bs.dropdown")), b.isDefaultPrevented() || d.removeClass("open").trigger("hidden.bs.dropdown")) }) } function c(b) { var c = b.attr("data-target"); c || (c = b.attr("href"), c = c && /#/.test(c) && c.replace(/.*(?=#[^\s]*$)/, "")); var d = c && a(c); return d && d.length ? d : b.parent() } var d = ".dropdown-backdrop", e = "[data-toggle=dropdown]", f = function (b) { a(b).on("click.bs.dropdown", this.toggle) }; f.prototype.toggle = function (d) { var e = a(this); if (!e.is(".disabled, :disabled")) { var f = c(e), g = f.hasClass("open"); if (b(), !g) { if ("ontouchstart" in document.documentElement && !f.closest(".navbar-nav").length && a('<div class="dropdown-backdrop"/>').insertAfter(a(this)).on("click", b), f.trigger(d = a.Event("show.bs.dropdown")), d.isDefaultPrevented()) return; f.toggleClass("open").trigger("shown.bs.dropdown"), e.focus() } return !1 } }, f.prototype.keydown = function (b) { if (/(38|40|27)/.test(b.keyCode)) { var d = a(this); if (b.preventDefault(), b.stopPropagation(), !d.is(".disabled, :disabled")) { var f = c(d), g = f.hasClass("open"); if (!g || g && 27 == b.keyCode) return 27 == b.which && f.find(e).focus(), d.click(); var h = a("[role=menu] li:not(.divider):visible a", f); if (h.length) { var i = h.index(h.filter(":focus")); 38 == b.keyCode && i > 0 && i--, 40 == b.keyCode && i < h.length - 1 && i++, ~i || (i = 0), h.eq(i).focus() } } } }; var g = a.fn.dropdown; a.fn.dropdown = function (b) { return this.each(function () { var c = a(this), d = c.data("dropdown"); d || c.data("dropdown", d = new f(this)), "string" == typeof b && d[b].call(c) }) }, a.fn.dropdown.Constructor = f, a.fn.dropdown.noConflict = function () { return a.fn.dropdown = g, this }, a(document).on("click.bs.dropdown.data-api", b).on("click.bs.dropdown.data-api", ".dropdown form", function (a) { a.stopPropagation() }).on("click.bs.dropdown.data-api", e, f.prototype.toggle).on("keydown.bs.dropdown.data-api", e + ", [role=menu]", f.prototype.keydown) }(window.jQuery), +function (a) { "use strict"; var b = function (b, c) { this.options = c, this.$element = a(b), this.$backdrop = this.isShown = null, this.options.remote && this.$element.load(this.options.remote) }; b.DEFAULTS = { backdrop: !0, keyboard: !0, show: !0 }, b.prototype.toggle = function (a) { return this[this.isShown ? "hide" : "show"](a) }, b.prototype.show = function (b) { var c = this, d = a.Event("show.bs.modal", { relatedTarget: b }); this.$element.trigger(d), this.isShown || d.isDefaultPrevented() || (this.isShown = !0, this.escape(), this.$element.on("click.dismiss.modal", '[data-dismiss="modal"]', a.proxy(this.hide, this)), this.backdrop(function () { var d = a.support.transition && c.$element.hasClass("fade"); c.$element.parent().length || c.$element.appendTo(document.body), c.$element.show(), d && c.$element[0].offsetWidth, c.$element.addClass("in").attr("aria-hidden", !1), c.enforceFocus(); var e = a.Event("shown.bs.modal", { relatedTarget: b }); d ? c.$element.find(".modal-dialog").one(a.support.transition.end, function () { c.$element.focus().trigger(e) }).emulateTransitionEnd(300) : c.$element.focus().trigger(e) })) }, b.prototype.hide = function (b) { b && b.preventDefault(), b = a.Event("hide.bs.modal"), this.$element.trigger(b), this.isShown && !b.isDefaultPrevented() && (this.isShown = !1, this.escape(), a(document).off("focusin.bs.modal"), this.$element.removeClass("in").attr("aria-hidden", !0).off("click.dismiss.modal"), a.support.transition && this.$element.hasClass("fade") ? this.$element.one(a.support.transition.end, a.proxy(this.hideModal, this)).emulateTransitionEnd(300) : this.hideModal()) }, b.prototype.enforceFocus = function () { a(document).off("focusin.bs.modal").on("focusin.bs.modal", a.proxy(function (a) { this.$element[0] === a.target || this.$element.has(a.target).length || this.$element.focus() }, this)) }, b.prototype.escape = function () { this.isShown && this.options.keyboard ? this.$element.on("keyup.dismiss.bs.modal", a.proxy(function (a) { 27 == a.which && this.hide() }, this)) : this.isShown || this.$element.off("keyup.dismiss.bs.modal") }, b.prototype.hideModal = function () { var a = this; this.$element.hide(), this.backdrop(function () { a.removeBackdrop(), a.$element.trigger("hidden.bs.modal") }) }, b.prototype.removeBackdrop = function () { this.$backdrop && this.$backdrop.remove(), this.$backdrop = null }, b.prototype.backdrop = function (b) { var c = this.$element.hasClass("fade") ? "fade" : ""; if (this.isShown && this.options.backdrop) { var d = a.support.transition && c; if (this.$backdrop = a('<div class="modal-backdrop ' + c + '" />').appendTo(document.body), this.$element.on("click.dismiss.modal", a.proxy(function (a) { a.target === a.currentTarget && ("static" == this.options.backdrop ? this.$element[0].focus.call(this.$element[0]) : this.hide.call(this)) }, this)), d && this.$backdrop[0].offsetWidth, this.$backdrop.addClass("in"), !b) return; d ? this.$backdrop.one(a.support.transition.end, b).emulateTransitionEnd(150) : b() } else !this.isShown && this.$backdrop ? (this.$backdrop.removeClass("in"), a.support.transition && this.$element.hasClass("fade") ? this.$backdrop.one(a.support.transition.end, b).emulateTransitionEnd(150) : b()) : b && b() }; var c = a.fn.modal; a.fn.modal = function (c, d) { return this.each(function () { var e = a(this), f = e.data("bs.modal"), g = a.extend({}, b.DEFAULTS, e.data(), "object" == typeof c && c); f || e.data("bs.modal", f = new b(this, g)), "string" == typeof c ? f[c](d) : g.show && f.show(d) }) }, a.fn.modal.Constructor = b, a.fn.modal.noConflict = function () { return a.fn.modal = c, this }, a(document).on("click.bs.modal.data-api", '[data-toggle="modal"]', function (b) { var c = a(this), d = c.attr("href"), e = a(c.attr("data-target") || d && d.replace(/.*(?=#[^\s]+$)/, "")), f = e.data("modal") ? "toggle" : a.extend({ remote: !/#/.test(d) && d }, e.data(), c.data()); b.preventDefault(), e.modal(f, this).one("hide", function () { c.is(":visible") && c.focus() }) }), a(document).on("show.bs.modal", ".modal", function () { a(document.body).addClass("modal-open") }).on("hidden.bs.modal", ".modal", function () { a(document.body).removeClass("modal-open") }) }(window.jQuery), +function (a) { "use strict"; var b = function (a, b) { this.type = this.options = this.enabled = this.timeout = this.hoverState = this.$element = null, this.init("tooltip", a, b) }; b.DEFAULTS = { animation: !0, placement: "top", selector: !1, template: '<div class="tooltip"><div class="tooltip-arrow"></div><div class="tooltip-inner"></div></div>', trigger: "hover focus", title: "", delay: 0, html: !1, container: !1 }, b.prototype.init = function (b, c, d) { this.enabled = !0, this.type = b, this.$element = a(c), this.options = this.getOptions(d); for (var e = this.options.trigger.split(" "), f = e.length; f--;) { var g = e[f]; if ("click" == g) this.$element.on("click." + this.type, this.options.selector, a.proxy(this.toggle, this)); else if ("manual" != g) { var h = "hover" == g ? "mouseenter" : "focus", i = "hover" == g ? "mouseleave" : "blur"; this.$element.on(h + "." + this.type, this.options.selector, a.proxy(this.enter, this)), this.$element.on(i + "." + this.type, this.options.selector, a.proxy(this.leave, this)) } } this.options.selector ? this._options = a.extend({}, this.options, { trigger: "manual", selector: "" }) : this.fixTitle() }, b.prototype.getDefaults = function () { return b.DEFAULTS }, b.prototype.getOptions = function (b) { return b = a.extend({}, this.getDefaults(), this.$element.data(), b), b.delay && "number" == typeof b.delay && (b.delay = { show: b.delay, hide: b.delay }), b }, b.prototype.getDelegateOptions = function () { var b = {}, c = this.getDefaults(); return this._options && a.each(this._options, function (a, d) { c[a] != d && (b[a] = d) }), b }, b.prototype.enter = function (b) { var c = b instanceof this.constructor ? b : a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type); return clearTimeout(c.timeout), c.hoverState = "in", c.options.delay && c.options.delay.show ? (c.timeout = setTimeout(function () { "in" == c.hoverState && c.show() }, c.options.delay.show), void 0) : c.show() }, b.prototype.leave = function (b) { var c = b instanceof this.constructor ? b : a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type); return clearTimeout(c.timeout), c.hoverState = "out", c.options.delay && c.options.delay.hide ? (c.timeout = setTimeout(function () { "out" == c.hoverState && c.hide() }, c.options.delay.hide), void 0) : c.hide() }, b.prototype.show = function () { var b = a.Event("show.bs." + this.type); if (this.hasContent() && this.enabled) { if (this.$element.trigger(b), b.isDefaultPrevented()) return; var c = this.tip(); this.setContent(), this.options.animation && c.addClass("fade"); var d = "function" == typeof this.options.placement ? this.options.placement.call(this, c[0], this.$element[0]) : this.options.placement, e = /\s?auto?\s?/i, f = e.test(d); f && (d = d.replace(e, "") || "top"), c.detach().css({ top: 0, left: 0, display: "block" }).addClass(d), this.options.container ? c.appendTo(this.options.container) : c.insertAfter(this.$element); var g = this.getPosition(), h = c[0].offsetWidth, i = c[0].offsetHeight; if (f) { var j = this.$element.parent(), k = d, l = document.documentElement.scrollTop || document.body.scrollTop, m = "body" == this.options.container ? window.innerWidth : j.outerWidth(), n = "body" == this.options.container ? window.innerHeight : j.outerHeight(), o = "body" == this.options.container ? 0 : j.offset().left; d = "bottom" == d && g.top + g.height + i - l > n ? "top" : "top" == d && g.top - l - i < 0 ? "bottom" : "right" == d && g.right + h > m ? "left" : "left" == d && g.left - h < o ? "right" : d, c.removeClass(k).addClass(d) } var p = this.getCalculatedOffset(d, g, h, i); this.applyPlacement(p, d), this.$element.trigger("shown.bs." + this.type) } }, b.prototype.applyPlacement = function (a, b) { var c, d = this.tip(), e = d[0].offsetWidth, f = d[0].offsetHeight, g = parseInt(d.css("margin-top"), 10), h = parseInt(d.css("margin-left"), 10); isNaN(g) && (g = 0), isNaN(h) && (h = 0), a.top = a.top + g, a.left = a.left + h, d.offset(a).addClass("in"); var i = d[0].offsetWidth, j = d[0].offsetHeight; if ("top" == b && j != f && (c = !0, a.top = a.top + f - j), /bottom|top/.test(b)) { var k = 0; a.left < 0 && (k = -2 * a.left, a.left = 0, d.offset(a), i = d[0].offsetWidth, j = d[0].offsetHeight), this.replaceArrow(k - e + i, i, "left") } else this.replaceArrow(j - f, j, "top"); c && d.offset(a) }, b.prototype.replaceArrow = function (a, b, c) { this.arrow().css(c, a ? 50 * (1 - a / b) + "%" : "") }, b.prototype.setContent = function () { var a = this.tip(), b = this.getTitle(); a.find(".tooltip-inner")[this.options.html ? "html" : "text"](b), a.removeClass("fade in top bottom left right") }, b.prototype.hide = function () { function b() { "in" != c.hoverState && d.detach() } var c = this, d = this.tip(), e = a.Event("hide.bs." + this.type); return this.$element.trigger(e), e.isDefaultPrevented() ? void 0 : (d.removeClass("in"), a.support.transition && this.$tip.hasClass("fade") ? d.one(a.support.transition.end, b).emulateTransitionEnd(150) : b(), this.$element.trigger("hidden.bs." + this.type), this) }, b.prototype.fixTitle = function () { var a = this.$element; (a.attr("title") || "string" != typeof a.attr("data-original-title")) && a.attr("data-original-title", a.attr("title") || "").attr("title", "") }, b.prototype.hasContent = function () { return this.getTitle() }, b.prototype.getPosition = function () { var b = this.$element[0]; return a.extend({}, "function" == typeof b.getBoundingClientRect ? b.getBoundingClientRect() : { width: b.offsetWidth, height: b.offsetHeight }, this.$element.offset()) }, b.prototype.getCalculatedOffset = function (a, b, c, d) { return "bottom" == a ? { top: b.top + b.height, left: b.left + b.width / 2 - c / 2 } : "top" == a ? { top: b.top - d, left: b.left + b.width / 2 - c / 2 } : "left" == a ? { top: b.top + b.height / 2 - d / 2, left: b.left - c } : { top: b.top + b.height / 2 - d / 2, left: b.left + b.width } }, b.prototype.getTitle = function () { var a, b = this.$element, c = this.options; return a = b.attr("data-original-title") || ("function" == typeof c.title ? c.title.call(b[0]) : c.title) }, b.prototype.tip = function () { return this.$tip = this.$tip || a(this.options.template) }, b.prototype.arrow = function () { return this.$arrow = this.$arrow || this.tip().find(".tooltip-arrow") }, b.prototype.validate = function () { this.$element[0].parentNode || (this.hide(), this.$element = null, this.options = null) }, b.prototype.enable = function () { this.enabled = !0 }, b.prototype.disable = function () { this.enabled = !1 }, b.prototype.toggleEnabled = function () { this.enabled = !this.enabled }, b.prototype.toggle = function (b) { var c = b ? a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type) : this; c.tip().hasClass("in") ? c.leave(c) : c.enter(c) }, b.prototype.destroy = function () { this.hide().$element.off("." + this.type).removeData("bs." + this.type) }; var c = a.fn.tooltip; a.fn.tooltip = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.tooltip"), f = "object" == typeof c && c; e || d.data("bs.tooltip", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.tooltip.Constructor = b, a.fn.tooltip.noConflict = function () { return a.fn.tooltip = c, this } }(window.jQuery), +function (a) { "use strict"; var b = function (a, b) { this.init("popover", a, b) }; if (!a.fn.tooltip) throw new Error("Popover requires tooltip.js"); b.DEFAULTS = a.extend({}, a.fn.tooltip.Constructor.DEFAULTS, { placement: "right", trigger: "click", content: "", template: '<div class="popover"><div class="arrow"></div><h3 class="popover-title"></h3><div class="popover-content"></div></div>' }), b.prototype = a.extend({}, a.fn.tooltip.Constructor.prototype), b.prototype.constructor = b, b.prototype.getDefaults = function () { return b.DEFAULTS }, b.prototype.setContent = function () { var a = this.tip(), b = this.getTitle(), c = this.getContent(); a.find(".popover-title")[this.options.html ? "html" : "text"](b), a.find(".popover-content")[this.options.html ? "html" : "text"](c), a.removeClass("fade top bottom left right in"), a.find(".popover-title").html() || a.find(".popover-title").hide() }, b.prototype.hasContent = function () { return this.getTitle() || this.getContent() }, b.prototype.getContent = function () { var a = this.$element, b = this.options; return a.attr("data-content") || ("function" == typeof b.content ? b.content.call(a[0]) : b.content) }, b.prototype.arrow = function () { return this.$arrow = this.$arrow || this.tip().find(".arrow") }, b.prototype.tip = function () { return this.$tip || (this.$tip = a(this.options.template)), this.$tip }; var c = a.fn.popover; a.fn.popover = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.popover"), f = "object" == typeof c && c; e || d.data("bs.popover", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.popover.Constructor = b, a.fn.popover.noConflict = function () { return a.fn.popover = c, this } }(window.jQuery), +function (a) { "use strict"; function b(c, d) { var e, f = a.proxy(this.process, this); this.$element = a(c).is("body") ? a(window) : a(c), this.$body = a("body"), this.$scrollElement = this.$element.on("scroll.bs.scroll-spy.data-api", f), this.options = a.extend({}, b.DEFAULTS, d), this.selector = (this.options.target || (e = a(c).attr("href")) && e.replace(/.*(?=#[^\s]+$)/, "") || "") + " .nav li > a", this.offsets = a([]), this.targets = a([]), this.activeTarget = null, this.refresh(), this.process() } b.DEFAULTS = { offset: 10 }, b.prototype.refresh = function () { var b = this.$element[0] == window ? "offset" : "position"; this.offsets = a([]), this.targets = a([]); var c = this; this.$body.find(this.selector).map(function () { var d = a(this), e = d.data("target") || d.attr("href"), f = /^#\w/.test(e) && a(e); return f && f.length && [[f[b]().top + (!a.isWindow(c.$scrollElement.get(0)) && c.$scrollElement.scrollTop()), e]] || null }).sort(function (a, b) { return a[0] - b[0] }).each(function () { c.offsets.push(this[0]), c.targets.push(this[1]) }) }, b.prototype.process = function () { var a, b = this.$scrollElement.scrollTop() + this.options.offset, c = this.$scrollElement[0].scrollHeight || this.$body[0].scrollHeight, d = c - this.$scrollElement.height(), e = this.offsets, f = this.targets, g = this.activeTarget; if (b >= d) return g != (a = f.last()[0]) && this.activate(a); for (a = e.length; a--;) g != f[a] && b >= e[a] && (!e[a + 1] || b <= e[a + 1]) && this.activate(f[a]) }, b.prototype.activate = function (b) { this.activeTarget = b, a(this.selector).parents(".active").removeClass("active"); var c = this.selector + '[data-target="' + b + '"],' + this.selector + '[href="' + b + '"]', d = a(c).parents("li").addClass("active"); d.parent(".dropdown-menu").length && (d = d.closest("li.dropdown").addClass("active")), d.trigger("activate") }; var c = a.fn.scrollspy; a.fn.scrollspy = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.scrollspy"), f = "object" == typeof c && c; e || d.data("bs.scrollspy", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.scrollspy.Constructor = b, a.fn.scrollspy.noConflict = function () { return a.fn.scrollspy = c, this }, a(window).on("load", function () { a('[data-spy="scroll"]').each(function () { var b = a(this); b.scrollspy(b.data()) }) }) }(window.jQuery), +function (a) { "use strict"; var b = function (b) { this.element = a(b) }; b.prototype.show = function () { var b = this.element, c = b.closest("ul:not(.dropdown-menu)"), d = b.attr("data-target"); if (d || (d = b.attr("href"), d = d && d.replace(/.*(?=#[^\s]*$)/, "")), !b.parent("li").hasClass("active")) { var e = c.find(".active:last a")[0], f = a.Event("show.bs.tab", { relatedTarget: e }); if (b.trigger(f), !f.isDefaultPrevented()) { var g = a(d); this.activate(b.parent("li"), c), this.activate(g, g.parent(), function () { b.trigger({ type: "shown.bs.tab", relatedTarget: e }) }) } } }, b.prototype.activate = function (b, c, d) { function e() { f.removeClass("active").find("> .dropdown-menu > .active").removeClass("active"), b.addClass("active"), g ? (b[0].offsetWidth, b.addClass("in")) : b.removeClass("fade"), b.parent(".dropdown-menu") && b.closest("li.dropdown").addClass("active"), d && d() } var f = c.find("> .active"), g = d && a.support.transition && f.hasClass("fade"); g ? f.one(a.support.transition.end, e).emulateTransitionEnd(150) : e(), f.removeClass("in") }; var c = a.fn.tab; a.fn.tab = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.tab"); e || d.data("bs.tab", e = new b(this)), "string" == typeof c && e[c]() }) }, a.fn.tab.Constructor = b, a.fn.tab.noConflict = function () { return a.fn.tab = c, this }, a(document).on("click.bs.tab.data-api", '[data-toggle="tab"], [data-toggle="pill"]', function (b) { b.preventDefault(), a(this).tab("show") }) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.options = a.extend({}, b.DEFAULTS, d), this.$window = a(window).on("scroll.bs.affix.data-api", a.proxy(this.checkPosition, this)).on("click.bs.affix.data-api", a.proxy(this.checkPositionWithEventLoop, this)), this.$element = a(c), this.affixed = this.unpin = null, this.checkPosition() }; b.RESET = "affix affix-top affix-bottom", b.DEFAULTS = { offset: 0 }, b.prototype.checkPositionWithEventLoop = function () { setTimeout(a.proxy(this.checkPosition, this), 1) }, b.prototype.checkPosition = function () { if (this.$element.is(":visible")) { var c = a(document).height(), d = this.$window.scrollTop(), e = this.$element.offset(), f = this.options.offset, g = f.top, h = f.bottom; "object" != typeof f && (h = g = f), "function" == typeof g && (g = f.top()), "function" == typeof h && (h = f.bottom()); var i = null != this.unpin && d + this.unpin <= e.top ? !1 : null != h && e.top + this.$element.height() >= c - h ? "bottom" : null != g && g >= d ? "top" : !1; this.affixed !== i && (this.unpin && this.$element.css("top", ""), this.affixed = i, this.unpin = "bottom" == i ? e.top - d : null, this.$element.removeClass(b.RESET).addClass("affix" + (i ? "-" + i : "")), "bottom" == i && this.$element.offset({ top: document.body.offsetHeight - h - this.$element.height() })) } }; var c = a.fn.affix; a.fn.affix = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.affix"), f = "object" == typeof c && c; e || d.data("bs.affix", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.affix.Constructor = b, a.fn.affix.noConflict = function () { return a.fn.affix = c, this }, a(window).on("load", function () { a('[data-spy="affix"]').each(function () { var b = a(this), c = b.data(); c.offset = c.offset || {}, c.offsetBottom && (c.offset.bottom = c.offsetBottom), c.offsetTop && (c.offset.top = c.offsetTop), b.affix(c) }) }) }(window.jQuery);

/* Comment Reply */
var addComment = { moveForm: function (a, b, c, d) { var e, f = this, g = f.I(a), h = f.I(c), i = f.I("cancel-comment-reply-link"), j = f.I("comment_parent"), k = f.I("comment_post_ID"); if (g && h && i && j) { f.respondId = c, d = d || !1, f.I("wp-temp-form-div") || (e = document.createElement("div"), e.id = "wp-temp-form-div", e.style.display = "none", h.parentNode.insertBefore(e, h)), g.parentNode.insertBefore(h, g.nextSibling), k && d && (k.value = d), j.value = b, i.style.display = "", i.onclick = function () { var a = addComment, b = a.I("wp-temp-form-div"), c = a.I(a.respondId); if (b && c) return a.I("comment_parent").value = "0", b.parentNode.insertBefore(c, b), b.parentNode.removeChild(b), this.style.display = "none", this.onclick = null, !1 }; try { f.I("comment").focus() } catch (l) { } return !1 } }, I: function (a) { return document.getElementById(a) } };

/* Mousewheel */
(function (e) { if (typeof define === "function" && define.amd) { define(["jquery"], e) } else if (typeof exports === "object") { module.exports = e } else { e(jQuery) } })(function (e) { function a(t) { var n = t || window.event, o = r.call(arguments, 1), u = 0, a = 0, c = 0, h = 0; t = e.event.fix(n); t.type = "mousewheel"; if ("detail" in n) { c = n.detail * -1 } if ("wheelDelta" in n) { c = n.wheelDelta } if ("wheelDeltaY" in n) { c = n.wheelDeltaY } if ("wheelDeltaX" in n) { a = n.wheelDeltaX * -1 } if ("axis" in n && n.axis === n.HORIZONTAL_AXIS) { a = c * -1; c = 0 } u = c === 0 ? a : c; if ("deltaY" in n) { c = n.deltaY * -1; u = c } if ("deltaX" in n) { a = n.deltaX; if (c === 0) { u = a * -1 } } if (c === 0 && a === 0) { return } if (n.deltaMode === 1) { var p = e.data(this, "mousewheel-line-height"); u *= p; c *= p; a *= p } else if (n.deltaMode === 2) { var d = e.data(this, "mousewheel-page-height"); u *= d; c *= d; a *= d } h = Math.max(Math.abs(c), Math.abs(a)); if (!s || h < s) { s = h; if (l(n, h)) { s /= 40 } } if (l(n, h)) { u /= 40; a /= 40; c /= 40 } u = Math[u >= 1 ? "floor" : "ceil"](u / s); a = Math[a >= 1 ? "floor" : "ceil"](a / s); c = Math[c >= 1 ? "floor" : "ceil"](c / s); t.deltaX = a; t.deltaY = c; t.deltaFactor = s; t.deltaMode = 0; o.unshift(t, u, a, c); if (i) { clearTimeout(i) } i = setTimeout(f, 200); return (e.event.dispatch || e.event.handle).apply(this, o) } function f() { s = null } function l(e, t) { return u.settings.adjustOldDeltas && e.type === "mousewheel" && t % 120 === 0 } var t = ["wheel", "mousewheel", "DOMMouseScroll", "MozMousePixelScroll"], n = "onwheel" in document || document.documentMode >= 9 ? ["wheel"] : ["mousewheel", "DomMouseScroll", "MozMousePixelScroll"], r = Array.prototype.slice, i, s; if (e.event.fixHooks) { for (var o = t.length; o;) { e.event.fixHooks[t[--o]] = e.event.mouseHooks } } var u = e.event.special.mousewheel = { version: "3.1.9", setup: function () { if (this.addEventListener) { for (var t = n.length; t;) { this.addEventListener(n[--t], a, false) } } else { this.onmousewheel = a } e.data(this, "mousewheel-line-height", u.getLineHeight(this)); e.data(this, "mousewheel-page-height", u.getPageHeight(this)) }, teardown: function () { if (this.removeEventListener) { for (var e = n.length; e;) { this.removeEventListener(n[--e], a, false) } } else { this.onmousewheel = null } }, getLineHeight: function (t) { return parseInt(e(t)["offsetParent" in e.fn ? "offsetParent" : "parent"]().css("fontSize"), 10) }, getPageHeight: function (t) { return e(t).height() }, settings: { adjustOldDeltas: true } }; e.fn.extend({ mousewheel: function (e) { return e ? this.bind("mousewheel", e) : this.trigger("mousewheel") }, unmousewheel: function (e) { return this.unbind("mousewheel", e) } }) })

/* jQuery Easing v1.3 */
jQuery.easing.jswing = jQuery.easing.swing; jQuery.extend(jQuery.easing, { def: "easeOutQuad", swing: function (e, f, a, h, g) { return jQuery.easing[jQuery.easing.def](e, f, a, h, g) }, easeInQuad: function (e, f, a, h, g) { return h * (f /= g) * f + a }, easeOutQuad: function (e, f, a, h, g) { return -h * (f /= g) * (f - 2) + a }, easeInOutQuad: function (e, f, a, h, g) { if ((f /= g / 2) < 1) { return h / 2 * f * f + a } return -h / 2 * ((--f) * (f - 2) - 1) + a }, easeInCubic: function (e, f, a, h, g) { return h * (f /= g) * f * f + a }, easeOutCubic: function (e, f, a, h, g) { return h * ((f = f / g - 1) * f * f + 1) + a }, easeInOutCubic: function (e, f, a, h, g) { if ((f /= g / 2) < 1) { return h / 2 * f * f * f + a } return h / 2 * ((f -= 2) * f * f + 2) + a }, easeInQuart: function (e, f, a, h, g) { return h * (f /= g) * f * f * f + a }, easeOutQuart: function (e, f, a, h, g) { return -h * ((f = f / g - 1) * f * f * f - 1) + a }, easeInOutQuart: function (e, f, a, h, g) { if ((f /= g / 2) < 1) { return h / 2 * f * f * f * f + a } return -h / 2 * ((f -= 2) * f * f * f - 2) + a }, easeInQuint: function (e, f, a, h, g) { return h * (f /= g) * f * f * f * f + a }, easeOutQuint: function (e, f, a, h, g) { return h * ((f = f / g - 1) * f * f * f * f + 1) + a }, easeInOutQuint: function (e, f, a, h, g) { if ((f /= g / 2) < 1) { return h / 2 * f * f * f * f * f + a } return h / 2 * ((f -= 2) * f * f * f * f + 2) + a }, easeInSine: function (e, f, a, h, g) { return -h * Math.cos(f / g * (Math.PI / 2)) + h + a }, easeOutSine: function (e, f, a, h, g) { return h * Math.sin(f / g * (Math.PI / 2)) + a }, easeInOutSine: function (e, f, a, h, g) { return -h / 2 * (Math.cos(Math.PI * f / g) - 1) + a }, easeInExpo: function (e, f, a, h, g) { return (f == 0) ? a : h * Math.pow(2, 10 * (f / g - 1)) + a }, easeOutExpo: function (e, f, a, h, g) { return (f == g) ? a + h : h * (-Math.pow(2, -10 * f / g) + 1) + a }, easeInOutExpo: function (e, f, a, h, g) { if (f == 0) { return a } if (f == g) { return a + h } if ((f /= g / 2) < 1) { return h / 2 * Math.pow(2, 10 * (f - 1)) + a } return h / 2 * (-Math.pow(2, -10 * --f) + 2) + a }, easeInCirc: function (e, f, a, h, g) { return -h * (Math.sqrt(1 - (f /= g) * f) - 1) + a }, easeOutCirc: function (e, f, a, h, g) { return h * Math.sqrt(1 - (f = f / g - 1) * f) + a }, easeInOutCirc: function (e, f, a, h, g) { if ((f /= g / 2) < 1) { return -h / 2 * (Math.sqrt(1 - f * f) - 1) + a } return h / 2 * (Math.sqrt(1 - (f -= 2) * f) + 1) + a }, easeInElastic: function (f, h, e, l, k) { var i = 1.70158; var j = 0; var g = l; if (h == 0) { return e } if ((h /= k) == 1) { return e + l } if (!j) { j = k * 0.3 } if (g < Math.abs(l)) { g = l; var i = j / 4 } else { var i = j / (2 * Math.PI) * Math.asin(l / g) } return -(g * Math.pow(2, 10 * (h -= 1)) * Math.sin((h * k - i) * (2 * Math.PI) / j)) + e }, easeOutElastic: function (f, h, e, l, k) { var i = 1.70158; var j = 0; var g = l; if (h == 0) { return e } if ((h /= k) == 1) { return e + l } if (!j) { j = k * 0.3 } if (g < Math.abs(l)) { g = l; var i = j / 4 } else { var i = j / (2 * Math.PI) * Math.asin(l / g) } return g * Math.pow(2, -10 * h) * Math.sin((h * k - i) * (2 * Math.PI) / j) + l + e }, easeInOutElastic: function (f, h, e, l, k) { var i = 1.70158; var j = 0; var g = l; if (h == 0) { return e } if ((h /= k / 2) == 2) { return e + l } if (!j) { j = k * (0.3 * 1.5) } if (g < Math.abs(l)) { g = l; var i = j / 4 } else { var i = j / (2 * Math.PI) * Math.asin(l / g) } if (h < 1) { return -0.5 * (g * Math.pow(2, 10 * (h -= 1)) * Math.sin((h * k - i) * (2 * Math.PI) / j)) + e } return g * Math.pow(2, -10 * (h -= 1)) * Math.sin((h * k - i) * (2 * Math.PI) / j) * 0.5 + l + e }, easeInBack: function (e, f, a, i, h, g) { if (g == undefined) { g = 1.70158 } return i * (f /= h) * f * ((g + 1) * f - g) + a }, easeOutBack: function (e, f, a, i, h, g) { if (g == undefined) { g = 1.70158 } return i * ((f = f / h - 1) * f * ((g + 1) * f + g) + 1) + a }, easeInOutBack: function (e, f, a, i, h, g) { if (g == undefined) { g = 1.70158 } if ((f /= h / 2) < 1) { return i / 2 * (f * f * (((g *= (1.525)) + 1) * f - g)) + a } return i / 2 * ((f -= 2) * f * (((g *= (1.525)) + 1) * f + g) + 2) + a }, easeInBounce: function (e, f, a, h, g) { return h - jQuery.easing.easeOutBounce(e, g - f, 0, h, g) + a }, easeOutBounce: function (e, f, a, h, g) { if ((f /= g) < (1 / 2.75)) { return h * (7.5625 * f * f) + a } else { if (f < (2 / 2.75)) { return h * (7.5625 * (f -= (1.5 / 2.75)) * f + 0.75) + a } else { if (f < (2.5 / 2.75)) { return h * (7.5625 * (f -= (2.25 / 2.75)) * f + 0.9375) + a } else { return h * (7.5625 * (f -= (2.625 / 2.75)) * f + 0.984375) + a } } } }, easeInOutBounce: function (e, f, a, h, g) { if (f < g / 2) { return jQuery.easing.easeInBounce(e, f * 2, 0, h, g) * 0.5 + a } return jQuery.easing.easeOutBounce(e, f * 2 - g, 0, h, g) * 0.5 + h * 0.5 + a } });

/* jQuery ScrollTo */
; (function ($) { var h = $.scrollTo = function (a, b, c) { $(window).scrollTo(a, b, c) }; h.defaults = { axis: 'xy', duration: parseFloat($.fn.jquery) >= 1.3 ? 0 : 1, limit: true }; h.window = function (a) { return $(window)._scrollable() }; $.fn._scrollable = function () { return this.map(function () { var a = this, isWin = !a.nodeName || $.inArray(a.nodeName.toLowerCase(), ['iframe', '#document', 'html', 'body']) != -1; if (!isWin) return a; var b = (a.contentWindow || a).document || a.ownerDocument || a; return /webkit/i.test(navigator.userAgent) || b.compatMode == 'BackCompat' ? b.body : b.documentElement }) }; $.fn.scrollTo = function (e, f, g) { if (typeof f == 'object') { g = f; f = 0 } if (typeof g == 'function') g = { onAfter: g }; if (e == 'max') e = 9e9; g = $.extend({}, h.defaults, g); f = f || g.duration; g.queue = g.queue && g.axis.length > 1; if (g.queue) f /= 2; g.offset = both(g.offset); g.over = both(g.over); return this._scrollable().each(function () { if (!e) return; var d = this, $elem = $(d), targ = e, toff, attr = {}, win = $elem.is('html,body'); switch (typeof targ) { case 'number': case 'string': if (/^([+-]=)?\d+(\.\d+)?(px|%)?$/.test(targ)) { targ = both(targ); break } targ = $(targ, this); if (!targ.length) return; case 'object': if (targ.is || targ.style) toff = (targ = $(targ)).offset() } $.each(g.axis.split(''), function (i, a) { var b = a == 'x' ? 'Left' : 'Top', pos = b.toLowerCase(), key = 'scroll' + b, old = d[key], max = h.max(d, a); if (toff) { attr[key] = toff[pos] + (win ? 0 : old - $elem.offset()[pos]); if (g.margin) { attr[key] -= parseInt(targ.css('margin' + b)) || 0; attr[key] -= parseInt(targ.css('border' + b + 'Width')) || 0 } attr[key] += g.offset[pos] || 0; if (g.over[pos]) attr[key] += targ[a == 'x' ? 'width' : 'height']() * g.over[pos] } else { var c = targ[pos]; attr[key] = c.slice && c.slice(-1) == '%' ? parseFloat(c) / 100 * max : c } if (g.limit && /^\d+$/.test(attr[key])) attr[key] = attr[key] <= 0 ? 0 : Math.min(attr[key], max); if (!i && g.queue) { if (old != attr[key]) animate(g.onAfterFirst); delete attr[key] } }); animate(g.onAfter); function animate(a) { $elem.animate(attr, f, g.easing, a && function () { a.call(this, e, g) }) } }).end() }; h.max = function (a, b) { var c = b == 'x' ? 'Width' : 'Height', scroll = 'scroll' + c; if (!$(a).is('html,body')) return a[scroll] - $(a)[c.toLowerCase()](); var d = 'client' + c, html = a.ownerDocument.documentElement, body = a.ownerDocument.body; return Math.max(html[scroll], body[scroll]) - Math.min(html[d], body[d]) }; function both(a) { return typeof a == 'object' ? a : { top: a, left: a } } })(jQuery);

/*! Respond.js v1.1.0: min/max-width media query polyfill. (c) Scott Jehl. MIT/GPLv2 Lic. j.mp/respondjs  */
(function (e) { e.respond = {}; respond.update = function () { }; respond.mediaQueriesSupported = e.matchMedia && e.matchMedia("only all").matches; if (respond.mediaQueriesSupported) { return } var w = e.document, s = w.documentElement, i = [], k = [], q = [], o = {}, h = 30, f = w.getElementsByTagName("head")[0] || s, g = w.getElementsByTagName("base")[0], b = f.getElementsByTagName("link"), d = [], a = function () { var D = b, y = D.length, B = 0, A, z, C, x; for (; B < y; B++) { A = D[B], z = A.href, C = A.media, x = A.rel && A.rel.toLowerCase() === "stylesheet"; if (!!z && x && !o[z]) { if (A.styleSheet && A.styleSheet.rawCssText) { m(A.styleSheet.rawCssText, z, C); o[z] = true } else { if ((!/^([a-zA-Z:]*\/\/)/.test(z) && !g) || z.replace(RegExp.$1, "").split("/")[0] === e.location.host) { d.push({ href: z, media: C }) } } } } u() }, u = function () { if (d.length) { var x = d.shift(); n(x.href, function (y) { m(y, x.href, x.media); o[x.href] = true; u() }) } }, m = function (I, x, z) { var G = I.match(/@media[^\{]+\{([^\{\}]*\{[^\}\{]*\})+/gi), J = G && G.length || 0, x = x.substring(0, x.lastIndexOf("/")), y = function (K) { return K.replace(/(url\()['"]?([^\/\)'"][^:\)'"]+)['"]?(\))/g, "$1" + x + "$2$3") }, A = !J && z, D = 0, C, E, F, B, H; if (x.length) { x += "/" } if (A) { J = 1 } for (; D < J; D++) { C = 0; if (A) { E = z; k.push(y(I)) } else { E = G[D].match(/@media *([^\{]+)\{([\S\s]+?)$/) && RegExp.$1; k.push(RegExp.$2 && y(RegExp.$2)) } B = E.split(","); H = B.length; for (; C < H; C++) { F = B[C]; i.push({ media: F.split("(")[0].match(/(only\s+)?([a-zA-Z]+)\s?/) && RegExp.$2 || "all", rules: k.length - 1, hasquery: F.indexOf("(") > -1, minw: F.match(/\(min\-width:[\s]*([\s]*[0-9\.]+)(px|em)[\s]*\)/) && parseFloat(RegExp.$1) + (RegExp.$2 || ""), maxw: F.match(/\(max\-width:[\s]*([\s]*[0-9\.]+)(px|em)[\s]*\)/) && parseFloat(RegExp.$1) + (RegExp.$2 || "") }) } } j() }, l, r, v = function () { var z, A = w.createElement("div"), x = w.body, y = false; A.style.cssText = "position:absolute;font-size:1em;width:1em"; if (!x) { x = y = w.createElement("body"); x.style.background = "none" } x.appendChild(A); s.insertBefore(x, s.firstChild); z = A.offsetWidth; if (y) { s.removeChild(x) } else { x.removeChild(A) } z = p = parseFloat(z); return z }, p, j = function (I) { var x = "clientWidth", B = s[x], H = w.compatMode === "CSS1Compat" && B || w.body[x] || B, D = {}, G = b[b.length - 1], z = (new Date()).getTime(); if (I && l && z - l < h) { clearTimeout(r); r = setTimeout(j, h); return } else { l = z } for (var E in i) { var K = i[E], C = K.minw, J = K.maxw, A = C === null, L = J === null, y = "em"; if (!!C) { C = parseFloat(C) * (C.indexOf(y) > -1 ? (p || v()) : 1) } if (!!J) { J = parseFloat(J) * (J.indexOf(y) > -1 ? (p || v()) : 1) } if (!K.hasquery || (!A || !L) && (A || H >= C) && (L || H <= J)) { if (!D[K.media]) { D[K.media] = [] } D[K.media].push(k[K.rules]) } } for (var E in q) { if (q[E] && q[E].parentNode === f) { f.removeChild(q[E]) } } for (var E in D) { var M = w.createElement("style"), F = D[E].join("\n"); M.type = "text/css"; M.media = E; f.insertBefore(M, G.nextSibling); if (M.styleSheet) { M.styleSheet.cssText = F } else { M.appendChild(w.createTextNode(F)) } q.push(M) } }, n = function (x, z) { var y = c(); if (!y) { return } y.open("GET", x, true); y.onreadystatechange = function () { if (y.readyState != 4 || y.status != 200 && y.status != 304) { return } z(y.responseText) }; if (y.readyState == 4) { return } y.send(null) }, c = (function () { var x = false; try { x = new XMLHttpRequest() } catch (y) { x = new ActiveXObject("Microsoft.XMLHTTP") } return function () { return x } })(); a(); respond.update = a; function t() { j(true) } if (e.addEventListener) { e.addEventListener("resize", t, false) } else { if (e.attachEvent) { e.attachEvent("onresize", t) } } })(this);

/* jQuery hashchange event */
; (function ($, e, b) { var c = "hashchange", h = document, f, g = $.event.special, i = h.documentMode, d = "on" + c in e && (i === b || i > 7); function a(j) { j = j || location.href; return "#" + j.replace(/^[^#]*#?(.*)$/, "$1") } $.fn[c] = function (j) { return j ? this.bind(c, j) : this.trigger(c) }; $.fn[c].delay = 50; g[c] = $.extend(g[c], { setup: function () { if (d) { return false } $(f.start) }, teardown: function () { if (d) { return false } $(f.stop) } }); f = (function () { var j = {}, p, m = a(), k = function (q) { return q }, l = k, o = k; j.start = function () { p || n() }; j.stop = function () { p && clearTimeout(p); p = b }; function n() { var r = a(), q = o(m); if (r !== m) { l(m = r, q); $(e).trigger(c) } else { if (q !== m) { location.href = location.href.replace(/#.*/, "") + q } } p = setTimeout(n, $.fn[c].delay) } $.browser.msie && !d && (function () { var q, r; j.start = function () { if (!q) { r = $.fn[c].src; r = r && r + a(); q = $('<iframe tabindex="-1" title="empty"/>').hide().one("load", function () { r || l(a()); n() }).attr("src", r || "javascript:0").insertAfter("body")[0].contentWindow; h.onpropertychange = function () { try { if (event.propertyName === "title") { q.document.title = h.title } } catch (s) { } } } }; j.stop = k; o = function () { return a(q.location.href) }; l = function (v, s) { var u = q.document, t = $.fn[c].domain; if (v !== s) { u.title = h.title; u.open(); t && u.write('<script>document.domain="' + t + '"<\/script>'); u.close(); q.location.hash = v } } })(); return j })() })(jQuery, this);

/* jQuery Waypoints - v2.0.4 */
(function () { var t = [].indexOf || function (t) { for (var e = 0, n = this.length; e < n; e++) { if (e in this && this[e] === t) return e } return -1 }, e = [].slice; (function (t, e) { if (typeof define === "function" && define.amd) { return define("waypoints", ["jquery"], function (n) { return e(n, t) }) } else { return e(t.jQuery, t) } })(this, function (n, r) { var i, o, l, s, f, u, c, a, h, d, p, y, v, w, g, m; i = n(r); a = t.call(r, "ontouchstart") >= 0; s = { horizontal: {}, vertical: {} }; f = 1; c = {}; u = "waypoints-context-id"; p = "resize.waypoints"; y = "scroll.waypoints"; v = 1; w = "waypoints-waypoint-ids"; g = "waypoint"; m = "waypoints"; o = function () { function t(t) { var e = this; this.$element = t; this.element = t[0]; this.didResize = false; this.didScroll = false; this.id = "context" + f++; this.oldScroll = { x: t.scrollLeft(), y: t.scrollTop() }; this.waypoints = { horizontal: {}, vertical: {} }; this.element[u] = this.id; c[this.id] = this; t.bind(y, function () { var t; if (!(e.didScroll || a)) { e.didScroll = true; t = function () { e.doScroll(); return e.didScroll = false }; return r.setTimeout(t, n[m].settings.scrollThrottle) } }); t.bind(p, function () { var t; if (!e.didResize) { e.didResize = true; t = function () { n[m]("refresh"); return e.didResize = false }; return r.setTimeout(t, n[m].settings.resizeThrottle) } }) } t.prototype.doScroll = function () { var t, e = this; t = { horizontal: { newScroll: this.$element.scrollLeft(), oldScroll: this.oldScroll.x, forward: "right", backward: "left" }, vertical: { newScroll: this.$element.scrollTop(), oldScroll: this.oldScroll.y, forward: "down", backward: "up" } }; if (a && (!t.vertical.oldScroll || !t.vertical.newScroll)) { n[m]("refresh") } n.each(t, function (t, r) { var i, o, l; l = []; o = r.newScroll > r.oldScroll; i = o ? r.forward : r.backward; n.each(e.waypoints[t], function (t, e) { var n, i; if (r.oldScroll < (n = e.offset) && n <= r.newScroll) { return l.push(e) } else if (r.newScroll < (i = e.offset) && i <= r.oldScroll) { return l.push(e) } }); l.sort(function (t, e) { return t.offset - e.offset }); if (!o) { l.reverse() } return n.each(l, function (t, e) { if (e.options.continuous || t === l.length - 1) { return e.trigger([i]) } }) }); return this.oldScroll = { x: t.horizontal.newScroll, y: t.vertical.newScroll } }; t.prototype.refresh = function () { var t, e, r, i = this; r = n.isWindow(this.element); e = this.$element.offset(); this.doScroll(); t = { horizontal: { contextOffset: r ? 0 : e.left, contextScroll: r ? 0 : this.oldScroll.x, contextDimension: this.$element.width(), oldScroll: this.oldScroll.x, forward: "right", backward: "left", offsetProp: "left" }, vertical: { contextOffset: r ? 0 : e.top, contextScroll: r ? 0 : this.oldScroll.y, contextDimension: r ? n[m]("viewportHeight") : this.$element.height(), oldScroll: this.oldScroll.y, forward: "down", backward: "up", offsetProp: "top" } }; return n.each(t, function (t, e) { return n.each(i.waypoints[t], function (t, r) { var i, o, l, s, f; i = r.options.offset; l = r.offset; o = n.isWindow(r.element) ? 0 : r.$element.offset()[e.offsetProp]; if (n.isFunction(i)) { i = i.apply(r.element) } else if (typeof i === "string") { i = parseFloat(i); if (r.options.offset.indexOf("%") > -1) { i = Math.ceil(e.contextDimension * i / 100) } } r.offset = o - e.contextOffset + e.contextScroll - i; if (r.options.onlyOnScroll && l != null || !r.enabled) { return } if (l !== null && l < (s = e.oldScroll) && s <= r.offset) { return r.trigger([e.backward]) } else if (l !== null && l > (f = e.oldScroll) && f >= r.offset) { return r.trigger([e.forward]) } else if (l === null && e.oldScroll >= r.offset) { return r.trigger([e.forward]) } }) }) }; t.prototype.checkEmpty = function () { if (n.isEmptyObject(this.waypoints.horizontal) && n.isEmptyObject(this.waypoints.vertical)) { this.$element.unbind([p, y].join(" ")); return delete c[this.id] } }; return t }(); l = function () { function t(t, e, r) { var i, o; r = n.extend({}, n.fn[g].defaults, r); if (r.offset === "bottom-in-view") { r.offset = function () { var t; t = n[m]("viewportHeight"); if (!n.isWindow(e.element)) { t = e.$element.height() } return t - n(this).outerHeight() } } this.$element = t; this.element = t[0]; this.axis = r.horizontal ? "horizontal" : "vertical"; this.callback = r.handler; this.context = e; this.enabled = r.enabled; this.id = "waypoints" + v++; this.offset = null; this.options = r; e.waypoints[this.axis][this.id] = this; s[this.axis][this.id] = this; i = (o = this.element[w]) != null ? o : []; i.push(this.id); this.element[w] = i } t.prototype.trigger = function (t) { if (!this.enabled) { return } if (this.callback != null) { this.callback.apply(this.element, t) } if (this.options.triggerOnce) { return this.destroy() } }; t.prototype.disable = function () { return this.enabled = false }; t.prototype.enable = function () { this.context.refresh(); return this.enabled = true }; t.prototype.destroy = function () { delete s[this.axis][this.id]; delete this.context.waypoints[this.axis][this.id]; return this.context.checkEmpty() }; t.getWaypointsByElement = function (t) { var e, r; r = t[w]; if (!r) { return [] } e = n.extend({}, s.horizontal, s.vertical); return n.map(r, function (t) { return e[t] }) }; return t }(); d = { init: function (t, e) { var r; if (e == null) { e = {} } if ((r = e.handler) == null) { e.handler = t } this.each(function () { var t, r, i, s; t = n(this); i = (s = e.context) != null ? s : n.fn[g].defaults.context; if (!n.isWindow(i)) { i = t.closest(i) } i = n(i); r = c[i[0][u]]; if (!r) { r = new o(i) } return new l(t, r, e) }); n[m]("refresh"); return this }, disable: function () { return d._invoke.call(this, "disable") }, enable: function () { return d._invoke.call(this, "enable") }, destroy: function () { return d._invoke.call(this, "destroy") }, prev: function (t, e) { return d._traverse.call(this, t, e, function (t, e, n) { if (e > 0) { return t.push(n[e - 1]) } }) }, next: function (t, e) { return d._traverse.call(this, t, e, function (t, e, n) { if (e < n.length - 1) { return t.push(n[e + 1]) } }) }, _traverse: function (t, e, i) { var o, l; if (t == null) { t = "vertical" } if (e == null) { e = r } l = h.aggregate(e); o = []; this.each(function () { var e; e = n.inArray(this, l[t]); return i(o, e, l[t]) }); return this.pushStack(o) }, _invoke: function (t) { this.each(function () { var e; e = l.getWaypointsByElement(this); return n.each(e, function (e, n) { n[t](); return true }) }); return this } }; n.fn[g] = function () { var t, r; r = arguments[0], t = 2 <= arguments.length ? e.call(arguments, 1) : []; if (d[r]) { return d[r].apply(this, t) } else if (n.isFunction(r)) { return d.init.apply(this, arguments) } else if (n.isPlainObject(r)) { return d.init.apply(this, [null, r]) } else if (!r) { return n.error("jQuery Waypoints needs a callback function or handler option.") } else { return n.error("The " + r + " method does not exist in jQuery Waypoints.") } }; n.fn[g].defaults = { context: r, continuous: true, enabled: true, horizontal: false, offset: 0, triggerOnce: false }; h = { refresh: function () { return n.each(c, function (t, e) { return e.refresh() }) }, viewportHeight: function () { var t; return (t = r.innerHeight) != null ? t : i.height() }, aggregate: function (t) { var e, r, i; e = s; if (t) { e = (i = c[n(t)[0][u]]) != null ? i.waypoints : void 0 } if (!e) { return [] } r = { horizontal: [], vertical: [] }; n.each(r, function (t, i) { n.each(e[t], function (t, e) { return i.push(e) }); i.sort(function (t, e) { return t.offset - e.offset }); r[t] = n.map(i, function (t) { return t.element }); return r[t] = n.unique(r[t]) }); return r }, above: function (t) { if (t == null) { t = r } return h._filter(t, "vertical", function (t, e) { return e.offset <= t.oldScroll.y }) }, below: function (t) { if (t == null) { t = r } return h._filter(t, "vertical", function (t, e) { return e.offset > t.oldScroll.y }) }, left: function (t) { if (t == null) { t = r } return h._filter(t, "horizontal", function (t, e) { return e.offset <= t.oldScroll.x }) }, right: function (t) { if (t == null) { t = r } return h._filter(t, "horizontal", function (t, e) { return e.offset > t.oldScroll.x }) }, enable: function () { return h._invoke("enable") }, disable: function () { return h._invoke("disable") }, destroy: function () { return h._invoke("destroy") }, extendFn: function (t, e) { return d[t] = e }, _invoke: function (t) { var e; e = n.extend({}, s.vertical, s.horizontal); return n.each(e, function (e, n) { n[t](); return true }) }, _filter: function (t, e, r) { var i, o; i = c[n(t)[0][u]]; if (!i) { return [] } o = []; n.each(i.waypoints[e], function (t, e) { if (r(i, e)) { return o.push(e) } }); o.sort(function (t, e) { return t.offset - e.offset }); return n.map(o, function (t) { return t.element }) } }; n[m] = function () { var t, n; n = arguments[0], t = 2 <= arguments.length ? e.call(arguments, 1) : []; if (h[n]) { return h[n].apply(null, t) } else { return h.aggregate.call(null, n) } }; n[m].settings = { resizeThrottle: 100, scrollThrottle: 30 }; return i.load(function () { return n[m]("refresh") }) }) }).call(this);

/*! http://mths.be/placeholder v2.0.7 by @mathias */
; (function (window, document, $) {

    // Opera Mini v7 doesnâ€™t support placeholder although its DOM seems to indicate so
    var isOperaMini = Object.prototype.toString.call(window.operamini) == '[object OperaMini]';
    var isInputSupported = 'placeholder' in document.createElement('input') && !isOperaMini;
    var isTextareaSupported = 'placeholder' in document.createElement('textarea') && !isOperaMini;
    var prototype = $.fn;
    var valHooks = $.valHooks;
    var propHooks = $.propHooks;
    var hooks;
    var placeholder;

    if (isInputSupported && isTextareaSupported) {

        placeholder = prototype.placeholder = function () {
            return this;
        };

        placeholder.input = placeholder.textarea = true;

    } else {

        placeholder = prototype.placeholder = function () {
            var $this = this;
            $this
            .filter((isInputSupported ? 'textarea' : ':input') + '[placeholder]')
            .not('.placeholder')
            .bind({
                'focus.placeholder': clearPlaceholder,
                'blur.placeholder': setPlaceholder
            })
            .data('placeholder-enabled', true)
            .trigger('blur.placeholder');
            return $this;
        };

        placeholder.input = isInputSupported;
        placeholder.textarea = isTextareaSupported;

        hooks = {
            'get': function (element) {
                var $element = $(element);

                var $passwordInput = $element.data('placeholder-password');
                if ($passwordInput) {
                    return $passwordInput[0].value;
                }

                return $element.data('placeholder-enabled') && $element.hasClass('placeholder') ? '' : element.value;
            },
            'set': function (element, value) {
                var $element = $(element);

                var $passwordInput = $element.data('placeholder-password');
                if ($passwordInput) {
                    return $passwordInput[0].value = value;
                }

                if (!$element.data('placeholder-enabled')) {
                    return element.value = value;
                }
                if (value == '') {
                    element.value = value;
                    // Issue #56: Setting the placeholder causes problems if the element continues to have focus.
                    if (element != safeActiveElement()) {
                        // We can't use `triggerHandler` here because of dummy text/password inputs :(
                        setPlaceholder.call(element);
                    }
                } else if ($element.hasClass('placeholder')) {
                    clearPlaceholder.call(element, true, value) || (element.value = value);
                } else {
                    element.value = value;
                }
                // `set` can not return `undefined`; see http://jsapi.info/jquery/1.7.1/val#L2363
                return $element;
            }
        };

        if (!isInputSupported) {
            valHooks.input = hooks;
            propHooks.value = hooks;
        }
        if (!isTextareaSupported) {
            valHooks.textarea = hooks;
            propHooks.value = hooks;
        }

        $(function () {
            // Look for forms
            $(document).delegate('form', 'submit.placeholder', function () {
                // Clear the placeholder values so they don't get submitted
                var $inputs = $('.placeholder', this).each(clearPlaceholder);
                setTimeout(function () {
                    $inputs.each(setPlaceholder);
                }, 10);
            });
        });

        // Clear placeholder values upon page reload
        $(window).bind('beforeunload.placeholder', function () {
            $('.placeholder').each(function () {
                this.value = '';
            });
        });

    }

    function args(elem) {
        // Return an object of element attributes
        var newAttrs = {};
        var rinlinejQuery = /^jQuery\d+$/;
        $.each(elem.attributes, function (i, attr) {
            if (attr.specified && !rinlinejQuery.test(attr.name)) {
                newAttrs[attr.name] = attr.value;
            }
        });
        return newAttrs;
    }

    function clearPlaceholder(event, value) {
        var input = this;
        var $input = $(input);
        if (input.value == $input.attr('placeholder') && $input.hasClass('placeholder')) {
            if ($input.data('placeholder-password')) {
                $input = $input.hide().next().show().attr('id', $input.removeAttr('id').data('placeholder-id'));
                // If `clearPlaceholder` was called from `$.valHooks.input.set`
                if (event === true) {
                    return $input[0].value = value;
                }
                $input.focus();
            } else {
                input.value = '';
                $input.removeClass('placeholder');
                input == safeActiveElement() && input.select();
            }
        }
    }

    function setPlaceholder() {
        var $replacement;
        var input = this;
        var $input = $(input);
        var id = this.id;
        if (input.value == '') {
            if (input.type == 'password') {
                if (!$input.data('placeholder-textinput')) {
                    try {
                        $replacement = $input.clone().attr({ 'type': 'text' });
                    } catch (e) {
                        $replacement = $('<input>').attr($.extend(args(this), { 'type': 'text' }));
                    }
                    $replacement
                    .removeAttr('name')
                    .data({
                        'placeholder-password': $input,
                        'placeholder-id': id
                    })
                    .bind('focus.placeholder', clearPlaceholder);
                    $input
                    .data({
                        'placeholder-textinput': $replacement,
                        'placeholder-id': id
                    })
                    .before($replacement);
                }
                $input = $input.removeAttr('id').hide().prev().attr('id', id).show();
                // Note: `$input[0] != input` now!
            }
            $input.addClass('placeholder');
            $input[0].value = $input.attr('placeholder');
        } else {
            $input.removeClass('placeholder');
        }
    }

    function safeActiveElement() {
        // Avoid IE9 `document.activeElement` of death
        // https://github.com/mathiasbynens/jquery-placeholder/pull/99
        try {
            return document.activeElement;
        } catch (err) { }
    }

}(this, document, jQuery));

/* jQuery djax */
/*
* jQuery djax
*
* @version v0.122
*
* Copyright 2012, Brian Zeligson
* Released under the MIT license.
* http://www.opensource.org/licenses/mit-license.php
*
* Homepage:
* http://beezee.github.com/djax.html
*
* Authors:
* Brian Zeligson
*
* Contributors:
* Gary Jones @GaryJones
*
* Maintainer:
* Brian Zeligson github @beezee
*
*/

/*jslint browser: true, indent: 4, maxerr: 50, sub: true */
/*jshint bitwise:true, curly:true, eqeqeq:true, forin:true, immed:true, latedef:true, noarg:true, noempty:true, nomen:true, nonew:true, onevar:true, plusplus:true, regexp:true, smarttabs:true, strict:true, trailing:true, undef:true, white:true, browser:true, jquery:true, indent:4, maxerr:50, */
/*global jQuery */

// ==ClosureCompiler==
// @compilation_level ADVANCED_OPTIMIZATIONS
// @output_file_name jquery.djax.js
// @externs_url http://closure-compiler.googlecode.com/svn/trunk/contrib/externs/jquery-1.7.js
// ==/ClosureCompiler==
// http://closure-compiler.appspot.com/home

(function ($, exports) {
    'use strict';

    $.fn.djax = function (selector, exceptions, replaceBlockWithFunc) {

        // If browser doesn't support pushState, abort now
        if (!history.pushState) {
            return $(this);
        }

        var self = this,
        blockSelector = selector,
        excludes = (exceptions && exceptions.length) ? exceptions : [],
        replaceBlockWith = (replaceBlockWithFunc) ? replaceBlockWithFunc : $.fn.replaceWith,
        djaxing = false;

        // Ensure that the history is correct when going from 2nd page to 1st
        window.history.replaceState(
        {
            'url': window.location.href,
            'title': $('title').text()
        },
        $('title').text(),
        window.location.href
        );

        self.clearDjaxing = function () {
            self.djaxing = false;
        }

        // Exclude the link exceptions
        self.attachClick = function (element, event) {

            var link = $(element),
            exception = false;

            $.each(excludes, function (index, exclusion) {
                if (link.attr('href').indexOf(exclusion) !== -1) {
                    exception = true;
                }
                if (window.location.href.indexOf(exclusion) !== -1) {
                    exception = true;
                }
            });

            // If the link is one of the exceptions, return early so that
            // the link can be clicked and a full page load as normal
            if (exception) {
                return $(element);
            }

            // From this point on, we handle the behaviour
            event.preventDefault();

            // If we're already doing djaxing, return now and silently fail
            if (self.djaxing) {
                setTimeout(self.clearDjaxing, 1000);
                return $(element);
            }

            $(window).trigger('djaxClick', [element]);
            self.reqUrl = link.attr('href');
            self.triggered = false;
            self.navigate(link.attr('href'), true);
        };

        // Handle the navigation
        self.navigate = function (url, add) {

            var blocks = $(blockSelector);

            self.djaxing = true;

            // Get the new page
            $(window).trigger(
            'djaxLoading',
            [{
                'url': url
            }]
            );

            var replaceBlocks = function (response) {
                if (url !== self.reqUrl) {
                    self.navigate(self.reqUrl, false);
                    return true;
                }

                var result = $(response),
                newBlocks = $(result).find(blockSelector);

                if (add) {
                    window.history.pushState(
                    {
                        'url': url,
                        'title': $(result).filter('title').text()
                    },
                    $(result).filter('title').text(),
                    url
                    );
                }

                // Set page title as new page title
                $('title').text($(result).filter('title').text());

                // Loop through each block and find new page equivalent
                blocks.each(function () {

                    var id = '#' + $(this).attr('id'),
                    newBlock = newBlocks.filter(id),
                    block = $(this);

                    $('a', newBlock).filter(function () {
                        return this.hostname === location.hostname;
                    }).addClass('dJAX_internal').on('click', function (event) {
                        return self.attachClick(this, event);
                    });

                    if (newBlock.length) {
                        if (block.html() !== newBlock.html()) {
                            replaceBlockWith.call(block, newBlock);
                        }
                    } else {
                        block.remove();
                    }

                });

                // Loop through new page blocks and add in as needed
                $.each(newBlocks, function () {

                    var newBlock = $(this),
                    id = '#' + $(this).attr('id'),
                    $previousSibling;

                    // If there is a new page block without an equivalent block
                    // in the old page, we need to find out where to insert it
                    if (!$(id).length) {

                        // Find the previous sibling
                        $previousSibling = $(result).find(id).prev();

                        if ($previousSibling.length) {
                            // Insert after the previous element
                            newBlock.insertAfter('#' + $previousSibling.attr('id'));
                        } else {
                            // There's no previous sibling, so prepend to parent instead
                            newBlock.prependTo('#' + newBlock.parent().attr('id'));
                        }
                    }

                    // Only add a class to internal links
                    $('a', newBlock).filter(function () {
                        return this.hostname === location.hostname;
                    }).addClass('dJAX_internal').on('click', function (event) {
                        return self.attachClick(this, event);
                    });

                });

                // Trigger djaxLoad event as a pseudo ready()
                if (!self.triggered) {
                    $(window).trigger(
                    'djaxLoad',
                    [{
                        'url': url,
                        'title': $(result).filter('title').text(),
                        'response': response
                    }]
                    );
                    self.triggered = true;
                    self.djaxing = false;
                }
            };
            $.get(url, function (response) {
                replaceBlocks(response);
            }).error(function (response) {
                // handle error
                console.log('error', response);
                replaceBlocks(response['responseText']);
            });
        }; /* End self.navigate */

        // Only add a class to internal links
        $(this).find('a').filter(function () {
            return this.hostname === location.hostname;
        }).addClass('dJAX_internal').on('click', function (event) {
            return self.attachClick(this, event);
        });


        // On new page load
        $(window).bind('popstate', function (event) {
            self.triggered = false;
            if (event.originalEvent.state) {
                self.reqUrl = event.originalEvent.state.url;
                self.navigate(event.originalEvent.state.url, false);
            }
        });

    };

}(jQuery, window));

/**
* Isotope v1.5.26
* An exquisite jQuery plugin for magical layouts
* http://isotope.metafizzy.co
*
* Commercial use requires one-time purchase of a commercial license
* http://isotope.metafizzy.co/docs/license.html
*
* Non-commercial use is licensed under the MIT License
*
* Copyright 2014 Metafizzy
*/
!function (t, i) { "use strict"; var s, e = t.document, n = e.documentElement, o = t.Modernizr, r = function (t) { return t.charAt(0).toUpperCase() + t.slice(1) }, a = "Moz Webkit O Ms".split(" "), h = function (t) { var i, s = n.style; if ("string" == typeof s[t]) return t; t = r(t); for (var e = 0, o = a.length; o > e; e++) if (i = a[e] + t, "string" == typeof s[i]) return i }, l = h("transform"), u = h("transitionProperty"), c = { csstransforms: function () { return !!l }, csstransforms3d: function () { var t = !!h("perspective"); if (t && "webkitPerspective" in n.style) { var s = i("<style>@media (transform-3d),(-webkit-transform-3d){#modernizr{height:3px}}</style>").appendTo("head"), e = i('<div id="modernizr" />').appendTo("html"); t = 3 === e.height(), e.remove(), s.remove() } return t }, csstransitions: function () { return !!u } }; if (o) for (s in c) o.hasOwnProperty(s) || o.addTest(s, c[s]); else { o = t.Modernizr = { _version: "1.6ish: miniModernizr for Isotope" }; var d, f = " "; for (s in c) d = c[s](), o[s] = d, f += " " + (d ? "" : "no-") + s; i("html").addClass(f) } if (o.csstransforms) { var m = o.csstransforms3d ? { translate: function (t) { return "translate3d(" + t[0] + "px, " + t[1] + "px, 0) " }, scale: function (t) { return "scale3d(" + t + ", " + t + ", 1) " } } : { translate: function (t) { return "translate(" + t[0] + "px, " + t[1] + "px) " }, scale: function (t) { return "scale(" + t + ") " } }, p = function (t, s, e) { var n, o, r = i.data(t, "isoTransform") || {}, a = {}, h = {}; a[s] = e, i.extend(r, a); for (n in r) o = r[n], h[n] = m[n](o); var u = h.translate || "", c = h.scale || "", d = u + c; i.data(t, "isoTransform", r), t.style[l] = d }; i.cssNumber.scale = !0, i.cssHooks.scale = { set: function (t, i) { p(t, "scale", i) }, get: function (t) { var s = i.data(t, "isoTransform"); return s && s.scale ? s.scale : 1 } }, i.fx.step.scale = function (t) { i.cssHooks.scale.set(t.elem, t.now + t.unit) }, i.cssNumber.translate = !0, i.cssHooks.translate = { set: function (t, i) { p(t, "translate", i) }, get: function (t) { var s = i.data(t, "isoTransform"); return s && s.translate ? s.translate : [0, 0] } } } var y, g; o.csstransitions && (y = { WebkitTransitionProperty: "webkitTransitionEnd", MozTransitionProperty: "transitionend", OTransitionProperty: "oTransitionEnd otransitionend", transitionProperty: "transitionend" }[u], g = h("transitionDuration")); var v, _ = i.event, A = i.event.handle ? "handle" : "dispatch"; _.special.smartresize = { setup: function () { i(this).bind("resize", _.special.smartresize.handler) }, teardown: function () { i(this).unbind("resize", _.special.smartresize.handler) }, handler: function (t, i) { var s = this, e = arguments; t.type = "smartresize", v && clearTimeout(v), v = setTimeout(function () { _[A].apply(s, e) }, "execAsap" === i ? 0 : 100) } }, i.fn.smartresize = function (t) { return t ? this.bind("smartresize", t) : this.trigger("smartresize", ["execAsap"]) }, i.Isotope = function (t, s, e) { this.element = i(s), this._create(t), this._init(e) }; var w = ["width", "height"], C = i(t); i.Isotope.settings = { resizable: !0, layoutMode: "masonry", containerClass: "isotope", itemClass: "isotope-item", hiddenClass: "isotope-hidden", hiddenStyle: { opacity: 0, scale: .001 }, visibleStyle: { opacity: 1, scale: 1 }, containerStyle: { position: "relative", overflow: "hidden" }, animationEngine: "best-available", animationOptions: { queue: !1, duration: 800 }, sortBy: "original-order", sortAscending: !0, resizesContainer: !0, transformsEnabled: !0, itemPositionDataEnabled: !1 }, i.Isotope.prototype = { _create: function (t) { this.options = i.extend({}, i.Isotope.settings, t), this.styleQueue = [], this.elemCount = 0; var s = this.element[0].style; this.originalStyle = {}; var e = w.slice(0); for (var n in this.options.containerStyle) e.push(n); for (var o = 0, r = e.length; r > o; o++) n = e[o], this.originalStyle[n] = s[n] || ""; this.element.css(this.options.containerStyle), this._updateAnimationEngine(), this._updateUsingTransforms(); var a = { "original-order": function (t, i) { return i.elemCount++, i.elemCount }, random: function () { return Math.random() } }; this.options.getSortData = i.extend(this.options.getSortData, a), this.reloadItems(), this.offset = { left: parseInt(this.element.css("padding-left") || 0, 10), top: parseInt(this.element.css("padding-top") || 0, 10) }; var h = this; setTimeout(function () { h.element.addClass(h.options.containerClass) }, 0), this.options.resizable && C.bind("smartresize.isotope", function () { h.resize() }), this.element.delegate("." + this.options.hiddenClass, "click", function () { return !1 }) }, _getAtoms: function (t) { var i = this.options.itemSelector, s = i ? t.filter(i).add(t.find(i)) : t, e = { position: "absolute" }; return s = s.filter(function (t, i) { return 1 === i.nodeType }), this.usingTransforms && (e.left = 0, e.top = 0), s.css(e).addClass(this.options.itemClass), this.updateSortData(s, !0), s }, _init: function (t) { this.$filteredAtoms = this._filter(this.$allAtoms), this._sort(), this.reLayout(t) }, option: function (t) { if (i.isPlainObject(t)) { this.options = i.extend(!0, this.options, t); var s; for (var e in t) s = "_update" + r(e), this[s] && this[s]() } }, _updateAnimationEngine: function () { var t, i = this.options.animationEngine.toLowerCase().replace(/[ _\-]/g, ""); switch (i) { case "css": case "none": t = !1; break; case "jquery": t = !0; break; default: t = !o.csstransitions } this.isUsingJQueryAnimation = t, this._updateUsingTransforms() }, _updateTransformsEnabled: function () { this._updateUsingTransforms() }, _updateUsingTransforms: function () { var t = this.usingTransforms = this.options.transformsEnabled && o.csstransforms && o.csstransitions && !this.isUsingJQueryAnimation; t || (delete this.options.hiddenStyle.scale, delete this.options.visibleStyle.scale), this.getPositionStyles = t ? this._translate : this._positionAbs }, _filter: function (t) { var i = "" === this.options.filter ? "*" : this.options.filter; if (!i) return t; var s = this.options.hiddenClass, e = "." + s, n = t.filter(e), o = n; if ("*" !== i) { o = n.filter(i); var r = t.not(e).not(i).addClass(s); this.styleQueue.push({ $el: r, style: this.options.hiddenStyle }) } return this.styleQueue.push({ $el: o, style: this.options.visibleStyle }), o.removeClass(s), t.filter(i) }, updateSortData: function (t, s) { var e, n, o = this, r = this.options.getSortData; t.each(function () { e = i(this), n = {}; for (var t in r) n[t] = s || "original-order" !== t ? r[t](e, o) : i.data(this, "isotope-sort-data")[t]; i.data(this, "isotope-sort-data", n) }) }, _sort: function () { var t = this.options.sortBy, i = this._getSorter, s = this.options.sortAscending ? 1 : -1, e = function (e, n) { var o = i(e, t), r = i(n, t); return o === r && "original-order" !== t && (o = i(e, "original-order"), r = i(n, "original-order")), (o > r ? 1 : r > o ? -1 : 0) * s }; this.$filteredAtoms.sort(e) }, _getSorter: function (t, s) { return i.data(t, "isotope-sort-data")[s] }, _translate: function (t, i) { return { translate: [t, i] } }, _positionAbs: function (t, i) { return { left: t, top: i } }, _pushPosition: function (t, i, s) { i = Math.round(i + this.offset.left), s = Math.round(s + this.offset.top); var e = this.getPositionStyles(i, s); this.styleQueue.push({ $el: t, style: e }), this.options.itemPositionDataEnabled && t.data("isotope-item-position", { x: i, y: s }) }, layout: function (t, i) { var s = this.options.layoutMode; if (this["_" + s + "Layout"](t), this.options.resizesContainer) { var e = this["_" + s + "GetContainerSize"](); this.styleQueue.push({ $el: this.element, style: e }) } this._processStyleQueue(t, i), this.isLaidOut = !0 }, _processStyleQueue: function (t, s) { var e, n, r, a, h = this.isLaidOut ? this.isUsingJQueryAnimation ? "animate" : "css" : "css", l = this.options.animationOptions, u = this.options.onLayout; if (n = function (t, i) { i.$el[h](i.style, l) }, this._isInserting && this.isUsingJQueryAnimation) n = function (t, i) { e = i.$el.hasClass("no-transition") ? "css" : h, i.$el[e](i.style, l) }; else if (s || u || l.complete) { var c = !1, d = [s, u, l.complete], f = this; if (r = !0, a = function () { if (!c) { for (var i, s = 0, e = d.length; e > s; s++) i = d[s], "function" == typeof i && i.call(f.element, t, f); c = !0 } }, this.isUsingJQueryAnimation && "animate" === h) l.complete = a, r = !1; else if (o.csstransitions) { for (var m, p = 0, v = this.styleQueue[0], _ = v && v.$el; !_ || !_.length;) { if (m = this.styleQueue[p++], !m) return; _ = m.$el } var A = parseFloat(getComputedStyle(_[0])[g]); A > 0 && (n = function (t, i) { i.$el[h](i.style, l).one(y, a) }, r = !1) } } i.each(this.styleQueue, n), r && a(), this.styleQueue = [] }, resize: function () { this["_" + this.options.layoutMode + "ResizeChanged"]() && this.reLayout() }, reLayout: function (t) { this["_" + this.options.layoutMode + "Reset"](), this.layout(this.$filteredAtoms, t) }, addItems: function (t, i) { var s = this._getAtoms(t); this.$allAtoms = this.$allAtoms.add(s), i && i(s) }, insert: function (t, i) { this.element.append(t); var s = this; this.addItems(t, function (t) { var e = s._filter(t); s._addHideAppended(e), s._sort(), s.reLayout(), s._revealAppended(e, i) }) }, appended: function (t, i) { var s = this; this.addItems(t, function (t) { s._addHideAppended(t), s.layout(t), s._revealAppended(t, i) }) }, _addHideAppended: function (t) { this.$filteredAtoms = this.$filteredAtoms.add(t), t.addClass("no-transition"), this._isInserting = !0, this.styleQueue.push({ $el: t, style: this.options.hiddenStyle }) }, _revealAppended: function (t, i) { var s = this; setTimeout(function () { t.removeClass("no-transition"), s.styleQueue.push({ $el: t, style: s.options.visibleStyle }), s._isInserting = !1, s._processStyleQueue(t, i) }, 10) }, reloadItems: function () { this.$allAtoms = this._getAtoms(this.element.children()) }, remove: function (t, i) { this.$allAtoms = this.$allAtoms.not(t), this.$filteredAtoms = this.$filteredAtoms.not(t); var s = this, e = function () { t.remove(), i && i.call(s.element) }; t.filter(":not(." + this.options.hiddenClass + ")").length ? (this.styleQueue.push({ $el: t, style: this.options.hiddenStyle }), this._sort(), this.reLayout(e)) : e() }, shuffle: function (t) { this.updateSortData(this.$allAtoms), this.options.sortBy = "random", this._sort(), this.reLayout(t) }, destroy: function () { var t = this.usingTransforms, i = this.options; this.$allAtoms.removeClass(i.hiddenClass + " " + i.itemClass).each(function () { var i = this.style; i.position = "", i.top = "", i.left = "", i.opacity = "", t && (i[l] = "") }); var s = this.element[0].style; for (var e in this.originalStyle) s[e] = this.originalStyle[e]; this.element.unbind(".isotope").undelegate("." + i.hiddenClass, "click").removeClass(i.containerClass).removeData("isotope"), C.unbind(".isotope") }, _getSegments: function (t) { var i, s = this.options.layoutMode, e = t ? "rowHeight" : "columnWidth", n = t ? "height" : "width", o = t ? "rows" : "cols", a = this.element[n](), h = this.options[s] && this.options[s][e] || this.$filteredAtoms["outer" + r(n)](!0) || a; i = Math.floor(a / h), i = Math.max(i, 1), this[s][o] = i, this[s][e] = h }, _checkIfSegmentsChanged: function (t) { var i = this.options.layoutMode, s = t ? "rows" : "cols", e = this[i][s]; return this._getSegments(t), this[i][s] !== e }, _masonryReset: function () { this.masonry = {}, this._getSegments(); var t = this.masonry.cols; for (this.masonry.colYs = []; t--;) this.masonry.colYs.push(0) }, _masonryLayout: function (t) { var s = this, e = s.masonry; t.each(function () { var t = i(this), n = Math.ceil(t.outerWidth(!0) / e.columnWidth); if (n = Math.min(n, e.cols), 1 === n) s._masonryPlaceBrick(t, e.colYs); else { var o, r, a = e.cols + 1 - n, h = []; for (r = 0; a > r; r++) o = e.colYs.slice(r, r + n), h[r] = Math.max.apply(Math, o); s._masonryPlaceBrick(t, h) } }) }, _masonryPlaceBrick: function (t, i) { for (var s = Math.min.apply(Math, i), e = 0, n = 0, o = i.length; o > n; n++) if (i[n] === s) { e = n; break } var r = this.masonry.columnWidth * e, a = s; this._pushPosition(t, r, a); var h = s + t.outerHeight(!0), l = this.masonry.cols + 1 - o; for (n = 0; l > n; n++) this.masonry.colYs[e + n] = h }, _masonryGetContainerSize: function () { var t = Math.max.apply(Math, this.masonry.colYs); return { height: t } }, _masonryResizeChanged: function () { return this._checkIfSegmentsChanged() }, _fitRowsReset: function () { this.fitRows = { x: 0, y: 0, height: 0 } }, _fitRowsLayout: function (t) { var s = this, e = this.element.width(), n = this.fitRows; t.each(function () { var t = i(this), o = t.outerWidth(!0), r = t.outerHeight(!0); 0 !== n.x && o + n.x > e && (n.x = 0, n.y = n.height), s._pushPosition(t, n.x, n.y), n.height = Math.max(n.y + r, n.height), n.x += o }) }, _fitRowsGetContainerSize: function () { return { height: this.fitRows.height } }, _fitRowsResizeChanged: function () { return !0 }, _cellsByRowReset: function () { this.cellsByRow = { index: 0 }, this._getSegments(), this._getSegments(!0) }, _cellsByRowLayout: function (t) { var s = this, e = this.cellsByRow; t.each(function () { var t = i(this), n = e.index % e.cols, o = Math.floor(e.index / e.cols), r = (n + .5) * e.columnWidth - t.outerWidth(!0) / 2, a = (o + .5) * e.rowHeight - t.outerHeight(!0) / 2; s._pushPosition(t, r, a), e.index++ }) }, _cellsByRowGetContainerSize: function () { return { height: Math.ceil(this.$filteredAtoms.length / this.cellsByRow.cols) * this.cellsByRow.rowHeight + this.offset.top } }, _cellsByRowResizeChanged: function () { return this._checkIfSegmentsChanged() }, _straightDownReset: function () { this.straightDown = { y: 0 } }, _straightDownLayout: function (t) { var s = this; t.each(function () { var t = i(this); s._pushPosition(t, 0, s.straightDown.y), s.straightDown.y += t.outerHeight(!0) }) }, _straightDownGetContainerSize: function () { return { height: this.straightDown.y } }, _straightDownResizeChanged: function () { return !0 }, _masonryHorizontalReset: function () { this.masonryHorizontal = {}, this._getSegments(!0); var t = this.masonryHorizontal.rows; for (this.masonryHorizontal.rowXs = []; t--;) this.masonryHorizontal.rowXs.push(0) }, _masonryHorizontalLayout: function (t) { var s = this, e = s.masonryHorizontal; t.each(function () { var t = i(this), n = Math.ceil(t.outerHeight(!0) / e.rowHeight); if (n = Math.min(n, e.rows), 1 === n) s._masonryHorizontalPlaceBrick(t, e.rowXs); else { var o, r, a = e.rows + 1 - n, h = []; for (r = 0; a > r; r++) o = e.rowXs.slice(r, r + n), h[r] = Math.max.apply(Math, o); s._masonryHorizontalPlaceBrick(t, h) } }) }, _masonryHorizontalPlaceBrick: function (t, i) { for (var s = Math.min.apply(Math, i), e = 0, n = 0, o = i.length; o > n; n++) if (i[n] === s) { e = n; break } var r = s, a = this.masonryHorizontal.rowHeight * e; this._pushPosition(t, r, a); var h = s + t.outerWidth(!0), l = this.masonryHorizontal.rows + 1 - o; for (n = 0; l > n; n++) this.masonryHorizontal.rowXs[e + n] = h }, _masonryHorizontalGetContainerSize: function () { var t = Math.max.apply(Math, this.masonryHorizontal.rowXs); return { width: t } }, _masonryHorizontalResizeChanged: function () { return this._checkIfSegmentsChanged(!0) }, _fitColumnsReset: function () { this.fitColumns = { x: 0, y: 0, width: 0 } }, _fitColumnsLayout: function (t) { var s = this, e = this.element.height(), n = this.fitColumns; t.each(function () { var t = i(this), o = t.outerWidth(!0), r = t.outerHeight(!0); 0 !== n.y && r + n.y > e && (n.x = n.width, n.y = 0), s._pushPosition(t, n.x, n.y), n.width = Math.max(n.x + o, n.width), n.y += r }) }, _fitColumnsGetContainerSize: function () { return { width: this.fitColumns.width } }, _fitColumnsResizeChanged: function () { return !0 }, _cellsByColumnReset: function () { this.cellsByColumn = { index: 0 }, this._getSegments(), this._getSegments(!0) }, _cellsByColumnLayout: function (t) { var s = this, e = this.cellsByColumn; t.each(function () { var t = i(this), n = Math.floor(e.index / e.rows), o = e.index % e.rows, r = (n + .5) * e.columnWidth - t.outerWidth(!0) / 2, a = (o + .5) * e.rowHeight - t.outerHeight(!0) / 2; s._pushPosition(t, r, a), e.index++ }) }, _cellsByColumnGetContainerSize: function () { return { width: Math.ceil(this.$filteredAtoms.length / this.cellsByColumn.rows) * this.cellsByColumn.columnWidth } }, _cellsByColumnResizeChanged: function () { return this._checkIfSegmentsChanged(!0) }, _straightAcrossReset: function () { this.straightAcross = { x: 0 } }, _straightAcrossLayout: function (t) { var s = this; t.each(function () { var t = i(this); s._pushPosition(t, s.straightAcross.x, 0), s.straightAcross.x += t.outerWidth(!0) }) }, _straightAcrossGetContainerSize: function () { return { width: this.straightAcross.x } }, _straightAcrossResizeChanged: function () { return !0 } }, i.fn.imagesLoaded = function (t) { function s() { t.call(n, o) } function e(t) { var n = t.target; n.src !== a && -1 === i.inArray(n, h) && (h.push(n), --r <= 0 && (setTimeout(s), o.unbind(".imagesLoaded", e))) } var n = this, o = n.find("img").add(n.filter("img")), r = o.length, a = "data:image/gif;base64,R0lGODlhAQABAIAAAAAAAP///ywAAAAAAQABAAACAUwAOw==", h = []; return r || s(), o.bind("load.imagesLoaded error.imagesLoaded", e).each(function () { var t = this.src; this.src = a, this.src = t }), n }; var z = function (i) { t.console && t.console.error(i) }; i.fn.isotope = function (t, s) { if ("string" == typeof t) { var e = Array.prototype.slice.call(arguments, 1); this.each(function () { var s = i.data(this, "isotope"); return s ? i.isFunction(s[t]) && "_" !== t.charAt(0) ? void s[t].apply(s, e) : void z("no such method '" + t + "' for isotope instance") : void z("cannot call methods on isotope prior to initialization; attempted to call method '" + t + "'") }) } else this.each(function () { var e = i.data(this, "isotope"); e ? (e.option(t), e._init(s)) : i.data(this, "isotope", new i.Isotope(t, this, s)) }); return this } }(window, jQuery);

/*
* Isotope custom layout mode that extends masonry in order to work with percentage-sized columns
*/
(function (l, e) {
    e.extend(e.Isotope.prototype, {
        _sloppyMasonryReset: function () { var b = this.element.width(), d = this.options.sloppyMasonry && this.options.sloppyMasonry.columnWidth || this.$filteredAtoms.outerWidth(!0) || b; this.sloppyMasonry = { cols: Math.round(b / d), columnWidth: d }; b = this.sloppyMasonry.cols; for (this.sloppyMasonry.colYs = []; b--;) this.sloppyMasonry.colYs.push(0) }, _sloppyMasonryLayout: function (b) {
            var d = this, c = d.sloppyMasonry; b.each(function () {
                var b = e(this), a = Math.round(b.outerWidth(!0) / c.columnWidth),
                a = Math.min(a, c.cols); if (1 === a) d._sloppyMasonryPlaceBrick(b, c.colYs); else { var f = c.cols + 1 - a, h = [], k, g; for (g = 0; g < f; g++) k = c.colYs.slice(g, g + a), h[g] = Math.max.apply(Math, k); d._sloppyMasonryPlaceBrick(b, h) }
            })
        }, _sloppyMasonryPlaceBrick: function (b, d) { for (var c = Math.min.apply(Math, d), e = 0, a = 0, f = d.length; a < f; a++) if (d[a] === c) { e = a; break } this._pushPosition(b, this.sloppyMasonry.columnWidth * e, c); c += b.outerHeight(!0); f = this.sloppyMasonry.cols + 1 - f; for (a = 0; a < f; a++) this.sloppyMasonry.colYs[e + a] = c }, _sloppyMasonryGetContainerSize: function () {
            return {
                height: Math.max.apply(Math,
                this.sloppyMasonry.colYs)
            }
        }, _sloppyMasonryResizeChanged: function () { return !0 }
    })
})(this, this.jQuery);