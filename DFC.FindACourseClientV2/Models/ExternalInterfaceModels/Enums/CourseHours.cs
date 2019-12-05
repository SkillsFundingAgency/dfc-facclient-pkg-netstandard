﻿using System.ComponentModel.DataAnnotations;

namespace DFC.FindACourseClientV2.Models.ExternalInterfaceModels.Enums
{
    public enum CourseHours
    {
        [Display(Name = "All", Order = 1)]
        All,

        [Display(Name = "Full time", Order = 2)]
        Fulltime,

        [Display(Name = "Part time", Order = 3)]
        PartTime,

        [Display(Name = "Flexible", Order = 4)]
        Flexible,
    }
}