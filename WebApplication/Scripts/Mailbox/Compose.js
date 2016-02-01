$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.mailbox');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.mailbox.compose')[0];
    subMenuItem.classList.add('active');

    //Add text editor
    $('#compose-textarea').wysihtml5();
});