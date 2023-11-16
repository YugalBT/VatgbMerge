$(document).ready(function () {
    //saveBatchHeader();
    
});
function saveBatchHeader() {
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
            if (result) {
                alert("Header Saved,Add Checked.");
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}
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