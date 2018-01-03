using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableCommon : Table
    {
        public TableCommon()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Mandrake_Root},
                new Ingredient {NameEnum = IngredientName.Quicksilver_Lichen},
                new Ingredient {NameEnum = IngredientName.Quicksilver_Lichen},
                new Ingredient {NameEnum = IngredientName.Wild_Sageroot},
                new Ingredient {NameEnum = IngredientName.Wild_Sageroot},
                new Ingredient {NameEnum = IngredientName.Bloodgrass},
                new Ingredient {NameEnum = IngredientName.Wyrmtongue_Petals},
                new Ingredient {NameEnum = IngredientName.Wyrmtongue_Petals},
                new Ingredient {NameEnum = IngredientName.Milkweed_Seeds},
                new Ingredient {NameEnum = IngredientName.Milkweed_Seeds},
                new Ingredient {NameEnum = IngredientName.Mandrake_Root},
            };
        }

        public override Ingredient GetIngredient(int v)
        {
            return Ingredients[v];
        }
    }
}
