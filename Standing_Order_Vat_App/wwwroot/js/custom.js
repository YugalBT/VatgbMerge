//loader
$(document).ajaxSend(function () {
    $("#cover-spin").show();
})
    .ajaxStop(function () {
        $("#cover-spin").hide();
    });

$(document).ready(function () {

    $("[data-val-required]").prev("label").addClass("required");
    $("#cover-spin").hide();
})


$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    $(".tox-statusbar__text-container").hide();

    //To get Process List
    $("#CategoryId").change(function () {
        $("#ProcessId").empty();
        $("#Steps").empty();
        $("#AddStpesFields").empty();
        $(".bt_add").empty();
        $.ajax({
            type: 'POST',
            url: '/Process/ProcessListById',
            dataType: 'json',
            data: { categoryId: $("#CategoryId").val() },
            success: function (process) {
                $("#ProcessId").removeAttr("disabled");
                $("#ProcessId").append('<option value=""> Select Process </option>'),
                    $.each(process, function (i, process) {
                        //  $("#Process option[value='" + process.processId + "']").prop('selected', true);
                        $("#ProcessId").append('<option value="'
                            + process.processId + '">'
                            + process.processType + '</option>');
                    });
            },
        });
    })

    // To get steps 
    $("#ProcessId").change(function () {
        $.ajax({
            type: "Post",
            url: '/Forms/FormExist',
            data: { processId: $('#ProcessId').val() },
            success: function (data) {
                if (data == false) {
                    $("#Steps").empty();
                    $("#AddStpesFields").empty();
                    $(".bt_add").empty();
                    $.ajax({
                        type: 'get',
                        url: '/Process/ProcessStepById',
                        dataType: 'html',
                        data: { processId: $('#ProcessId').val() },
                        success: function (data) {
                            var res = '<button type="button" class="btn btn-primary cutom_btn" onclick="SaveDataInDB()">Add Form</button>';
                            $("#AddStpesFields").html(data);
                            $(".bt_add").html(res);
                            $("#Steps").html($("#TotalStepsCount").text());
                            //alert($("#TotalStepsCount").text())
                        }
                    });
                }
                if (data != false) {
                    $.toast({
                        heading: 'Warning',
                        text: 'This form is already created.',
                        showHideTransition: 'slide',
                        icon: 'warning',
                        position: 'top-right',
                        loaderBg: '#9EC600'// Change it to false to disable loader
                    })
                    setTimeout(function () { location.href = "forms/edit/" + data }, 1000);
                }
            }
        })
    });

    //generate Fields
    $("body").on("click", "#AddFieldButton", function () {
        $(function () {
            $(".sortab").sortable();
            $(".sortabVal").sortable();
        });
        var gloThis = $(this);
        $(this).parents(".form-create").siblings("span").remove();
        $(this).parents(".form-create").siblings("br").remove();
        var FieldName = $(this).siblings("input[type=text]").val();
        var FieldTypeId = $(this).siblings("select").val();
        if (FieldName == "") {
            $(this).parent(".form-create").after("<span class='text-danger'>Please enter field name!</span></br>")
        }
        if (FieldTypeId == "") {
            $(this).parent(".form-create").after("<span class='text-danger'>Please select field type!</span></br>")
        }
        if (FieldName != "" && FieldTypeId != "") {
            $.ajax({
                type: "GET",
                url: '/Forms/GenerateFields',
                data: { fieldTypeId: FieldTypeId, fieldName: FieldName },
                success: function (data) {
                    $(gloThis).parents(".setField").siblings(".getFields").find(".sortab").append(data);
                }

            });
            $(this).siblings(".fieldName").val("");
            $(this).siblings(".fieldType").val("");
        }

    })
});

//Add Fields Values
function AddTextValuesFields(ele) {
    var clearfield = 'ClearFieldAttr(this)';
    $(ele).parent().next(".AddTextValuesFields").find(".sortabVal").append('<li class="val" ><div class="card m-3"><div class="row align-items-end frm_1 mb-2">' +
        '<div class= "col-md-3 m-3" style = "width:330px;margin-left:15px;" > ' +
        '<div class="form-label mb-1 required">Text</div>' +
        '<input type="text" class="form-control showText" placeholder="" value="" minlength="3" maxlength="15" required>' +
        '</div>' +
        '<div class="col-md-1 m-3" >' +
        '<button class="btn btn-outline-secondary rounded-circle" style="margin-top: 21px;" type="button" onclick=' + clearfield + ' ><i class="icofont-close"></i></button>' +
        ' </div></div>' +
        '</div></li> ');
}

