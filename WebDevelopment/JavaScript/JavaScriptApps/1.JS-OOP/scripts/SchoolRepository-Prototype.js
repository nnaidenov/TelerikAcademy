var School = {
    init: function(name, town, students) {
        this.name = name;
        this.town = town;
        this.students = students;
    }
};

var Class = {
    init: function(name, capacity, students, formTeacher) {
        this.name = name;
        this.capacity = capacity;
        this.students = students;
        this.formTeacher = formTeacher;
    },
    introduce: function() {
        var studentsList = "";
        
        for (i = 0; i < this.students.length; i++) {
            studentsList += this.students[i].introduce() + ", ";
        }
        
        var introd = "Name: " + this.name + ", Capacity: " + this.capacity + ", Students: " + studentsList + ", Form-Teacher " + this.formTeacher.introduce();
        return  introd;
    }
};

var Person = {
    init: function(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    },
    introduce: function() {
        return  "Name: " + this.firstName + " " + this.lastName + ", Age: " + this.age;
    }
};

var Student = Person.extend({
    init: function(firstName, lastName, age, grade) {
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.grade = grade;
    },
    introduce: function() {
        return  this._super.introduce() + ", Grade: " + this.grade;
    }
});

var Teacher = Person.extend({
    init: function(firstName, lastName, age, speciality) {
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.speciality = speciality;
    },
    introduce: function() {
        return this._super.introduce() + ", Speciality: " + this.speciality;
    }
});

var student1 = Object.create(Student);
student1.init("Stoyan", "Georgiev", 25, 4);

var student2 = Object.create(Student);
student2.init("Ivan", "Petrov", 28, 7);

var student3 = Object.create(Student);
student3.init("Dragan", "Ivanov", 26, 5);

var teacher1 = Object.create(Teacher);
teacher1.init("Georgi", "Georgiev", 24, "C# cources");

var teacher2 = Object.create(Teacher);
teacher2.init("Pavel", "Kolev", 27, "JS cources");

//console.log(student1.introduce());
//console.log(student2.introduce());
//console.log(teacher1.introduce());
//console.log(teacher2.introduce());

var classA = Object.create(Class);
classA.init("classA", 10, new Array(student1, student2, student3), teacher1);
//var classB = Object.create(Class);
//classB.init("classB", 2, new Array(student1, student3), teacher2);
console.log(classA.introduce());
//console.log(classB.introduce());
//var school = Object.create(School);
//school.init("Telerik", "Sofia", new Array(classA, classB));
//console.log(school.introduce());