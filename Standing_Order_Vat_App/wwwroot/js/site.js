// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function highlightActiveMenuItem() {

    $("a[class='nav-link']").removeClass("active");
    var url = window.location.pathname;
    var gbLink = ["/DormantRegister/Index", "/FrgnChks/Index"]
    if (gbLink.indexOf(url) > -1 || url.includes("DormantRegister") || url.includes("FrgnChks")) {
        $('a[href="/GBRegister/Index"]').addClass('active');
    }
    if (url.includes("DormantRegister")) {
        $('a[href="/DormantRegister/Index"]').addClass('active');
    }
    if (url.includes("FrgnChks")) {
        $('a[href="/FrgnChks/Index"]').addClass('active');
    }
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

function SaveBatchChecks(e) {
    debugger
    let parentTr = $(e).parents("#batchDetails");
    let formParent = $(e).parents("form");
    let BatchId = $(formParent).find("#BatchId").val();
    let CheckNumber = $(formParent).find("#CheckNumber").val();
    let PayerAcctNumber = $(formParent).find("#PayerAcctNumber").val();
    let PayerAcctName = $(formParent).find("#PayerAcctName").val();
    let DepositAcctNumber = $(formParent).find("#DepositAcctNumber").val();
    let DepositAcctName = $(formParent).find("#DepositAcctName").val();
    let CheckAmount = $(formParent).find("#CheckAmount").val();
    let actionBtn = $(e).attr("name");

    let obj = {
        BatchId: BatchId,
        CheckNumber: CheckNumber,
        PayerAcctNumber: PayerAcctNumber,
        PayerAcctName: PayerAcctName,
        DepositAcctNumber: DepositAcctNumber,
        DepositAcctName: DepositAcctName,
        CheckAmount: CheckAmount
    }
    requestAjax("/FrgnChks/AddFrgnCheck", "Post", { actionbtn: actionBtn, foreignChecksDetail: obj }, function (res) {
        ShowBatchDetails(BatchId, parentTr)
    })

}