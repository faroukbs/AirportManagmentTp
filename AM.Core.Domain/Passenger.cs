using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public  class Passenger
    {
        //public int Id { get; set; }
        [DataType(DataType.DateTime,ErrorMessage ="entrer une date valide")]
        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }
        [Key]
        [MaxLength(7,ErrorMessage ="max length 7"),MinLength(7,ErrorMessage ="min length 7")]
        public string PassportNumber { get; set; }
        [EmailAddress(ErrorMessage ="it's an email")]
        public string EmailAddress { get; set; }
        //[MinLength(3,ErrorMessage ="min length 3"),MaxLength(25,ErrorMessage ="max length 25")]
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public FullName MyFullName { get; set; }
        [Phone(ErrorMessage ="phone number")]
        public string TelNumber { get; set; }
        //public int Age { get; set; }

       // public IList<Flight> Flights { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        public override string ToString()
        {
            return "BirthDate:" + BirthDate 
                + ";PassportNumber:" + PassportNumber 
                + ";EmailAddress:" + EmailAddress + ";FirstName:" 
                + MyFullName.FirstName + ";LastName:" + MyFullName.LastName + ";Telnumber:" 
                + TelNumber;
        }
        ///Tp1.Q11.A
        ///public bool CheckProfile(String firstname, String lastname)
        ///{
        ///  return FirstName==firstname && LastName==lastname ;
        ///}
        ///TP1.Q11.B
        ///public bool CheckProfile(String firstname, String lastname,String emailaddress)
        ///{
           /// return EmailAddress==emailaddress && LastName==lastname && FirstName==firstname ;
        ///}
        ///tp1.q11.C
        public bool CheckProfile(String firstname, String lastname, String emailaddress=null)
        {
            return EmailAddress == emailaddress && MyFullName.LastName == lastname && MyFullName.FirstName == firstname;
        }
        
        public virtual string GetPassengerType()
        {
            return "I'm passenger";
        }
        int age;
        public int Age
        {
            get
            {
                age = DateTime.Now.Year - BirthDate.Year;
                if (BirthDate.Month > DateTime.Now.Month)
                {
                    age -= 1;
                }
                else if (
             BirthDate.Month == DateTime.Now.Month
                    && BirthDate.Day > DateTime.Now.Day)
                {

                    age--;
                }
                return age;
            }
        }
    }
}
