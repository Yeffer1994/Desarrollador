
$(document).ready(function () {
    $('.modal').modal({
        backdrop: 'static',
        keyboard: false
    })

});

async function Gudarinformacion() {

    debugger

    var div2 = document.getElementById('PanelInformacionPersonal');
    var infoPersonal = div2.style.display;
    var div1 = document.getElementById('PanelInformacionInscripcion');
    var infoInscripcion = div1.style.display;

    if (infoPersonal == "none") {

        var PrimerNombre = $("#IIPrimerNombre").val();

        if (PrimerNombre == "") {
            alert("Debe ingresar el primer nombre");
            return;
        }

        var SegundoNombre = $("#IISegundoNomre").val();
        var PrimerApellido = $("#IIPrimerApellido").val();

        if (PrimerApellido == "") {
            alert("Debe ingresar el primer Apellido");
            return;
        }

        var SegundoApellido = $("#IISegundoApellido").val();

        if (SegundoApellido == "") {
            alert("Debe ingresar el segundo Apellido");
            return;
        }

        var fechadenacimiento = $("#fr_fechadenacimiento").val();
        if (fechadenacimiento == "") {
            alert("Debe seleccionar una fecha de nacimiento");
            return;
        }

        var Pais = $("#IIPais").val();
        if (Pais == "--Seleccione--") {
            alert("Debe seleccionar un pais");
            return;
        }

        var Departamento = $("#IIDepartamento").val();
        if (Departamento == "--Seleccione--") {
            alert("Debe seleccionar un Departamento");
            return;
        }

        var Ciudad = $("#IICiudad").val();
        if (Ciudad == "--Seleccione--") {
            alert("Debe seleccionar una ciudad");
            return;
        }

        var GrupoG = $("#IIGrupoG").val();
        if (GrupoG == "--Seleccione--") {
            alert("Debe seleccionar un grupo sanguineo");
            return;
        }

        var TipoIdent = $("#IITipoIdent").val();
        if (TipoIdent == "--Seleccione--") {
            alert("Debe seleccionar un tipo de identificacion");
            return;
        }

        var identificationNumber = $("#IIidentificationNumber").val();
        if (identificationNumber == "") {
            alert("Debe escribir un numero de identificacion");
            return;
        }

        var fechadeExpedicion = $("#fr_fechadeExpedicion").val();
        if (fechadeExpedicion == "") {
            alert("Debe seleccionar una fecha de expedicion");
            return;
        }

        var CiudadExpedicion = $("#IICiudadExpedicion").val();
        if (CiudadExpedicion == "--Seleccione--") {
            alert("Debe seleccionar una ciudad de expedicion");
            return;
        }

        var sexo = "";
        if (document.getElementById('IIMusculino').checked == true) {
            sexo = "M";
        }
        else {
            sexo = "F";
        }

        if (sexo == "") {
            alert("Debe seleccionar un sexo");
            return;
        }

        var EstadoCivil = "";

        if (document.getElementById('IISoltero').checked == true) {
            EstadoCivil = "Soltero";
        }
        else if (document.getElementById('IICasado').checked == true) {
            EstadoCivil = "Casado";
        }
        else if (document.getElementById('IIUnionLibre').checked == true) {
            EstadoCivil = "UnionLibre";
        }
        else if (document.getElementById('IIViudo').checked == true) {
            EstadoCivil = "Viudo";
        }
        else if (document.getElementById('IISeparado').checked == true) {
            EstadoCivil = "Separado";
        }

        if (EstadoCivil == "") {
            alert("Debe seleccionar un estado civil");
            return;
        }


        let url = window.location.href.split('?')[0];
        url = url.replace("/index", "") + `/GuardarInfoInscripcion?PrimerNombre=` + PrimerNombre + `&SegundoNombre=` + SegundoNombre + `&PrimerApellido=` + PrimerApellido + `&SegundoApellido=` + SegundoApellido + `&fechadenacimiento=` + fechadenacimiento + `&Pais=` + Pais + `&Departamento=` + Departamento + `&Ciudad=` + Ciudad + `&GrupoG=` + GrupoG + `&TipoIdent=` + TipoIdent + `&identificationNumber=` + identificationNumber + `&fechadeExpedicion=` + fechadeExpedicion + `&CiudadExpedicion=` + CiudadExpedicion + `&sexo=` + sexo + `&EstadoCivil=` + EstadoCivil;
        fetch(url, {
            method: "GET"
        })
            .then(res => res.text())
            .then(data => {

                $("#IIPrimerNombre")[0].value = "";
                $("#IISegundoNomre")[0].value = "";
                $("#IIPrimerApellido")[0].value = "";
                $("#IISegundoApellido")[0].value = "";
                $("#fr_fechadenacimiento")[0].value = "";
                $("#IIPais")[0].value = "--Seleccione--";
                $("#IIDepartamento")[0].value = "--Seleccione--";
                $("#IICiudad")[0].value = "--Seleccione--";
                $("#IIGrupoG")[0].value = "--Seleccione--";
                $("#IITipoIdent")[0].value = "--Seleccione--";
                $("#IIidentificationNumber")[0].value = "";
                $("#fr_fechadeExpedicion")[0].value = "";
                $("#IICiudadExpedicion")[0].value = "--Seleccione--";

                document.getElementById('IIMusculino').checked = false
                document.getElementById('IIFemenino').checked = false
                document.getElementById('IISoltero').checked = false
                document.getElementById('IICasado').checked = false
                document.getElementById('IIUnionLibre').checked = false
                document.getElementById('IIViudo').checked = false
                document.getElementById('IISeparado').checked = false

                if (data == "Cedula Error") {
                    alert("La cedula que quiere inscribir ya se encuentra registrada");
                }
                else if (data == "Ok") {
                    alert("se registro con exito la informacion de inscripcion");
                }

            })
            .catch(error => {
                console.log(error)
            });

    }
    else {

        var TipoEstudiante = "";

        if (document.getElementById('rdbNuevo').checked == true) {
            TipoEstudiante = "Nuevo";
        }
        else if (document.getElementById('rdbReingreso').checked == true) {
            TipoEstudiante = "Reingreso";
        }
        else if (document.getElementById('rdbTExterna').checked == true) {
            TipoEstudiante = "Transferencia Externa";
        }
        else if (document.getElementById('rdbInterna').checked == true) {
            TipoEstudiante = "Transferencia Interna";
        }

        if (TipoEstudiante == "") {
            alert("Debe seleccionar un tipo de aspirante");
            return;
        }

        var Modalidad = $("#IPModalidad").val();
        if (Modalidad == "--Seleccione--") {
            alert("Debe seleccionar una Modalidad");
            return;
        }

        var Sede = $("#IPSede").val();
        if (Sede == "--Seleccione--") {
            alert("Debe seleccionar una Sede");
            return;
        }

        var Programa = $("#IPPrograma").val();
        if (Programa == "--Seleccione--") {
            alert("Debe seleccionar un programa");
            return;
        }

        var Periodo = $("#IPPeriodoA").val();
        if (Periodo == "") {
            alert("Debe ingresar un perido academico");
            return;
        }

        var CedulaAspirante = $("#IPCedulaAspirante").val();
        if (CedulaAspirante == "") {
            alert("Debe ingresar su cedula");
            return;
        }


        let url = window.location.href.split('?')[0];
        url = url.replace("/index", "") + `/GuardarInfoPersonal?TipoEstudiante=` + TipoEstudiante + `&Modalidad=` + Modalidad + `&Sede=` + Sede + `&Programa=` + Programa + `&Periodo=` + Periodo + `&CedulaAspirante=` + CedulaAspirante;
        fetch(url, {
            method: "GET"
        })
        .then(res => res.text())
        .then(data => {

            $("#IPCedulaAspirante")[0].value = "";
            $("#IPPeriodoA")[0].value = "";
            $("#IPPrograma")[0].value = "--Seleccione--";
            $("#IPSede")[0].value = "--Seleccione--";
            $("#IPModalidad")[0].value = "--Seleccione--";

            document.getElementById('rdbNuevo').checked = false
            document.getElementById('rdbReingreso').checked = false
            document.getElementById('rdbTExterna').checked = false
            document.getElementById('rdbInterna').checked = false

            if (data == "Cedula no inscrita") {
                alert("Primero debe de llenar el formulario de: Informacion de inscripcion");
                return;
            }
            else if (data == "Ok") {
                alert("Se incribio con exito al programa seleccionado");
                return;
            }

        })
        .catch(error => {
            console.log(error)
        });

    }

}

