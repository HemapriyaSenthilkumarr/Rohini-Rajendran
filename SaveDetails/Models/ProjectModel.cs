using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace SaveDetails.Models
{
    public class ProjectModel
    {

        // Primary key for the ProjectModel table
        [Key]
        public int ProjectId { get; set; }

        // Required field for the project name
        [Required(ErrorMessage = "Please enter project name")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please enter Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter Client Name")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Please enter Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Please enter Number of Members")]
        public int NoOfMembers { get; set; }

        [Required(ErrorMessage = "Please enter Project URL ")]
        public string ProjectURL { get; set; }
    }
}
