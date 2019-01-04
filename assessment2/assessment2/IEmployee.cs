using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment2
{
    public interface IEmployee   //interface Iemployee
    {
        int empId { get; set; }     
        string empName { get; set; }
        int empAge { get; set; }
        string deapartment { get; set; }
    }
}
