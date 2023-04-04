using System;

public class Functions
{
	public Functions()
	{
	}

    public static void MakeCircularButton(Button button)
    {
        button.BackColor = Color.Transparent;
        button.FlatAppearance.BorderSize = 0;
        button.FlatStyle = FlatStyle.Flat;
        button.Size = new Size(50, 50);
        button.TabStop = false;
        button.BackgroundImage = CropToCircle(button.BackgroundImage, button.Size);
        button.BackgroundImageLayout = ImageLayout.Zoom;
    }
}
