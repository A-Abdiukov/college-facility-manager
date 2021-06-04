﻿namespace BusinessLayer
{
    public class Course
    {
        //CONSTRUCTOR
        public Course(string CourseName, string Semester, string UnitName,
            int UnitHoursAmount, string CampusName, string Delivery, bool isCurrent)
        {
            this.CourseName = CourseName;
            this.Semester = Semester;
            this.UnitName = UnitName;
            this.UnitHoursAmount = UnitHoursAmount;
            this.CampusName = CampusName;
            this.Delivery = Delivery;
            this.isCurrent = isCurrent;
        }

        //PROPERTIES
        public bool isCurrent
        {
            get; set;
        }
        public string CourseName
        {
            get; set;
        }

        public string Semester
        {
            get; set;
        }

        public string UnitName
        {
            get; set;
        }

        public int UnitHoursAmount
        {
            get; set;
        }

        public string CampusName
        {
            get; set;
        }

        public string Delivery
        {
            get; set;
        }

    }
}
