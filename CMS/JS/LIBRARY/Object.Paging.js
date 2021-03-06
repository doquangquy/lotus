// Javascript document
// Paging Class
var Paging = function(curentPage, totalRow, objContainer, callBack, objPaging, rowPerPage, pagePerSeg, className, showButton) {
    this.curentPage = typeof (curentPage) == "undefined" ? 1 : curentPage;
    this.totalRow = typeof (totalRow) == "undefined" ? 0 : totalRow;
    this.objContainer = typeof (objContainer) == "undefined" ? "#navigator" : objContainer;
    this.callBack = typeof (callBack) == "undefined" ? function() { } : callBack;
    this.objPaging = typeof (objPaging) == "undefined" ? "objPaging" : objPaging;
    this.rowPerPage = typeof (rowPerPage) == "undefined" ? 20 : rowPerPage;
    this.pagePerSeg = typeof (pagePerSeg) == "undefined" ? 5 : pagePerSeg;
    this.className = typeof (className) == "undefined" ? 'pages_m fr' : className;
    this.showButton = typeof (showButton) == "undefined" ? true : showButton;
    this.handler = "page";
    this.numPage = 1;
    this.Next = function() {
        if (this.curentPage < this.totalRow) {
            this.curentPage++;
            this.callBack();
        }
    };
    this.Prev = function() {
        if (this.curentPage > 0) {
            this.curentPage--;
            this.callBack();
        }
    };
    this.First = function() {
        this.curentPage = 1;
        this.callBack();
    };
    this.Last = function() {
        this.curentPage = this.numPage;
        this.callBack();
    };
    this.GoToPage = function(i) {
        if (i > 0 && i < this.totalRow) {
            this.curentPage = i;
            this.callBack();
        }
    };
    this.WrapPaging = function() {
        this.numPage = this.totalRow / this.rowPerPage;
        if (this.numPage > Math.floor(this.numPage)) {
            this.numPage = Math.floor(this.numPage) + 1;
        }
        if (this.curentPage > this.numPage) this.curentPage = this.numPage;
        if (this.numPage <= 1) {
            $(this.objContainer).html("");
            return;
        }
        if (this.numPage > 1) {
            var startIndex = 0, endIndex = this.totalRow;
            var constDelta = Math.floor(this.pagePerSeg / 2);
            startIndex = this.curentPage - constDelta;
            if (startIndex <= 0) startIndex = 1;
            endIndex = startIndex + this.pagePerSeg;
            if (endIndex > this.numPage)
                endIndex = this.numPage + 1;
            // Genarate Navigation
            var _handlerString = this.handler != "" ? ' href="#' + this.handler + '{0}" ' : ' href="javascript:;" ';
            var sHTMLNavi = '<div class="' + this.className + '">';
            if (this.curentPage > 1) {
                if (this.showButton) {
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.First()" class="first_page" title="Đầu" ' + _handlerString.format('1') + '>&nbsp;</a>&nbsp;';
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.Prev()" class="first_page_s" title="Trước" ' + _handlerString.format(parseInt(this.curentPage - 1)) + '>&nbsp;</a>';
                }
                else {
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.First()" class="first_page" title="Đầu" ' + _handlerString.format('1') + '>Trang đầu</a>&nbsp;';
                    //sHTMLNavi += '<a onclick="' + this.objPaging + '.Prev()" class="first_page_s" title="Trước" ' + _handlerString.format(parseInt(this.curentPage - 1)) + '>&nbsp;</a>';
                }
                sHTMLNavi += '<span>...</span>';
            }
            for (i = startIndex; i < endIndex; i++) {
                if (i == this.curentPage)
                    sHTMLNavi += '<a class=\"selected\">' + i + '</a>';
                else {
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.GoToPage(' + i + ')" title="Trang ' + i + '" ' + _handlerString.format(i) + '>' + i + '</a>';
                }
            }
            if (this.curentPage < this.numPage) {
                sHTMLNavi += '<span>...</span>';
                if (this.showButton) {
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.Next()" class="end_page_s" title="Sau" ' + _handlerString.format(parseInt(this.curentPage) + 1) + '>&nbsp;</a>&nbsp;';
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.Last()" class="end_page" title="Cuối" ' + _handlerString.format(parseInt(this.numPage)) + ' >&nbsp;</a>';
                }
                else {
                    //sHTMLNavi += '<a onclick="' + this.objPaging + '.Next()" class="end_page_s" title="Sau" ' + _handlerString.format(parseInt(this.curentPage) + 1) + '>&nbsp;</a>&nbsp;';
                    sHTMLNavi += '<a onclick="' + this.objPaging + '.Last()" class="end_page" title="Cuối" ' + _handlerString.format(parseInt(this.numPage)) + ' >Trang cuối</a>';
                }
            }
            sHTMLNavi += '</div>';
            $(this.objContainer).html(sHTMLNavi);
        }
        return this.curentPage;
    }
}