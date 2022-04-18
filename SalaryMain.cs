using System;

namespace SalaryApp{
    public class MainApp{
        static void Main(string[] args){
            Salary s1=new Salary("George", 980);
            s1.displaySalary();
            Salary s2=new Salary("Irina", 3400);
            s2.displaySalary();

 
        }
    }
}