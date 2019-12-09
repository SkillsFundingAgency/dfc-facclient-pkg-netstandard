﻿using DFC.FindACourseClient.Models.APIResponses.CourseGet.Enums;
using System.Collections.Generic;

namespace DFC.FindACourseClient.Models.APIRequests
{
    public class CourseSearchRequest
    {
        public string SubjectKeyword { get; set; }

        public string DfE1619Funded { get; set; }

        public double Distance { get; set; }

        public List<int> QualificationLevels { get; set; }

        public List<StudyMode> StudyModes { get; set; }

        public List<DeliveryMode> DeliveryModes { get; set; } // List of enum

        public List<int> AttendancePatterns { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public int SortBy { get; set; }

        public string StartDateFrom { get; set; }

        public string StartDateTo { get; set; }

        public int Limit { get; set; }

        public int Start { get; set; }
    }
}