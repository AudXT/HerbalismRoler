using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableMountains : Table
    {
        public TableMountains()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Baslisks_Breath},
                new Ingredient {NameEnum = IngredientName.Frozen_Seedlings, Double = true },
                new Ingredient {NameEnum = IngredientName.Arctic_Creeper, Double = true},
                new Ingredient {NameEnum = IngredientName.Dried_Ephedra},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Darkus_Flower},
                new Ingredient {NameEnum = IngredientName.Luminous_Cap_Dust, Double = true},
                new Ingredient {NameEnum = IngredientName.Rock_Vine},
                new Ingredient {NameEnum = IngredientName.Primordial_Balm},
            };
        }
    }
}
