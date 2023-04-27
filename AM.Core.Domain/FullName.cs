using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    //classe de configuration ou bien cette annotation [Owned]
    public class FullName
    {

        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
