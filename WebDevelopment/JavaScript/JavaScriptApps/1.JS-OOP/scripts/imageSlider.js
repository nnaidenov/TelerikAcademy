var Slider = {
    init: function(images, nextButton, prevButton) {
        this.images = images;
        this._currentImageIndex = 0;
        this.nextButton = nextButton;
        this.prevButton = prevButton;

        return;
    },
    creatSlider: function() {
        var self = this;

        var holder = $(document.createElement('div'));
        holder.attr('id', 'holder');

        var bigImgHolder = $(document.createElement('div'));
        bigImgHolder.attr('id', 'bigImgHolder');

        var thumbsHolder = $(document.createElement('ul'));
        thumbsHolder.attr('id', 'thumbImgHolder');

        var prevButton = $(document.createElement('button'));
        prevButton.text(this.prevButton.name);
        prevButton.attr('id', 'prev');
        prevButton.on('click', function() {
            var originalImgName = $('#bigImgHolder img');
            var prev = Button.prev(self._currentImageIndex);
            self._currentImageIndex = prev;
            originalImgName.attr('src', self.images[prev].fullSizeURL);
        });

        var nextButton = $(document.createElement('button'));
        nextButton.attr('id', 'next');
        nextButton.text(this.nextButton.name);
        nextButton.on('click', function() {
            var originalImgName = $('#bigImgHolder img');
            var next = Button.next(self._currentImageIndex, self.images.length);
            console.log(next);
            originalImgName.attr('src', self.images[next].fullSizeURL);
            self._currentImageIndex = next;
        });


        thumbsHolder.on('click', function(ev) {

            var id = $(ev.target).attr('id');
            var originalImgName = $('#bigImgHolder img');

            originalImgName.attr('src', self.images[id].fullSizeURL);
            self._currentImageIndex = id;
            console.log(self._currentImageIndex);

        });

        holder.append(bigImgHolder);
        holder.append(prevButton);
        holder.append(thumbsHolder);
        holder.append(nextButton);

        $('#wrapper').append(holder);

        return this;
    },
    viewLarg: function() {
        var self = this;
        var bigImgHolder = $('#bigImgHolder');

        var bigImg = $(document.createElement('img'));
        bigImg.attr('src', this.images[self._currentImageIndex].fullSizeURL);
        bigImgHolder.append(bigImg);

        return this;
    },
    viewThumbs: function() {

        var thumbsHolder = $('#thumbImgHolder');

        for (i = 0; i < this.images.length; i++) {
            var li = $(document.createElement('li'));
            var image = $(document.createElement('img'));
            image.attr('src', this.images[i].thumbURL);
            image.attr('name', this.images[i].title);
            image.attr('id', i);
            li.append(image);
            thumbsHolder.append(li);
        }

        return this;
    }
};

var Image = {
    init: function(title, fullSizeURL, thumbURL) {
        this.title = title;
        this.fullSizeURL = fullSizeURL;
        this.thumbURL = thumbURL;
    }
};

var Button = {
    init: function(name) {
        this.name = name;
    },
    prev: function(currentIndex) {
        if (currentIndex > 0) {
            return parseInt(currentIndex) - 1;
        }
        else {
            return currentIndex;
        }
    },
    next: function(currentIndex, lenght) {
        if (currentIndex < lenght - 1) {
            return parseInt(currentIndex) + 1;
        }
        else {
            return currentIndex;
        }
    }
};

var image = Object.create(Image);
image.init('pile', 'img/bigOne.jpg', 'img/smallOne.png');
var image2 = Object.create(Image);
image2.init('kuche', 'img/bigTwo.jpg', 'img/smallTwo.png');
var image3 = Object.create(Image);
image3.init('riba', 'img/bigThree.jpg', 'img/smallThree.png');

var nextButton = Object.create(Button);
nextButton.init('next');
var prevButton = Object.create(Button);
prevButton.init('prev');

var slider = Object.create(Slider);
slider.init(new Array(image, image2, image3), nextButton, prevButton);
slider.creatSlider().viewLarg().viewThumbs();