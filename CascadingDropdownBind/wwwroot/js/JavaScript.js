$(document).ready(function () {
    GetCountry();
    $('#Country').change(function () {
       
        var id = $(this).val();
        $('#City').empty();
        $('#City').append('<option> --Select City -- </option>');
        $.ajax({
            url: '/Home/City?id=' + id,
            success: function (result) {

                $.each(result, function (i,data) {
                    $('#City').append('<option value =' + data.id + '>' + data.name + '  </option>');
                });
            }
        });
    });
    
});


function GetCountry() {

    $.ajax({
        url: '/Home/Country',
        success: function (result) {
            $.each(result, function (i, data) { 
                $('#Country').append('<option value =' + data.id + '> ' + data.name + '</option>');
            });
        }
    });
}   