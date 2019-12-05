﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zilla.Models
{
    public class Team
    {
        public Team()
        {
            Members = new HashSet<ApplicationUser>();
        }

        [Key]
        public int TeamId { get; set; }

        [Required(ErrorMessage = "Please provide a team title")]
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> Members { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }

    public class MembersViewModel
    {
        [Display(Name = "Team")]
        public Team Team { get; set; }

        [Display(Name = "Members")]
        public IEnumerable<ApplicationUser> Members { get; set; }
    }

}