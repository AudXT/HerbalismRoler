using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableCostalUnderwater : Table
    {
        public TableCostalUnderwater()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Hydrathistle, Double = true},
                new Ingredient {NameEnum = IngredientName.Amanita_Cap},
                new Ingredient {NameEnum = IngredientName.Hyancinth_Nectar},
                new Ingredient {NameEnum = IngredientName.Chromus_Slime, Double = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Lavender_Sprig, Double = true},
                new Ingredient {NameEnum = IngredientName.Blue_Toadshade},
                new Ingredient {NameEnum = IngredientName.Wrackwort_Bulbs},
                new Ingredient {NameEnum = IngredientName.Cosmos_Glond, Double = true},
            };
        }
    }
}
