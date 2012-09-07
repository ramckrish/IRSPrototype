

function typeChange(val) {
    document.getElementById("SubType").options.length = 0;
    var SubType = document.getElementById("SubType");


    switch (val) {
        case "Unexpected Complication":
            var arr;
            var option;
            arr = new Array("Select","Code Blue", "Hemorrhage/Excessive Bleeding", "Malignant Hyperthermia","Nausiea and/or vomiting Required Intervention");
            SubType.disabled = false;
            SubType.options.length = 0;
            for (var i = 0; i < arr.length; i++) {
                option = new Option(arr[i], arr[i]);
                SubType.options[i] = option;
            }
            break;


        case "Post-Surgical Infection":
            var arr;
            var option;
            arr = new Array("Break in sterile technique", "Fever Post discharge", "instrument processed for immediate use","Reported infection by doctor","Reported infection by post op call");
            SubType.disabled = false;
            SubType.options.length = 0;
            for (var i = 0; i < arr.length; i++) {
                option = new Option(arr[i], arr[i]);
                SubType.options[i] = option;
            }
            break;

        case "Tissue Review":
            var arr;
            var option;
            arr = new Array("Lost Specimen", "Specimen not labeled accurately","Specimen incorrectly prepared","other");
            SubType.disabled = false;
            SubType.options.length = 0;
            for (var i = 0; i < arr.length; i++) {
                option = new Option(arr[i], arr[i]);
                SubType.options[i] = option;
            }
            break;

        case "Injury":
            var arr;
            var option;
            arr = new Array("Fall", "Back", "Needlestick", "other");
            SubType.disabled = false;
            SubType.options.length = 0;
            for (var i = 0; i < arr.length; i++) {
                option = new Option(arr[i], arr[i]);
                SubType.options[i] = option;
            }
            break;

        default:
            SubType.disabled = false;
            SubType.options.length = 0;
            break;
    }
}

