$(document).ready(function () {
    
    showGallery = function (idOfSourceInput, pathToCurrentImageSm) {
        $("#pictureDemonstratorSourceInput").val( $("#" + idOfSourceInput).val());

         showImage(pathToCurrentImageSm);

         $("#pictureDemonstrator").modal('show');
    };

    showImage = function (pathToCurrentImageSm) {
          
        var pathToImage = pathToCurrentImageSm.replace('_sm.jpg', '.jpg');

        $("#pictureDemonstratorCurrentImage").val(pathToImage);

        var newImage = `<table><tr><td><img src="/images/10pxtemplate.jpg"/></td>
                                    <td><img src="${pathToImage}" class="kc-main-gallery-image"/></td>
                                </tr></table>`;



        $("#pictureDemonstratorContainer").html(newImage);


        //$("#pictureDemonstratorContainer").animate({ opacity: 0 }, 1000,
        //    function() {
        //        $(this).html(newImage).find("table>tr>td>img").bind("load",
        //            function() {
        //                $(this).parent().animate({ opacity: 1 }, 1000);
        //            });
        //    });
    }

    showNextImage = function (direction) {
        let currentImage = $("#pictureDemonstratorCurrentImage").val();
        let imageList = $("#pictureDemonstratorSourceInput").val().split(';');

        let indexOfNextImage = 0;

        let indexOfCurrentImage = imageList.lastIndexOf(currentImage);

        if (direction === "forward") {
            if (indexOfCurrentImage !== imageList.length - 1) {
                indexOfNextImage = indexOfCurrentImage + 1;
            }
        }
        if (direction === "back") {
            if (indexOfCurrentImage !== 0) {
                indexOfNextImage = indexOfCurrentImage - 1;
            } else {
                indexOfNextImage = imageList.length - 1;
            }
        }

        showImage(imageList[indexOfNextImage]);
    }

    $('#pictureDemonstrator-nextImage').on("click", function (evnt) {
        showNextImage("forward");
    });

    $('#pictureDemonstrator-previousImage').on("click", function (evnt) {
        showNextImage("back");
    });

    $('#contactsFeedbackForm').on('click', function () {
        $("#feedbackForm").modal('show');
    });

});
