using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal.Utils
{
    internal static class GridLengthUtil
    {
        #region Identifier
        private static TypeConverter _tcGridLength;
        private static TypeConverter _tcDataGridLength;
        #endregion

        #region Ctor
        static GridLengthUtil()
        {
            _tcGridLength = TypeDescriptor.GetConverter(typeof(GridLength));
            _tcDataGridLength = TypeDescriptor.GetConverter(typeof(DataGridLength));
        }
        #endregion

        #region Methods

        #region ConvertToGridLength
        public static GridLength ConvertToGridLength(string widthOrHeight)
        {
            try
            {
                return (GridLength)_tcGridLength.ConvertFromString(widthOrHeight);
            }
            catch
            {
                return new GridLength(1, GridUnitType.Auto);
            }
        }
        #endregion

        #region ConvertToDataGridLength
        public static DataGridLength ConvertToDataGridLength(string widthOrHeight)
        {
            try
            {
                return (DataGridLength)_tcDataGridLength.ConvertFromString(widthOrHeight);
            }
            catch
            {
                return new DataGridLength(1, DataGridLengthUnitType.Auto);
            }
        }
        #endregion

        #region ComputeValue
        public static double ComputeValue(double value, GridLength gridLength)
        {
            if (gridLength.IsAbsolute)
            {
                return gridLength.Value;
            }
            if (gridLength.IsStar)
            {
                return Math.Max(value, value * gridLength.Value);
            }
            return double.NaN;
        }
        #endregion

        #endregion
    }
}
