"using strict";

var MyScript = {
    init: function () {
        var textBox = document.getElementById("Guess");

        textBox.focus();
        textBox.select();
    }
};

window.onload = MyScript.init;