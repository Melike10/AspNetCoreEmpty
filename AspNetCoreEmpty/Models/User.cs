using System.ComponentModel.DataAnnotations;

namespace AspNetCoreEmpty.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage ="Kullanıcı Adı Gereklidir'") ]
        [StringLength(150)]
        public string UserName { get; set; }


    }
}
