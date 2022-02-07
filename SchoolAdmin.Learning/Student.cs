namespace SchoolAdmin.Learning {
    ///<summary>
    ///Provides a set of properties that represents a student
    ///</summary>
    class Student {
        private readonly int _regNumber;
        private readonly string _studentName;

        public string Level { get; set; } = default!;

        public int RegNumber { get {return _regNumber;} }
        public string StudentName { get {return _studentName;} }

        ///<summary>
        /// Enables instantiation of a student object given a reg number and a name
        ///</summary>
        public Student(int regNumber, string studentName)
        {
            _regNumber = regNumber;
            _studentName = studentName;
        }

        public void Learn() {
            Console.WriteLine("I'm Learning....");
        }
    }
}

// A Student class with the following features:
// Properties: RegNumber (int, readonly), Name (string, readonly), Level (string)
// Methods: Learn()
// It should have a constructor that takes in the student’s registration number and full name as parameters.
// It should store both values in private fields, hidden from other classes.
// It should expose these values via the public properties, in readonly form.
// Put the Student class in a SchoolAdmin.Learning namespace.