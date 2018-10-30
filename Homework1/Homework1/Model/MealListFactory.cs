using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class MealListFactory
    {
        const char SPLIT_CONDITION = ' ';
        /// <summary>
        /// 開檔讀檔 並寫入mealList
        /// </summary>
        /// <returns></returns>
        public void ReadData(BindingList<Meal> mealList, BindingList<Category> categories)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\MealData.txt");
            while (!streamReader.EndOfStream)
            {
                Meal meal = new Meal();
                string Access = streamReader.ReadLine();
                string[] splitAccess = Access.Split(SPLIT_CONDITION);
                meal.MealName = splitAccess[0];
                meal.MealPrice = Int32.Parse(splitAccess[1]);
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].CategoryName.Equals(splitAccess[Constant.MAX_SPLIT_NUMBER]))
                        meal.Category = categories[i];
                }
                mealList.Add(meal);
            }
            streamReader.Close();
            SetMealDescription(mealList);
        }

        /// <summary>
        /// 設定菜單簡介
        /// </summary>
        /// <param name="mealList"></param>
        public void SetMealDescription(BindingList<Meal> mealList)
        {
            int count = 0;
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\MealDescription.txt");
            while (!streamReader.EndOfStream)
            {
                string Access = streamReader.ReadLine();
                mealList[count].MealDescription = Access;
                count++;
            }
            streamReader.Close();
        }

        /// <summary>
        /// 設定CategoryList
        /// </summary>
        /// <param name="categories"></param>
        public void ReadCategory(BindingList<Category> categories)
        {
            
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\Category.txt");
            while (!streamReader.EndOfStream)
            {
                Category category = new Category();
                string Access = streamReader.ReadLine();
                category.CategoryName = Access;
                categories.Add(category);
            }
            streamReader.Close();
        }

    }
}