async function InformacionPersonal() {
    await CargarModalidad();
    await CargarSede();
    await CargarPrograma();

    var div2 = document.getElementById('PanelInformacionPersonal');
    div2.style.display = '';
    var div1 = document.getElementById('PanelInformacionInscripcion');
    div1.style.display = 'none';
    //await CargarSede();
    //await CargarPrograma();
}

async function InformacionInscripcion() {

    await CargarPais();
    await CargarTipoIdentificiacion();
    await CargarGrupoSanguineo();
    await CargarCiudadExpedicion();

    var div2 = document.getElementById('PanelInformacionPersonal');
    div2.style.display = 'none';
    var div1 = document.getElementById('PanelInformacionInscripcion');
    div1.style.display = '';

}


async function CargarCiudadExpedicion() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/CiudadExpedicion`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IICiudadExpedicion").empty();
            var options = $("#IICiudadExpedicion");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option  value=" + data[i].codigo.toString() + " >" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}

async function CargarGrupoSanguineo() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/GrupoSanguineo`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IIGrupoG").empty();
            var options = $("#IIGrupoG");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option  value=" + data[i].codigo.toString() + " >" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}

async function CargarTipoIdentificiacion() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Identificacion`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IITipoIdent").empty();
            var options = $("#IITipoIdent");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option  value=" + data[i].codigo.toString() + " >" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}

async function CargarPais() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Pais`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IIPais").empty();
            var options = $("#IIPais");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option  value=" + data[i].codigo.toString() + " >" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}

