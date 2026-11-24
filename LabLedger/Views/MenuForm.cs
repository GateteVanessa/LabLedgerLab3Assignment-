using LabLedger.Models;
namespace LabLedger.Views;
public partial class MenuForm : Form
{
 public MenuForm(){InitializeComponent();FormTheme.ApplyGreenButtons(this);button1.Click+=(_,_)=>{using var f=new AddEquipmentForm();f.ShowDialog(this);};button3.Click+=(_,_)=>{using var f=new Statistics();f.ShowDialog(this);};button4.Click+=Logout;}
 private void MenuForm_Load(object? sender,EventArgs e)=>label1.Text=$"Welcome, {Session.Username}";
 private void button2_Click(object? sender,EventArgs e){using var f=new ViewEquipmentForm();f.ShowDialog(this);}
 private void Logout(object? sender,EventArgs e){if(MessageBox.Show("Log out of LabLedger?","Confirm logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)return;Session.Username="";Hide();using(var login=new LoginForm())login.ShowDialog();Close();}
}
