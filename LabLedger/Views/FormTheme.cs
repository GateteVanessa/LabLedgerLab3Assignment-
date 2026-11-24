namespace LabLedger.Views;

internal static class FormTheme
{
    public static void ApplyGreenButtons(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            if (control is Button button)
            {
                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.FromArgb(46, 125, 50);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.FromArgb(36, 105, 40);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
                button.Cursor = Cursors.Hand;
            }

            if (control.HasChildren)
                ApplyGreenButtons(control);
        }
    }
}
