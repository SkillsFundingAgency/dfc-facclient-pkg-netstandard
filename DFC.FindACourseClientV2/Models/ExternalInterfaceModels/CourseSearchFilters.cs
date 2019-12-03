﻿using System;

namespace DFC.FindACourseClientV2.Models.ExternalInterfaceModels
{
    public class CourseSearchFilters
    {
        public string SearchTerm { get; set; }

        public DateTime StartDateFrom { get; set; }

        public string Provider { get; set; }

        public string Location { get; set; }

        public float Distance { get; set; } = 10f;

        public bool DistanceSpecified { get; set; }

        public bool Only1619Courses { get; set; }

        public StartDate StartDate { get; set; } = StartDate.Anytime;

        public CourseHours CourseHours { get; set; } = CourseHours.All;

        public CourseType CourseType { get; set; } = CourseType.All;

        public bool IsValidStartDateFrom =>
            StartDate == StartDate.SelectDateFrom && !StartDateFrom.Equals(DateTime.MinValue);
    }
}