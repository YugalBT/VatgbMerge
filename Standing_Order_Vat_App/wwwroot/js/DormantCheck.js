function DeleteDormantBatch(id, e) {
    if (confirm('Are you sure you want to delete Dormant ?')) {
        $.ajax({
            url: $(e).data('request-url'),
            data: { id: id },
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

function UpdateDormantJs(e) {
    let data = $(e).parents("tr");
    let accNo = $(data).find("#dormant_Acct_Number").val();
    let recId = $(data).find("#dormant_RecordID").val();
    let rectId = $(data).find("#dormant_Reactivate_Id_Employee").val();
    let branch = $(data).find("#dormant_Branch").val();
    let sts = $(data).find("#dormant_entsts").val();
    var obj = {
        AccountNo: accNo,
        RecordId: recId,
        Reactive_id: rectId,
        BranchName: branch,
        Status: sts
    }
    requestAjax($(e).data('request-url'), "post", { vm: obj }, function (res) {
        if (res.successful) {
            alert(res.message)
        } else {
            alert(res.message);
        }
    });
}