$(function () {
    var menuItem = document.getElementById('left.sidebar.menu.tables');
    menuItem.classList.add('active');
    var subMenuItem = menuItem.getElementsByClassName('left.sidebar.menu.tables.data')[0];
    subMenuItem.classList.add('active');

    $('#example1').DataTable();
    $('#example2').DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false
    });
});