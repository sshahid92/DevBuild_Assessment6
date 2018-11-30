document.getElementById("isGoing").style.display = "none";

function validateName(name) {
    var pattern = /^[a-z]+$/;
    return pattern.test(String(name));
}
function validateEmail(email) {
    var pattern = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return pattern.test(String(email).toLowerCase());
}



function validate() {
    var fnMessage = $("#fnMessage");
    var firstname = $("#firstname").val();
    fnMessage.text("");

    var lnMessage = $("#lnMessage");
    var lastname = $("#lastname").val();
    lnMessage.text("");

    var emailMessage = $("#emailMessage");
    var email = $("#email").val();
    emailMessage.text("");

    var isGoingMessage = $("#isGoingMessage");
    isGoingMessage.text("");


    if (!validateName(firstname)) {
        fnMessage.text(firstname + " is not a valid name");
        fnMessage.css("color", "red");
        return false;
    }
    if (!validateName(lastname)) {
        lnMessage.text(lastname + " is not a valid name");
        lnMessage.css("color", "red");
        return false;
    }

    if (!validateEmail(email)) {
        emailMessage.text(email + " is not a valid email");
        emailMessage.css("color", "red");
        return false;
    }
    if (!document.getElementById("yes").checked && !document.getElementById("no").checked) {
        isGoingMessage.text("Please check whether your are going.");
        isGoingMessage.css("color", "red");
        return false;
    }

    if (document.getElementById("yes").checked) {
        $("#isGoingMessage").text("");
        var dateMessage = $("#dateMessage");
        dateMessage.text("");

        var guestMessage = $("#guestMessage");
        guestMessage.text("");

        var guestfnMessage = $("#guestfnMessage");
        var guestfirstname = $("#guestfirstname").val();
        guestfnMessage.text("");

        var guestlnMessage = $("#guestlnMessage");
        var guestlastname = $("#guestlastname").val();
        guestlnMessage.text("");
        if (!document.getElementById("date1").checked && !document.getElementById("date2").checked) {
            dateMessage.text("Please select a date.");
            dateMessage.css("color", "red");
            return false;
        }
        if (!document.getElementById("guestYes").checked && !document.getElementById("guestNo").checked) {
            guestMessage.text("Please check whether you are bringing a guest.");
            guestMessage.css("color", "red");
            return false;
        }
    }
    return true;
}

$("#rsvp").bind("click", validate);

function isGoing() {
    var x = document.getElementById("isGoing");
    if (document.getElementById("yes").checked) {
        x.style.display = "block";
    } else if (document.getElementById("no").checked) {
        x.style.display = "none";
    }
}



