using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MovieStarInteface{

    class MovieStarMain{
        static void Main(string [] args){
            StreamReader txtFile=new StreamReader(@"/Users/antooo/app/input.txt");
            string jsonString=txtFile.ReadToEnd();

            List<MovieStar>objs=JsonConvert.DeserializeObject<List<MovieStar>>(jsonString);
            foreach(MovieStar star in objs){
                Console.WriteLine(star.name+" "+star.surname);
                Console.WriteLine(star.sex);
                Console.WriteLine(star.nationality);
                Console.WriteLine(star.getAge()+" years old. \n");
            }
        }
    }    
}
