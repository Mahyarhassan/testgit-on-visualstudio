$(document).ready(function () {

    $.post("/Default/getdep")

    

        .done(function (res) {
            console.log(res)

            for (var item in res) { 
            $("#department").append(

                "<option>" + res[item].pkID + "-" + res[item].skills + "</option>"

            )}
           

        })
        .fail(function () {

        })
        .always(function () {

        });


    $("#department").change(function (event) {
        /* alert("You have Selected  :: " + $(this).val());*/
        var dep = $('#department').val();
        var dep2 = dep.split("-")

        var e2 = dep2[0];
        
        $.post("/Default/getdoc", { e: e2 })


            .done(function (res) {
                




                for (var item in res) {
                    $("#doctor").empty();
                    $("#doctor").append(

                        "<option> انتخاب دکتر</option>"+"<option>" + res[item].pkID + res[item].Name + " " + res[item].Family + "</option>"

                    )
                }

            })
            .fail(function () {

            })
            .always(function () {

            })

       
    });
    


   






}
)