using LabLedger.Controllers;
namespace LabLedger.Views;
public partial class Statistics : Form
{
 public Statistics(){InitializeComponent();FormTheme.ApplyGreenButtons(this);Text="Statistics";button1.Click+=(_,_)=>Close();Load+=ShowStatistics;}
 private void ShowStatistics(object? sender,EventArgs e){try{var s=new StatisticsController().Get();textBox1.Text=s.TotalItems.ToString();textBox5.Text=s.TotalUnits.ToString();textBox4.Text=s.OnLoan.ToString();textBox3.Text=s.MostBorrowed;textBox2.Text=s.OutOfStock.ToString();foreach(var box in new[]{textBox1,textBox2,textBox3,textBox4,textBox5})box.ReadOnly=true;}catch(Exception){MessageBox.Show("Statistics could not be loaded.","LabLedger",MessageBoxButtons.OK,MessageBoxIcon.Error);}}
 private void textBox5_TextChanged(object? sender,EventArgs e) { }
}
