$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.examples');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.examples.register')[0];
    subMenuItem.classList.add('active');

    $('input').iCheck({
        checkboxClass: 'icheckbox_square-blue',
        radioClass: 'iradio_square-blue',
        increaseArea: '20%' // optional
    });
});