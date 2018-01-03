using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableForest : Table
    {
        public TableForest()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Harrada_Leaf},
                new Ingredient {NameEnum = IngredientName.Nightshade_Berries },
                new Ingredient {NameEnum = IngredientName.Emetic_Wax},
                new Ingredient {NameEnum = IngredientName.Verdant_Nettle},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Arrow_Root},
                new Ingredient {NameEnum = IngredientName.Ironwood_Heart},
                new Ingredient {NameEnum = IngredientName.Blue_Toadshade},
                new Ingredient {NameEnum = IngredientName.Wisp_Stalks, Double = true },
                //Add a way for the wisp stalks to check if day or night
            };
        }
    }
}