//Fields Closer
function ClearFieldBy(ele) {
    $(ele).parents(".AddField").remove();
}

//Fields Closer attribute
function ClearFieldAttr(ele) {
    $(ele).parents(".val").remove();
}

//Form Type
function GetFormType(ele) {
    var val = $(ele).val();
    if (val == 1) {
        $(ele).parents(".radioParent").siblings(".formType").css('display', 'block');
        $(ele).parents(".radioParent").siblings(".ecomType").css('display', 'none');
        $(ele).parents(".radioParent").siblings(".docType").css('display', 'none');
    }
    if (val == 2) {
        $(ele).parents(".radioParent").siblings(".ecomType").css('display', 'block');
        $(ele).parents(".radioParent").siblings(".formType").css('display', 'none');
        $(ele).parents(".radioParent").siblings(".docType").css('display', 'none');
    }
    if (val == 3) {
        $(ele).parents(".radioParent").siblings(".docType").css('display', 'block');
        $(ele).parents(".radioParent").siblings(".formType").css('display', 'none');
        $(ele).parents(".radioParent").siblings(".ecomType").css('display', 'none');
    }
}

function valueChanged(ele) {
    var val = $(ele).val();
    if (val == 1) {
        $(ele).parents(".radioParent").siblings(".showText").css('display', 'block');
    }
    else {
        $(ele).parents(".radioParent").siblings(".showText").css('display', 'none');
    }

}

//copy to clipboard
function copyToClipboard(element) {
    var copyText = element;//document.getElementById("myInput");
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    navigator.clipboard.writeText(copyText.value);

    var tooltip = document.getElementById("myTooltip");
    tooltip.innerHTML = "Copied";
}

function outFunc() {
    var tooltip = document.getElementById("myTooltip");
    tooltip.innerHTML = "Copy to clipboard";
}



$(".multi_section").on("click", function (e) {
    e.stopPropagation();
    $(this).find(".btn-group").toggleClass("show");
    $(this).find(".dropdown-menu").toggleClass("show");
});

$(document).on('click', function (e) {
    if (($(e.target) != $(".multi_section")) && ($(".dropdown-menu").hasClass('show'))) {
        $(".dropdown-menu").removeClass('show');
    }
});

$(".dropdown_1 dt a").on('click', function () {
    $(".dropdown_1 dd ul").slideToggle('fast');
});

$(".dropdown_1 dd ul li a").on('click', function () {
    $(".dropdown_1 dd ul").hide();
});

function getSelectedValue(id) {
    return $("#" + id).find("dt a span.value").html();
}

$(document).bind('click', function (e) {
    var $clicked = $(e.target);
    if (!$clicked.parents().hasClass("dropdown_1")) $(".dropdown_1 dd ul").hide();
});

$('.mutliSelect input[type="checkbox"]').on('click', function () {
    var title = $(this).closest('.mutliSelect').find('input[type="checkbox"]').val(),
        title = $(this).val() + ",";

    if ($(this).is(':checked')) {
        var html = '<span title="' + title + '">' + title + '</span>';
        $('.multiSel').append(html);
        $(".hida").hide();
    } else {
        $('span[title="' + title + '"]').remove();
        var ret = $(".hida");
        $('.dropdown_1 dt a').append(ret);

    }
});

$(".dropdown_11 dt a").on('click', function () {
    $(".dropdown_11 dd ul").slideToggle('fast');
});

$(".dropdown_11 dd ul li a").on('click', function () {
    $(".dropdown_11 dd ul").hide();
});

$(document).bind('click', function (e) {
    var $clicked = $(e.target);
    if (!$clicked.parents().hasClass("dropdown_11")) $(".dropdown_11 dd ul").hide();
});

$('.mutliSelect-1 input[type="checkbox"]').on('click', function () {

    var title = $(this).closest('.mutliSelect-1').find('input[type="checkbox"]').val(),
        title = $(this).val() + ",";

    if ($(this).is(':checked')) {
        var html = '<span title="' + title + '">' + title + '</span>';
        $('.multiSel-1').append(html);
        $(".hida-1").hide();
    } else {
        $('span[title="' + title + '"]').remove();
        var ret = $(".hida-1");
        $('.dropdown_11 dt a').append(ret);

    }
});

