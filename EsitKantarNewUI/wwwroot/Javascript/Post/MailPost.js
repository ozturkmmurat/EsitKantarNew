
var r1 = Math.floor(Math.random() * 10);
var r2 = Math.floor(Math.random() * 10);
var addition = r1 + r2;

$(document).ready(function () {
    document.getElementById("calculator").innerHTML = r1 +  " + " + r2 + " = ?";
});
$(document).ready(function () {

    $('#sendMailDiv').on('click', '.sendMail', function () {
        var userMail = new Array();
        var pushClass = {};
        pushClass.AdSoyad = $("#AdSoyad").val()
        pushClass.Email = $("#Email").val()
        pushClass.TelNo = $("#TelNo").val()
        pushClass.MailIcerik = $("#MailIcerik").val()
        pushClass.ProductName = $("#ProductName").val()
        var additioninput = document.getElementById("sayi").value;

        var loca = window.location.pathname.split('/')[1]

       

        userMail.push(pushClass);
        $.ajax({
            type: 'json',
            method: 'POST',
            url: '/'+loca+'/Contact/Index',
            data: { userMail },
            success: function (data) {
                if (data[0].status == "Error") {
                    for (var i = 0; i < data.length; i++) {
                        toastr.error(data[i].message)
                    }
                } else if (data[0].status == "Ok") {

                    if (addition != additioninput) {
                        alert("HATALI TOPLAMA İŞLEMİ");
                    }
                    else {
                        for (var i = 0; i < data.length; i++) {
                            toastr.success(data[i].message)
                        }
                    }
                    
                }

            }
        });
    })
});