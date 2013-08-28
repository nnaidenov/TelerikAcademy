var controls = (function() {

	function Grind(selector) {
	    var rowsList = [];
	    var headerList = [];
	    var gridItem = document.querySelector(selector);
	    var table = document.createElement("table");

      gridItem.addEventListener("click",
    function(ev) {
      if (!ev) {
        ev = window.event;
      }
      ev.stopPropagation();
      ev.preventDefault();
      var clickedItem = ev.target;
      if (!(clickedItem instanceof HTMLTableCellElement)) {
        return;
      }

      var nextRow = ev.target.parentNode.nextElementSibling;

      if (nextRow.children[0].toString() == "[object HTMLTableElement]") {
        var hereIsTable = nextRow.children[0];
        if (hereIsTable.style.display === "none") {
          hereIsTable.style.display = "block";
        } else {
          hereIsTable.style.display = "none";
        }
      };
    }, false);

	    this.addRow = function() {
	    	var args = arguments;

	        var newRow = new Row(args);
	        var roww = newRow.addRow();
	        rowsList.push(roww);

	        return newRow;
      	};

      	this.addHeader = function() {
	    	var args = arguments;

	        var newRow = new Row(args);
	        var roww = newRow.addRow();
	        headerList.push(roww);

	        return newRow;
      	};


      	this.render = function() {
      		// console.log(rowsList);
			while (gridItem.firstChild) {
				gridItem.removeChild(gridItem.firstChild);
			}

      		while (table.firstChild) {
	        	table.removeChild(table.firstChild);
	      	}

	      	for (var i = 0; i < headerList.length; i++) {
      			var oneRow = headerList[i];
      			var tableRow = document.createElement("tr");
      			for (var j = 0; j < oneRow.length; j++) {
      					var tableCell = document.createElement("th");
      					tableCell.innerHTML = oneRow[j].cell[0].name;
      					tableRow.appendChild(tableCell);
      			}
      			table.appendChild(tableRow);
      			
      		}
      		gridItem.appendChild(table);
	      	
      		for (var i = 0; i < rowsList.length; i++) {
      			var oneRow = rowsList[i];
      			var tableRow = document.createElement("tr");
      			for (var j = 0; j < oneRow.length; j++) {
      					var tableCell = document.createElement("td");
      					tableCell.innerHTML = oneRow[j].cell[0].name;
      					tableRow.appendChild(tableCell);
      			}
      			table.appendChild(tableRow);
      			
      		}
      		gridItem.appendChild(table);

      		return this;
      	}
    };

    function Row(arguments) {
    	var row = [];
    	var arg = arguments;
  		
    	this.addRow = function() {
    		
    		var newRow = new Row();

			for (var i = 0; i < arg.length; i++) {
				var newCell = new Cell(arg[i]);
				var colll = newCell.addRow();
				// row.push(colll);
				row.push( { cell: colll } );

			}

	      	return row;
	      }

        this.getNestedGridView = function() {
          var row = document.createElement("tr");
          var grid = new Grind("#grid-holder tr:last-child");

          return grid;
        }
	    };


	 
    function Cell(args) {
    	var cells = [];

    	this.addRow = function() {
        var tagsToReplace = {
    '&': '&amp;',
    '<': '&lt;',
    '>': '&gt;'
};

function replaceTag(tag) {
    return tagsToReplace[tag] || tag;
}

function safe_tags_replace(str) {
    return str.replace(/[&<>]/g, replaceTag);
}
var escaping = safe_tags_replace(args);
	      	var newCell = new Cell(escaping);
	      	cells.push( { name: escaping } );
	      	return cells;
    	};

      	
    }

    return {
	    getGridView: function(selector) {
		      return new Grind(selector);
		    }
  	}

}());