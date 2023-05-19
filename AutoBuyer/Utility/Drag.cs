namespace AutoBuyer.Utility
{
    internal class Drag
    {
        public Point MousePointer { get; protected set; }

        public void SetStartPoint(MouseEventArgs e) => SetStartPoint(-e.X, -e.Y);

        public void SetStartPoint(int x, int y) => MousePointer = new Point(x, y);

        public Point MouseDrag(Point currentPosition)
        {
            var mousePosition = currentPosition;
            mousePosition.Offset(MousePointer.X, MousePointer.Y);

            return mousePosition;
        }
    }
}
