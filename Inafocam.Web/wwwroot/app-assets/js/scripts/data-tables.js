/*
 * DataTables - Tables
 */

var dtable;
var pdt;

$(function () {

    // Simple Data Table

    $('#data-table-simple').DataTable({
        "responsive": true,
    });

    // Row Grouping Table

    var table = $('#data-table-row-grouping').DataTable({
        "responsive": true,
        "columnDefs": [{
            "visible": false,
            "targets": 2
        }],
        "order": [
            [2, 'asc']
        ],
        "displayLength": 25,
        "drawCallback": function (settings) {
            var api = this.api();
            var rows = api.rows({
                page: 'current'
            }).nodes();
            var last = null;

            api.column(2, {
                page: 'current'
            }).data().each(function (group, i) {
                if (last !== group) {
                    $(rows).eq(i).before(
                        '<tr class="group"><td colspan="5">' + group + '</td></tr>'
                    );

                    last = group;
                }
            });
        }
    });



    // Page Length Option Table

    dtable = $('#page-length-option').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        },
        "responsive": true,
        "lengthMenu": [
            [10, 25, 50, -1],
            [10, 25, 50, "All"]
        ],
        "autoWidth": false
    });

   pdt = $('#productos-data-table').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        },
        "responsive": true,
        "lengthMenu": [
            [10, 25, 50, -1],
            [10, 25, 50, "All"]
        ],
       "autoWidth": false,
        "destroy": true
    });

    // Custom search
    function filterGlobal() {
        dtable.search($("#global_filter").val(), $("#global_regex").prop("checked"), $("#global_smart").prop("checked")).draw();
        pdt.search($("#global_filter").val(), $("#global_regex").prop("checked"), $("#global_smart").prop("checked")).draw();
    }

    function filterColumn(i) {
        dtable
            .column(i)
            .search(
                $("#col" + i + "_filter").val(),
                $("#col" + i + "_regex").prop("checked"),
                $("#col" + i + "_smart").prop("checked")
            )
            .draw();
        pdt
            .column(i)
            .search(
                $("#col" + i + "_filter").val(),
                $("#col" + i + "_regex").prop("checked"),
                $("#col" + i + "_smart").prop("checked")
            )
            .draw();
    }

    $("input#global_filter").on("keyup click", function () {
        filterGlobal();
    });
    // Dynmaic Scroll table

    $('#scroll-dynamic').DataTable({
        "responsive": true,
        "searching": true,
        scrollY: '50vh',
        scrollCollapse: true,
        paging: false,
        "dom": "frtip"

    });

    // Horizontal And Vertical Scroll Table

    $('#scroll-vert-hor').DataTable({
        "scrollY": 200,
        "scrollX": true
    });

    // Multi Select Table

    $('#multi-select').DataTable({
        responsive: true,
        "paging": true,
        "ordering": false,
        "info": false,
        "columnDefs": [{
            "visible": false,
            "targets": 2
        }],


    });

});



// Datatable click on select issue fix
$(window).on('load', function () {
    $(".dropdown-content.select-dropdown li").on("click", function () {
        var that = this;
        setTimeout(function () {
            if ($(that).parent().parent().find('.select-dropdown').hasClass('active')) {
                // $(that).parent().removeClass('active');
                $(that).parent().parent().find('.select-dropdown').removeClass('active');
                $(that).parent().hide();
            }
        }, 100);
    });
});

var checkbox = $('#multi-select tbody tr th input');
var selectAll = $('#multi-select .select-all');

var checkboxcustom = $('#page-length-option tbody tr th input')
var selectAllcustom = $('#page-length-option .select-all')

// Select A Row Function

$(document).ready(function () {
    checkbox.on('click', function () {
        $(this).parent().parent().parent().toggleClass('selected');
    })

    checkbox.on('click', function () {
        if ($(this).attr("checked")) {
            $(this).attr('checked', false);
        } else {
            $(this).attr('checked', true);
        }
    })



    // Select Every Row 

    selectAll.on('click', function () {
        $(this).toggleClass('clicked');
        if (selectAll.hasClass('clicked')) {
            $('#multi-select tbody tr').addClass('selected');
        } else {
            $('#multi-select tbody tr').removeClass('selected');
        }

        if ($('#multi-select tbody tr').hasClass('selected')) {
            checkbox.prop('checked', true);

        } else {
            checkbox.prop('checked', false);

        }
    })

    checkboxcustom.on('click', function () {
        $(this).parent().parent().parent().toggleClass('selected');
    })

    checkboxcustom.on('click', function () {
        if ($(this).attr("checked")) {
            $(this).attr('checked', false);
        } else {
            $(this).attr('checked', true);
        }
    })

    selectAllcustom.on('click', function () {
        $(this).toggleClass('clicked');
        if (selectAllcustom.hasClass('clicked')) {
            $('#page-length-option tbody tr').addClass('selected');
        } else {
            $('#page-length-option tbody tr').removeClass('selected');
        }

        if ($('#page-length-option tbody tr').hasClass('selected')) {
            checkboxcustom.prop('checked', true);

        } else {
            checkboxcustom.prop('checked', false);

        }
    })
})