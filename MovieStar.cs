/*-	Develop a Console Application that reads the file “Input.txt”. Create a class called “MovieStar” 
and assign the properties from the file to instances of this class. Loop through each object of “MovieStar” and 
display the properties to the console. Calculate the age of each actor as shown in the example picture bellow. Use 
“Newtonsoft.Json” framework.*/
using System;
namespace MovieStarInteface{
public class MovieStar {
    //Object Members 
    public DateTime dateOfBirth {get;set;}
    public string name{set;get;}
    public string surname{set;get;}
    public string sex {set;get;}
    public string nationality {set;get;}

    //Method gets Movie Star birth date and calculates movie star's age 
    public int getAge(){
        int todaysDate=int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int birthDate=int.Parse(dateOfBirth.ToString("yyyyMMdd"));
        int age=(todaysDate-birthDate)/10000;
        return age;
    }

}
}