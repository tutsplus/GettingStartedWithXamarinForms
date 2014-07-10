using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBox.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookingTime { get; set; }
        public List<string> Directions { get; set; }
    }
}
