using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }
        public void assignExercise(Student student, Exercise exercise)
        {

            student.Exercises.Add(exercise);

        }
        public List<Exercise> Exercises { get; set; } =  new List<Exercise>();

    }

}