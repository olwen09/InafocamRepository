$(".formValidate").validate({
    rules: {
        ccodigo: {
            required: true,
            minlength: 7,
			maxlength: 7
        },
        uname: {
            required: true,
            minlength: 5
        },
        cemail: {
            required: true,
            email: true
        },
        password: {
            required: true,
            minlength: 5
        },
        cpassword: {
            required: true,
            minlength: 5,
            equalTo: "#password"
        },
        curl: {
            required: true,
            url: true
        },
        crole: "required",
        ccomment: {
            required: true,
            minlength: 15
        },
        cgender: "required",
        cagree: "required",
    },
    //For custom messages
    messages: {
        uname: {
            required: "Enter a username",
            minlength: "Enter at least 5 characters"
        },
        ccodigo: {
            required: "Es necesario asignar un código",
            minlength: "deben ser 7 caracteres",
            maxlength: "deben ser 7 caracteres"

        },
        curl: "Enter your website",
    },
    errorElement: 'div',
    errorPlacement: function (error, element) {
        var placement = $(element).data('error');
        if (placement) {
            $(placement).append(error)
        } else {
            error.insertAfter(element);
        }
    }
});