var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net",
    ".net", "css", "wordpress", "xaml", "js", "http", "web", "web",
    "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "wp", "wp",
    "javascript", "js", "cms", "html", "javascript", "http", "http",
    "http", "http", "CMS", "CMS", "CMS"];

function generateTagCloud(tags, min, max) {
    var smallTags = new Array();
    for (var i = 0, l = tags.length; i < l; i+=1) {
        smallTags[i] = tags[i].toLowerCase();
    }

    var newTagArr = new Array();
    var counter = new Array();
    for (var k = 0; k < smallTags.length; k++) {
        counter[k] = 0;
    }
    
    for (var i = 0; i < smallTags.length; i++) {
        var isReplace = false;
        for (var j = 0; j < newTagArr.length; j++) {
            if(newTagArr[j] == smallTags[i]) {
                counter[j] += 1;
                isReplace = true;
            }
        }
        if (!isReplace) {
            newTagArr.push(smallTags[i]);
        }
    }

    var maxReplace = Math.max.apply(Math, counter);
    var minReplace = Math.min.apply(Math, counter);
    var countTags = newTagArr.length;
    var sizer = Math.floor((max - min) / (maxReplace - minReplace))

    var docFragment = document.createDocumentFragment();
    for (var i = 0; i < newTagArr.length; i++) {
        var actualSize = min + sizer * counter[i];
        var p = document.createElement("p");
        p.className = "cloud";
        p.style.fontSize = actualSize + "px";
        p.innerHTML = newTagArr[i];
        docFragment.appendChild(p);
    }

    var wrapper = document.getElementById("wrapper");
    wrapper.appendChild(docFragment);
}

