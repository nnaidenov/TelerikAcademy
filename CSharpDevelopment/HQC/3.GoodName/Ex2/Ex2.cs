namespace Ex2
{
    enum Sex { male, female };
    class Human
    {
        class Person
        {
            public Sex sex { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }

        //Personal Identification Number => PIN
        public void MakePerson(int PIN)
        {
            Person newPerson = new Person();
            newPerson.age = PIN;
            if (PIN % 2 == 0)
            {
                newPerson.name = "Батката";
                newPerson.sex = Sex.male;
            }
            else
            {
                newPerson.name = "Мацето";
                newPerson.sex = Sex.female;
            }
        }
    }
}
