// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function highlightActiveMenuItem() {

    $("a[class='nav-link']").removeClass("active");
    //var cparr = ["/Client/AddOrEditReferral", "/Client/AddNotes", "/Client/AddOrEditClientEligibility", "/Client/SSP"]
    var url = window.location.pathname;
    $('a[href="' + url + '"]').addClass('active');
}

function requestAjax (targetUrl, ajaxType, params, callback) {

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
function GetAccountInfo() {
    let AcctNumber = $("#AcctNumber").val();
    requestAjax("/DormantRegister/GetAccountInfo", "get", { AccNo: AcctNumber }, function (res) {
        if (res.successful) {
            $("[id='Name']").val(res.value.name);
            $("[id='AcctType']").val(res.value.accountType);
            $("[id='AcctStatus']").val(res.value.accountStatus);
            $("[id='CoreBranchNumber']").val(res.value.branchNumber);
        } else {
            alert(res.message);
            $("[id='Name']").val("");
            $("[id='AcctType']").val("");
            $("[id='AcctStatus']").val("");
            $("[id='CoreBranchNumber']").val("");
        }
    })
}
