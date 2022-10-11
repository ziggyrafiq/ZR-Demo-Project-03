using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using ZR.Demo.Domains.Enums;

namespace ZR.Demo.Domains
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Display(Name = "First Name"),
        Required(ErrorMessage = "Please Enter Your First Name."),
       Comment("Customer First Name"),
       Column(Order = 1)]
        public string? FirstName { get; set; } = string.Empty;




        [Display(Name = "Last Name"),
         Required(ErrorMessage = "Please Enter Your Last Name."),
         Comment("Customer Last Name"),
        Column(Order = 2)]
        public string? LastName { get; set; } = string.Empty;




        [Display(Name = "Age"),
         Range(1, 100, ErrorMessage = "Please enter valid age from 1 to 100"),
         Required(ErrorMessage = "Please enter Your Age"),
         Comment("Customer Age"),
        Column(Order = 3)]

        public int? Age { get; set; }

        [Display(Name = "Gender"),
         Required(ErrorMessage = "Please Enter Your Last Name."),
         Comment("Customer Last Name"),
        Column(Order = 4)]
        public GenderType Gender { get; set; }



        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }

    }
}