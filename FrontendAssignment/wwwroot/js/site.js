
$(document).ready(function () {

    $(".mobileExpandContainer").on("click", function () {
        $(this).toggleClass("open");
    });

    var detailsheight = $(".details-description").css("height");

    if (parseInt(detailsheight) > 100) {
        $(".details-description").addClass("closed");
    }

    $(".details-description.closed").on("click", function(){
        $(this).toggleClass("expanded");
    });

});
