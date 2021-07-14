using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Panuon.UI.Core
{
    public class PathBuilder
    {
        #region Fields
        private StringBuilder _pathBuilder;

        private Point? _currentStartPoint;
        #endregion

        #region Ctor
        public PathBuilder()
        {
            _pathBuilder = new StringBuilder();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return _pathBuilder.ToString();
        }
        #endregion

        #region Internal Methods
        internal void Append(string path)
        {
            _pathBuilder.Append(path);
        }
        #endregion
    }

    public static class PathBuilderExtensions
    {
        #region LineTo
        public static PathBuilder LineTo(this PathBuilder pathBuilder, Point endPoint)
        {
            return pathBuilder.LineTo(endPoint.X, endPoint.Y);
        }

        public static PathBuilder LineTo(this PathBuilder pathBuilder, double endX, double endY)
        {
            pathBuilder.Append($"L {endX},{endY}");
            return pathBuilder;
        }
        #endregion

        #region AddLine
        public static PathBuilder AddLine(this PathBuilder pathBuilder, Point startPoint, Point endPoint)
        {
            return pathBuilder.AddLine(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }

        public static PathBuilder AddLine(this PathBuilder pathBuilder, double startX, double startY, double endX, double endY)
        {
            pathBuilder.Append($"M {startX},{startY} L {endX},{endY}");
            return pathBuilder;
        }
        #endregion

        #region ArcTo
        public static PathBuilder ArcTo(this PathBuilder pathBuilder, Point endPoint, double radiusX, double radiusY)
        {
            return pathBuilder.ArcTo(endPoint.X, endPoint.Y, radiusX, radiusY);
        }

        public static PathBuilder ArcTo(this PathBuilder pathBuilder, double endX, double endY, double radiusX, double radiusY)
        {
            pathBuilder.Append($"A {endX},{endY}");
            return pathBuilder;
        }
        #endregion

        #region AddArc
        #endregion

        #region PolyLineTo
        #endregion

        #region AddPolyLine
        #endregion

        #region ArrowTo
        #endregion

        #region AddArrow
        #endregion

        #region SmoothCurveTo
        #endregion

        #region AddSmoothCurve
        #endregion
    }
}
