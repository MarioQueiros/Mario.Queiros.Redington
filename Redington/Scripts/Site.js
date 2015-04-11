function ValidateForm() {
    $('.result').hide(100);

    if ($('#myForm').valid()) {
        var probabilityOne = parseFloat($('#ProbabilityOne').val());
        var probabilityTwo = parseFloat($('#ProbabilityTwo').val());
        var selectedOption = $('#SelectedOption').val();

        var result = Calculation(probabilityOne, probabilityOne, selectedOption);

        if (result) {
            SaveResult(probabilityOne, probabilityOne, selectedOption, result);
        }

        $('.result').show(500);
        $('.labelResult').html(result);
    }
}

function ClearForm() {
    $("#myForm").trigger('reset');
    $('.result').hide(100);
}

function Calculation(probabilityOne, probabilityTwo, selectedOption) {
    var result = undefined;

    if (selectedOption === '0') {
        result = probabilityOne * probabilityTwo;
    } else if (selectedOption === '1') {
        result = probabilityOne + probabilityTwo - (probabilityOne * probabilityTwo);
    }

    return result ? result : -1;
}

function SaveResult(probabilityOne, probabilityTwo, selectedOption, result) {
    $.ajax({
        url: '/Home/SaveResults',
        contentType: 'application/json',
        type: 'POST',
        data: JSON.stringify({ probabilityOne: probabilityOne, probabilityTwo: probabilityTwo, selectedOption: selectedOption, result: result }),
        success: function (data) {
            console.log('Results of calculation successfully saved.');
        },
        error: function (x, error) {
            console.log('Error saving results of calculation.');
        }
    });
}