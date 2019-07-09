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
    };

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
    };

    $('#pictureDemonstrator-nextImage').on("click", function (evnt) {
        showNextImage("forward");
    });

    $('#pictureDemonstrator-previousImage').on("click", function (evnt) {
        showNextImage("back");
    });

    $('#contactsFeedbackFormBtn').on('click', function () {
        showFeedbackForm();
    });

    $('#askQuestionIcon').on('click', function () {
        showFeedbackForm();
    });

    showFeedbackForm = function () {
        $("#formfeedbackInputs-successPost").hide();
        $("#formfeedbackInputs-failPost").hide();
        $("#formfeedbackInputs").show();
        $('#feedbackForm').modal({ backdrop: 'static', keyboard: false });
    }

    sendFeedbackForm = function () {

        var formData = new FormData($("form").get(0));

        $.ajax({
            type: 'POST',
            url: 'FeedbackForm/FeedbackForm',
            async: true,
            data: formData,
            dataType: 'json',
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.status == "success") {
                    showPostFeedbackFormResult("formfeedbackInputs-successPost");
                } else {
                    showPostFeedbackFormResult("formfeedbackInputs-failPost");
                }

            },
            error: function (response) {
                showPostFeedbackFormResult("formfeedbackInputs-failPost");
            }
        }).then(function (response) {
        });

    };


    showPostFeedbackFormResult = function (elementName) {
        $("#formfeedbackInputs").hide();

        $("#" + elementName).show();

        setTimeout(function() {
            $("#" + elementName).hide();
            $("#feedbackCloseBtn").click();
        }, 5000);
    }
});