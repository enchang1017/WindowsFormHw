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
    public partial class CustomerPresentationModel : INotifyPropertyChanged
    {
        private bool _isAddButtonEnabled = false;
        /// <summary>
        /// 通知畫面更改 DataBinding
        /// </summary>
        /// <param name="propertyName"></param>
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TotalPrice
        {
            get
            {
                return Constant.TOTAL_PRICE + _dataModel.FormData.TotalPrice + Constant.DOLLARS;
            }
        }

        public string PageLabel
        {
            get
            {
                return _dataModel.FormData.GetPageLabelText();
            }
        }

        public bool IsPreviousPageEnable
        {
            get
            {
                if (_dataModel.FormData.NowPage == 1)
                {
                    return false;
                }
                return true;
            }
        }

        public bool IsNextPageEnable
        {
            get
            {
                if (_dataModel.FormData.NowPage == _dataModel.FormData.TotalPage)
                {
                    return false;
                }
                return true;
            }
        }

        public bool IsAddButtonEnable
        {
            get
            {
                if (_isAddButtonEnabled)
                    return true;
                return false;
            }
        }
    }
}
