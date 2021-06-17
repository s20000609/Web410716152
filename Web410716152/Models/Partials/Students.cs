using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410716152.Models
{
    [MetadataType(typeof(StudentMetaData))]


    public partial class Student
    {
    }


    public class StudentMetaData
    {
        public int id { get; set; }

        [Required(ErrorMessage = "請輸入姓名")]
        [Display(Name = "姓名")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "請輸入 2 ~ 5 個字")]

        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入學號")]
        [Display(Name = "學號")]
        [StringLength(10, ErrorMessage = "請輸入 1 ~ 10 個字")]
        public string Number { get; set; }

        [Required(ErrorMessage = "請輸入 Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}