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

        var e = dep2[0];
        alert(e);


        $.post("/Default/getdoc", { e })


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

        //$.ajax({
        //    type: "POST",
        //    url: "/person/create",
        //    dataType: "json",
        //    contentType: "application/json; charset=utf-8",
        //    data: jsonData,
        //    success: function (result) {
        //        console.log(result); //log to the console to see whether it worked
        //    },
        //    error: function (error) {
        //        alert("There was an error posting the data to the server: " + error.responseText);
        //    }
        //});




        
    });
    


   






}
)