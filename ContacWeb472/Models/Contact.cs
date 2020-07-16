using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContacWeb472.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(ContacWebConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(ContacWebConstants.MAX_FIRST_NAME_LENGTH)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ContacWebConstants.MAX_PHONE_LENGTH)]
        public String PhonePrimary { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(ContacWebConstants.MAX_PHONE_LENGTH)]
        public string PhoneSecondary { get; set; }

        [DataType(DataType.Date)]
        public string Birthay { get; set; }

        public DateTime Birthday { get; set; }

        [StringLength(ContacWebConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddres1 { get; set; }

        [StringLength(ContacWebConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddres2 { get; set; }

        [Required]
        [StringLength(ContacWebConstants.MAX_CITY_LENGTH)]
        public string city { get; set; }

        [Required(ErrorMessage = "State is required")]
        public int StateId { get; set; }
        public virtual State State { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [Display(Name ="Zip Code")]
        [StringLength(ContacWebConstants.MAX_ZIP_CODE_LENGTH, MinimumLength = ContacWebConstants.MIN_ZIP_CODE_LENGTH)]
        public string Zip { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Display(Name = "Full Name")]
        public string FRiendelyName => $"{FirstName} {LastName}";

        [Display(Name= "Full Address")]
        public string FriendlyAddress => string.IsNullOrWhiteSpace(StreetAddres2)
                                             ? $"{StreetAddres1}, {city}, {State.Abbreviation}, {Zip}"
                                             : $"{StreetAddres1} - {StreetAddres2}, {city}, {State.Abbreviation},{Zip}";
    }
}
 