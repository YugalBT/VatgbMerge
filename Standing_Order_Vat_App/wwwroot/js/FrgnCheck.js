$(document).ready(function () {
    //saveBatchHeader();

});
function removeValidation() {
    $("#btnAdd").hide();
    $("#savBatchbtn").removeAttr("disabled");
    $("#DateRecived").val("");
    $("#AddfrgnCheck").hide();
    ValidateField()
}

function saveBatchHeader() {
    let dtRecvd = $('#DateRecived').val();
    let dtProcessed = $('#dateProcessed').val();
    let batchStat = $('#btchStatId').val();
    let branch = $('#branch').val();
    let empId = $('#empId').val();
    let bankId = $('#BankId').val()
    let errorCount = ValidateField()
    if (errorCount == 0 ) {
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