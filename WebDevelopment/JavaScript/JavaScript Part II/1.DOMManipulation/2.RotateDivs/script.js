function createDivs() {
    var wrapper = document.getElementById("wrapper");
    var docFragment = document.createDocumentFragment();

    for (var i = 0; i < 5; i += 1) {
        var div = document.createElement("div");
        div.style.width = "50px";
        div.style.height = "50px";
        div.style.backgroundColor = generateRandomColor();
        div.style.borderColor = generateRandomColor();
        div.style.position = "absolute";
        div.style.top = arrY[i] + "px";
        div.style.left = arrX[i] + "px";
        div.className = "moving";
        docFragment.appendChild(div);
    }

    wrapper.appendChild(docFragment);
}

function generateRandomColor() {
    var red = (Math.random() * 256) | 0;
    var green = (Math.random() * 256) | 0;
    var blue = (Math.random() * 256) | 0;

    return "rgb(" + red + "," + green + "," + blue + ")";
}

function moveDivs() {
    var position = 4;
    setInterval(function () {
        position += 1;
        if (position > 11) {
            position = 0;
        }

        for (var i = 0; i < 5; i += 1) {
            var newPosition = position - i;
            if (newPosition < 0) {
                newPosition += 12;
            }
            divs[i].style.top = arrY[newPosition] + "px";
            divs[i].style.left = arrX[newPosition] + "px";
        }
    }, 100);
}

var divs = document.getElementsByClassName("moving");

var arrX = new Array();
arrX[0] = 613;
arrX[1] = 764;
arrX[2] = 841;
arrX[3] = 874;
arrX[4] = 841;
arrX[5] = 764;
arrX[6] = 613;
arrX[7] = 465;
arrX[8] = 387;
arrX[9] = 353;
arrX[10] = 387;
arrX[11] = 465;
arrX[12] = 613;

var arrY = new Array();
arrY[0] = 147
arrY[1] = 175;
arrY[2] = 260;
arrY[3] = 387;
arrY[4] = 512;
arrY[5] = 599;
arrY[6] = 647;
arrY[7] = 599;
arrY[8] = 512;
arrY[9] = 387;
arrY[10] = 260;
arrY[11] = 175;
arrY[12] = 195;