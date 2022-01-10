$(document).ready(function () {
    setTimeout(function () {
        var h_user_name = $('header .user-name').width();
        var h_logout = $('header .logout').width();
        var h_logo_block = 'calc(100% - ' + h_user_name + 'px - ' + h_logout + 'px - 10px)';
        $('header .logo-block').css('width', h_logo_block);
    }, 10);

    $('.toolbar .submenu_btn').click(function (event) {
        $(this).toggleClass('on');
        $(this).parent().children('ul').slideToggle(200);
    });
    $('.hide-menu').click(function (event) {
        $('.toolbar').toggleClass('hide_toolbar');
        $('.content').toggleClass('full_width');
    });

    if ($('textarea').is('#ck_editor_1'))
        CKEDITOR.replace('ck_editor_1',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    if ($('textarea').is('#ck_editor_2'))
        CKEDITOR.replace('ck_editor_2',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    if ($('textarea').is('#ck_editor_3'))
        CKEDITOR.replace('ck_editor_3',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    if ($('textarea').is('#ck_editor_4'))
        CKEDITOR.replace('ck_editor_4',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    if ($('textarea').is('#ck_editor_5'))
        CKEDITOR.replace('ck_editor_5',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    if ($('textarea').is('#ck_editor_6'))
        CKEDITOR.replace('ck_editor_6',
            {
                height: 400,
                filebrowserUploadUrl: '/upload_ck_editor',
                filebrowserBrowseUrl: '/filebrowse'
            });

    $('.bth-ck-editor').click(function (event) {
        event.preventDefault();
        $(this).closest('div.ck-block').children('div.hide-block').toggle(300);
    });

    $('.js_delete_imgbanner').click(function () {
        $('.js_imgbanner').removeAttr("value");
        $('.js_show_imgbanner').remove();
        $(this).remove();
    });

    $('.addProductForRegion').click(function () {
        regionId = $(this).data("id");
        prodId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/region/AddProductForRegion",
            data: {
                regionId: regionId,
                prodId: parseInt(prodId)
            },
            success: function () {
                location.reload();
            }
        });
    });

    $('.addProductForService').click(function () {
        serId = $(this).data("id");
        prodId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/service/AddProductForService",
            data: {
                serId: serId,
                prodId: parseInt(prodId)
            },
            success: function () {
                location.reload();
            }
        });
    });
    $('.addProjectForService').click(function () {
        serId = $(this).data("id");
        projId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/service/AddProjectForService",
            data: {
                serId: serId,
                projId: parseInt(projId)
            },
            success: function () {
                location.reload();
            }
        });
    });
    $('.addProductForFloor').click(function () {
        floorId = $(this).data("id");
        prodId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/floor/AddProductForFloor",
            data: {
                floorId: floorId,
                prodId: parseInt(prodId)
            },
            success: function () {
                location.reload();
            }
        });
    });
    $('.addQuestionForFloor').click(function () {
        floorId = $(this).data("id");
        artId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/floor/AddQuestionForFloor",
            data: {
                floorId: floorId,
                artId: parseInt(artId)
            },
            success: function () {
                location.reload();
            }
        });
    });
    $('.addAreaForService').click(function () {
        serId = $(this).data("id");
        floorId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/service/AddFloorForService",
            data: {
                serId: serId,
                floorId: parseInt(floorId)
            },
            success: function () {
                location.reload();
            }
        });
    });
    $('.addQuestionForService').click(function () {
        serId = $(this).data("id");
        artId = $(this).parent().children("select").val();

        $.ajax({
            type: 'POST',
            url: "/cp/service/AddQuestionForService",
            data: {
                serId: serId,
                artId: parseInt(artId)
            },
            success: function () {
                location.reload();
            }
        });
    });

    $(".updateEur").click(function () {
        var eur = $(this).parent().find("#eurCourse").val();
        console.log(eur);
        $.ajax({
            type: 'POST',
            url: "/cp/product/updateeur",
            data: {
                eur: eur
            },
            success: function () {
                location.reload();
            }
        });
    });
});
function translateUrl() {
    $('.js_translate_set').val(transliterate($('.js_translate_get').val()));
}
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {

            if ($(input).data("id") === "previewbanner") {
                $('#previewbanner').attr('src', e.target.result);
            }

            if ($(input).data("id") === "previewthumb") {
                $('#previewthumb').attr('src', e.target.result);
            }

            if ($(input).data("id") === "previewlist") {
                $('#previewlist').attr('src', e.target.result);
            }

            if ($(input).data("id") === "previewproduct") {
                $('#previewproduct').attr('src', e.target.result);
            }

            $('#previewImg').attr('src', e.target.result);
        };

        reader.readAsDataURL(input.files[0]);
    }
}

