$(document).ready(function () {
    $('#form1').submit(function (e) {
        var fileInput = $('#upload-file');
        var maxSize = fileInput.attr('data-max-size');
        if (fileInput.get(0).files.length) {
            var fileSize = fileInput.get(0).files[0].size;
            if (fileSize > maxSize) {
                alert('file size is more than ' + maxSize + ' bytes:' + fileSize);
                return false;
            } else {
                alert('file size is correct - ' + fileSize + ' bytes');
            }
        } else {
            alert('Please select the file to upload');
            return false;
        }
    });
});