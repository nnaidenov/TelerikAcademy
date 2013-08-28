function generateDivs() {
    var wrapper = document.getElementById("wrapper");
    var count = document.getElementById("numberDivs").value | 0;

    for (var i = 0; i < count; i++) {
        var div = document.createElement("div");
        var strong = document.createElement("strong");
        strong.innerHTML = strong.innerHTML + "div"

        div.style.width = randomSize(20, 100);
        div.style.height = randomSize(20, 100);
        div.style.borderColor = randomColor();
        div.style.borderWidth = randomSize(1, 20);
        div.style.borderStyle = "solid";
        div.style.borderRadius = randomSize(5, 20);
        div.style.backgroundColor = randomColor();
        div.style.color = randomColor();

        div.style.position = "absolute";
        div.style.top = parseInt(Math.random() * (screen.height - 140)) + "px";
        div.style.left = parseInt(Math.random() * (screen.width - 140)) + "px";
        //div.style.border = "3px solid " + randomColor();

        wrapper.appendChild(div);
        div.appendChild(strong);
    }
}

function randomSize(min, max) {
    var size = Math.floor(Math.random() * (max - min + 1)) + min;
    return size + "px";
}

function randomColor() {
    var red = (Math.random() * 256) | 0;
    var green = (Math.random() * 256) | 0;
    var blue = (Math.random() * 256) | 0;

    var color = "rgb(" + red + "," + green + "," + blue + ")";

    return color;
}