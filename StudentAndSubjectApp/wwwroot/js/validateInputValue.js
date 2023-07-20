$(document).ready(function () {
    $('#studentForm').submit(function () {
        var inputValue = $('#firstName').val();

        if (inputValue.length > 25) {
            alert("Input value for 'First name' cannot exceed 25 characters.");
            return false;
        }
    });
});

$(document).ready(function () {
    $('#studentForm').submit(function () {
        var inputValue = $('#surname').val();

        if (inputValue.length > 25) {
            alert("Input value for 'Surname' cannot exceed 25 characters.")
            return false;
        }
    });
});

$(document).ready(function () {
    $('#studentForm').submit(function () {
        var inputValue = $('#emailAddress').val();

        if (inputValue.length > 50) {
            alert("Input value for your 'Email address' cannot exceed 50 characters.");
            return false;
        }
    });
});
