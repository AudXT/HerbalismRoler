using HerbalismRoler.Objects;
using System;
using System.Collections.Generic;

namespace HerbalismRoler
{
    public class Table
    {
        public List<Ingredient> Ingredients;

        public virtual Ingredient GetIngredient(int v)
        {
            if (Ingredients[v].IsCommon)
            {
                TableCommon table = new TableCommon();
                return table.GetIngredient(v);
            }

            return Ingredients[v];
        }
    }
}