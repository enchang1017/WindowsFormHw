using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public partial class RestaurantSidePresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DataModel _dataModel = new DataModel();
        private BindingList<string> _mealListData = new BindingList<string>();
        private bool _isMealSaveButtonEnable = false;
        private bool _isCategoryButtonEnable = false;
        private string _mealSaveButtonText = Constant.SAVE;
        private string _categorySaveButtonText = Constant.SAVE;

        public RestaurantSidePresentationModel(DataModel dataModel)
        {
            _dataModel = dataModel;
        }

        //更改後把Save 按鈕設為true
        public void ChangeDescription()
        {
            _isMealSaveButtonEnable = true;
            Notify(Constant.NOTIFY_SAVE_BUTTON_ENABLE);
        }

        //判斷CategorySaveButton狀態
        public void ChangeCategoryTextBoxText(string text)
        {
            if (text != "")
            {
                _isCategoryButtonEnable = true;
            }
            else
            {
                _isCategoryButtonEnable = false;
            }
            Notify(Constant.NOTIFY_SAVE_CATEGORY);
        }

        //判斷SaveButton狀態
        public void ChangeTextBoxText(string[] text)
        {
            foreach (string texts in text)
            {
                if (texts == Constant.INITIAL)
                {
                    _isMealSaveButtonEnable = false;
                    break;
                }
                _isMealSaveButtonEnable = true;
            }
            Notify(Constant.NOTIFY_SAVE_BUTTON_ENABLE);
        }

        /// <summary>
        /// 取得ManagerGroupBox頁面
        /// </summary>
        public void GetCategoryManagerGroupBox()
        {
            _isCategoryButtonEnable = false;
            Notify(Constant.NOTIFY_SAVE_BUTTON_ENABLE);
        }

    }
}