
$(document).ready(async function () {
    await CargarDatosEstudiantes();
});

function Export() {
    var table2excel = new Table2Excel();
    table2excel.export(document.querySelectorAll('table')); 
}

function generate() {
    var doc = new jsPDF('p', 'pt', 'letter');
    var htmlstring = '';
    var tempVarToCheckPageHeight = 0;
    var pageHeight = 0;
    pageHeight = doc.internal.pageSize.height;
    specialElementHandlers = {
        // element with id of "bypass" - jQuery style selector  
        '#bypassme': function (element, renderer) {
            // true = "handled elsewhere, bypass text extraction"  
            return true
        }
    };
    margins = {
        top: 50,
        bottom: 60,
        left: 40,
        right: 40,
        width: 200
    };
    var y = 20;
    doc.setLineWidth(2);
    doc.text(200, y = y + 30, "TOTAL DE ALUMNOS");
    doc.autoTable({
        html: '#example',
        startY: 70,
        theme: 'grid',
        columnStyles: {
            0: {
                cellWidth: 80,
            },
            1: {
                cellWidth: 80,
            },
            2: {
                cellWidth: 80,
            }
        },
        styles: {
            minCellHeight: 40
        }
    })
    doc.save('Alumnos.pdf');
}  




async function CargarDatosEstudiantes() {

    $("#AspirantesInscritos").empty();

    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/CargarInfoEstudiantes?`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            var obj = data;

            const tr = document.createElement('tr');
            const th = document.createElement('th');
            const td = document.createElement('td');
            const td1 = document.createElement('td');
            const td2 = document.createElement('td');
            const td3 = document.createElement('td');
            const td4 = document.createElement('td');
            const td5 = document.createElement('td');
            const td6 = document.createElement('td');
            const td7 = document.createElement('td');
            const td8 = document.createElement('td');
            const td9 = document.createElement('td');

            const Button = document.createElement('button');
            const Button1 = document.createElement('button');

            const input = document.createElement('input');
            var lista = "";

            if (data.length > 0) {
                for (var a = 0; a < data.length; a++) {
                    td.innerHTML = data[a].estado;
                    td1.innerHTML = data[a].sede;
                    td2.innerHTML = data[a].programaAcademico;
                    td3.innerHTML = data[a].periodoAcademico;
                    td5.innerHTML = data[a].tipoDocumento;
                    td7.innerHTML = data[a].numeroDocumento;
                    td8.innerHTML = data[a].nombres;
                    td9.innerHTML = data[a].apellidos;

                    //Button.setAttribute("data-identificadorUsuario", data[a].identificador);
                    //Button.setAttribute("id", "EliminarEUP");

                    //Button.setAttribute("onclick", "EliminarEntidadUsuario(this)");
                    //Button.innerHTML = "Eliminar";
                    //Button.className = "btn btn-outline-danger btn-sm m-1";

                    //Button1.setAttribute("data-identificadorUsuario", data[a].identificador);
                    //Button1.setAttribute("onclick", "ActualizarEntidadUsuario(this)");
                    //Button1.innerHTML = "Actualizar";
                    //Button1.className = "btn btn-outline-primary btn-sm m-1";

                    
                    tr.append(td);
                    tr.append(td1);
                    tr.append(td2);
                    tr.append(td3);
                    tr.append(td5);
                    //td4.append(Button);
                    //td6.append(Button1);
                    tr.append(td7);
                    tr.append(td8);
                    tr.append(td9);

                    lista = lista + tr.outerHTML;

                }

                $("#AspirantesInscritos").append(lista);

                var table = $('#example').DataTable({
                    orderCellsTop: true,
                    fixedHeader: true
                });

                //Creamos una fila en el head de la tabla y lo clonamos para cada columna
                $('#example thead tr').clone(true).appendTo('#example thead');

                $('#example thead tr:eq(1) th').each(function (i) {
                    var title = $(this).text(); //es el nombre de la columna
                    $(this).html('<input type="text" placeholder="Search...' + title + '" />');

                    $('input', this).on('keyup change', function () {
                        if (table.column(i).search() !== this.value) {
                            table
                                .column(i)
                                .search(this.value)
                                .draw();
                        }
                    });
                });

                var div2 = document.getElementById('LabelinfoEstudiantes');
                div2.style.display = 'none';
            }
            else {
                var div2 = document.getElementById('LabelinfoEstudiantes');
                div2.style.display = '';
            }

        })
        .catch(error => {
            console.log(error)
        });
}
