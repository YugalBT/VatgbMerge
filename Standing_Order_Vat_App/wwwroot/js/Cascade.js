$(document).ready(function () {
    getStatus();
    getBanks();
});

function getStatus() {
    $.ajax({
        url: '/FrgnChks/Status',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#Status').append('<option value=' + data.entryStatusId + '>' + data.entryStatusDescription + '</option>');
            });
        }


    });
}
function getBanks() {
    $.ajax({
        url: '/FrgnChks/Banks',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#Banks').append('<option value=' + data.bankId + '>' + data.name + '</option>');
            });
        }


    });
}