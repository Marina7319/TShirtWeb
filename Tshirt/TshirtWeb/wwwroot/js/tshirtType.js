var dataTable;

$(document).ready(function () {
    loadDatatable();
});

function loaddataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url":"/Admin/Category/GetAll"
        },
        "columns": [
            { "data": "name", "width": "60%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-xenter">
                    <a href="/Admin/Category/Upsert/${data}" class="btn btn"
                ` }
            }
        ]
    })
}