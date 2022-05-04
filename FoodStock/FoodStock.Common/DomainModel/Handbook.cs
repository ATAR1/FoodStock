using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStock.Common.DomainModel
{
    /// <summary>
    /// Справочник продуктов, блюд, приемов пищи, советов и  энергозатрат  
    /// </summary>
    public class Handbook
    {
        public DishesTree Dishes { get; }

        public FoodItemsCatalog FoodItems { get; }

        public AdviceCatalog Advices { get; }

        public EnergyCostTree EnergyCost { get; }

        //todo Начинать сохранение с продуктов 
        public void SaveAll()
        {
            throw new NotImplementedException();
        }

        public void SaveCurrent()
        {
            //todo CurrentCatalog.Save();
        }
        
    }
}
