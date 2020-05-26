using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exmination.Models.Account
{
    public class Registration
    {
        [Required]
        public string ExaminationApplied { get; set; }
        [Required]
        public string CandidateName { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string ConfirmMoblile{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ConfirmEmail { get; set; }

    }
}
