using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Incident
    {
        [Display(Name = "Incident Number")]
        public string IncidentNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Incident")]
        public DateTime IncidentDate { get; set; }

        [Display(Name = "Time of Incident")]
        public string Time { get; set; }

        [Display(Name = "Person communicated")]
        public string PersonComm { get; set; }

        [Display(Name = "Comm. Tim")]
        public string CommTime { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Comm. date")]
        public DateTime commDate { get; set; }
        [Display(Name = "Day of Week")]
        public string DayofWeek { get; set; }

        [Display(Name = "Witness")]
        public bool WitnessCheck { get; set; }

        [Display(Name = "Witness Name")]
        public string WitnessName { get; set; }

        [Display(Name = "Witness Address")]
        public string WitnessAddress { get; set; }


        [Display(Name = "Name of Person Completing Report")]
        public string ReportName { get; set; }

        [Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Report Date")]
        public DateTime ReportDate { get; set; }

        [Display(Name = "Description of the incident")]
        public string ReportDesc { get; set; }
        [Display(Name = "Additional information")]
        public string AddlInfo { get; set; }

        [Display(Name = "Persons Involved 1")]
        public string Person1 { get; set; }
        [Display(Name = "Persons Involved 2")]
        public string Person2 { get; set; }
        [Display(Name = "Persons Involved 3")]
        public string Person3 { get; set; }
        [Display(Name = "Persons Involved 4")]
        public string Person4 { get; set; }
        [Display(Name = "Persons Involved 5")]
        public string Person5 { get; set; }
        [Display(Name = "Persons Involved 6")]
        public string Person6 { get; set; }

        [Display(Name = "Incident Category")]
        public string Category { get; set; }
        [Display(Name = "Incident Type")]
        public string slc_target { get; set; }
        [Display(Name = "Incident Sub Type")]
        public string SubType { get; set; }

        [Display(Name = "Did incident result in a direct hospital transfer?")]
        public bool chkTransfer { get; set; }

        [Display(Name = "Was transfer emergent?")]

        public bool chkEmergency { get; set; }

        [Display(Name = "Corrective Action")]
        public string correctiveAction { get; set; }

        [Display(Name = "Preventive Action")]
        public string preventiveAction { get; set; }

        [Display(Name = "Root Cause Analysis")]
        public string RCA { get; set; }

        [Display(Name = "Closed Date")]
        public DateTime ClosedDate { get; set; }

        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }
        [Display(Name = "Patient ID")]
        public string PatientID { get; set; }

    }



}