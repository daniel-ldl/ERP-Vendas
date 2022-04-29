$(document).ready(function () {
    LoadStates();
    LoadMask();
});

function LoadMask() {

    $('#TxtCPF').mask('000.000.000-00', { placeholder: "___.___.___-__" });

    $('#TxtCep').mask('00000-000', { placeholder: "_____-___" });

}

function LoadStates() {

    const loadData = (result) => {
        for (var i = 0; i <= result.length - 1; i++) {
            $('#CbbEstado').append(`<option value="${result[i].id}">${result[i].sigla}</option>`);
        }
    }

    const options = {
        method: 'GET',
        mode: 'cors',
        cache: 'default'
    }

    fetch(`https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome`, options)
        .then((response => {
            response.json()
                .then(data => loadData(data))
        }))
        .catch(e => console.log(e))

    const states = document.querySelector("#CbbEstado");

    states.addEventListener("change", e => LoadCities())

}

function LoadCities() {

    const states = document.querySelector("#CbbEstado");
    const city = document.querySelector("#CbbCidade");

    city.innerHTML = '<option value="" selected>Selecione...</option>'

    let search = states.value;    

    const loadData = (result) => {
        for (var i = 0; i <= result.length - 1; i++) {
            city.innerHTML += `<option value="${result[i].id}" >${result[i].nome}</option>`
        }
    }

    const options = {
        method: 'GET',
        mode: 'cors',
        cache: 'default'
    }

    fetch(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/${search}/municipios?orderBy=nome`, options)
        .then((response => {
            response.json()
                .then(data => loadData(data))
        }))
        .catch(e => console.log(e))
}