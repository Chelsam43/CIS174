
//import validation for Model Properies
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMortenson.Models
{

    //Model that stores guidlines for user input and validation
    public class UserModel
    {
        //const to calculate age
        public const int CURRENT_YEAR = 2026;


        //user name required, only accepting letters. it will accept spaces
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters")]
        public string Name { get; set; } = string.Empty;


        //user input of birth year required, year has to be 1900 or later. 
        [Required(ErrorMessage = "Birth year is required")]
        [Range(1900, CURRENT_YEAR, ErrorMessage = "Birth year must be between 1900 and 2026")]
        public int BirthYear { get; set; }

        //calculation of user's age, sutracts from current year
        public int AgeThisYear => CURRENT_YEAR - BirthYear;
       
        //current year public to be used in other areas/views
        public int CurrentYear => CURRENT_YEAR;
    }
}

