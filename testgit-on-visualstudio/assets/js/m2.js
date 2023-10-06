$(document).ready(function () {

    $.post("/Default/getdep")



        .done(function (res) {
            console.log(res)

            for (var item in res) {
                $("#department").append(

                    "<option>" + res[item].pkID + "-" + res[item].skills + "</option>"

                )
            }


        })
        .fail(function () {

        })
        .always(function () {

        });


    $("#department").change(function (event) {
        /* alert("You have Selected  :: " + $(this).val());*/
        var dep = $('#department').val();
        var dep2 = dep.split("-");

        var e2 = dep2[0];
        $("#Visit").empty();
        $("#Visit").append("<option> انتخاب نوبت</option>")


        $.post("/Default/getdoc", { e: e2 })


            .done(function (res) {





                for (var item in res) {
                    $("#doctor").empty();
                    $("#doctor").append(

                        "<option> انتخاب دکتر</option>" + "<option>" + res[item].pkID + "-" + res[item].Name + " " + res[item].Family + "</option>"

                    )
                }

            })
            .fail(function () {

            })
            .always(function () {

            })
    });


    $("#doctor").change(function (event) {

        var doc = $('#doctor').val();
        var doc2 = doc.split("-");

        var e2 = doc2[0];
        console.log("hello doc");
        $("#Visit").empty();
        $("#Visit").append("<option> انتخاب نوبت</option>")

        $.post("/Default/getVisit", { e: e2 })


            .done(function (res) {









                for (var item in res) {

                    $("#Visit").append(

                        "<option>" + res[item].pkID + " - " + res[item].PSDate + " | " + res[item].PSTime + "</option>"

                    )
                }
                
                


            })
            .fail(function () {

                $("#Visit").empty();
                $("#Visit").append("<option> نوبتی موجود نیست </option>")

            })
            .always(function () {

            });
    });














}
)