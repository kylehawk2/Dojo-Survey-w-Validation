using System.ComponentModel.DataAnnotations;

namespace DojoSurvey_Validation
{
    public class User
    {
        [Required]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        [MinLength(2)]
        [MaxLength(15)]
        public string Name { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Location { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Language { get; set; }

        [MinLength(8)]
        [MaxLength(30)]
        public string Comment { get; set; }
    }
}