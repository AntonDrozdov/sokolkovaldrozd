$(document).ready(function () {

    showGallery = function (idOfSourceInput, pathToCurrentImageSm) {
        debugger;
        $("#pictureDemonstratorSourceInput").val( $("#" + idOfSourceInput).val());

        showCurrentImage(pathToCurrentImageSm);
    };

    showCurrentImage = function(pathToCurrentImage) {
        var pathToImage = pathToCurrentImage.replace('_sm.jpg', '.jpg');

        var newImage = `</i><img src="${pathToImage}" class="kc-main-gallery-image"/>`;

        $("#pictureDemonstratorContainer").html(newImage);

        $("#pictureDemonstrator").modal('show');
    }

    showNextImage = function (pathToCurrentImageSm) {

        var pathToImage = pathToCurrentImageSm.replace('_sm.jpg', '.jpg');

        var newImage = `</i><img src="${pathToImage}" class="kc-main-gallery-image"/>`;

        $("#pictureDemonstratorContainer").html(newImage);

        $("#pictureDemonstrator").modal('show');

    }


});
