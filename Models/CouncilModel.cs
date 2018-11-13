using System;

namespace coouncil.Models
{
    public class CouncilModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string FirstPic { get; set; }
        
        public string SecondName { get; set; }
        public string SecondPic { get; set; }

        public string TheirdName { get; set; }
        public string TheirdPic { get; set; }
    }
}