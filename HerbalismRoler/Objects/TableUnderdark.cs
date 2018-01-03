using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableUnderdark : Table
    {
        public TableUnderdark()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Primordial_Balm, Double = true},
                new Ingredient {NameEnum = IngredientName.Silver_Hibiscus },
                new Ingredient {NameEnum = IngredientName.Devils_Bloodleaf},
                new Ingredient {NameEnum = IngredientName.Chromus_Slime},
                new Ingredient {NameEnum = IngredientName.Mortflesh_Powder, Double = true},
                new Ingredient {NameEnum = IngredientName.Fennel_Silk},
                new Ingredient {NameEnum = IngredientName.Friends_Ivy},
                new Ingredient {NameEnum = IngredientName.Gengko_Brush},
                new Ingredient {NameEnum = IngredientName.Luminous_Cap_Dust},
                new Ingredient {NameEnum = IngredientName.Radiant_Synthseed, Double = true},
                new Ingredient {NameEnum = IngredientName.Wisp_Stalks},
            };
        }
    }
}
