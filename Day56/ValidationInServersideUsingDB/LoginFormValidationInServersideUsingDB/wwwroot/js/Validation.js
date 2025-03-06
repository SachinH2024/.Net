//$(function () {
//    $("form[id='registerForm']").validate({
//        rules: {
//            firstname: "required",
//            lastname: "required",
//           },
//        messages: {
//            firstname: "Please enter your firstname",
//            lastname: "Please enter your lastname",
//        },
//        submitHandler: function (form) {
//            form.submit();
//        }
//    });
//});

$(document).ready(function () {
    $('#registerForm').on('submit', function (event) {
        var firstName = $('#firstName').val();
        var lastName = $('#lastName').val();
        var isValid = validatefirstName(firstName, lastName);
        if (!isValid) {
            $('#usernameError1').show();
            $('#usernameError2').show();
            event.preventDefault();
        } else {
            $('#usernameError1').hide();
            $('#usernameError2').hide();
        }

    });

    function validatefirstName(firstName, lastName) {
        // Example validation: username must be between 3 and 15 characters and contain only alphanumeric characters
        var regex = /^[a-zA-Z]{3,15}$/;
        return regex.test(firstName, lastName);

    }
});