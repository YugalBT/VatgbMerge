function UpdateDatePaymentRequest(BatchId, e) {
    debugger;
    let DatePayment = $(e).parents("tr").find("#dormant_DatePaymentRequested").val()
    let obj = {
        BatchId: BatchId,
        DatePaymentRequest: DatePayment
    }

    requestAjax("/FrgnChks/UpdateDatePayment", "Post", { vm: obj }, function (res) {
        if (res.successful) {
            $(e).parents("tr").removeClass("active");
            alert(res.message);
        }
        else {
            alert(res.message);
        }
    });
}
function removeValidation() {
    $("#btnAdd").hide();
    $("#savBatchbtn").removeAttr("disabled");
    $("#DateRecived").val("");
    $("#AddfrgnCheck").hide();
    ValidateField()
}
function Banksanddate() {
    if ($("#sel").val() == "2") {
        $('#datef').show();
        $('#datet').show();
        $('#sele').hide();
    }
    else if ($("#sel").val() == "3") {
        $('#sele').hide();
        $('#datef').hide();
        $('#datet').hide();
    }
    else {
        $('#sele').show();
    }
}
function saveBatchHeader() {
    let dtRecvd = $('#DateRecived').val();
    let dtProcessed = $('#dateProcessed').val();
    let batchStat = $('#btchStatId').val();
    let branch = $('#branch').val();
    let empId = $('#empId').val();
    let bankId = $('#BankId').val()
    let errorCount = ValidateField()
    if (errorCount == 0) {
        var empObj = {
            dtRecvd: dtRecvd,
            dtProcessed: dtProcessed,
            batchStat: batchStat,
            branch: branch,
            empId: empId,
            bankId: bankId
        };
        $.ajax({
            url: "/FrgnChks/SaveFrgnBatchHeader",
            data: { frgnCheckVm: empObj },
            type: "POST",
            success: function (result) {
                /* loadData();*/
                if (result.successful) {
                    $("#btnAdd").show();
                    $("#savBatchbtn").attr("disabled", "disabled");
                    ValidateField()
                    alert(result.message);

                }
                else {
                    $("#btnAdd").hide();
                    alert("error: " + result.message);
                }
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}
function showdiv() {
    $("#AddfrgnCheck").show();
};
function Addfrgncheck() {
    debugger
    var empObj = {
        dtRecvd: $('#DateRecived').val(),
        dtProcessed: $('#dateProcessed').val(),
        batchStat: $('#btchStatId').val(),
        branch: $('#branch').val(),
        empId: $('#empId').val(),
        bankId: $('#Banks').val()
    };
    $.ajax({
        url: "/FrgnChks/SaveFrgnBatchHeader",
        data: { frgnCheckVm: empObj },
        type: "POST",
        success: function (result) {
            /* loadData();*/
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function ValidateField() {
    let error = 0
    let dtRecvd = $('#DateRecived').val();
    let bankId = $('#BankId').val()
    if (dtRecvd == null || dtRecvd == "") {
        error += 1
        $('[data-valmsg-for="DateRecived"]').html("This field is required.");
    }
    else {
        $('[data-valmsg-for="DateRecived"]').html("");
    }
    if (bankId == 0 || bankId == null) {
        error += 1
        $('[data-valmsg-for="BankId"]').html("This field is required.");
    }
    else {
        $('[data-valmsg-for="BankId"]').html("");
    }
    return error
}
function UpdateFrgnCheck(e) {
    let data = $(e).parents("tr")

    let btchId = $('#BatchId').val();
    let chkNum = $(data).find('#item_CheckNumber').val();
    let payAcctNum = $(data).find('#item_PayerAcctNumber').val();
    let payAcctName = $(data).find('#item_PayerAcctName').val();
    let depAcctNum = $(data).find('#item_DepositAcctNumber').val();
    let depAcctName = $(data).find('#item_DepositAcctName').val();
    let chkAmt = $(data).find('#item_CheckAmount').val();
    let recId = $(data).find('#item_RecordId').val()
    //let errorCount = ValidateField()
    //if (errorCount == 0) {
    var empObj = {
        BatchId: btchId,
        CheckNumber: chkNum,
        PayerAcctNumber: payAcctNum,
        PayerAcctName: payAcctName,
        DepositAcctNumber: depAcctNum,
        DepositAcctName: depAcctName,
        CheckAmount: chkAmt,
        RecordId: recId
    }
    $.ajax({
        url: $(e).data('request-url'),
        data: { foreignCheck: empObj },
        type: "POST",
        success: function (result) {
            /* loadData();*/
            if (result.successful) {
                $("tr").removeClass("active");
                $("[id='TotalAmount']").val(parseFloat(result.value).toFixed(2));
                alert(result.message);
            }
            else {
                $("tr").removeClass("active");
                alert("error: " + result.message);
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

function DeleteBatch(batchId, e) {
    if (confirm('Are you sure you want to delete this Batch?')) {
        $.ajax({
            url: ("/FrgnChks/DeletefrgnCheck"),
            data: { batchid: batchId },
            type: "POST",
            success: function (result) {
                /* loadData();*/
                if (result.successful == true) {
                    $(e).parents('tr').remove();
                    alert(result.message);
                }
                else {
                    alert("error: " + result.message);
                }
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

function SettleBatch() {
    $("tbody tr td #SettleBatch").each(function () {
        if ($(this).is(":checked")) {
            $(this).attr("name")
        }
    })
}
function ShowBatchDetails(batchId,type, e) {
    if ($(e).attr("class").includes("fa-arrow-right") || type =="saveCheck" ) {
        requestAjax("/FrgnChks/ShowBatchCheckList", "Post", { BatchId: batchId }, function (res) {
            $(e).parents("table").find("[id='ShowBAtchCheckList']").remove();
            $(e).parents("table").find(".fa-arrow-down").removeClass("fa-arrow-down").addClass("fa-arrow-right");
            $(e).parents("tr").after("<tr id='ShowBAtchCheckList'  class='collapse'><td colspan='9'></td></tr>");
            $(e).parents("tr").next("#ShowBAtchCheckList").find("td").html(res);
            $("#ShowBAtchCheckList").show();
            $(e).removeClass("fa-arrow-right").addClass("fa-arrow-down");
        })
    }
    else {
        $(e).removeClass("fa-arrow-down").addClass("fa-arrow-right");
        $(e).parents("table").find("[id='ShowBAtchCheckList']").remove();
    }
}
function SaveBatchChecks(e) {
    debugger
    let parentTr = $(e).parents("#ShowBAtchCheckList").prev("#batchDetails").find(".fa-arrow-down");
    let formParent = $(e).parents("form");
    let BatchId = $(formParent).find("#BatchId").val();
    let CheckNumber = $(formParent).find("#CheckNumber").val();
    let PayerAcctNumber = $(formParent).find("#PayerAcctNumber").val();
    let PayerAcctName = $(formParent).find("#PayerAcctName").val();
    let DepositAcctNumber = $(formParent).find("#DepositAcctNumber").val();
    let DepositAcctName = $(formParent).find("#DepositAcctName").val();
    let CheckAmount = $(formParent).find("#CheckAmount").val();
    let actionBtn = $(e).attr("value");

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
        ShowBatchDetails(BatchId, actionBtn, parentTr)
    })

}