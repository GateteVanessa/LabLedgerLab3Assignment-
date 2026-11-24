using LabLedger.Controllers;
namespace LabLedger.Views;
public partial class LoginForm : Form
{
 private readonly AuthController auth=new();
 public LoginForm(){InitializeComponent();FormTheme.ApplyGreenButtons(this);textBox2.UseSystemPasswordChar=true;button1.Click+=Login;button2.Click+=(_,_)=>Close();AcceptButton=button1;}
 private void Login(object? sender,EventArgs e){var result=auth.Login(textBox1.Text,textBox2.Text);if(!result.Success){MessageBox.Show(result.Message,"Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);return;}Hide();using(var menu=new MenuForm())menu.ShowDialog();Close();}
 // These handlers remain because the unchanged designer still references them.
 private void label1_Click(object? sender,EventArgs e) { }
 private void textBox1_TextChanged(object? sender,EventArgs e) { }
}
