var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Admin/User/GetAll'
        },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "email", "width": "15%" },
            { "data": "city", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "company.name", "width": "15%" },
            { "data": "role", "width": "15%" },
           // {
           //     "data": "id", 
           //     "render": function (data) {         
           //             return `
           //             <div class="text-center">
           //                  <a ohref="/Admin/Category/Upsert/${data.id}" class="btn btn-danger text-white" style="cursor:pointer; width:100px;">
           //                         <i class="bi bi-lock-fill"></i>  Lock
           //                     </a> 
           //                     <a onclick=Delete("/Admin/user/RoleManagment?userId=${data.id}" class="btn btn-danger text-white" style="cursor:pointer; width:150px;">
           //                          <i class="bi bi-pencil-square"></i> Permission
           //                     </a>
           //             </div>
           //         `
           //         }
           //         else {
           //             return `
           //             <div class="text-center">
           //                   <a onclick=LockUnlock('${data.id}') class="btn btn-success text-white" style="cursor:pointer; width:100px;">
           //                         <i class="bi bi-unlock-fill"></i>  UnLock
           //                     </a>
           //                     <a href="/admin/user/RoleManagment?userId=${data.id}" class="btn btn-danger text-white" style="cursor:pointer; width:150px;">
           //                          <i class="bi bi-pencil-square"></i> Permission
           //                     </a>
           //             </div>
           //         `
           //         }
           //
           //
           //     },
           //     "width": "25%"
           // }
        ]
    });
}


function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: '/Admin/User/LockUnlock',
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                dataTable.ajax.reload();
            }
        }
    });
}