function DeleteDormantBatch(id, e) {
    if (confirm('Are you sure you want to delete Dormant ?')) {
        $.ajax({
            url: "/DormantRegister/DeleteDormant",
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