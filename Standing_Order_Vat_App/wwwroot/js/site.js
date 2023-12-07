// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let requestAjax = (targetUrl, ajaxType, params, callback) => {

    $.ajax({
        url: targetUrl,
        type: ajaxType,
        data: params,
        beforeSend: function () {
            /*BoxLoading(parentId);*/
        },
        success: callback,
        error: function (response) {
            console.log("error");
        },
        complete: function (data) {
            /*  *//* BoxLoadingRemove(parentId);*/
        }
    });
}