var transliterate = function (text) {
    
    text = text
        .replace(/ /g, '-')
        .replace(/[&\/\\#,+()$~%.'":*?!=^@<>{}]/g, '')
        .replace(/\u0401/g, 'YO')
        .replace(/\u0419/g, 'J')
        .replace(/\u0426/g, 'C')
        .replace(/\u0423/g, 'U')
        .replace(/\u041A/g, 'K')
        .replace(/\u0415/g, 'E')
        .replace(/\u041D/g, 'N')
        .replace(/\u0413/g, 'G')
        .replace(/\u0428/g, 'SH')
        .replace(/\u0429/g, 'SHCH')
        .replace(/\u0417/g, 'Z')
        .replace(/\u0425/g, 'KH')
        .replace(/\u042A/g, '')
        .replace(/\u0451/g, 'yo')
        .replace(/\u0439/g, 'j')
        .replace(/\u0446/g, 'c')
        .replace(/\u0443/g, 'u')
        .replace(/\u043A/g, 'k')
        .replace(/\u0435/g, 'e')
        .replace(/\u043D/g, 'n')
        .replace(/\u0433/g, 'g')
        .replace(/\u0448/g, 'sh')
        .replace(/\u0449/g, 'shch')
        .replace(/\u0437/g, 'z')
        .replace(/\u0445/g, 'kh')
        .replace(/\u044A/g, '')
        .replace(/\u0424/g, 'F')
        .replace(/\u042B/g, 'I')
        .replace(/\u0412/g, 'V')
        .replace(/\u0410/g, 'a')
        .replace(/\u041F/g, 'P')
        .replace(/\u0420/g, 'R')
        .replace(/\u041E/g, 'O')
        .replace(/\u041B/g, 'L')
        .replace(/\u0414/g, 'D')
        .replace(/\u0416/g, 'ZH')
        .replace(/\u042D/g, 'E')
        .replace(/\u0444/g, 'f')
        .replace(/\u044B/g, 'y')
        .replace(/\u0432/g, 'v')
        .replace(/\u0430/g, 'a')
        .replace(/\u043F/g, 'p')
        .replace(/\u0440/g, 'r')
        .replace(/\u043E/g, 'o')
        .replace(/\u043B/g, 'l')
        .replace(/\u0434/g, 'd')
        .replace(/\u0436/g, 'zh')
        .replace(/\u044D/g, 'eh')
        .replace(/\u042F/g, 'Ya')
        .replace(/\u0427/g, 'CH')
        .replace(/\u0421/g, 'S')
        .replace(/\u041C/g, 'M')
        .replace(/\u0418/g, 'I')
        .replace(/\u0422/g, 'T')
        .replace(/\u042C/g, '')
        .replace(/\u0411/g, 'B')
        .replace(/\u042E/g, 'YU')
        .replace(/\u044F/g, 'ya')
        .replace(/\u0447/g, 'ch')
        .replace(/\u0441/g, 's')
        .replace(/\u043C/g, 'm')
        .replace(/\u0438/g, 'i')
        .replace(/\u0442/g, 't')
        .replace(/\u044C/g, '')
        .replace(/\u0431/g, 'b')
        .replace(/\u044E/g, 'yu');

    return text;
};