"use strict";

function deleteDrink(id) {

    $.get("Delete/" + id, function (data, status) {

        console.log("Data: " + data + "\nStatus: " + status);

    })
    .done(function () {
        $("#drinkItemId" + id).remove();
    })
    .fail(function () {
        console.log("error");
    });
}

function createDrink() {
    $.post("Create",                            //url
        {                                      //data 
            Name: $("#drinkName").val() ,
            Volume: $("#drinkVolume").val(),
            Alcoholic: false,
            Carbonated: false
        }
    , function (data, status) {                 //respons from server

        console.log("Data: " + data + "\nStatus: " + status);

        $("#drinkList").append(data);

    })
    .done(function () {                         //what to do if it was a sucsses
        $("#drinkName").val("");
        $("#drinkVolume").val("");
    })
        .fail(function () {                         //what to do if it was a error
        console.log("create error");
    });
}