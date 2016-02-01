$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.forms');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.forms.editors')[0];
    subMenuItem.classList.add('active');

    // Replace the <textarea id="editor1"> with a CKEditor
    // instance, using default configuration.
    CKEDITOR.replace('editor1');
    //bootstrap WYSIHTML5 - text editor
    $(".textarea").wysihtml5();
});