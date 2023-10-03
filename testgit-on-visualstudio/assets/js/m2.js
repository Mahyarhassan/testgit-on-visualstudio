$(document).ready(function () {

    $.post("/Default/getdep")

    

        .done(function (res) {
            console.log(res)

            for (var item in res) { 
            $("#department").append(

                "<option>" + res[item].pkID + res[item].skills + "</option>"

            )}
           

        })
        .fail(function () {

        })
        .always(function () {

        });


    $.post("/Default/getdoc")
    

        .done(function (res) {
            console.log(res)

            //for (var item in res) {
            //    $("#doctor").append(

            //        "<option>" + res[item].pkID + res[item].Name +" " + res[item].Family + "</option>"

            //    )
            //}

        })
        .fail(function () {

        })
        .always(function () {

        })






}
)