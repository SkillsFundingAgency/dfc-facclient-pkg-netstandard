﻿using System;

namespace DFC.FindACourseClientV2.Models.APIResponses.CourseGet
{
    public class CourseDetailResponseCourse
    {
        public bool AdvancedLearnerLoan { get; set; }

        public string AwardOrgCode { get; set; }

        public string CourseDescription { get; set; }

        public Guid CourseId { get; set; }

        public string LearnAimRef { get; set; }

        public string QualificationLevel { get; set; }

        public string WhatYoullLearn { get; set; }

        public string WhatYoullNeed { get; set; }

        public string WhereNext { get; set; }

        public string EntryRequirements { get; set; }

        public string HowYoullBeAssessed { get; set; }

        public string HowYoullLearn { get; set; }
    }
}