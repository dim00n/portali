
$(function () {

    var getDeleteWarning = function () {
        var template = $('#my-delete-warning-template').clone().html();
        var html = template
                    .replace('{{AppName}}', $(this).closest('tr').children('td[data-my-appname]').attr("data-my-appname"))
                    .replace('{{AppType}}', $(this).closest('tr').children('td[data-my-apptype]').attr("data-my-apptype"));
        //                    .replace('{{AppId}}', $(this).closest('tr').attr("data-my-appid"));
        $('div.modal-body p:first').replaceWith(html);
        $('div.modal-footer input[name="id"]').attr('value', $(this).closest('tr').attr("data-my-appid"));
    };

    var ajaxFormSubmit = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-my-target"));
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
        });
        return false;
    };

    var submitAutocompleteForm = function (event, ui) {
        var $input = $(this);
        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    };


    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-my-autocomplete"),
            select: submitAutocompleteForm
        };

        $input.autocomplete(options);
    };

    var getPage = function () {
        var $a = $(this);

        var options = {
            url: $a.attr("href"),
            data: $("form").serialize(),
            type: "get"
        };

        $.ajax(options).done(function (data) {
            var $target = $($a.parents("div.pagedList").attr("data-my-target"));
            $target.replaceWith(data);
        });

        return false;
    };

    /* -- remove validation error and highlighting when user starts typing in that input --  */
    $(document).on('keypress change', '.input-validation-error', function () {
        var name = $(this).attr('name');
        $(this).removeClass('input-validation-error').siblings('span.help-inline').find('.field-validation-error[data-valmsg-for="' + name + '"]').remove();
        $(this).closest('.control-group').removeClass('error');
    });

    $("form[data-my-ajax='true']").submit(ajaxFormSubmit);
    $("input[data-my-autocomplete]").each(createAutocomplete);

    $(".pagedList a").on("click", getPage);

    $(".my-delete-button").on("click", getDeleteWarning);
});