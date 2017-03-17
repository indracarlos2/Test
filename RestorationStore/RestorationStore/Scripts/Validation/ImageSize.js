$(document).ready(function () {
    $('form').submit(function (e) {
        var fileInput = $('#upload-file');
        var maxSize = 2097152;//5247;
        if (fileInput.get(0).files.length) {
            var fileSize = fileInput.get(0).files[0].size;
            if (fileSize > maxSize) {
                alert('Please select an image less than '+maxSize+' bytes');
                return false;
            }
        } else {
            alert('Please select an image to upload');
            return false;
        }
    });
});