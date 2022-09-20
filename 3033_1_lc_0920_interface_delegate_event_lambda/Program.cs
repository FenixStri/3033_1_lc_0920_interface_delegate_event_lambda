// Fenix Strickland 113437176
using _3033_1_lc_0920_interface_delegate_event_lambda;


Person p1;
p1 = new Person();
p1.name = "Fenix";
p1.age = 22;

Person p2;
p2 = new Person() { name = "Goku", age = 41};


Student stu1;
stu1 = new Student() { age = 25,name = "Vegeta", stuID = "stu114444"};


Person p3;
p3 = stu1;

p3 = new Student() { age = 19, name = "Gohan", stuID = "stu14" };

Student stu3;
stu3 = (Student) p3;

int i = Convert.ToInt32("130");

IMIS3033 mis3033Stu;
//mis3033Stu = new IMIS3033(); cannot be made a student

mis3033Stu = stu3;
double gradeDbl = mis3033Stu.FinishExercise(20);
Console.WriteLine(gradeDbl);

Student stu4;
stu4 = (Student)mis3033Stu;


Console.ReadLine();

