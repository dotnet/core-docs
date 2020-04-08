﻿// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";
    WinJS.strictProcessing();

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    app.start();
})();

/*
function Add() {
    "use strict";

    var calculator = new Contoso.Calculator();

    var a = document.getElementById("a");
    var b = document.getElementById("b");

    document.getElementById("result").innerHTML = "Result: " + calculator.add(a.value, b.value);
}
*/

function Add() {
    "use strict";

    var calculator = new Contoso.Calculator();
    calculator.onprimenumberfound = function (ev) {
        document.getElementById("primes").innerHTML += " " + ev.target;
    };

    var a = document.getElementById("a");
    var b = document.getElementById("b");

    document.getElementById("result").innerHTML = "Result: " + calculator.add(a.value, b.value);
}