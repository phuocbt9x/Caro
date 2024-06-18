namespace Caro;

class Board : IDrawable {
    protected readonly float cellSize = 50f;
    private float offsetX = 0f;
    private float offsetY = 0f;

    public void UpdateOffset(float dx, float dy)
    {
        offsetX += dx;
        offsetY += dy;
    }

    public void Draw(ICanvas canvas, RectF rect) {
        canvas.StrokeColor = Colors.Black;
        canvas.StrokeSize = 1;

        int numberOfLinesHorizontal = (int)Math.Ceiling(rect.Height / cellSize);
        int numberOfLinesVertical = (int)Math.Ceiling(rect.Width / cellSize);

        for (int i = 0; i <= numberOfLinesHorizontal; i++) {
            float y = i * cellSize + offsetY % cellSize;
            canvas.DrawLine(rect.Left, y, rect.Right, y);
        }

        for (int j = 0; j <= numberOfLinesVertical; j++) {
            float x = j * cellSize + offsetX % cellSize;
            canvas.DrawLine(x, rect.Top, x, rect.Bottom);
        }
    }
}