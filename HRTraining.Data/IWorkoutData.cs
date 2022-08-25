using HRTraining.Core;
using System.Collections.Generic;

namespace HRTraining.Data
{
    // Keeping data access separate from entities and UI/web application part
    public interface IWorkoutData
    {
        public IEnumerable<Workout> GetAll();
    }
}
