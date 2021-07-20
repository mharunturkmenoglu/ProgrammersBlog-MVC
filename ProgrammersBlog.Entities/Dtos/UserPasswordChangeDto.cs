using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserPasswordChangeDto
    {
        [DisplayName("Su Anki Sifreniz")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [DisplayName("Yeni Sifreniz")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DisplayName("Yeni Sifrenizin Tekrari")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage = "Yeni Sifrenizin Tekrari birbiriyle uyusmalidir.")]
        public string RepeatPassword { get; set; }
    }
}
