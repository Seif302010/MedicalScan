$(document).ready(function () {
    $('#specialities-menu').change(function () {
        var selectedSpeciality = $(this).val();
        $('.doctor-box').hide();
        if (selectedSpeciality === "All") {
            $('.doctor-box').show();
        } else {
            $('.doctor-box:has(h6:contains("' + selectedSpeciality + '"))').show();
        }
    });
});
