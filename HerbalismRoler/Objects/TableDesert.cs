using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableDesert : Table
    {
        public TableDesert()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Cosmos_Glond},
                new Ingredient {NameEnum = IngredientName.Arrow_Root },
                new Ingredient {NameEnum = IngredientName.Dried_Ephedra},
                new Ingredient {NameEnum = IngredientName.Cactus_Juice, Double = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Darkus_Flower},
                new Ingredient {NameEnum = IngredientName.Scillia_Beans},
                new Ingredient {NameEnum = IngredientName.Spineflower_Barries},
                new Ingredient {NameEnum = IngredientName.Voidroot, ExtraWater = true },
            };
        }
    }
}
