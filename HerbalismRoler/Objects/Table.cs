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
                throw new NotImplementedException();

            return Ingredients[v];
        }
    }
}