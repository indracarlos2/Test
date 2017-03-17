function getData() {
    $.ajax({
        type: "GET",
        url: "/api/commentary/" + $('#id_response').attr('value'),
        success: function (data) {
            $('#tableCommentary').empty();
            for (var i = 0; i < data.length; i++) {
                $('#tableCommentary').append('<tr>'
                + '<td>' + data[i].Author + '</td>'
                + '<td>' + data[i].Message + '</td></tr>');
            }
        }
    });
}

function addMessage() {
    var message = $("#Message").attr('value');
    if(message.trim().length>0&&message.trim().length<100){
        $.ajax({
            type: "POST",
            url: "/api/commentary/",
            data: $('#messageForm').serialize(),
            success: function (result) {
                if (result) {
                    getData();
                }
            }
        });
    } 
}
$(document).ready(function () {
    getData();
    $("button").click(function (e) {
        switch (e.target.id) {
            case "addMessage":
                addMessage();
                break;
        }
    });
});