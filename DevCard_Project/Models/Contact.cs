using System.ComponentModel.DataAnnotations;

namespace DevCard_Project.Models
{
    public class Contact
    {
        [Required (ErrorMessage = "لطفا نام را وارد نمایید ")]
        [MinLength(3 , ErrorMessage = "حدقل کارکتر های اسم 3 تا است")]
        [MaxLength(100 , ErrorMessage = "حداکثر کارکتر های اسم 100 تا است")]
        public string  Name { get; set; }   
        [Required(ErrorMessage = "لطفا ایمیل را وارد نمایید ")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
