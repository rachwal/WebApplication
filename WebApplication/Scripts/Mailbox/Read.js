$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.mailbox');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.mailbox.read')[0];
    subMenuItem.classList.add('active');
});