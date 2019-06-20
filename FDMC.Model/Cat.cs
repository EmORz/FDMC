using System;

namespace FDMC.Model
{
    public class Cat : BaseEntity<string>
    {
        public Cat()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string ImageUrl { get; set; }

        /*•	Cat Name – text 
           •	Cat Age – number 
           •	Cat Breed – text
           •	Cat Image Url – text 
           */
    }
}