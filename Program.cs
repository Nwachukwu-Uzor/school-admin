using SchoolAdmin.Learning;
using SchoolAdmin.Teaching;



namespace SchoolAdmin
{
    class Program {
        static void Main(string[] args) {
            Teacher teacher1 = new Teacher(1, "Phillips"){
                Subject = "C# .Net",
                Learners = new string[] {"Ifunanya", "Emeka", "Henry", "Raphael", "Uzor"}
            };
           
           Student student1 = new Student(1001, "David") {
               Level = "Beginner",
           };

           Console.WriteLine($"Staff ID: {teacher1.StaffID}\nName: {teacher1.TeacherName}\nSubject(s): {teacher1.Subject}");

           foreach (string learner in teacher1.Learners) {
               Console.WriteLine(learner);
           }

           Console.WriteLine("\n\n");
           Console.WriteLine($"Reg No.: {student1.RegNumber}\nName: {student1.StudentName}\nLevel: {student1.Level}");

           if (Array.IndexOf(teacher1.Learners, student1.StudentName) > -1 )
            Console.WriteLine($"{student1.StudentName} is a student of {teacher1.TeacherName}");
           else
            Console.WriteLine($"{student1.StudentName} is a not student of {teacher1.TeacherName}");
        }
    }
}

/*
    Import the SchoolAdmin.Teaching namespace.
    Import the SchoolAdmin.Learning namespace.
    Declare a variable of type Teacher then assign it an instance of the Teacher class.
    Set the Subject property to a suitable value.
    Set the Learners property to an array of learner names.
    Declare a variable of type Student then assign it an instance of the Student class.
    Set the Level property to a suitable value.
    Write the following to the console, for the teacher you created in task 3:
    Their staff number and name
    The subject they teach
    The number of learners they were assigned
    The names of their assigned learners, one per line.
    Write the following to the console, for the student you created in task 4:
    Their registration number and name
    Their current level
    Check if the student created in task 4 is one of those assigned to the teacher created in task 3. Display the result on the console.
*/
