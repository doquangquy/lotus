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
        return ret;
    }
}