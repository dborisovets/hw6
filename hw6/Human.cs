namespace ClassLibrary_Human
{

    public class Human
    {
        private string _name;
        public string _lastName;
        public string _gender;
        public int _age;
        public string _dateOfBirth;
        public string _marriageStatus;
        public string _numberOfChildren;
        public string _education;

        public Human(string name, string lastName, string gender, int age,
        string dateOfBirth, string marriageStatus, string numberOfChildren, string education)
        {
            this._name = name;
            this._lastName = lastName;
            this._gender = gender;
            this._age = age;
            this._dateOfBirth = dateOfBirth;
            this._marriageStatus = marriageStatus;
            this._numberOfChildren = numberOfChildren;
            this._education = education;
        }

        protected Human(string name)
        {
            this._name = name;
        }

        public Human() { }

        public Human(string name, string lastName, string gender, int age)
        {
            this._name = name;
            this._lastName = lastName;
            this._gender = gender;
            this._age = age;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string DateOfBirth { get; set; }

        public string MarriageStatus { get; set; }

        public string NumberOfChildren { get; set; }

        public string Education { get; set; }

        public virtual void PrintShortInfo() => Console.WriteLine($"Name: {_name} age: {_age}");

        public void PrintSomeInfo() => Console.WriteLine($"Name: {_name} last_name: {_lastName} gender:{_gender} age: {_age} ");

    }

}
