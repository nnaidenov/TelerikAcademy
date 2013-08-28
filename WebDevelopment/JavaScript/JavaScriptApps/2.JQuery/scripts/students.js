var Student = {
    init: function(firstName, lastName, grade) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.grade = grade;

        return this;
    },
    render: function(table) {
        var tr = $(document.createElement('tr'));

        var firstName = $(document.createElement('td'));
        firstName.text(this.firstName);

        var lastName = $(document.createElement('td'));
        lastName.text(this.lastName);

        var grade = $(document.createElement('td'));
        grade.text(this.grade);

        tr.append(firstName);
        tr.append(lastName);
        tr.append(grade);

        table.append(tr);

        return this;
    }
};

var StudentTable = {
    init: function(students) {
        this.students = students;

        return this;
    },
    create: function() {
        var holder = $('#wrapper');
        this.table = $(document.createElement('table'));

        var tHead = $(document.createElement('tr'));

        var firstName = $(document.createElement('td'));
        firstName.text('First name');

        var lastName = $(document.createElement('td'));
        lastName.text('Last name');

        var grade = $(document.createElement('td'));
        grade.text('Grade');

        tHead.append(firstName);
        tHead.append(lastName);
        tHead.append(grade);

        this.table.append(tHead);
        holder.append(this.table);

        return this;
    },
    render: function() {
        for (i = 0; i < this.students.length; i++) {
            this.students[i].render(this.table);
        }

        return this;
    }
};

studentOne = Object.create(Student);
studentOne.init('Peter', 'Ivanov', 3);
studentTwo = Object.create(Student);
studentTwo.init('Milena', 'Grigorova', 6);
studentThree = Object.create(Student);
studentThree.init('Gergana', 'Borisova', 12);
studentFour = Object.create(Student);
studentFour.init('Boyko', 'Petrov', 7);

var tableOfStudents = Object.create(StudentTable);
tableOfStudents.init(new Array(studentOne, studentTwo, studentThree, studentFour)).create().render();