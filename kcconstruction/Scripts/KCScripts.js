$(document).ready(function () {

    openImage = function (pathToImageSm) {
        var pathToImage = pathToImageSm.replace('_sm.jpg', '.jpg');
        var newImage = "<img src=\"" + pathToImage + "\" class=\"kc-main-gallery-image\"/>";

        $("#pictureDemonstratorContainer").html(newImage);

        $("#pictureDemonstrator").modal('show');

    };




});
