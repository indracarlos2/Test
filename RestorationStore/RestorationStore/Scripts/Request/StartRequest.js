function submitEditPost() {
    //$.ajax({
    //    type: "POST",
    //    url: "SetInProgress?id_request=" + $('#id_request').attr('value'),
    //    success: function (data) {
    //        if (data) {
    //            $('#myId').hide();
    //        }
    //    }
    //});
   // location.href = "Menu.aspx";
    //$('#mydiv2').hide();
}
$(document).ready(function () {
    $("button").click(function (e) {
        switch (e.target.id) {
            case "submitEditPost":
                submitEditPost()
                break;
        }
    });
});