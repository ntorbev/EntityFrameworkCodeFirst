         $("#submit").on('click', function (ev) {
               ev.stopPropagation();
               ev.preventDefault();
               var user = document.getElementById("user").value;
               var pass = document.getElementById("pass").value;
               var result = localStorage[user];
               //alert(result);
               if (result === pass) {
                   clearHtml();
                   getNewView();
               } else {
                   $(".error").css("display", "block");
               }
           });
           initDatabase();
           function initDatabase() {
               // set username and password
               var data = [{ "pesho": "secret" }, { "sasho": "123" }, { "mimi": "qwe" }];
               for (obj in data) {
                   for (key in data[obj]) {
                       //console.log(key + " " + data[obj][key]);
                       localStorage.setItem(key, data[obj][key]);
                   }        
               }
           }
           function clearHtml() {
               $("#wrapper").empty();
           }
           function getNewView() {
               //append new html here
               $("#wrapper").append("<p>Create new view here</p>");
           }