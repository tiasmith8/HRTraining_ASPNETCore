using System.Collections.Generic;
using HRTraining.Core;
using HRTraining.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace HRTraining_ASPNETCore.Pages
{
    public class WorkoutsListModel : PageModel
    {        
        private readonly IConfiguration config;
        private readonly IWorkoutData workoutData;
        
        // Page model properties - output models
        public string Message { get; set; }
        public IEnumerable<Workout> Workouts { get; set; }
        
        // Output model to populate value for the search term to show the user what is being search on
        [BindProperty(SupportsGet = true)] // By default only does POST requests
        public string SearchTerm { get; set; }

        // IWorkoutData is a service that knows how to fetch workouts
        public WorkoutsListModel(IConfiguration config, IWorkoutData workoutData)
        {
            this.config = config;
            this.workoutData = workoutData;
        }

        public void OnGet()
        {
            Message = config["Message"];
            Workouts = workoutData.GetWorkoutsByName(SearchTerm);
        }
    }
}
