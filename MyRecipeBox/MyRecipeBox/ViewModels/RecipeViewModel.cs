using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyRecipeBox.Annotations;
using MyRecipeBox.Models;

namespace MyRecipeBox.ViewModels
{
    public class RecipeViewModel : INotifyPropertyChanged {
        private Recipe _recipe;
        public event PropertyChangedEventHandler PropertyChanged;

        public RecipeViewModel( Recipe recipe ) {
            _recipe = recipe;
            Directions = new ObservableCollection<string>( _recipe.Directions );
        }

        public string Name {
            get { return _recipe != null ? _recipe.Name : null; }
            set {
                if ( _recipe != null ) {
                    _recipe.Name = value;

                    if ( PropertyChanged != null ) {
                        PropertyChanged( this, new PropertyChangedEventArgs( "Name" ) );
                    }
                }
            }
        }

        public string Description {
            get { return _recipe != null ? _recipe.Description : null; }
            set {
                if ( _recipe != null ) {
                    _recipe.Description = value;

                    if ( PropertyChanged != null ) {
                        PropertyChanged( this, new PropertyChangedEventArgs( "Description" ) );
                    }
                }
            }
        }

        public string PrepTime {
            get { return _recipe != null ? _recipe.PrepTime.ToString() : "None"; }
            set {
                if ( _recipe != null ) {
                    _recipe.PrepTime = TimeSpan.Parse(value);

                    if ( PropertyChanged != null ) {
                        PropertyChanged(this, new PropertyChangedEventArgs("PrepTime"));
                    }
                }
            }
        }

        public string CookingTime {
            get { return _recipe != null ? _recipe.CookingTime.ToString() : "None"; }
            set {
                if ( _recipe != null ) {
                    _recipe.CookingTime = TimeSpan.Parse(value);

                    if ( PropertyChanged != null ) {
                        PropertyChanged(this, new PropertyChangedEventArgs("CookingTime"));
                    }
                }
            }
        }

        public ObservableCollection<string> Directions { get; set; } 
    }
}
