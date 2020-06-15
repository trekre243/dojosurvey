using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name")]
        public string Name {get;set;}
        [Required]
        public string Dojo {get;set;}
        [Required]
        public string FavoriteLanguage {get;set;}
        [MaxLength(20)]
        [Display(Name = "Comment (Optional)")]
        public string Comment {get;set;}
    }
}