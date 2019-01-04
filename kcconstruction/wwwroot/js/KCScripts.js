$(document).ready(function () {

    openImage = function (pathToImageSm) {
        var pathToImage = pathToImageSm.replace('_sm.jpg', '.jpg');
        //var newImage = `<i class="fas fa-chevron-left"></i><img src="${pathToImage}" class="kc-main-gallery-image"/><i class="fas fa-chevron-right"></i>`;
        var newImage = `</i><img src="${pathToImage}" class="kc-main-gallery-image"/>`;

        $("#pictureDemonstratorContainer").html(newImage);

        $("#pictureDemonstrator").modal('show');

    };




});
