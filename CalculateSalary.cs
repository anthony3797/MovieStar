/*Create a console application that would calculate and output the net salary given the 
gross value as input. The taxation rules in the country of Imaginaria as of date are as follows:
1.)	There is no taxation for any amount lower or equal to 1000 Imagiaria Dolars (IDR).
2.)	Income tax of 10% is incurred to the excess (amount above 1000).
3.)	Social contributions of 15% are expected to be made as well. As for the previous case, 
the taxable income is whatever is above 1000 IDR but social contributions never apply to 
amounts higher than 3000. */

using System;

namespace SalaryApp{
   public class Salary{
       public string employeeName;
       public double netSalary;
       
       private double incomeTax,socialContributions,totalTax,totalSalary;
        
        
        public Salary(string anEmployeeName, double aNetSalary){
            employeeName=anEmployeeName;
            netSalary=aNetSalary;

        }
       private double calculateIncomeTax(double aNetSalary){
            if(aNetSalary>1000){
                double taxableSalary = aNetSalary - 1000;
                incomeTax =taxableSalary*0.10;
            }
            else{
                incomeTax=0;
                }

                return incomeTax;
       }
       private double calculateSocialContributions(double aNetSalary){
           if(aNetSalary>1000&&aNetSalary<3000){
               double taxableSalary=aNetSalary-1000;
               socialContributions=taxableSalary*0.15;
           }
           else if(aNetSalary>1000&&aNetSalary>3000)
            socialContributions=300;
            
            else 
            socialContributions=0;

            return socialContributions;
       }

       private double calculateTotalTax(double aSocialContributions, double anIncomeTax){
            return totalTax=aSocialContributions+anIncomeTax;
       }

       private double calculateTotalSalary(double aNetSalary){
           calculateIncomeTax(aNetSalary);
           calculateSocialContributions(aNetSalary);
           calculateTotalTax(incomeTax,socialContributions);
           return totalSalary=aNetSalary-totalTax;
       }

       public void displaySalary(){
            Console.WriteLine("The net salary of "+employeeName+" is: "+netSalary+" IDR");
            Console.WriteLine("The total income tax deduction is: "+calculateIncomeTax(netSalary)+" IDR");
            Console.WriteLine("The Social contributions are: "+calculateSocialContributions(netSalary)+" IDR");
            Console.WriteLine("The total deductions are: $"+calculateTotalTax(incomeTax,socialContributions)+" IDR");
            Console.WriteLine("With deductions "+employeeName+" gets to bring home $"+calculateTotalSalary(netSalary)+" IDR");
            
       }

   }
}
