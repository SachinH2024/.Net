$(document).ready(function () {
    $('#usercheck').hide();
    $('#passcheck').hide();

    var user_err = true;
    var pass_err = true;

    $('#usernames').keyup(function () {
        username_check();
    });

    function username_check() {
        var user_val = $('#usernames').val();
        if (user_val.length == '') {
            $('#usercheck').show();
            user_err = false;
            return false;
        } else {
            $('#usercheck').hide();
        }
    }

    $('#password').keyup(function () {
        password_check();
    });

    function password_check() {
        var pass_val = $('#password').val();
        if (pass_val.length == '') {
            $('#passcheck').show();
            pass_err = false;
            return false;
        } else {
            $('#passcheck').hide();
        }
    }

    $('#submitbtn').click(function () {
        user_err = true;
        pass_err = true;

        username_check();
        password_check();

        if (user_err == true && pass_err == true) {
            return true;
        } else {
            return false;
        }
    });
});