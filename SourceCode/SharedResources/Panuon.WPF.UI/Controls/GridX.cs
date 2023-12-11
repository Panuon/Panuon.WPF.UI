using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class GridX
        : Grid
    {
        #region Properties

        #region HorizontalGridLinesBrush
        public Brush HorizontalGridLinesBrush
        {
            get { return (Brush)GetValue(HorizontalGridLinesBrushProperty); }
            set { SetValue(HorizontalGridLinesBrushProperty, value); }
        }

        public static readonly DependencyProperty HorizontalGridLinesBrushProperty =
            DependencyProperty.Register("HorizontalGridLinesBrush", typeof(Brush), typeof(GridX), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #region VerticalGridLinesBrush
        public Brush VerticalGridLinesBrush
        {
            get { return (Brush)GetValue(VerticalGridLinesBrushProperty); }
            set { SetValue(VerticalGridLinesBrushProperty, value); }
        }

        public static readonly DependencyProperty VerticalGridLinesBrushProperty =
            DependencyProperty.Register("VerticalGridLinesBrush", typeof(Brush), typeof(GridX), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #region HorizontalGridLinesThickness
        public double HorizontalGridLinesThickness
        {
            get { return (double)GetValue(HorizontalGridLinesThicknessProperty); }
            set { SetValue(HorizontalGridLinesThicknessProperty, value); }
        }

        public static readonly DependencyProperty HorizontalGridLinesThicknessProperty =
            DependencyProperty.Register("HorizontalGridLinesThickness", typeof(double), typeof(GridX), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #region VerticalGridLinesThickness
        public double VerticalGridLinesThickness
        {
            get { return (double)GetValue(VerticalGridLinesThicknessProperty); }
            set { SetValue(VerticalGridLinesThicknessProperty, value); }
        }

        public static readonly DependencyProperty VerticalGridLinesThicknessProperty =
            DependencyProperty.Register("VerticalGridLinesThickness", typeof(double), typeof(GridX), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #region 
        public GridXGridLinesVisibility GridLinesVisibility
        {
            get { return (GridXGridLinesVisibility)GetValue(GridLinesVisibilityProperty); }
            set { SetValue(GridLinesVisibilityProperty, value); }
        }

        public static readonly DependencyProperty GridLinesVisibilityProperty =
            DependencyProperty.Register("GridLinesVisibility", typeof(GridXGridLinesVisibility), typeof(GridX), new FrameworkPropertyMetadata(GridXGridLinesVisibility.Both, FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #endregion

        #region Overrides

        #region ArrangeOverride
        protected override Size ArrangeOverride(Size arrangeSize)
        {
            var size = base.ArrangeOverride(arrangeSize);
            InvalidateVisual();
            return size;
        }
        #endregion

        #region OnRender
        protected override void OnRender(DrawingContext context)
        {
            if (GridLinesVisibility != GridXGridLinesVisibility.None
                && (VerticalGridLinesThickness > 0 || HorizontalGridLinesThickness > 0))
            {
                var hPen = new Pen(HorizontalGridLinesBrush, HorizontalGridLinesThickness);
                hPen.Freeze();
                var vPen = new Pen(VerticalGridLinesBrush, VerticalGridLinesThickness);
                vPen.Freeze();

                if (ColumnDefinitions.Count == 0
                    && RowDefinitions.Count == 0)
                {
                    return;
                }
                var horizontalGrids = new int[RowDefinitions.Count + 1, ColumnDefinitions.Count + 1];
                var verticalGrids = new int[RowDefinitions.Count + 1, ColumnDefinitions.Count + 1];

                foreach (FrameworkElement child in Children)
                {
                    var row = Math.Min(RowDefinitions.Count - 1, Math.Max(0, Grid.GetRow(child)));
                    var column = Math.Min(ColumnDefinitions.Count - 1, Math.Max(0, Grid.GetColumn(child)));

                    var rowSpan = Math.Max(0, Grid.GetRowSpan(child));
                    var columnSpan = Math.Max(0, Grid.GetColumnSpan(child));

                    var toRow = Math.Min(RowDefinitions.Count, row + rowSpan);
                    var toColumn = Math.Min(ColumnDefinitions.Count, column + columnSpan);

                    if (toRow >= 0)
                    {
                        for (int i = row; i < toRow; i++)
                        {
                            if (column >= 0)
                            {
                                verticalGrids[i + 1, column] = 1;
                            }
                            if (toColumn >= 0)
                            {
                                verticalGrids[i + 1, toColumn] = 1;
                            }
                        }
                    }
                    if (toColumn >= 0)
                    {
                        for (int i = column; i < toColumn; i++)
                        {
                            if (row >= 0)
                            {
                                horizontalGrids[row, i + 1] = 1;
                            }
                            if (toRow >= 0)
                            {
                                horizontalGrids[toRow, i + 1] = 1;
                            }
                        }
                    }

                }

                var offsetX = 0d;
                var offsetY = 0d;
                for (int row = 0; row <= RowDefinitions.Count; row++)
                {
                    offsetX = 0d;

                    var rowHeight = row == 0
                        ? (RowDefinitions.Count == 0 ? ActualHeight : 0)
                        : RowDefinitions[row - 1].ActualHeight;
                    if (rowHeight <= 0)
                    {
                        continue;
                    }

                    for (int column = 0; column <= ColumnDefinitions.Count; column++)
                    {
                        var columnWidth = column == 0
                            ? (ColumnDefinitions.Count == 0 ? ActualWidth : 0)
                            : ColumnDefinitions[column - 1].ActualWidth;
                        if(columnWidth <= 0)
                        {
                            continue;
                        }
                        if ((GridLinesVisibility == GridXGridLinesVisibility.Horizontal || GridLinesVisibility == GridXGridLinesVisibility.Both)
                            && horizontalGrids[row, column] != 0)
                        {
                            context.DrawLine(hPen, new Point(offsetX, offsetY + rowHeight), new Point(offsetX + columnWidth, offsetY + rowHeight));
                        }
                        if ((GridLinesVisibility == GridXGridLinesVisibility.Vertical || GridLinesVisibility == GridXGridLinesVisibility.Both)
                            && verticalGrids[row, column] != 0)
                        {
                            context.DrawLine(vPen, new Point(offsetX + columnWidth, offsetY), new Point(offsetX + columnWidth, offsetY + rowHeight));
                        }
                        offsetX += columnWidth;
                    }
                    offsetY += rowHeight;
                }
                base.OnRender(context);
            }
        }
        #endregion

        #endregion
    }
}
