$(document).ready(function () {
    $('.multselect').multiselect({
        columns: 1,
        placeholder: 'Выбор покрытия',
        search: false,
        selectAll: false,
        maxPlaceholderOpts: 1,
        onOptionClick: function (element, option) {
            setTimeout(function () {
                if ($('.ms-options-wrap>.ms-options>ul li.selected').length > 1) {
                    $('.ms-options-wrap>button>span').text('Выбрано - ' + $('.ms-options-wrap>.ms-options>ul li.selected').length)
                }
            }, 5);
        }
    });
    var galleryThumbs = new Swiper('.gallery-thumbs', {
        spaceBetween: 0,
        slidesPerView: 7,
        freeMode: true,
        watchSlidesVisibility: true,
        watchSlidesProgress: true,
        allowTouchMove: false
    });
    var galleryTop = new Swiper('.gallery-top', {
        spaceBetween: 0,
        thumbs: {
            //swiper: galleryThumbs
        },
        speed: 500,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
    });
    $('.gallery-thumbs .swiper-slide').on('mouseover', function () {
        galleryTop.slideTo($(this).index());
        $('.gallery-thumbs .swiper-slide').removeClass('swiper-slide-active');
        $(this).addClass('swiper-slide-active');
    })

    var photosThumbs = new Swiper('.main-photos-thumb', {
        spaceBetween: 4,
        slidesPerView: 4,
        freeMode: true,
        watchSlidesVisibility: true,
        watchSlidesProgress: true,
        allowTouchMove: false,
        breakpoints: {
            768: {
                slidesPerView: 3
            }
        }
    });
    var photosTop = new Swiper('.main-photos-top', {
        spaceBetween: 0,
        thumbs: {
            swiper: photosThumbs
        },
        on: {
            click: function () {
                $('.wrap-modal-slider').addClass('active');
                swiperModal.update();
                swiperModal.slideTo(photosTop.activeIndex, 0);
            },
        }
    });

    var swiperModal = new Swiper('.swiper-modal', {
        spaceBetween: 0,
        slidesPerView: 1,
        autoHeight: true
    });

    $('.wrap-modal-slider .close-modal').click(function (event) {
        $('.wrap-modal-slider').removeClass('active');
    });
    $('.wrap-modal-slider .right-swiper').click(function (event) {
        swiperModal.slideNext();
    });
    $('.wrap-modal-slider .left-swiper').click(function (event) {
        swiperModal.slidePrev();
    });

    var videosThumbs = new Swiper('.main-videos-thumb', {
        spaceBetween: 4,
        slidesPerView: 4,
        freeMode: true,
        watchSlidesVisibility: true,
        watchSlidesProgress: true,
        allowTouchMove: false,
        breakpoints: {
            768: {
                slidesPerView: 3
            }
        }
    });
    var videosTop = new Swiper('.main-videos-top', {
        spaceBetween: 0,
        thumbs: {
            swiper: videosThumbs
        }
    });
    $('.main-videos-top .play-button').click(function (event) {
        $(this).parent().addClass('active');
    });

    $('.video .play-button').click(function (event) {
        $(this).parent().addClass('active');
    });

    var mainQuestions = new Swiper('.swiper-main-questions', {
        spaceBetween: 40,
        slidesPerView: 3,
        allowTouchMove: false,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            1024: {
                slidesPerView: 2,
                allowTouchMove: false
            },
            768: {
                slidesPerView: 1,
                allowTouchMove: true,
                spaceBetween: 0
            }
        }
    });

    var mainNews = new Swiper('.swiper-main-news', {
        spaceBetween: 22,
        slidesPerView: 3,
        allowTouchMove: false,
        breakpoints: {
            1270: {
                spaceBetween: 10
            },
            1024: {
                slidesPerView: 2,
                spaceBetween: 10
            },
            600: {
                slidesPerView: 1,
                spaceBetween: 10
            }
        }
    });

    var mainProjects = new Swiper('.swiper-main-projects', {
        spaceBetween: 4,
        slidesPerView: 2,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            600: {
                slidesPerView: 1
            }
        }
    });

    var aboutTeam = new Swiper('.swiper-about-team', {
        spaceBetween: 60,
        slidesPerView: 3,
        allowTouchMove: false,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            1100: {
                spaceBetween: 30
            },
            900: {
                spaceBetween: 15
            },
            768: {
                spaceBetween: 15,
                allowTouchMove: true,
                slidesPerView: 2
            },
            420: {
                slidesPerView: 1,
                spaceBetween: 0
            }
        }
    });

    var aboutDeadlines = new Swiper('.swiper-about-deadlines', {
        spaceBetween: 15,
        slidesPerView: 3,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            550: {
                slidesPerView: 2
            }
        }
    });

    var aboutClients = new Swiper('.swiper-about-clients', {
        spaceBetween: 15,
        slidesPerView: 3,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            650: {
                slidesPerView: 2
            },
            500: {
                slidesPerView: 1
            }
        }
    });

    var aboutWork = new Swiper('.swiper-about-work', {
        spaceBetween: 45,
        slidesPerView: 3,
        allowTouchMove: false,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            900: {
                spaceBetween: 15,
                slidesPerView: 1,
                allowTouchMove: true,
            }
        }
    });

    var aboutWork = new Swiper('.swiper-about-partners', {
        spaceBetween: 70,
        slidesPerView: 4,
        allowTouchMove: false,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            1300: {
                spaceBetween: 40
            },
            1100: {
                spaceBetween: 20
            },
            768: {
                slidesPerView: 3,
                allowTouchMove: true
            },
            550: {
                slidesPerView: 2,
                allowTouchMove: true
            },
            400: {
                slidesPerView: 1,
                allowTouchMove: true
            }
        }
    });

    $('.catalog-page .filter a').click(function (event) {
        $('.catalog-page .filter li').removeClass('active');
        $(this).parent('li').addClass('active');
    });

    $('.gallery-page .list a').click(function (event) {
        var i = $(this).data("id");
        $('.wrap-modal-slider').addClass('active');
        swiperModal.update();
        swiperModal.slideTo(i, 0);
    });


    if ($('.gallery-page .list').length > 0) {
        $('.gallery-page .list').imagesLoaded({ background: true }, function () {
            var options = { minMargin: 8, maxMargin: 8, itemSelector: ".item" };
            $(".gallery-page .list").rowGrid(options);
        })
    }

    $('.floor-page .photos .list .item a').click(function (event) {
        var i = $(this).data("id");
        if (i != "no-click") {
            $('.wrap-modal-slider').addClass('active');
            swiperModal.update();
            swiperModal.slideTo(i, 0);
        }
    });


    if ($('.floor-page .photos .list').length > 0) {
        $('.floor-page .photos .list').imagesLoaded({ background: true }, function () {
            var options = { minMargin: 8, maxMargin: 8, itemSelector: ".item" };
            $(".floor-page .photos .list").rowGrid(options);
        })
    }

    $('.service-page .photos .list .item a').click(function (event) {
        var i = $(this).data("id");
        if (i != "no-click") {
            $('.wrap-modal-slider').addClass('active');
            swiperModal.update();
            swiperModal.slideTo(i, 0);
        }
    });


    if ($('.service-page .photos .list').length > 0) {
        $('.service-page .photos .list').imagesLoaded({ background: true }, function () {
            var options = { minMargin: 8, maxMargin: 8, itemSelector: ".item" };
            $(".service-page .photos .list").rowGrid(options);
        })
    }

    var galleryTag3 = new Swiper('.swiper-gallery-tag-3', {
        spaceBetween: 2,
        slidesPerView: 7,
        allowTouchMove: false,
        breakpoints: {
            1270: {
                slidesPerView: 6
            },
            1100: {
                slidesPerView: 5
            },
            1025: {
                slidesPerView: 4
            },
            768: {
                slidesPerView: 3
            },
            600: {
                slidesPerView: 2
            },
            480: {
                slidesPerView: 1
            }
        }
    });

    var lastnews = new Swiper('.swiper-news-lastnews', {
        spaceBetween: 10,
        slidesPerView: 2,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            550: {
                slidesPerView: 1,
                spaceBetween: 0
            }
        }
    });

    $('.gallery-page .filter-tabs .swiper-right-tag-3').click(function (event) {
        galleryTag3.slideNext();
        $('.swiper-gallery-tag-3').addClass('active');
        setTimeout(function () {
            galleryTag3.update();
        }, 300);
    });
    $('.gallery-page .filter-tabs .swiper-left-tag-3').click(function (event) {
        galleryTag3.slidePrev();
    });

    //$('.contacts-page .cities li .scroll_tab').click(function (event) {
    //    event.preventDefault();
    //    var id = $(this).attr("href");
    //    $('html,body').animate({
    //        scrollTop: $(id).offset().top
    //    }, 'slow');
    //});

    $('.articles-filter .questions').click(function (event) {
        event.preventDefault();
        var id = $(this).attr("href");
        $('html,body').animate({
            scrollTop: $(id).offset().top
        }, 'slow');
    });

    var mainMaterials = new Swiper('.swiper-main-materials', {
        spaceBetween: 15,
        slidesPerView: 4,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            1150: {
                slidesPerView: 3
            },
            1025: {
                slidesPerView: 2
            },
            768: {
                slidesPerView: 2,
                spaceBetween: 15
            },
            600: {
                slidesPerView: 1,
                spaceBetween: 0
            }
        }
    });

    $('.main-materials .swiper-arrows .left').click(function (event) {
        mainMaterials.slidePrev();
    });
    $('.main-materials .swiper-arrows .right').click(function (event) {
        mainMaterials.slideNext();
    });

    var projectsPage = new Swiper('.swiper-projects-block', {
        spaceBetween: 3,
        slidesPerView: 3,
        allowTouchMove: true,
        pagination: {
            el: '.swiper-pagination',
            clickable: true
        },
        breakpoints: {
            768: {
                slidesPerView: 2,
                allowTouchMove: true,
            },
            550: {
                slidesPerView: 1,
                allowTouchMove: true,
            }
        }
    });

    var itemGalleryThumbs = new Swiper('.item-gallery-thumbs', {
        spaceBetween: 20,
        slidesPerView: 3,
        freeMode: true,
        watchSlidesVisibility: true,
        watchSlidesProgress: true,
        direction: 'vertical',
        breakpoints: {
            768: {
                direction: 'horizontal'
            }
        }
    });
    var itemGalleryTop = new Swiper('.item-gallery-top', {
        spaceBetween: 0,
        thumbs: {
            swiper: itemGalleryThumbs
        }
    });
    $('.item-gallery-top-left').click(function (event) {
        itemGalleryTop.slidePrev();
    });
    $('.item-gallery-top-right').click(function (event) {
        itemGalleryTop.slideNext();
    });

    $('.item-page-details .tab-btn a').click(function (event) {
        event.preventDefault();
        var id = $(this).attr("href");
        $('.item-page-details .tab-btn a').removeClass('active');
        $(this).addClass('active');
        $('.item-page-details .tab-block>div').hide();
        $(id).show();
    });

    $(document).on("click", '.cart-total button', function (event) {
        event.preventDefault();
        $('.cart-order').slideDown(300);
    });
    $(document).on("click", '.cart-order .cancel-btn', function (event) {
        $('.cart-order').slideUp(300);
    });

    $('.js-open-call').click(function (event) {
        ym(2173534, 'reachGoal', 'id-topzvonok');
        $('.wrap-modal').addClass('active');
        $('.wrap-modal #modalCall').addClass('active');
    });

    $('.js-open-call-footer').click(function (event) {
        ym(2173534, 'reachGoal', 'id-downzvonok')
        $('.wrap-modal').addClass('active');
        $('.wrap-modal #modalCall').addClass('active');
    });

    $('.js-open-order').click(function (event) {
        ym(2173534, 'reachGoal', 'id-topzayavka')
        $('.wrap-modal').addClass('active');
        $('.wrap-modal .modal-lead').addClass('active');
    });

    $('.js-open-order-footer').click(function (event) {
        ym(2173534, 'reachGoal', 'id-downzayavka')
        $('.wrap-modal').addClass('active');
        $('.wrap-modal .modal-lead').addClass('active');
    });

    $('.close-modal, .js_close_modal').click(function (event) {
        $('.wrap-modal').removeClass('active');
        $('.wrap-modal .modal').removeClass('active');
    });

    $('.menu-btn').click(function (event) {
        $(this).toggleClass('active');
        $('header ul').slideToggle(300);
        $('.header2 .top-block ul').slideToggle(300);
    });

    $(document).on("click", '#mainLead input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#Name').val();
        var email = $('#Email').val();
        var phone = $('#Phone').val();
        var covering = $('#Covering').val();
        var square = $('#Square').val();
        var city = $('#City').val();
        var address = $('#Address').val();
        var description = $('#Description').val();
        var pageUrl = window.location.href;
        var form = $('#mainLead form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();

        $.ajax({
            url: "/MainLead",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                name: name,
                email: email,
                phone: phone,
                covering: covering,
                square: square,
                city: city,
                address: address,
                description: description,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#mainLead').html(data);
                $('.multselect').multiselect({
                    columns: 1,
                    placeholder: 'Выбор покрытия',
                    search: false,
                    selectAll: false,
                    maxPlaceholderOpts: 1,
                    onOptionClick: function (element, option) {
                        setTimeout(function () {
                               if ($('.ms-options-wrap>.ms-options>ul li.selected').length > 1) {
                                $('.ms-options-wrap>button>span').text('Выбрано - ' + $('.ms-options-wrap>.ms-options>ul li.selected').length)
                            }
                        }, 5);
                    }
                });
            }
        });
    });
    $(document).on("click", '#cartOrder input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#Name').val();
        var email = $('#Email').val();
        var phone = $('#Phone').val();
        var description = $('#Description').val();
        var pageUrl = window.location.href;
        var form = $('#cartOrder form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        ym(2173534, 'reachGoal', 'id-order');

        $.ajax({
            url: "/CartOrder",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                name: name,
                email: email,
                phone: phone,
                description: description,
                pageUrl: pageUrl,
            },
            success: function (data) {
                var idx = data.indexOf("Заказ оформлен");
                
                $('#cartOrder').html(data);
                if (idx !== -1) {
                    $('.header2 .cart i').text(0);
                    $('.header2 .cart span').text(0);
                    $('.cart-flex').remove();
                }
            }
        });
    });
    $(document).on("click", '#modalCall input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#ModalCallName').val();
        var phone = $('#ModalCallPhone').val();
        var form = $('#modalCall form');
        var pageUrl = window.location.href;
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        ym(2173534, 'reachGoal', 'id-zvonok');

        $.ajax({
            url: "/ModalCall",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                modalCallName: name,
                modalCallPhone: phone,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#modalCall').html(data);
            }
        });
    });
    $(document).on("click", '#modalLead input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#MName').val();
        var email = $('#MEmail').val();
        var phone = $('#MPhone').val();
        var covering = $('#MCovering').val();
        var square = $('#MSquare').val();
        var city = $('#MCity').val();
        var address = $('#MAddress').val();
        var description = $('#MDescription').val();
        var pageUrl = window.location.href;
        var form = $('#modalLead form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        ym(2173534, 'reachGoal', 'id-zayavka');

        $.ajax({
            url: "/ModalLead",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                mname: name,
                memail: email,
                mphone: phone,
                mcovering: covering,
                msquare: square,
                mcity: city,
                maddress: address,
                mdescription: description,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#modalLead').html(data);
                $('.multselect').multiselect({
                    columns: 1,
                    placeholder: 'Выбор покрытия',
                    search: false,
                    selectAll: false,
                    maxPlaceholderOpts: 1,
                    onOptionClick: function (element, option) {
                        setTimeout(function () {
                            if ($('.ms-options-wrap>.ms-options>ul li.selected').length > 1) {
                                $('.ms-options-wrap>button>span').text('Выбрано - ' + $('.ms-options-wrap>.ms-options>ul li.selected').length)
                            }
                        }, 5);
                    }
                });
            }
        });
    });
    $(document).on("click", '#questions-tab input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#Name').val();
        var email = $('#Email').val();
        var phone = $('#Phone').val();
        var city = $('#City').val();
        var description = $('#Description').val();
        var pageUrl = window.location.href;
        var form = $('#questions-tab form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();

        $.ajax({
            url: "/QuestionsTab",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                name: name,
                email: email,
                phone: phone,
                city: city,
                description: description,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#questions-tab').html(data);
            }
        });
    });
    $(document).on("click", '#serviceForm input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#SoName').val();
        var email = $('#SoEmail').val();
        var phone = $('#SoPhone').val();
        var count = $('#SoCount').val();
        var pageUrl = window.location.href;
        var form = $('#serviceForm form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();

        $.ajax({
            url: "/ServiceForm",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                soname: name,
                soemail: email,
                sophone: phone,
                socount: count,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#serviceForm').html(data);
            }
        });
    });
    $(document).on("click", '#regionForm input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#ReName').val();
        var email = $('#ReEmail').val();
        var phone = $('#RePhone').val();
        var count = $('#ReCount').val();
        var covering = $('#ReCovering').val();
        var pageUrl = window.location.href;
        var form = $('#regionForm form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();

        $.ajax({
            url: "/RegionForm",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                rename: name,
                reemail: email,
                rephone: phone,
                recount: count,
                recovering: covering,
                pageUrl: pageUrl,
            },
            success: function (data) {
                $('#regionForm').html(data);
                $('.multselect').multiselect({
                    columns: 1,
                    placeholder: 'Выбор покрытия',
                    search: false,
                    selectAll: false,
                    maxPlaceholderOpts: 1,
                    onOptionClick: function (element, option) {
                        setTimeout(function () {
                            if ($('.ms-options-wrap>.ms-options>ul li.selected').length > 1) {
                                $('.ms-options-wrap>button>span').text('Выбрано - ' + $('.ms-options-wrap>.ms-options>ul li.selected').length)
                            }
                        }, 5);
                    }
                });
            }
        });
    });
    $(document).on("click", '#calcOrder input[type="submit"]', function (event) {
        event.preventDefault();
        var name = $('#Name').val();
        var email = $('#Email').val();
        var phone = $('#Phone').val();
        var description = $('#Description').val();

        var pageUrl = window.location.href;
        var formTitle = $('#calcOrder p.block-title').text();
        var formArea = $('#Area').val();
        var formThick = $('#Thick').val();
        var formVarnish = $('#radio_3').prop('checked');

        var tableRes = $('.price-page table').html();
        var priceRes1 = $('.price-result-1').text();
        var priceRes2 = $('.price-result-2').text();

        var form = $('#calcOrder form');
        var token = $('input[name="__RequestVerificationToken"]', form).val();

        ym(2173534, 'reachGoal', 'id-raschet');

        $.ajax({
            url: "/CalcOrder",
            type: "POST",
            data: {
                __RequestVerificationToken: token,
                name: name,
                email: email,
                phone: phone,
                description: description,
                pageUrl: pageUrl,
                formTitle: formTitle,
                formArea: formArea,
                formThick: formThick,
                formVarnish: formVarnish,
                tableRes: tableRes,
                priceRes1: priceRes1,
                priceRes2: priceRes2
            },
            success: function (data) {
                $('#calcOrder').html(data);
                $('#calcOrder p.block-title').text(formTitle);
            }
        });
    });

    $(document).on("click", ".js_AddInCart", function () {
        var idProduct = $(this).data("product");
        var thisProduct = $(this);
        var thisProductDelete = $(this).parent().children('a.js_DeleteInCart');
        var countProduct = $(this).parent().find('input').val();

        $.ajax({
            type: "POST",
            url: "/CartAdd",
            data: {
                idProduct: idProduct,
                countProduct: countProduct
            },
            success: function (data) {
                var container = $('li[data-item-id=' + idProduct + ']');
                var containerOpenProduct = $('div[data-item-id=' + idProduct + ']');
                $('header .cart i').text(data.countProducts);
                $('.header2 .cart i').text(data.countProducts);
                $('.header2 .cart span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
                thisProduct.hide();
                thisProductDelete.show();
                $(container).find('input[type=number]').val(countProduct);
                $(containerOpenProduct).find('input[type=number]').val(countProduct);
                $('.wrap-modal').addClass('active');
                $('.wrap-modal #modalCartLink').addClass('active');

                $(container).find('input[type=number]').parent().removeClass('counterNoCart').addClass('counterIsCart');
                $(containerOpenProduct).find('input[type=number]').parent().removeClass('counterNoCart').addClass('counterIsCart');
            }
        });
    });

    $(document).on("click", ".js_CartDeleteInCart", function () {
        var idProduct = $(this).data("product");
        var thisProductDelete = $(this);
        var thisProductAdd = $(this).parent().children('a.js_AddInCart');

        $.ajax({
            url: "/CartDelete",
            type: "POST",
            data: {
                idProduct: idProduct
            },
            success: function (data) {
                var container = $('li[data-item-id=' + idProduct + ']');
                var containerCart = $('li.cartli[data-item-id=' + idProduct + ']');
                var containerOpenProduct = $('div[data-item-id=' + idProduct + ']');
                $(container).find('input[type=number]').val(0);
                $(containerOpenProduct).find('input[type=number]').val(0);
                $('header .cart i').text(data.countProducts);
                $('.header2 .cart i').text(data.countProducts);
                $('.header2 .cart span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
                thisProductDelete.hide();
                thisProductAdd.show();
                containerCart.remove();
                $('.cart-total b span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
                if ($('.cart-total b span').text() === "0") {
                    $('.cart-flex').remove();
                }
            }
        });
    });

    $(document).on("click", ".counterIsCart .minus", function () {
        var idProduct = $(this).data("item-id");
        var countProduct = $(this).parent().children('input').val();
        var page = $(this).data("page");

        $.ajax({
            url: "/CartMinus",
            type: "POST",
            data: {
                idProduct: idProduct,
                countProduct: countProduct,
                page: page
            },
            success: function (data) {

                if (page === 'cart') {
                    if ($('li.cartli[data-item-id=' + idProduct + ']').find('input[type=number]').val() == 1) {
                        $('li.cartli[data-item-id=' + idProduct + ']').remove();
                    }
                }
                else {
                    if ($('li[data-item-id=' + idProduct + ']').find('input[type=number]').val() == 2) {
                        $('li[data-item-id=' + idProduct + ']').find('input[type=number]').val(1);
                        $('li[data-item-id=' + idProduct + ']').find('a.js_AddInCart').show();
                        $('li[data-item-id=' + idProduct + ']').find('a.js_DeleteInCart').hide();
                        $('li[data-item-id=' + idProduct + ']').find('div.counter').addClass('counterNoCart').removeClass('counterIsCart');
                    }

                    if ($('div[data-item-id=' + idProduct + ']').find('input[type=number]').val() == 2) {
                        $('div[data-item-id=' + idProduct + ']').find('input[type=number]').val(1);
                        $('div[data-item-id=' + idProduct + ']').find('a.js_AddInCart').show();
                        $('div[data-item-id=' + idProduct + ']').find('a.js_DeleteInCart').hide();
                        $('div[data-item-id=' + idProduct + ']').find('div.counter').addClass('counterNoCart').removeClass('counterIsCart');
                    }
                }

                $.each(data.items, function (index, value) {
                    var containerCart = $('li.cartli[data-item-id=' + value.idProduct + ']');
                    if (containerCart.length > 0) {
                        $(containerCart).find('p.price b span').text(value.totalSum.formatMoney(0, ',', ' '));
                    }
                    var containerOpenProduct = $('div[data-item-id=' + value.idProduct + ']');
                    if (containerOpenProduct.length > 0) {
                        $(containerOpenProduct).find('input[type=number]').val(value.count);
                    }

                    var container = $('li[data-item-id=' + value.idProduct + ']');
                    if (container.length > 0) {
                        $(container).find('input[type=number]').val(value.count);
                    }
                });

                $('header .cart i').text(data.countProducts);
                $('.header2 .cart i').text(data.countProducts);
                $('.header2 .cart span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
                $('.cart-total b span').text(data.totalSumProducts.formatMoney(0, ',', ' '));

                if ($('.cart-total b span').text() === "0") {
                    $('.cart-flex').remove();
                }
            }
        });
    });

    $(document).on("click", ".counterIsCart .plus", function () {
        var idProduct = $(this).data("item-id");
        var countProduct = $(this).parent().children('input').val();

        $.ajax({
            url: "/CartPlus",
            type: "POST",
            data: {
                idProduct: idProduct,
                countProduct: countProduct
            },
            success: function (data) {
                $.each(data.items, function (index, value) {
                    var containerCart = $('li.cartli[data-item-id=' + value.idProduct + ']');
                    $(containerCart).find('p.price b span').text(value.totalSum.formatMoney(0, ',', ' '));

                    var container = $('li[data-item-id=' + value.idProduct + ']');
                    $(container).find('input[type=number]').val(value.count);

                    var containerOpenProduct = $('div[data-item-id=' + value.idProduct + ']');
                    $(containerOpenProduct).find('input[type=number]').val(value.count);
                });
                $('header .cart i').text(data.countProducts);
                $('.header2 .cart i').text(data.countProducts);
                $('.header2 .cart span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
                $('li[data-item-id=' + idProduct + ']').find('a.js_AddInCart').hide();
                $('li[data-item-id=' + idProduct + ']').find('a.js_DeleteInCart').show();
                $('div[data-item-id=' + idProduct + ']').find('a.js_AddInCart').hide();
                $('div[data-item-id=' + idProduct + ']').find('a.js_DeleteInCart').show();
                $('.cart-total b span').text(data.totalSumProducts.formatMoney(0, ',', ' '));
            }
        });
    });

    $(document).on("click", ".counterNoCart .plus", function () {
        var input = $(this).parent().children('input');
        input.val(parseInt(input.val()) + 1);
    });
    $(document).on("click", ".counterNoCart .minus", function () {
        var input = $(this).parent().children('input');
        if (parseInt(input.val()) > 1)
            input.val(parseInt(input.val()) - 1);
    });

    var timeoutID;
    $(document).on('mouseover', '.burst-scheme-legend a', function () {
        var $this = $(this);
        clearTimeout(timeoutID);
        $this.parents('.burst-scheme-box').find('.burst-scheme_layer').each(function () {
            $(this).removeClass('burst-scheme_layer__active').addClass('burst-scheme_layer__inactive');
        });
        $this.parents('.burst-scheme-box').find('.burst-scheme').addClass('burst-scheme__active');
        $this.parents('.burst-scheme-box').find('.' + $this.attr('rel')).addClass('burst-scheme_layer__active');
    });
    $(document).on('mouseout', '.burst-scheme-legend a', function () {
        var $this = $(this);
        $this.parents('.burst-scheme-box').find('.burst-scheme_layer').each(function () {
            $(this).removeClass('burst-scheme_layer__active');
        });
        timeoutID = setTimeout(function (obj) {
            if ($(obj).find('.burst-scheme_layer__active').length == 0) {
                $(obj).find('.burst-scheme_layer').each(function () {
                    $(this).removeClass('burst-scheme_layer__active').removeClass('burst-scheme_layer__inactive');
                });
            }
        }, 800, $this.parents('.burst-scheme-box').find('.burst-scheme'));
    });
    $(document).on('mouseenter', '.burst-scheme-box', function () {
        var $this = $(this);
        $this.find('.burst-scheme').addClass('burst-scheme__active');
    });
    $(document).on('mouseleave', '.burst-scheme-box', function () {
        var $this = $(this);
        $this.find('.burst-scheme-legend_item__active').removeClass('burst-scheme-legend_item__active');
        $this.find('.burst-scheme__active').removeClass('burst-scheme__active');
        $this.find('.burst-scheme_layer').each(function () {
            $(this).removeClass('burst-scheme_layer__active').removeClass('burst-scheme_layer__inactive');
        });
    });
    $(document).on('click', '.sheme-collapse', function () {
        var $sheme = $(this).parents('.burst-scheme-box');
        $sheme.find('.burst-scheme-legend_item__active').removeClass('burst-scheme-legend_item__active');
        $sheme.find('.burst-scheme__active').removeClass('burst-scheme__active');
        $sheme.find('.burst-scheme_layer').each(function () {
            $(this).removeClass('burst-scheme_layer__active').removeClass('burst-scheme_layer__inactive');
        });
        return false;
    });

    //$(window).scroll(function () {
    //    if ($(this).scrollTop() > 0) {
    //        $('header').addClass('scroll');
    //        $('.header2').addClass('scroll');
    //        $('body').css('padding-top', $('.header2').height());
    //    } else {
    //        $('header').removeClass('scroll');
    //        $('.header2').removeClass('scroll');
    //        $('body').css('padding-top', 0);
    //    }
    //});


    $('.js_calc_open_form').click(function (event) {
        event.preventDefault();
        var title = $(this).text();
        $('#calcOrder').slideDown(300);
        $('#calcOrder p.block-title').text(title);
        ym(2173534, 'reachGoal', 'id-zakaz');
        
        $('html,body').animate({
            scrollTop: $('#calcOrder').offset().top
        }, 1000);
    });

    $('.js_calc_open_form2').click(function (event) {
        event.preventDefault();
        var title = $(this).text();
        $('#calcOrder').slideDown(300);
        $('#calcOrder p.block-title').text(title);
        ym(2173534, 'reachGoal', 'id-stoimost');

        $('html,body').animate({
            scrollTop: $('#calcOrder').offset().top
        }, 1000);
    });

    $('.js_service_anchor').click(function (event) {
        event.preventDefault();
        var id = $(this).attr('href');
        $('html,body').animate({
            scrollTop: $(id).offset().top
        }, 'slow');
    });
});
Number.prototype.formatMoney = function (c, d, t) {
    var n = this,
        c = isNaN(c = Math.abs(c)) ? 2 : c,
        d = d == undefined ? "." : d,
        t = t == undefined ? "," : t,
        s = n < 0 ? "-" : "",
        i = String(parseInt(n = Math.abs(Number(n) || 0).toFixed(c))),
        j = (j = i.length) > 3 ? j % 3 : 0;
    return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};
String.prototype.convertToNumber = function () {
    return this.replace(/[^0-9\.]+/g, '') * 1;
}