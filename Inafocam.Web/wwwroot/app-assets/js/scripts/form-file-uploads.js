$(document).ready(function(){
    var drEvent = $('.dropify-event').dropify({
        messages: {
            default: 'Puede arrastrar la imagen aquí o pulsar para seleccionar una',
            replace: 'Reemplazar',
            remove: 'Remover',
            error: 'Hubo un error, vuelva a intentarlo'
        }
    });
    // Basic
    $('.dropify').dropify();

    // Translated
    //drEvent.dropify({
    //    messages: {
    //        default: 'Puede arrastrar la imagen aquí',
    //        replace: 'Reemplazar',
    //        remove:  'Remover',
    //        error:   'Hubo un error, vuelva a intentarlo'
    //    }
    //});

    // Used events

    drEvent.on('dropify.beforeClear', function(event, element){
        return confirm("Desea remover la imagen ?");
    });

    drEvent.on('dropify.afterClear', function(event, element){
        alert('Imagen borrada');
    });
});