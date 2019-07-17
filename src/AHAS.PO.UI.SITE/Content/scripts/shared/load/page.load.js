$(window).on('load', function () {
    $('.preloader').addClass('complete');
});

$('.datatable-1').dataTable({
    "initComplete": function (settings, json) {
        $('#preloader').remove();
        $('#gridtable').removeAttr("hidden");
    }
});