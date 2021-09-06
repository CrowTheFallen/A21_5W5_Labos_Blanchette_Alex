using System;
using System.ComponentModel.DataAnnotations;

namespace JungleModels
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Region { get; set; }


    }
}
