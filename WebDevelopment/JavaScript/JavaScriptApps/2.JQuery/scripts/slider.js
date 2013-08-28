var Slider = {
    init: function(content, time, nextButton, prevButton) {
        this.slideContent = content;
        this._currentSlideIndex = 0;
        this.nextButton = nextButton;
        this.prevButton = prevButton;
        this.time = time;

        return;
    },
    creatSlider: function() {
        var self = this;

        var ticker = setInterval(function() {
            console.log('a');
            nextButton.click();
        }, self.time * 1000);

        var holder = $(document.createElement('div'));
        holder.attr('id', 'holder');

        var holderContent = $(document.createElement('div'));
        holderContent.attr('id', 'holderContent');

        var prevButton = $(document.createElement('button'));
        prevButton.text(this.prevButton.name);
        prevButton.attr('id', 'prev');
        prevButton.on('click', function() {
            var prev = Button.prev(self._currentSlideIndex);
            self._currentSlideIndex = prev;
            self.viewSlide(prev);
        });

        var nextButton = $(document.createElement('button'));
        nextButton.attr('id', 'next');
        nextButton.text(this.nextButton.name);
        nextButton.on('click', function() {
            var next = Button.next(self._currentSlideIndex, self.slideContent.length);
            self._currentSlideIndex = next;
            self.viewSlide(next);
        });

        holder.append(prevButton);
        holder.append(nextButton);
        holder.append(holderContent);

        $('#wrapper').append(holder);

        return this;
    },
    viewSlide: function(indexOfSlide) {

        $('#holderContent').html('');
        var index = parseInt(indexOfSlide) || 0;

        var slideTitle = this.slideContent[index].title;
        var slideContent = this.slideContent[index].content;

        var h1 = $(document.createElement('h1'));
        h1.attr('class', 'title');
        h1.text(slideTitle);

        var div = $(document.createElement('div'));
        div.attr('class', 'conteiner');
        div.html(slideContent);

        $('#holderContent').append(h1);
        $('#holderContent').append(div);

        return this;
    }
};

var Slide = {
    init: function(title, content) {
        this.title = title;
        this.content = content;
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

var nextButton = Object.create(Button);
nextButton.init('next');
var prevButton = Object.create(Button);
prevButton.init('prev');

var slide = Object.create(Slide);
slide.init('First Slide </br>', '<ul><li>list item</li><li><a href="google.com">list item</a></li><li>list item</li></ul>');
var slide2 = Object.create(Slide);
slide2.init('Second Slide </br>', '<ul><li>list item 2</li><li>list item 2</li><li>list item 2</li></ul>');
var slide3 = Object.create(Slide);
slide3.init('Image', '<img src="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQkIrvGc4oWwr9xj60_YAMEXD06isd_PF__OXMHmWpGmeoGLoiOxg"/>');

var slider = Object.create(Slider);
slider.init(new Array(slide, slide2, slide3), 5, nextButton, prevButton);
slider.creatSlider().viewSlide();