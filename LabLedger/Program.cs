using LabLedger.Data;
using LabLedger.Views;
namespace LabLedger;
internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        try { DatabaseHelper.Initialize(); Application.Run(new LoginForm()); }
        catch (Exception ex) { MessageBox.Show($"The database could not be initialized. {ex.Message}", "LabLedger", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
}
