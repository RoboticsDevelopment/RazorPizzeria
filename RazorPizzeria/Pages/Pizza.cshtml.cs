using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=2
            },

            
            new PizzasModel()
            {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                FinalPrice=5

            },
            new PizzasModel()
            {
                ImageTitle="MeatFeast",
                PizzaName="Meat Feast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Ham=true,
                Beef=true,
                FinalPrice=10

            },
            new PizzasModel()
            {
                ImageTitle="Vegetarian",
                PizzaName="Vagetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=4

            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian",
                PizzaName="Hawaian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                Ham=true,
                FinalPrice=4

            },
            new PizzasModel()
            {
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=4

            },
        };
        public void OnGet()
        {
        }
    }
}
