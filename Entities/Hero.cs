using System;
using System.ComponentModel.DataAnnotations;
namespace api.Entities
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SuperPower { get; set; }
        public Hero()
        {
            
        }
    }
}