using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebSunglass.Models
{
    public class Customer
    {
        [Required(ErrorMessage ="You need to inset your Id")]
        [Display(Name ="Customer Id")]
        [Range(10000000,999999999,ErrorMessage ="you need to insert  valid id (8-9 digit).")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="you need to insert your FirstName.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "you need to insert your LastName.")]
        public String LastName { get; set; } 
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "you need to insert your Email.")]
        public String Email { get; set; }

        [Compare("Email",ErrorMessage ="The email and Confirm Email must be match.")]
        [Display(Name = "Confrim Email")]
        public String ConfrimEmail { get; set; }

        [StringLength(20,MinimumLength =5,ErrorMessage ="The length of password need to be between 5-20")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "you need to insert your password.")]
        [Display(Name = "Password")]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "The Password and Confirm Password must be match")]
        [Display(Name = "Confrim Password")]
        public String ConfrimPassword { get; set; } 
    }
}