using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class EmployCrud
    {
        static List<Employ> employList    ; 
        
        static EmployCrud()
        {
            employList = new List<Employ>();
        }

        public string UpdateEmploy(Employ updEmploy)
        {
            Employ res = SearchEmploy(updEmploy.Empno);
            if (res != null)
            {
                foreach (Employ emp in employList) 
                {
                    if (emp.Empno == updEmploy.Empno)
                    {
                        emp.Name = updEmploy.Name;
                        emp.Basic = updEmploy.Basic;
                    }
                }
                 
                return "Record Updated";
            }
            return "Record not found";
        }
        public string DeleteEmploy(int empno)
        {
            Employ employ = SearchEmploy( empno);
            if (employ != null)
            {
                employList.Remove(employ);
                return "record deleted";
            }
            return "record not found";
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employ = null;
            foreach (Employ e in employList)
            {
                if (e.Empno == empno)
                {
                    employ = e;
                }

            }
            return employ;
        }

        public string AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Employ added successfully";

        }

        public List<Employ> Show()
        {
            return employList;
        }
        
    }
}
