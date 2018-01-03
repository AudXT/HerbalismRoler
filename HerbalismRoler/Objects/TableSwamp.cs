using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableSwamp : Table
    {
        public TableSwamp()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Devils_Bloodleaf},
                new Ingredient {NameEnum = IngredientName.Spineflower_Barries },
                new Ingredient {NameEnum = IngredientName.Emetic_Wax},
                new Ingredient {NameEnum = IngredientName.Amanita_Cap, Double = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Blue_Toadshade, Double = true},
                new Ingredient {NameEnum = IngredientName.Wrackwort_Bulbs},
                new Ingredient {NameEnum = IngredientName.Hydrathistle, Double = true},
                new Ingredient {NameEnum = IngredientName.Primordial_Balm},
            };
        }
    }
}
