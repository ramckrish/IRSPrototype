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

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Incident Date")]
        public DateTime IncidentDate { get; set; }

        [Display(Name = "Incident Time")]
        public string Time { get; set; }

        [Display(Name = "Person reporting Incident")]
        public string ReportName { get; set; }

        [Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Reported Date")]
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

        [Display(Name = "Was tranfer emergent?")]

        public bool chkEmergency { get; set; }

        [Display(Name = "Corrective Action")]
        public string correctiveAction { get; set; }

        [Display(Name = "Preventive Action")]
        public string preventiveAction { get; set; }

        [Display(Name = "Closed Date")]
        public DateTime ClosedDate { get; set; }


    }



}