using LabLedger.Controllers;
namespace LabLedger.Views;
public partial class AddEquipmentForm : Form
{
 private readonly EquipmentController controller=new();
 public AddEquipmentForm(){InitializeComponent();FormTheme.ApplyGreenButtons(this);Text="Add Equipment";button1.Click+=Save;button2.Click+=(_,_)=>Close();}
 private void Save(object? sender,EventArgs e){var category=textBox4.Text.Trim();if(string.IsNullOrWhiteSpace(category)){MessageBox.Show("Enter a category (Laptop, Desktop, Projector, Network Device, Peripheral or Other).","Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);return;}var result=controller.Add(textBox1.Text,textBox5.Text,category,textBox3.Text,textBox2.Text);MessageBox.Show(result.Message,"LabLedger",MessageBoxButtons.OK,result.Success?MessageBoxIcon.Information:MessageBoxIcon.Warning);if(result.Success){textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();textBox5.Clear();}}
 private void label4_Click(object? sender,EventArgs e) { }
 private void label3_Click(object? sender,EventArgs e) { }
}
