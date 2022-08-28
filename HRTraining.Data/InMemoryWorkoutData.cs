using HRTraining.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HRTraining.Data
{
    public class InMemoryWorkoutData : IWorkoutData
    {
        private readonly List<Workout> workouts;

        public InMemoryWorkoutData()
        {
            workouts = new List<Workout>()
            {
                new Workout()
                {
                    ID = Guid.NewGuid(),
                    Duration = new TimeSpan(0, 10, 10),
                    Name = "Workout One - Run",
                    StartTime = new DateTime(2022, 8, 23, 14, 14, 14),
                    WorkoutType = WorkoutType.Run
                },
                new Workout()
                {
                    ID = Guid.NewGuid(),
                    Duration = new TimeSpan(0, 20, 10),
                    Name = "Workout Two - Walk",
                    StartTime = new DateTime(2022, 8, 24, 14, 14, 14),
                    WorkoutType = WorkoutType.Walk
                },
                new Workout()
                {
                    ID = Guid.NewGuid(),
                    Duration = new TimeSpan(0, 25, 10),
                    Name = "Workout Three - Hike",
                    StartTime = new DateTime(2022, 8, 25, 14, 14, 14),
                    WorkoutType = WorkoutType.Hike
                }
            };
        }

        public IEnumerable<Workout> GetWorkoutsByName(string name = null) // Default value so name becomes optional
        {
            return from w in workouts
                   where string.IsNullOrEmpty(name) || w.Name.StartsWith(name)
                   orderby w.Name
                   select w;
        }
    }
}