function Save() {
    FormData = {}
    FormData["FormId"] = $("#formId").val();
    FormData["CategoryId"] = $('#CategoryId').val();
    FormData["ProcessId"] = $('#ProcessId').val();
    FormData["TotalSteps"] = parseInt($('#Steps').text().replace(/[^0-9.]/g, ""));
    fromModel = [];
    if ($("#formId").val() == null) {
        k = 1;
    }
    if ($("#formId").val() > 0) {
        k = 1;
    }
    $("#AddStpesFields").find(".AddStpesFields").each(function () {

        Steps = {};
        $(this).find(".stepsId").each(function () {
            var StepId = $(this).val();
            Steps["StepId"] = StepId;
        });
        $(this).find(".stepName").each(function () {
            var StepName = $(this).val();
            Steps["StepName"] = StepName;
        });
        $(this).find(".description").each(function () {
            var StepDescription = $(this).val();
            Steps["StepDescription"] = StepDescription;
        });
        $(this).find(".approveStep").each(function () {
            var ApproveStep = parseInt($(this).val().replace(/[^0-9.]/g, ""));
            Steps["ApproveStep"] = ApproveStep;
        });
        $(this).find(".rejectStep ").each(function () {
            var FinalStep = parseInt($(this).val().replace(/[^0-9.]/g, ""));
            Steps["RejectStep"] = FinalStep;
        });
        $(this).find(".action").each(function () {
            var stepType = parseInt($("input[name='action_" + k + "']:checked").val());
            Steps["StepType"] = stepType;
        });
        $(this).find(".userNoti").each(function () {
            var userNoti = $(this).val();
            Steps["UserNotification"] = userNoti;
        });
        $(this).find(".adminNoti").each(function () {
            var adminNoti = $(this).val();
            Steps["AdminNotification"] = adminNoti;
        });
        if (Steps["StepType"] == 1) {
            Fields = [];
            $(this).find(".stepDiv").each(function () {
                FieldsValues = {}
                $(this).find(".field").each(function () {
                    var FieldId = $(this).val();
                    FieldsValues["FieldId"] = FieldId;
                });
                $(this).find(".token").each(function () {
                    var Token = $(this).val();
                    FieldsValues["Token"] = Token;
                });
                $(this).find(".fieldType").each(function () {
                    var FieldType = $(this).val();
                    FieldsValues["FieldType"] = FieldType;
                });
                $(this).find(".fieldLabel").each(function () {
                    var FieldLabel = $(this).val();
                    FieldsValues["FieldLabel"] = FieldLabel;
                });
                $(this).find(".errorMessageText").each(function () {
                    var ErrorMessage = $(this).val();
                    FieldsValues["ErrorMessage"] = ErrorMessage;
                });
                $(this).find(".placeholderText").each(function () {
                    var PlaceholderText = $(this).val();
                    FieldsValues["PlaceholderText"] = PlaceholderText;
                });
                $(this).find("input[type='checkbox']").each(function () {
                    var ChkRequired = $(this).is(':checked');
                    FieldsValues["ChkRequired"] = ChkRequired;
                });
                TextValue = [];
                if (FieldsValues["FieldType"] == "Dropdown" || FieldsValues["FieldType"] == "Radio" || FieldsValues["FieldType"] == "CheckBox") {
                    $(this).find(".AddTextValuesFields").each(function () {
                        $(this).find(".val").each(function (i) {
                            TextValues = {}
                            $(this).find(".fieldAttr").each(function () {
                                var FieldAttrId = $(this).val();
                                TextValues["FieldAttrId"] = FieldAttrId;
                            });
                            $(this).find(".showText").each(function () {
                                var FieldText = $(this).val();
                                TextValues["FieldText"] = FieldText;
                                TextValues["FieldValue"] = FieldText.replace(" ", "") + i;
                            });
                            TextValue.push(TextValues);
                        });
                    });
                }
                FieldsValues["FieldAttributes"] = TextValue;
                Fields.push(FieldsValues);
                Steps["Field"] = Fields;
            });
            $(this).find(".formType").each(function () {
                if ($(this).find(".documentDiv label .contactCheckBox").is(':checked')) {
                    FieldsValues = {}
                    let FieldId = $(this).find(".field").val();
                    FieldsValues["FieldId"] = FieldId;
                    let DocumentId = $(this).find(".documentDiv .textar textarea ").attr("id");
                    let Document = tinymce.get(DocumentId).getContent();
                    FieldsValues["FieldLabel"] = "No Label";
                    FieldsValues["Document"] = Document;
                    FieldsValues["FieldType"] = "9";
                    FieldsValues["IsContract"] = $(this).find(".documentDiv label .contactCheckBox").is(':checked');
                    FieldsValues["ErrorMessage"] = "Not an error";
                    Fields.push(FieldsValues);
                }
            });
            Steps["Field"] = Fields;
            fromModel.push(Steps);
        }
        if (Steps["StepType"] == 2) {
            Field = [];
            $(this).find(".ecom-create").each(function () {
                FieldsValues = {}
                var FieldId = $(this).find(".field").val();
                FieldsValues["FieldId"] = FieldId;
                var Amount = $(this).find(".amount").val().replace(/[^0-9.]/g, "");
                FieldsValues["FieldLabel"] = "No Label";
                FieldsValues["Amount"] = Amount;
                FieldsValues["FieldType"] = "8";
                FieldsValues["ErrorMessage"] = "Not an error";
                Field.push(FieldsValues);
            });
            Steps["Field"] = Field;
            fromModel.push(Steps);
        }
        k++;
    });
    FormData["Steps"] = fromModel;
    return FormData;
}

