"using strict";

var MyScript = {
    init: function () {
        var textBox = document.getElementById("Amount");

        textBox.focus();
        textBox.select();
    }
};

window.onload = MyScript.init;