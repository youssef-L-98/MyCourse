using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.ViewModels
{
    public class LessonViewModel
    {
        public string Title{ get; set; }
        public TimeSpan Duration { get; set; } //TimeSpan è un tipo particolare che mette a disposizione c# e serve per le durate temporali
    }
}