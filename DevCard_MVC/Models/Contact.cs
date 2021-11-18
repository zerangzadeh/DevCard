using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "لطفا این فیلد را پر کنبد.")]
        [MinLength(3,ErrorMessage = "حداقل طول نام ۳ کاراکتر است.")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام ۱۰۰ کاراکتر است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا این فیلد را پر کنبد")]
        [EmailAddress(ErrorMessage = "این یک آدرس ایمیل نیست")]
        public string Email { get; set; }
        public int Service { get; set; }
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}
