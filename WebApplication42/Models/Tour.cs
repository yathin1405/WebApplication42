using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication42.Models
{
    public class Tour
    {
        public Tours Tour_Type { get; set; }
        public enum Tours
        {

            Ushaka,
            Cape_Of_Good_Hope,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Durban_Natural_Science_Museum,


        }
        //public struct ConvertEnum
        //{
        //    public int Value
        //    {
        //        get;
        //        set;
        //    }
        //    public String Text
        //    {
        //        get;
        //        set;
        //    }
        //}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TourId { get; set; }

 
        [Display(Name = "Tour Duration")]
        public string Tour_Duration { get; set; }

        [Display(Name = "Tour Date")]
        [DataType(DataType.Date)]
        public DateTime Tour_Date { get; set; }
        [Display(Name = "Tour Time")]
        public DateTime Tour_Time { get; set; }
        public double UshakPrice = 150;
        public double DNS = 100;
        public double AppMuseum = 200;
        public double GoodHope = 250;
        public double GoldReef = 175;






        public Tours1 TourType { get; set; }
        public enum Tours1
        {

            Ushaka,
            Cape_Of_Good_Hope,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Durban_Natural_Science_Museum,


        }
        //Tour user = new Tour();
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int GuestID { get; set; }

        [Display(Name = "Number of adults")]
        public int Num_Adults { get; set; }

        [Display(Name = "Number of Kids")]
        public int Num_Kids { get; set; }
        public double Deposit { get; set; }
        public double Discount { get; set; }
        public int Total_Tickets { get; set; }
        public double Total_Cost { get; set; }
        public double GuestCost { get; set; }
        public double Tour_Cost { get; set; }
       
        public string TDuraton()
        {
            string x = " ";
          
            
                x = Tour_Duration;
            
            return x;
        }
        public double TourCost()
        {
            double x = 0;
            if (TourType == Tours1.Ushaka)
            {
                x = ((UshakPrice * Num_Adults) + ((UshakPrice * 0.50) * Num_Kids));
            }
            else if (TourType == Tours1.Apartheid_Museum)
            {
                x = (AppMuseum * Num_Adults) + ((AppMuseum * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Cape_Of_Good_Hope)
            {
                x = (GoodHope * Num_Adults) + ((GoodHope * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Gold_Reef_City_Theme_Park)
            {
                x = (GoldReef * Num_Adults) + ((GoldReef * Num_Kids) * 0.10);
            }
            else if (TourType == Tours1.Durban_Natural_Science_Museum)
            {
                x = (DNS * Num_Adults) + ((DNS * Num_Kids) * 0.10);
            }
            return x;


        }


        public double deposit()
        {

            double deposit = 0;
            if (TourCost() <= 100)
            {
                deposit = TourCost() * 0.15;
            }
            else
                if (TourCost() > 100 && TourCost() <= 150)
            {
                deposit = TourCost() * 0.20;
            }
            else
                if (TourCost() > 150 && TourCost() <= 175)
            {
                deposit = TourCost() * 0.25;
            }
            else
                if (TourCost() > 175 && TourCost() <= 200)
            {
                deposit = TourCost() * 0.30;
            }
            else
                if (TourCost() > 200)
            {
                deposit = TourCost() * 0.40;
            }
            return deposit;

        }
        //public double Guest_Cost()
        //{
        //    double x = 0;
        //    x = (TourCost() * Num_Adults) + ((TourCost() * Num_Kids) / 0.50);
        //    return x;
        //}

        public double TotalCost()
        {
            double x = 0;

            {
                x = TourCost() + deposit() - discount();

                return x;
            }

        }
        public double discount()
        {
            double x = 0;
            if (numOfTickets() >= 4 && numOfTickets() <= 6)
            {
                x = TourCost() * 0.05;

            }
            else if (numOfTickets() > 6 && numOfTickets() <= 10)
            {
                x = TourCost() * 0.10;

            }
            else if (numOfTickets() > 10 && numOfTickets() <= 15)
            {
                x = TourCost() * 0.15;

            }
            else if (numOfTickets() > 15 && numOfTickets() <= 20)
            {
                x = TourCost() * 0.20;

            }
            else
            {
                x = 0;
            }
            return x;



        }
        public int numOfTickets()
        {
            int x = Num_Adults + Num_Kids;
            return x;
        }
    }
}