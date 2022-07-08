using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Utils
{
    static class DrawingContextUtil
    {
        public static void DrawLine(DrawingContext drawingContext, Pen pen, Point startPoint, Point endPoint)
        {
            var guidelineSet = new GuidelineSet();
            guidelineSet.GuidelinesX.Add(startPoint.X);
            guidelineSet.GuidelinesY.Add(startPoint.Y);
            guidelineSet.GuidelinesX.Add(endPoint.X);
            guidelineSet.GuidelinesY.Add(endPoint.Y);
            drawingContext.PushGuidelineSet(guidelineSet);

            var half = pen.Thickness / 2;
            startPoint = new Point(startPoint.X + half, startPoint.Y + half);
            endPoint = new Point(endPoint.X + half, endPoint.Y + half);
            drawingContext.DrawLine(pen, startPoint, endPoint);
            drawingContext.Pop();
        }

    }
}
