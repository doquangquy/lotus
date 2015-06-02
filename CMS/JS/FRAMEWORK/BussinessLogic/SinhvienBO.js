
var SinhviensBO = {

    Sel_ByAll: function () {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Sinhviens&action=Sel_ByAll",
            type: "POST",
            dataType: "json",
            data: "",
            success: function (data, dataStatus) {
                ret = data;
            },
            timeout: 30000,
            async: false,
            error: function (request, error) {
            }
        });
        return ret;},
    Ins: function() {
        EnableLoading();
        
            $.ajax({
                url: "/Action/ProcessBackendAction.ashx?ActionObject=Sinhviens&action=Ins",
                type: "POST",
                dataType: "json",
                data: $("#frmIns_Sinhvien").serialize(),

                success: function (data) {
                    if (data.status == "success") {

                        DisableLoading();

                        //ShowMessageBox("Thêm Contents thành công.");
                        alert("Thêm sinh viên thành công.");
                    }
                    else if (data.status != "success") {
                        DisableLoading();

                       

                    }
                },
                error: function (ex) {
                }
            });
        }

        
    }