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
                return Constant.TOTAL_PRICE + _dataModel.GetFormDataInstance().totalPrice + Constant.DOLLARS;
            }
        }
    }
}
