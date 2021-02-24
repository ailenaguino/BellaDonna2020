$(document).ready(function () {
    var serviceImg = ".service-img";

    $(serviceImg).hover(
        function () { hoverImagenServicio(this) },
        function () { saleDeHoverImagenServicio(this) });

    function hoverImagenServicio(imagen) {
        $(imagen).find("img").animate({ opacity: '0.5' })
        $(imagen).find("p").show("slow");
        $(imagen).find("img").addClass("hoverImagen")

    }

    function saleDeHoverImagenServicio(imagen) {
        $(imagen).find("img").animate({ opacity: '1.0' })
        $(imagen).find("p").hide("slow");
        $(".service-img").css("box-shadow", "")
        $(imagen).find("img").removeClass("hoverImagen")
    }

    $('#carousel-index').slick({
        dots: true,
        arrows: true
    });
});