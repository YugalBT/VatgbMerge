// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


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
            $("#Name").val(res.value.name);
            $("#AcctType").val(res.value.accountType);
            $("#AcctStatus").val(res.value.accountStatus);
            $("#IssuingDeptId").val(parseInt(res.value.branchNumber));
        } else {
            alert(res.message);
            $("#Name").val("");
            $("#AcctType").val("");
            $("#AcctStatus").val("");
            $("#IssuingDeptId").val("");
        }
    })
}
