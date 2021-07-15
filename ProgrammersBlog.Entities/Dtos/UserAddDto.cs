using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserAddDto 
    {
        [DisplayName("Kullanici Adi")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        public string UserName { get; set; }
        [DisplayName("Email Adresi")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Sifre")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden az olmamalidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Telefon Numarasi")]
        [Required(ErrorMessage = "{0} bos gecilmemelidir.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden fazla olmamalidir")]
        [MinLength(13, ErrorMessage = "{0} {1} karakterden az olmamalidir")]    // 13 chars // +905555555555
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lutfen bir {0} seciniz")]
        [DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }
        public string Picture { get; set; }
    }
}
