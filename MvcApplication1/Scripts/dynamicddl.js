

function srcChange(val) 
{
    document.getElementById("slc_target").options.length = 0;
    var slc_target = document.getElementById("slc_target");


switch (val)
{
    case "Patient Incident":
        var arr;
        var option;
        arr = new Array("Unexpected Complication", "Post-Surgical Infection", "Tissue Review");
        slc_target.disabled = false;
        slc_target.options.length = 0;
        for (var i = 0; i < arr.length; i++) {
            option = new Option(arr[i], arr[i]);
            slc_target.options[i] = option;
        }
        break;


    case "Employee Incident":
        var arr;
        var option;
        arr = new Array("Injury","other","other 2");
        slc_target.disabled = false;
        slc_target.options.length = 0;
        for (var i = 0; i < arr.length; i++) {
            option = new Option(arr[i], arr[i]);
            slc_target.options[i] = option;
        }
        break;

    case "Customer Service Incident":
        var arr;
        var option;
        arr = new Array("Physician Complaint", "Physician office Complaint");
        slc_target.disabled = false;
        slc_target.options.length = 0;
        for (var i = 0; i < arr.length; i++) {
            option = new Option(arr[i], arr[i]);
            slc_target.options[i] = option;
        }
        break;


    default:
        slc_target.disabled = false;
        slc_target.options.length = 0;
        break;
}
}

