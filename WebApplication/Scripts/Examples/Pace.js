$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.examples');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.examples.pace')[0];
    subMenuItem.classList.add('active');

    $(document).ajaxStart(function () { Pace.restart(); });
    $('.ajax').click(function () {
        $.ajax({
            url: '#', success: function (result) {
                $('.ajax-content').html('<hr>Ajax Request Completed !');
            }
        });
    });
});