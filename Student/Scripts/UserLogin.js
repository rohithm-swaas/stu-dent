function Loginpage(Email, password) {

    var Email = $('#Email').val();
    var password = $('#password').val();
   
        $.ajax({
            url: "/Login/UpdateLoginStatus/",
            data: { Email: Email, Password: password },
            type: "GET",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                if (result == 1) {
                    window.location = "http://localhost:65057/"
                }
                else {
                    alert("login Failed");
                }
                   
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    
}