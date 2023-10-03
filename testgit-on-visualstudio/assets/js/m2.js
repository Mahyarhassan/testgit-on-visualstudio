$(document).ready(function () {

    $.post("/Default/getdep")

        .done(function (res) {

            for (var item in res) { 
            $("#department").apend(

                "<option>" + res[item].pkID + res[item].skill + "</option>"

            )}
           

        })
        .fail(function () {

        })
        .always(function () {

        });


    $.post("/Default/getdoc")

        .done(function (res) {

            for (var item in res) {
                $("#doctors").apend(

                    "<option>" + res[item].pkID + res[item].Name + + res[item].Family + "</option>"

                )
            }

        })
        .fail(function () {

        })
        .always(function () {

        })






}
)