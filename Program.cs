using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Student Exercises");

            Exercise Heist = new Exercise () {
                ExerciseLanguage = "C#",
                ExerciseName = "Heist"

            };
            Exercise Millionaires = new Exercise () {
                ExerciseLanguage = "C#",
                ExerciseName = "Millionaires"

            };
            Exercise Kennel = new Exercise () {
                ExerciseLanguage = "React",
                ExerciseName = "Kennel"

            };
            Exercise KandyKorner = new Exercise () {
                ExerciseLanguage = "React",
                ExerciseName = "Kandy Korner"

            };
            Student Rose = new Student () {
                FirstName = "Rose",
                LastName = "Wisotzky",
                SlackHandle = "kielbossanova",
            };
            Student Mo = new Student () {
                FirstName = "Mo",
                LastName = "Silvera",
                SlackHandle = "momospaghettio",
            };
            Student Leah = new Student () {
                FirstName = "Leah",
                LastName = "Hoefling",
                SlackHandle = "splant",
            };
            Student Jenna = new Student () {
                FirstName = "Jenna",
                LastName = "Solis",
                SlackHandle = "cultleader55",
            };
            Cohort C37 = new Cohort () {
                CohortName = "Day Cohort 37"
            };
            Cohort C36 = new Cohort () {
                CohortName = "Day Cohort 36"
            };
            Cohort C38 = new Cohort () {
                CohortName = "Day Cohort 38"
            };
            Cohort C39 = new Cohort () {
                CohortName = "Day Cohort 39"
            };
            Instructor Dwayne = new Instructor () {
                FirstName = "Dwayne",
                LastName = "The Rock Johnson",
                SlackHandle = "therock",
                Specialty = "Bein' buff as hell"
            };
            Instructor Vin = new Instructor () {
                FirstName = "Vin",
                LastName = "Diesel",
                SlackHandle = "vinny",
                Specialty = "Bein' buff as hell"
            };
            Instructor Hulk = new Instructor () {
                FirstName = "Hulk",
                LastName = "Hogan",
                SlackHandle = "hulkhogan",
                Specialty = "Bein' buff as hell"
            };
            //Adding students to cohorts -- Must account for both entities 
            C37.Students.Add (Rose);
            Rose.Cohort = C37;
            C37.Students.Add (Mo);
            Mo.Cohort = C37;
            C37.Students.Add (Leah);
            Leah.Cohort = C37;
            C37.Students.Add (Jenna);
            Jenna.Cohort = C37;

            //Assiging instructors to Cohorts
            C37.Instructors.Add (Vin);
            Vin.Cohort = C37;
            C37.Instructors.Add (Dwayne);
            Dwayne.Cohort = C37;

            //Instructors assigning exercises to students

            Dwayne.assignExercise (Leah, Heist);
            Dwayne.assignExercise (Leah, Kennel);
            Dwayne.assignExercise (Mo, Kennel);
            Dwayne.assignExercise (Mo, Millionaires);
            Dwayne.assignExercise (Rose, Kennel);
            Dwayne.assignExercise (Rose, Millionaires);
            Vin.assignExercise (Rose, KandyKorner);
            Vin.assignExercise (Jenna, Millionaires);

            var students = new List<Student> ();
            students.Add (Rose);
            students.Add (Mo);
            students.Add (Leah);
            students.Add (Jenna);

            var exercises = new List<Exercise> ();
            exercises.Add (Heist);
            exercises.Add (Kennel);
            exercises.Add (KandyKorner);
            exercises.Add (Millionaires);

            foreach (Exercise exercise in exercises) {
                Console.WriteLine ($"{exercise.ExerciseName}:");
                
                foreach (Student student in students) {
                    foreach (Exercise studentExercise in student.Exercises) {
                        if (studentExercise == exercise) {
                            Console.WriteLine ($"{student.FirstName} {student.LastName}");
                        }
                    }
                }

            }

        }
    }
}