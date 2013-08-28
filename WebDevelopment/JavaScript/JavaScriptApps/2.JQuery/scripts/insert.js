$.prototype.afterElement = function (newElement) {
    var element = $('<' + newElement + '/>');

    var selectedElement = $(this).attr('data', 'jSelected');

    var newHTML = '';
    
    for (i = 0; i < selectedElement.parent().children().length; i++) {

        var currElement = selectedElement.parent().children()[i];
        if ($(currElement).attr('data') === 'jSelected') {
            newHTML += currElement.outerHTML;
            newHTML += element[0].outerHTML;
            continue;
        }

        newHTML += currElement.outerHTML;
    }

    selectedElement.parent().html(newHTML);
    
    return this;
};

$.prototype.beforeElement = function (newElement) {
    var element = $('<' + newElement + '/>');

    var selectedElement = $(this).attr('data', 'jSelected');

    var newHTML = '';
    console.log(selectedElement.parent().children().length);
    for (i = 0; i < selectedElement.parent().children().length; i++) {
        
        var currElement = selectedElement.parent().children()[i];
        if ($(currElement).attr('data') === 'jSelected') {
            newHTML += element[0].outerHTML;
            newHTML += currElement.outerHTML;
            continue;
        }

        newHTML += currElement.outerHTML;
    }

    selectedElement.parent().html(newHTML);
    
    return this;
};