function Init_LotusTable() {
    //oTable.fnDestroy();

    InitLotusTable("#checkBll",
        {

            'url': sys_CommonType.URL_CMS + '/Action/ProcessBackendAction.ashx?ActionObject=Sinhviens&action=Sel_ByAll',
            'Col_Key': 'Id',
            //'Col_Image': 'Contents_Image',
            //'Path_Image': sys_CommonType.URL_CMS + '/Action/ProcessImageServiceAction.ashx?W=60&H=60&Scale=crop&Img=',
            //'pageLength': 14,

            columns: [

                        { data:'Id' },
                        { data:'Hoten'},
                        { data:'Diachi'},
                        { data:'Tuoi'}

            ]

        }
     
        );
 
    


}