using System.ComponentModel.DataAnnotations;

namespace Carvilla.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name{ get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]

        public string Surname{ get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string UserName{ get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        [DataType(DataType.Password)]
        public string Password{ get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        [DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword{ get; set; }
    }
}
