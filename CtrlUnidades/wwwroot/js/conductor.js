var dataTable;

$(document).ready(function () {
    cargarDatatable();
});


function cargarDatatable() {
    dataTable = $("#tblConductores").DataTable({
        "ajax": {
            "url": "/Admin/Conductores/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "idCond", "width": "3%" },
            { "data": "nombre", "width": "20%" },
            { "data": "idLin", "width": "8%" },
            { "data": "telefono", "width": "12%" },
            { "data": "ine", "width": "19%" },
            { "data": "licencia", "width": "18%" },
            {
                "data": "idCond",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href='/Admin/Conductores/Edit/${data}' class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-edit'></i> Editar
                            </a>
                            &nbsp;
                            <a onclick=Delete("/Admin/Conductores/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-trash-alt'></i> Borrar
                            </a>
                            `;
                }, "width": "20%"
            }
        ],
        "language": {
            "decimal": "",
            "emptyTable": "No hay registros",
            "info": "Mostrando _START_ a _END_ de _TOTAL_ Entradas",
            "infoEmpty": "Mostrando 0 to 0 of 0 Entradas",
            "infoFiltered": "(Filtrado de _MAX_ total entradas)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ Entradas",
            "loadingRecords": "Cargando...",
            "processing": "Procesando...",
            "search": "Buscar:",
            "zeroRecords": "No hay registros",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            }
        },
        "width": "100%"
    });
}