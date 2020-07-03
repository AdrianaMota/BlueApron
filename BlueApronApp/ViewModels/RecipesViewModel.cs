using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BlueApronApp.Models;
using BlueApronApp.Views;
using Xamarin.Forms;

namespace BlueApronApp.ViewModels
{
    public class RecipesViewModel : BaseViewModel
    {
        public INavigation navigation { get; set; }
        public Command GetStarted { get; set; }
        public ObservableCollection<Recipe> Recipes { get; set; }
 

        public RecipesViewModel(INavigation _navigation)
        {
            navigation = _navigation;

            GetStarted = new Command(async () => {

                await navigation.PushAsync(new PlansView());
            });

            Recipes = new ObservableCollection<Recipe>()
            {
                new Recipe {Name = "Cheesy Pesto Chicken Calzones",
                    Description="With Tomato Sauce & Marinated Zucchini",
                    ImageUrl="https://images.unsplash.com/photo-1517686469429-8bdb88b9f907?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1650&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem.",
                    Time="20-30 min",
                    Servings="4",
                    Calories="340 per serving"
                },

                new Recipe {Name = "Monterey Jack Cheeseburgers",
                    Description="Topped with Poblano & Tomato Salsa",
                    ImageUrl="https://images.unsplash.com/photo-1558250070-363aa42f9a00?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1650&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi.",
                    Time="40-50 min",
                    Servings="1",
                    Calories="500 per serving"
                },

                new Recipe {Name = "Roast Pork & Vegetables",
                    Description="With Basil Pesto & Marinated Tomatoes",
                    ImageUrl="https://images.unsplash.com/photo-1590579670545-bfbb5b038f86?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1650&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi.",
                    Time="20-30 min",
                    Servings="4",
                    Calories="400 per serving"
                },

                new Recipe {Name = "Orango-soy Barramundi & fried rice",
                    Description="With Snow Peas & Bok Chois",
                    ImageUrl="https://images.unsplash.com/photo-1540100716001-4b432820e37f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1986&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem.",
                    Time="20-30 min",
                    Servings="5",
                    Calories="140 per serving"
                },

                new Recipe {Name = "Sweet Potato & Spicy Cucumber Bao 🍃",
                    Description="With Black Garlic Mayo",
                    ImageUrl="https://images.unsplash.com/photo-1568919618505-13f7d9eb373f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1650&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem.",
                    Time="20-30 min",
                    Servings="2",
                    Calories="130 per serving"
                },

                new Recipe {Name = "Tahini Chicken",
                    Description="With Crispy Mashed Potatoes & Snow Peas Tomato Salad",
                    ImageUrl="https://images.unsplash.com/photo-1532550907401-a500c9a57435?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1650&q=80",
                    Details="Etiam nullam euismod cras sed aenean leo cursus. Donec viverra risus integer a. Et habitasse natoque viverra erat consectetur nulla molestie eget. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi. Ut lectus volutpat, turpis laoreet morbi donec scelerisque purus lorem. Sed ut sit placerat cursus praesent habitasse euismod. Gravida integer auctor elit, fringilla nisl. Blandit est a nisl, mauris. Nulla mattis integer auctor feugiat ac diam turpis morbi morbi.",
                    Time="50-90 min",
                    Servings="4",
                    Calories="360 per serving"
                }

            };
            
        }
    }
}
