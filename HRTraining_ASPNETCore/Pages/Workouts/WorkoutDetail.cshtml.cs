using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRTraining.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRTraining_ASPNETCore.Pages.Workouts
{
    public class WorkoutDetailModel : PageModel
    {
        public Workout Workout { get; set; }

        public void OnGet()
        {
            Workout = new Workout();
        }
    }
}
