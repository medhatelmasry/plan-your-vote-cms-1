﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Candidate
    {
        [Key]
        [Display(Name = "CandidateId")]
        public int CandidateId { get; set; }

        [Display(Name = "ElectionId")]
        public int ElectionId { get; set; }

        [Display(Name = "Election")]
        public Election Election { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Display(Name = "CandidateDetails")]
        public List<CandidateDetail> Details { get; set; }

        [Display(Name = "OrganizationId")]
        public int OrganizationId { get; set; }

        [Display(Name = "Organization")]
        public Organization Organization { get; set; }

        // relation
        [Display(Name = "CandidateRaces")]
        public List<CandidateRace> CandidateRaces { get; set; }

        // relation
        [Display(Name = "Contacts")]
        public List<Contact> Contacts { get; set; }
    }
}
