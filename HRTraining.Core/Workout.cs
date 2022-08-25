using System;

// Core represents the classes, types, processing algorithms that are the Core of the application
// This application is primarily concerned about Workouts
namespace HRTraining.Core
{
    public class Workout
    {
        // Defining properties/information to store about the workout
        public Guid ID { get; set; }
        public string Name { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
