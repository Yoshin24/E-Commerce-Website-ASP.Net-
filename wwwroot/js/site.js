﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var counter = 1;
setInterval(funtion()){
    document.getElementById("radio" + counter).checked = true;
    counter++;
    if (counter > 4) {
        counter = 1;
    }
}, 5000);