var Person = Class.create({
    init: function(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    },
    introduce: function() {
        return  "Name: " + this.firstName + " " + this.lastName + ", Age: " + this.age;
    }
});

var Student = Class.create({
    init: function(firstName, lastName, age, grade) {
        this._super = new this._super(arguments);
        this._super.init(firstName, lastName, age);
        this.grade = grade;
    },
    introduce: function() {
        return this._super.introduce() + ", grade: " + this.grade;
    }
});

Student.inherit(Person);

var Teacher = Class.create({
    init: function(firstName, lastName, age, speciality) {
        this._super = new this._super(arguments);
        this._super.init(firstName, lastName, age);
        this.speciality = speciality;
    },
    introduce: function() {
        return this._super.introduce() + ", Speciality: " + this.speciality;
    }
});

Teacher.inherit(Person);

var School = Class.create({
    init: function(name, town, students) {
        this.name = name;
        this.town = town;
        this.students = students;
    }
});

var Class = Class.create({
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
});

var student1 = new Student("Stoyan", "Georgiev", 25, 4);
var student2 = new Student("Ivan", "Petrov", 28, 7);
var student3 = new Student("Dragan", "Ivanov", 26, 5);
var teacher1 = new Teacher("Georgi", "Georgiev", 24, "C# cources");
var teacher2 = new Teacher("Pavel", "Kolev", 27, "JS cources");
console.log(student1.introduce());
console.log(student2.introduce());
console.log(teacher1.introduce());
console.log(teacher2.introduce());

var classA = new Class("classA", 10, new Array(student1, student2, student3), teacher1);
var classB = new Class("classB", 2, new Array(student1, student3), teacher2);
console.log(classA.introduce());
console.log(classB.introduce());
var school = new School("Telerik", "Sofia", new Array(classA, classB));