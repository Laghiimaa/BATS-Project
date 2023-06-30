$(document).ready(function () {
    AsigPer();
});
function AsigPer() {
    let ValorPer = (document.getElementById('Datos').value).split('|');

    document.getElementById('NombreC').value = (ValorPer[0]);
    document.getElementById('RFC').value = (ValorPer[1]);
    document.getElementById('Calle').value = (ValorPer[2]);
    document.getElementById('Colonia').value = (ValorPer[3]);
    document.getElementById('Ciudad').value = (ValorPer[4]);
    document.getElementById('Estado').value = (ValorPer[5]);
    document.getElementById('CP').value = (ValorPer[6]);
    document.getElementById('Correo').value = (ValorPer[7]);
    document.getElementById('Tel').value = (ValorPer[8]);
    document.getElementById('Ubi').value = (ValorPer[9]);
    document.getElementById('Contacto').value = (ValorPer[10]);

};

function Actualizar(inputtxt) {

    document.getElementById('Datos').value =
        document.getElementById('NombreC').value + '|' +
        document.getElementById('RFC').value + '|' +
        document.getElementById('Colonia').value + '|' +
        document.getElementById('Ciudad').value + '|' +
        document.getElementById('Estado').value + '|' +
        document.getElementById('CP').value + '|' +
        document.getElementById('Correo').value + '|' +
        document.getElementById('Tel').value + '|' +
        document.getElementById('RFC').value + '|' +
        document.getElementById('Ubi').value + '|' +
        document.getElementById('Contacto').value;

    //alert(document.getElementById('Datos').value)
}
