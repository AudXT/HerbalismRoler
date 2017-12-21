using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class CommonTable : Table
    {
        public CommonTable()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {Name = "Mandrake Root"},
                new Ingredient {Name = "Quicksilver Lichen"},
                new Ingredient {Name = "Quicksilver Lichen"},
                new Ingredient {Name = "Wild Sageroot"},
                new Ingredient {Name = "Wild Sageroot"},
                new Ingredient {Name = "Bloodgrass"},
                new Ingredient {Name = "Wyrmtoungue Petals"},
                new Ingredient {Name = "Wyrmtoungue Petals"},
                new Ingredient {Name = "Milkweed Seeds"},
                new Ingredient {Name = "Milkweed Seeds"},
                new Ingredient {Name = "Mandrake Root"},
            };
        }

        public override Ingredient GetIngredient(int v)
        {
            return Ingredients[v];
        }
    }
}
