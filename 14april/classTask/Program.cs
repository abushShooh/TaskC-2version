

// task1
// Teacher teacher1 = new Teacher();
// Teacher teacher2 = new Teacher("John Doe", "Mathematics");
// Teacher teacher3 = new Teacher("Jane Smith", "Physics", 12);
// teacher2.SetExperience(7);
// Console.WriteLine(teacher2.Teach());
// Console.WriteLine($"Experience: {teacher2.GetExperience()}");
// Console.WriteLine(teacher3.Teach());
// Console.WriteLine($"Experience: {teacher3.GetExperience()}");

// task2
// Student student1 = new Student();
// Student student2 = new Student("Ali Ahmadov", 18);
// Student student3 = new Student("Zarina Karimova", 19, 11);
// student2.Study();
// student2.SetGrade(9);
// Console.WriteLine(student2.GetGrade());
// student3.Study();
// Console.WriteLine(student3.GetGrade());

// task3
// Patient patient = new Patient("Ivan Ivanov", 30);
// Doctor doctor = new Doctor("Petr Petrov", "Therapist", 12);
// patient.AddMedicalRecord("Flu");
// patient.AddMedicalRecord("Regular checkup");
// Console.WriteLine(doctor.TreatPatient(patient));
// Console.WriteLine(doctor.PerformMedicalExamination(patient));
// Console.WriteLine(doctor.PrescribeMedication(patient, "Ibuprofen"));
// Console.WriteLine($"Experience: {doctor.GetExperience()}");
// Console.WriteLine("Medical history:");
// foreach (string record in patient.GetMedicalHistory())
// {
//     Console.WriteLine(record);
// }

// task4
// Actor actor = new Actor("Leonardo DiCaprio", 49, "Male");
// Movie movie1 = new Movie("Inception", 2010);
// Movie movie2 = new Movie("Titanic", 1997);
// actor.AddMovie(movie1);
// actor.AddMovie(movie2);
// Console.WriteLine($"Age: {actor.GetAge()}");
// Console.WriteLine($"Gender: {actor.GetGender()}");
// Console.WriteLine("Movies played:");
// foreach (Movie movie in actor.GetMoviesPlayed())
// {
//     Console.WriteLine($"{movie.GetTitle()} ({movie.GetReleaseYear()})");
// }

public class Teacher
{
    private string fullName;
    private string subject;
    private int experience;

    public Teacher()
    {
        fullName = "";
        subject = "";
        experience = 0;
    }

    public Teacher(string name, string subject)
    {
        fullName = name;
        this.subject = subject;
        experience = 0;
    }

    public Teacher(string name, string subject, int experience)
    {
        fullName = name;
        this.subject = subject;
        this.experience = experience;
    }

    public string Teach()
    {
        return $"{fullName} is teaching {subject}.";
    }

    public void SetExperience(int years)
    {
        experience = years;
    }

    public int GetExperience()
    {
        return experience;
    }
}

public class Student
{
    private string fullName;
    private int age;
    private int grade;

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public Student()
    {
        fullName = "";
        age = 0;
        grade = 0;
    }

    public Student(string name, int age)
    {
        fullName = name;
        this.age = age;
        grade = 0;
    }

    public Student(string name, int age, int grade)
    {
        fullName = name;
        this.age = age;
        this.grade = grade;
    }

    public void Study()
    {
        Console.WriteLine($"{fullName} is studying.");
    }

    public void SetGrade(int newGrade)
    {
        grade = newGrade;
    }

    public int GetGrade()
    {
        return grade;
    }
}

public class Patient
{
    private string fullName;
    private int age;
    private List<string> medicalHistory;

    public Patient(string fullName, int age)
    {
        this.fullName = fullName;
        this.age = age;
        medicalHistory = new List<string>();
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void AddMedicalRecord(string record)
    {
        if (!string.IsNullOrWhiteSpace(record))
        {
            medicalHistory.Add(record);
        }
    }

    public List<string> GetMedicalHistory()
    {
        return new List<string>(medicalHistory);
    }
}

public class Doctor
{
    private string fullName;
    private string specialty;
    private int experience;
    private List<Patient> patients;

    public Doctor()
    {
        fullName = "";
        specialty = "";
        experience = 0;
        patients = new List<Patient>();
    }

    public Doctor(string fullName, string specialty)
    {
        this.fullName = fullName;
        this.specialty = specialty;
        experience = 0;
        patients = new List<Patient>();
    }

    public Doctor(string fullName, string specialty, int experience)
    {
        this.fullName = fullName;
        this.specialty = specialty;
        this.experience = experience;
        patients = new List<Patient>();
    }

    private void AddPatient(Patient patient)
    {
        if (patient != null && !patients.Contains(patient))
        {
            patients.Add(patient);
        }
    }

    public string TreatPatient(Patient patient)
    {
        AddPatient(patient);
        return $"{fullName}, {specialty}, treats patient {patient.GetFullName()}";
    }

    public string PerformMedicalExamination(Patient patient)
    {
        AddPatient(patient);
        return $"{fullName} performs a medical examination for patient {patient.GetFullName()}";
    }

    public string PrescribeMedication(Patient patient, string medication)
    {
        AddPatient(patient);
        return $"{fullName} prescribes {medication} to patient {patient.GetFullName()}";
    }

    public void SetExperience(int years)
    {
        experience = years;
    }

    public int GetExperience()
    {
        return experience;
    }
}

public class Movie
{
    private string title;
    private int releaseYear;

    public Movie(string title, int releaseYear)
    {
        this.title = title;
        this.releaseYear = releaseYear;
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetReleaseYear()
    {
        return releaseYear;
    }
}

public class Actor
{
    private string fullName;
    private int age;
    private string gender;
    private List<Movie> moviesPlayed;

    public Actor(string fullName, int age, string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
        moviesPlayed = new List<Movie>();
    }

    public void AddMovie(Movie movie)
    {
        if (movie != null)
        {
            moviesPlayed.Add(movie);
        }
    }

    public List<Movie> GetMoviesPlayed()
    {
        return new List<Movie>(moviesPlayed);
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGender(string gender)
    {
        this.gender = gender;
    }

    public string GetGender()
    {
        return gender;
    }
}
