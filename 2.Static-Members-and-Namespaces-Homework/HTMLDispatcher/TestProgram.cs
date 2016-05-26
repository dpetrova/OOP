using System;

namespace HTMLDispatcher
{
    class TestProgram
    {
        static void Main()
        {
            //test html element builder
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            div.IsSelfClosed = false;
            Console.WriteLine(div * 2);

            
            //test html dispatcher
            string myImage = HTMLDispatcher.CreateImage("image1.jpg", "test image", "test image");
            Console.WriteLine(myImage);
            string myLink = HTMLDispatcher.CreateURL("http://www.softuni.bg", "www.softuni.bg", "www.softuni.bg");
            Console.WriteLine(myLink);
            string myInput = HTMLDispatcher.CreateInput("submit", "submit", "Submit");
            Console.WriteLine(myInput);          
            
        }
    }
}
