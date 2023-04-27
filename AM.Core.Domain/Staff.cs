using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    //2eme methode [Table("Staffs")]
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string Function { get; set; }
        [DataType(DataType.Currency,ErrorMessage ="currency")]
        public float Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                " ;EmploymentDate:" + EmploymentDate 
                + " ;Function:" + Function + " ;Salary:" + Salary;
        }
        public override string GetPassengerType()
        {
            return base.GetPassengerType() + "I'm a staff Member";
        }
    }
}
