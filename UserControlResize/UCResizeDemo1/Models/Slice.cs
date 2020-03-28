using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace UCResizeDemo1
{
    class Slice
    {
        private class SliceData
        {
            private Point origin;

            public Point Origin
            {
                get { return origin; }
                set { origin = value; }
            }
            
            private double startAngle;

            public double StartAngle
            {
                get { return startAngle; }
                set { startAngle = value; }
            }

            private double terminalAngle;

            public double TerminalAngle
            {
                get { return terminalAngle; }
                set { terminalAngle = value; }
            }

            private bool isGreaterThan180;

            public bool IsGreaterThan180
            {
                get { return isGreaterThan180; }
                set { isGreaterThan180 = value; }
            }

            private Point initialSide;

            public Point InitialSide
            {
                get { return initialSide; }
                set { initialSide = value; }
            }

            private Point terminalSide;

            public Point TerminalSide
            {
                get { return terminalSide; }
                set { terminalSide = value; }
            }

            public SliceData()
            {
            }
            public SliceData(Point origin, double startAngle, double terminalAngle)
            {
                this.origin = origin;
                this.startAngle = startAngle;
                this.terminalAngle = terminalAngle;
            }
        }

        private Point CreatePointFromAngle(double angleInRadians, Point origin)
        {
            Point point = new Point();
            point.X = -origin.X * Math.Cos(angleInRadians) + origin.X;
            point.Y = -origin.X * Math.Sin(angleInRadians) + origin.Y;
            return point;
        }

        private double ConvertToRadians(double theta)
        {
            return (Math.PI / 180) * theta;
        }

        private PathFigure CreateIsecak(SliceData isecakData)
        {
            SweepDirection sweepDirection;

            if (isecakData.StartAngle < 0 && isecakData.StartAngle > isecakData.TerminalAngle)
            {
                sweepDirection = SweepDirection.Counterclockwise;
            } else
            {
                sweepDirection = SweepDirection.Clockwise;
            }

            PathFigure isecak = new PathFigure();
            Point origin = isecakData.Origin;
            isecak.StartPoint = origin;
            // Create initial side
            isecak.Segments.Add(new LineSegment(isecakData.InitialSide, true));
            // Add arc
            Size size = new Size(origin.X, origin.X);
            isecak.Segments.Add(
            new ArcSegment(
            isecakData.TerminalSide,
            size,
            0,
            isecakData.IsGreaterThan180,
            sweepDirection,
            true
            )
            );
            // Complete the terminal side line
            isecak.Segments.Add(new LineSegment(new Point(origin.X, origin.Y), true));
            return isecak;
        }

        public PathGeometry makeIsecak(Point origin, double startAngle, double terminalAngle)
        {
            SliceData isecakPodaci = new SliceData(origin, startAngle, terminalAngle);
 
            double angle = terminalAngle - startAngle;
            double thetaInit = ConvertToRadians(startAngle);
            double thetaEnd = ConvertToRadians(terminalAngle);
            isecakPodaci.InitialSide = CreatePointFromAngle(thetaInit, origin);
            isecakPodaci.TerminalSide = CreatePointFromAngle(thetaEnd, origin);
            isecakPodaci.IsGreaterThan180 = (angle > 180);

            PathGeometry isecakGeometry = new PathGeometry();
            isecakGeometry.Figures.Add(CreateIsecak(isecakPodaci));

            return isecakGeometry;
        }
    }
}
