
//var mensajes = document.createElement("SCRIPT");

//mensajes.src = '../../lib/toastr.js/toastr.min.js';
//mensajes.type = 'text/javascript';

//document.getElementsByTagName('head')[0].appendChild(toastr);

var handleMessages = function (tipo, titulo, texto) {

    console.log(tipo);
    console.log(titulo);
    console.log(texto);
    //console.log(mensajes);


    toastr[tipo](texto, titulo);


    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-bottom-center",
        "preventDuplicates": true,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut",
        "toastClass": "toastr"
    }
    
};


Toastr = function () {
    "use strict";
    return {
        init: function (tipo, titulo, texto) {
            handleMessages(tipo, titulo, texto);
        }
    }
}();