async function ConsultarDepartametos(CodigoPais) {

    if (CodigoPais == "--Seleccione--") {
        $("#IIDepartamento").empty();
        $("#IICiudad").empty();
        var options = $("#IIDepartamento");
        var options1 = $("#IICiudad");

        options.append("<option>" + "--Seleccione--" + "</option>");
        options1.append("<option>" + "--Seleccione--" + "</option>");
        return;
    }

    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Departamentos?CodigoPais=` + CodigoPais;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IIDepartamento").empty();
            var options = $("#IIDepartamento");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option value=" + data[i].codigo.toString() + ">" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}


async function ConsultarCiudades(CodigoDepartamento) {

    if (CodigoDepartamento == "--Seleccione--") {
        $("#IICiudad").empty();
        var options1 = $("#IICiudad");
        options1.append("<option>" + "--Seleccione--" + "</option>");
        return;
    }

    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Ciudades?CodigoDepartamento=` + CodigoDepartamento;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IICiudad").empty();
            var options = $("#IICiudad");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option value=" + data[i].codigo.toString() + ">" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}

async function CargarModalidad() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Modalidad`;
    fetch(url, {
        method: "GET"
    })
    .then(res => res.json())
    .then(data => {

        $("#IPModalidad").empty();
        var options = $("#IPModalidad");
        options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
        for (var i = 0; i < data.length; i++) {
            options.append("<option value=" + data[i].codigo.toString() + ">" + data[i].nombre + "</option>");
        }
    })
    .catch(error => {
        console.log(error)
    });
}

async function CargarSede() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Sede`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IPSede").empty();
            var options = $("#IPSede");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option value=" + data[i].codigo.toString() + ">" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}


async function CargarPrograma() {
    let url = window.location.href.split('?')[0];
    url = url.replace("/index", "") + `/Programa`;
    fetch(url, {
        method: "GET"
    })
        .then(res => res.json())
        .then(data => {

            $("#IPPrograma").empty();
            var options = $("#IPPrograma");
            options.append("<option value=" + "--Seleccione--" + ">" + "--Seleccione--" + "</option>");
            for (var i = 0; i < data.length; i++) {
                options.append("<option value=" + data[i].codigo.toString() + ">" + data[i].nombre + "</option>");
            }
        })
        .catch(error => {
            console.log(error)
        });
}