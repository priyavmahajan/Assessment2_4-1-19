using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment2
{
    class Employee:IEmployee   //Employee class implements IEmployee interface
    {
        private object p;
        public int empId { get; set ; }
        public string empName { get ; set ; }
        public int empAge { get; set; }
        public string deapartment { get ; set ; }
        public Employee( string empName, int empAge, string deapartment)   //parameterised constructor of employee class
        {
            this.empName = empName;
            this.empAge = empAge;
            this.deapartment = deapartment;
        }
        public Employee(object p)
        {
            this.p = p;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();     
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
