using System;
using CursoPratico02.Entities;

namespace CursoPratico02
{
    class Program
    {
        static void Main(string[] args)
        {


            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow, thats awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2021 13:05:44"),
                "Traveling to New Zealand ",
                "Im going to visit this wonderful country ",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);



            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("See you tomorrow");

            Post p2 = new Post(DateTime.Parse("28/07/2021 23:14:19"),
                "Good night guys ",
                "See you tomorrow ",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }




    }
}





















// Um POST com comentários, podendo adicionar e remover
//  Pastas ( POST e COMMENT )







