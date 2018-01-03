using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableGrasslands : Table
    {
        public TableGrasslands()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Harrada_Leaf},
                new Ingredient {NameEnum = IngredientName.Darkus_Flower },
                new Ingredient {NameEnum = IngredientName.Lavender_Sprig, Double = true},
                new Ingredient {NameEnum = IngredientName.Arrow_Root},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Scillia_Beans, Double = true },
                new Ingredient {NameEnum = IngredientName.Cactus_Juice},
                new Ingredient {NameEnum = IngredientName.Tail_Leaf},
                new Ingredient {NameEnum = IngredientName.Hyancinth_Nectar},
            };
        }
    }
}
