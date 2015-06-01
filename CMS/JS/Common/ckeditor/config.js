/**
 * @license Copyright (c) 2003-2015, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.filebrowserBrowseUrl = '../JS/Common/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '../JS/Common/ckfinder/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '../JS/Common/ckfinder/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '../JS/Common/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '../JS/Common/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    config.filebrowserFlashUploadUrl = '../JS/Common/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
};
