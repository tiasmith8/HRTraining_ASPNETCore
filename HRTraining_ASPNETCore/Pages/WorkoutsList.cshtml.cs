using System.Collections.Generic;
using HRTraining.Core;
using HRTraining.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace HRTraining_ASPNETCore.Pages
{
    public class WorkoutsListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IWorkoutData workoutData;

        public string Message { get; set; }
        public IEnumerable<Workout> Workouts { get; set; }

        // IWorkoutData is a service that knows how to fetch workouts
        public WorkoutsListModel(IConfiguration config, IWorkoutData workoutData)
        {
            this.config = config;
            this.workoutData = workoutData;
        }

        public void OnGet(string searchTerm) // ASP.NET Core will try to find something that is a searchTerm
        {
            Message = config["Message"];
            Workouts = workoutData.GetWorkoutsByName(searchTerm);
        }
    }
}
