using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication42.Models
{
    public class RequestQuote
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter Number of Adults")]
        [Display(Name = "Number of Adults")]

        public int NumAdults { get; set; }

        [Required(ErrorMessage = "Please enter Number of Kids")]
        [Display(Name = "Number of Kids")]
        public int NumKids { get; set; }

        [Required(ErrorMessage = "What is your Departure Date?")]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]

        public DateTime DepartureDate { get; set; }

         

        [Display(Name = "Tours")]
        public bool Tour { get; set; }
        public Tours Tour_Type { get; set; }
        public enum Tours
        {

            Ushaka,
            Cape_Of_Good_Hope,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Durban_Natural_Science_Museum,


        }
        [Display(Name = "Departure Time")]
        public string DepartTime { get; set; }
        [Display(Name = "Cruises")]
        public bool Cruises { get; set; }
        public Ships1 Ship_name { get; set; }
        public enum Ships1
        {
            Princess_Cruises,
            Costa_Cruises,
            MSC_Cruises,
            Royal_Caribbean_Cruises,

        }

        public From1 CruiseFROM1 { get; set; }
        public enum From1
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }
        public To1 CruiseTO1 { get; set; }
        public enum To1
        {
            Port_Elizabeth,
            Durban,
            Capetown,

        }

        [Display(Name = "Flights")]
        public bool Flights { get; set; }
        
        [Display(Name = "Return Date")]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
        public Airline Airways { get; set; }
        public enum Airline
        {
            Mango,
            SAA,
            British_Airways,
            Kulula,

        }
        public From FlightFROM { get; set; }
        public enum From
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public To FlightTO { get; set; }
        public enum To
        {
            King_Shaka_International,
            OR_Tambo,
            Lanseria,
            CapeTown_International,

        }
        public Class SeatType { get; set; }
        public enum Class
        {
            Economy,
            Business,
            First,

        }

        public int RefID { get; set; }
        public int Determinkey()
        {
            Random ran = new Random();


            int randomOne = ran.Next(1, 101);
            int randomTwo = ran.Next(101, 201);
            int randomThree = ran.Next(201, 301);
            int diff = randomThree - randomTwo-randomOne;

            return diff;

        }


    }
}