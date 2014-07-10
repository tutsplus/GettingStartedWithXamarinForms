using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecipeBox.Models;

namespace MyRecipeBox.ViewModels
{
    public class RecipeListViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeListViewModel(  ) {
            Recipes = new ObservableCollection<Recipe>();

            Recipes.Add(new Recipe {
                Name = "Toast",
                Description = "Are you kidding? It's toast.",
                CookingTime = new TimeSpan(0, 2, 0),
                PrepTime = new TimeSpan(0, 0, 15),
                Directions = new List<string> {
                    "Pick up bread",
                    "Put break in toaster",
                    "Eat Toast"
                }
            });

            Recipes.Add(new Recipe
            {
                Name = "Cereal",
                Description = "You know, the breakfast stuff.",
                CookingTime = TimeSpan.Zero,
                PrepTime = new TimeSpan(0, 1, 0),
                Directions = new List<string> {
                    "Put cereal in bowl",
                    "Put milk in bowl",
                    "Put spoon in bowl",
                    "Put spoon in mouth"
                }
            });

            Recipes.Add(new Recipe
            {
                Name = "Sandwich",
                Description = "Bread and stuff.  YUM!",
                CookingTime = TimeSpan.Zero,
                PrepTime = new TimeSpan(0, 5, 0),
                Directions = new List<string> {
                    "Get 2 slices of bread",
                    "Put cheese between bread slices",
                    "Put ham between bread slices",
                    "Enjoy"
                }
            });
        }
    }
}
