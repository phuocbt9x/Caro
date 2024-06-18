namespace Caro;
using System.Diagnostics;

public partial class MainPage : ContentPage
{
	private Board board;
	public MainPage()
	{
		InitializeComponent();
		board = (Board)Resources["board"];
	}

	private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
		if (e.StatusType == GestureStatus.Running)
        {
            board.UpdateOffset((float)e.TotalX, (float)e.TotalY);
            BoardView.Invalidate();
        }
    }
}

