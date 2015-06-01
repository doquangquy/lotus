
var AlbumsBO = {
    LoadListFile_ByCodeAlbum: function (CodeAlbum, Type ,TitleLenght, IntroLenght, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=Sel_File_ByCodeAlbum&CodeAlbum=" + CodeAlbum + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
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
    },
    SelectListAlbums_ByListCodeAlbums: function (CodeAlbum, Type, TitleLenght, IntroLenght, Limit, Order, IsDesc) {

        var ret;
        jQuery.ajax({
            url: "/Action/ProcessFrontendAction.ashx?ActionObject=Albums&action=SelectListAlbums_ByListCodeAlbums&CodeAlbum=" + CodeAlbum + "&Limit=" + Limit + "&IsDesc=" + IsDesc + "&Order=" + Order,
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
    },


    // insert albums
    Ins: function ()
    {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Ins",
            type: "POST",
            dataType: "json",
            data: $("#frmIns_Albums").serialize(),

            success: function (data) {
                if (data.status == "success") {
                   // $(".flexgripAlbums").flexReload();
                    alert("Thêm Albums thành công.");

                }
                else if (data.status != "success") {
                    alert("Thêm Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function (ex) {
            }
        });
    },
    // update albums
    Upd: function (ID)
    {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Upd&IDAlbums=" + ID,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success") {
                   // $(".flexgripAlbums").flexReload();
                    alert("Update Albums thành công.");

                }
                else if (data.status != "success") {
                    alert("Update Albums lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function (ex) {
            }
        });
    },
    // delete albums
    Del: function (ID)
    {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Del&IDAlbums=" + ID,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success") {
                  //  $(".flexgripAlbums").flexReload();
                    //sys_Lang.Item[1]
                    alert("Delete thành công.");

                }
                else if (data.status != "success") {
                    alert("Delete lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function (ex) {
            }
        });
    },
    Dis: function (ID)
    {
        $.ajax({
            url: "/Action/ProcessBackendAction.ashx?ActionObject=Albums&action=Dis&IDAlbums=" + ID,
            type: "POST",
            dataType: "json",
            data: $("#frmUpd_Albums").serialize(),
            success: function (data) {
                if (data.status == "success") {
                   // $(".flexgripAlbums").flexReload();
                    //sys_Lang.Item[1]
                    alert("Disable thành công.");

                }
                else if (data.status != "success") {
                    alert("Disable lỗi: <font style='font-size:9px'>" + data.message + "</font>");

                }
            },
            error: function (ex) {
            }
        });
    },

    //=================================


} 