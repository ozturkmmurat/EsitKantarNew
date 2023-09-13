function sayiKontrol(event) {
    if (event.keyCode != 8 && event.keyCode != 0 && (event.keyCode < 48 || event.keyCode > 57))
        return false;
    var frm = document.getElementById("sayisal_form");
    frm.setAttribute("onsubmit", true);
    return true;
}