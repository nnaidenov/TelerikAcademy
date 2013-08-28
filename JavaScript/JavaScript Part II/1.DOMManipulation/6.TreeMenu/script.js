var li = document.getElementsByTagName("li");

for (var i = 0, length = li.length; i < length; i++) {
    if (li[i] instanceof HTMLElement) {
        li[i].addEventListener("click", onDisplay, false);
        li[i].style.listStyleImage = "url('images/right.png')";
    };

    if (li[i].childNodes[1] == undefined) {
        li[i].style.listStyleImage = "url('images/none.png')";
    }
}

function onDisplay() {

    if (this.childNodes[1] instanceof HTMLUListElement) {
        if (this.childNodes[1].style.display == 'none') {
            this.childNodes[1].style.display = 'block';
            this.style.listStyleImage = "url('images/down.png')";
        }
        else {
            this.childNodes[1].style.display = 'none';
            this.style.listStyleImage = "url('images/right.png')";
        }
    }

    if (!e) {
        var e = window.event;
    }

    e.cancelBubble = true;
    if (e.stopPropagation) e.stopPropagation();
}