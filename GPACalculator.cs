﻿string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

decimal course1Credit = 3;
decimal course2Credit = 3;
decimal course3Credit = 4;
decimal course4Credit = 4;
decimal course5Credit = 3;

decimal grade1 = 4;
decimal grade2 = 3;
decimal grade3 = 3;
decimal grade4 = 3;
decimal grade5 = 4;
decimal GPA1 = grade1 * course1Credit;
decimal GPA2 = grade2 * course2Credit;
decimal GPA3 = grade3 * course3Credit;
decimal GPA4 = grade4 * course4Credit;
decimal GPA5 = grade5 * course5Credit;
decimal finalGPA =(GPA1 + GPA2 + GPA3 + GPA4 + GPA5) / (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);
int leadingDigit = (int) finalGPA; 
int firstDigit = (int) (finalGPA * 10) % 10;
int secondDigit = (int) (finalGPA * 100 ) % 10;


Console.WriteLine("Student: " + studentName);
Console.WriteLine($"\nCourse\t\t\t" + "Grade\t" + "Credit Hours\t");
Console.WriteLine($"{course1Name}\t\t" + $"{grade1}\t\t" + $"{course1Credit}\t");
Console.WriteLine($"{course2Name}\t\t" + $"{grade2}\t\t" + $"{course2Credit}\t");
Console.WriteLine($"{course3Name}\t\t" + $"{grade3}\t\t" + $"{course3Credit}\t");
Console.WriteLine($"{course4Name}\t" + $"{grade4}\t\t" + $"{course4Credit}\t");
Console.WriteLine($"{course5Name}\t\t" + $"{grade5}\t\t" + $"{course5Credit}\t\n");
Console.WriteLine($"Final GPA: \t" + $"{leadingDigit}.{firstDigit}{secondDigit}");