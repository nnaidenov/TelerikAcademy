var body = $('body');
var colorPicker = $('input[name=color]');

$('form').on('change', function() {
    var color = colorPicker.val();
    body.css('background', color);
});