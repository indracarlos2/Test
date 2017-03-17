function addFilter() {
        $.ajax({
            type: "POST",
            url: "Index/date?=" + $('#date').attr('value').toString()
        });
        alert($('#date').attr('value'));
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