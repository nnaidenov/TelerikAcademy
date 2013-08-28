var FavoriteSitesBar = Class.create({
    init: function(urls, folders) {
        this.urls = urls;
        this.folders = folders;
    },
    display: function() {
        var holder = $(document.createElement('div'));


        for (var i = 0; i < this.urls.length; i++) {
            var div = $(document.createElement('div'));
            div.append(this.urls[i].displayUrl(div));
            holder.append(div);
        }

        for (var i = 0; i < this.folders.length; i++) {
            var div = $(document.createElement('div'));
            div.text(this.folders[i].title);
            div.append(this.folders[i].displayFolder(div));
            holder.append(div);
        }

        $('#wrapper').append(holder);
    }
});

var Folder = Class.create({
    init: function(title, urls) {
        this.title = title;
        this.urls = urls;
    },
    displayFolder: function(div) {
        var ul = $(document.createElement('ul'));
        for (var i = 0; i < this.urls.length; i++) {
            var li = $(document.createElement('li'));
            li.append(this.urls[i].displayUrl(li));
            ul.append(li);
        }
        div.append(ul);
    }
});

var Url = Class.create({
    init: function(title, url) {
        this.title = title;
        this.url = url;
    },
    displayUrl: function(li) {
        var a = $(document.createElement('a'));
        a.attr('href', this.url);
        a.text(this.title);
        li.append(a);
    }
});


var academyOfficial = new Url("Telerik Academy", "http://academy.telerik.com/");
var studentSystem = new Url("Telerik Academy Student System", "http://telerikacademy.com/");
var forum = new Url("Telerik Academy Forums", "http://forums.academy.telerik.com/");

var nakovBlog = new Url("Nakov blog", "http://www.nakov.com/");
var nikiBlog = new Url("Niki blog", "http://nikolay.it/index.html");
var donchoBlog = new Url("Doncho blog", "http://minkov.it/");
var joroBlog = new Url("Joro blog", "http://itgeorge.net/");
var trainersBlogs = new Folder("Folder 1", new Array(nakovBlog, nikiBlog, donchoBlog, joroBlog));

var dataStructuresAndAlgorithms =
        new Url("Data structures and algorithms", "http://telerikacademy.com/Courses/Courses/Details/89");
var jsApplications =
        new Url("JavaScript applications", "http://telerikacademy.com/Courses/Courses/Details/87");
var currentCourses = new Folder("Folder 2", new Array(dataStructuresAndAlgorithms, jsApplications));

var academyFavoriteSitesBar = new FavoriteSitesBar(
        new Array(academyOfficial, studentSystem, forum),
        new Array(trainersBlogs, currentCourses));
academyFavoriteSitesBar.display();