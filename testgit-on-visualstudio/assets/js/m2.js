$(document).ready(function () {

    $.post("/DefaultController/getdep")

        .done(function (res) {
            console.log()

        })
        .fail(function () {

        })
        .always(function () {

        })


}
)