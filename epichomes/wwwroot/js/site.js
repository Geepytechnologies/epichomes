// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $("#datepicker").datepicker({
        minDate: 0,
        dateFormat: "MM d, yy"
    });
    // Set the input field value to the default date
    $("#datepicker").datepicker("setDate", new Date());
    // Set the input field as readonly
    $("#datepicker").prop("readonly", true);
    // Attach an event handler for the Datepicker's onSelect event
    $("#datepicker").on("change", function () {
        // Get the selected date value from the input
        var selectedDate = $(this).val();

        // Log the selected date to the console (you can use it as needed)
        console.log("Selected Date: " + selectedDate);
    });
});

$(function () {
    $("#datepicker2").datepicker({
        minDate: 0,
        dateFormat: "MM d, yy"
    });
    // Set the input field value to the default date
    $("#datepicker2").datepicker("setDate", new Date(new Date().getTime() + 2 * 24 * 60 * 60 * 1000));
    // Set the input field as readonly
    $("#datepicker2").prop("readonly", true);
    // Attach an event handler for the Datepicker's onSelect event
    $("#datepicker2").on("change", function () {
        // Get the selected date value from the input
        var selectedDate = $(this).val();

        // Log the selected date to the console (you can use it as needed)
        console.log("Selected Date: " + selectedDate);
    });
});
