// PROPERTIES - int staffId, string name, ssubject(s), learners

namespace SchoolAdmin.Teaching {
    ///<summary>
    ///Provides a set of properties that represents a teacher
    ///</summary>
    class Teacher {

        private int _staffID;

        private string _teacherName;

        public int StaffID { get { return _staffID; } }

        // optionally
        // public int StaffID => _staffID;

        public string TeacherName { get { return _teacherName; } }

        public string Subject { get; set; } = default!;

        public string[] Learners {get; set; } = default!;

        ///<summary>
        /// Enables instantiation of a Teacher object given a staff ID and a name
        ///</summary>
        public Teacher (int staffID, string teacherName)  {
            _staffID = staffID;
            _teacherName = teacherName;
        }

        public void Teach() {
            Console.WriteLine("I'm teaching a class now.");
        }
    }
}

// A Teacher class with the following features:
// Properties: StaffId (int, readonly), Name (string, readonly), Subject (string), Learners (string array)
// Methods: Teach()
// It should have a constructor that takes in the teacher’s ID number and full name as parameters.
// It should store both values in private fields, hidden from other classes.
// It should expose these values via the public properties, in readonly form.
// Put the Teacher class in a SchoolAdmin.Teaching namespace.