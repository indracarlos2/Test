function addFilter() {
    var date = $('#date').attr('value').replace(":","");
        $.ajax({
            type: "GET",
            url: "Graphic/GetCurrenSales/" + date
        });
}
$(document).ready(function () {
    $("button").click(function (e) {
        switch (e.target.id) {
            case "addFilter":
                addFilter();
                break;
        }
    });
});