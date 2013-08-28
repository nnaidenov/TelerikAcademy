if (!document.querySelector || !document.querySelectorAll) {
    document.querySelectorAll = function (selector) {
        var selectorText = selector.substring(1);

        if (selector.indexOf('#') === 0) {
            console.log(selectorText);
            return document.getElementById(selectorText);
        }
        else if (selector.indexOf('.') === 0) {
            console.log(selectorText);
            return document.getElementsByClassName(selectorText);
        }
        
    }

    document.querySelector = function (selector) {
        var selectorText = selector.substring(1);

        if (selector.indexOf('#') === 0) {
            console.log(selectorText);
            return document.getElementById(selectorText);
        }
        else if (selector.indexOf('.') === 0) {
            console.log(selectorText);
            return document.getElementsByClassName(selectorText)[0];
        }
    }
}