using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableHills : Table
    {
        public TableHills()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Devils_Bloodleaf},
                new Ingredient {NameEnum = IngredientName.Nightshade_Berries },
                new Ingredient {NameEnum = IngredientName.Tail_Leaf, Double = true},
                new Ingredient {NameEnum = IngredientName.Lavender_Sprig},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Ironwood_Heart},
                new Ingredient {NameEnum = IngredientName.Gengko_Brush},
                new Ingredient {NameEnum = IngredientName.Rock_Vine, Double = true},
                new Ingredient {NameEnum = IngredientName.Harrada_Leaf},
            };
        }
    }
}
