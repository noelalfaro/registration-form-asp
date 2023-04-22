using System;
using System.ComponentModel.DataAnnotations;

namespace noel_registration_form.Models
{
	public class Reservation
	{

        [Required(ErrorMessage = "Please enter your full name.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a check-in date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CheckIn { get; set; }

        [Required(ErrorMessage = "Please enter a check-out date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CheckOut { get; set; }

        [Required(ErrorMessage = "Please select a room type.")]
        public RoomType RoomType { get; set; }

        [Required(ErrorMessage = "Please select a bed type.")]
        public BedType BedType { get; set; }

        [Required(ErrorMessage = "Please select if you'd like to smoke")]
        public Boolean Smoking { get; set; }

        [Required(ErrorMessage = "Please select the number of nights you are staying")]
        public int Nights { get; set; }

        [Required(ErrorMessage = "Please select the number of adults staying")]
        public int Adults { get; set; }


        public string? SpecialRequests { get; set; }
    }

    public enum RoomType
    {
        Standard,
        Business,
        Suite
    }

    public enum BedType
    {
        King,
        Queen,
        Double
    }


}