function setUserId(userId) {
    this.userId = userId;
    // remove checkbox
    $("input[name='UserAssignKeywords']").prop('checked', false);
    var keywordIds = [];
    var keywordIdString = $("#keyword_" + userId + " #hiddenkeyword_" + userId + "").val();
    if (keywordIdString != undefined) {
        keywordIds = keywordIdString.split('_');
        //check checkbox
        $("input[name=UserAssignKeywords]").each(function () {
            if ($.inArray($(this).val(), keywordIds) != -1) {
                $(this).prop("checked", true);
            }
        })
        for (var i = 0; i < keywordIds.Length; i++) {
            $("#inlineCheckbox_" + parseInt(keywordIds[i])).prop('checked', true);
        }
    }
}


function CheckKeywordsBroadcast() {
    let c = 0
    $(".KeywordDataDiv > div").each(function () {
        if ($(this).find("input[type=checkbox]").is(':checked')) {
            c += 1
        }
    })
    if (c > 0) {
        $("#Model_Keywords").empty()
    }
    else {
        $("#Model_Keywords").html("This Fields is required")
    }
    return c;
}

function AssignKeyword() {
    var keywordIDs = $("input[name=UserAssignKeywords]:checked").map(function () {
        return $(this).val();
    }).get();
    $.ajax({
        type: "Post",
        url: '/User/assignkeyword',
        async: false,
        datatype: "json",
        data: { keywordIds: keywordIDs, userId: this.userId },
        success: function (vm) {
            if (vm == "success") {
                location.href = "/User/List";
            }
            else {
                alert(vm);
            }
        }
    })
}

$(function () {
    $(".sortab").sortable();
    $(".sortabVal").sortable();
});

$(document).on("click", function () {
    $(document).find("select").removeClass("error");
})

$(document).ready(function () {
    $("#CategoryBroadcast").change(function () {
        $("#ProcessBroadcast").empty();
        $.ajax({
            type: 'POST',
            //url: '@Url.Action("ProcessListById","Process")' + $('#CategoryBroadcast').val(),
            url: '/Process/ProcessListById/' + $('#CategoryBroadcast').val(),
            dataType: 'json',
            data: { categoryId: $("#CategoryBroadcast").val() },
            success: function (process) {
                $("#ProcessBroadcast").append('<option value=""> Select Process type </option>'),
                    $.each(process, function (i, process) {
                        //  $("#Process option[value='" + process.processId + "']").prop('selected', true);
                        $("#ProcessBroadcast").append('<option value="'
                            + process.processId + '">'
                            + process.processType + '</option>');
                    });
            },
            error: function (ex) {
                console.log('Failed to retrieve Process.' + ex);
            }
        });
    })
})
function dataSave() {
    $("#broadcast").submit();
}

