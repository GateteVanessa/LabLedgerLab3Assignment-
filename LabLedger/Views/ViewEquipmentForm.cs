using LabLedger.Controllers;
using LabLedger.Models;

namespace LabLedger.Views;

public partial class ViewEquipmentForm : Form
{
    private readonly EquipmentController equipment = new();
    private readonly LoanController loans = new();

    public ViewEquipmentForm()
    {
        InitializeComponent();
        FormTheme.ApplyGreenButtons(this);
        button1.Click += (_, _) => LoadEquipment(txtSearch.Text);
        button2.Click += (_, _) =>
        {
            txtSearch.Clear();
            LoadEquipment();
        };
        button3.Click += Borrow;
        button5.Click += Return;
        button4.Click += Delete;
        button6.Click += (_, _) => Close();
        txtSearch.KeyDown += (_, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadEquipment(txtSearch.Text);
            }
        };
        Load += (_, _) => LoadEquipment();
    }

    private void LoadEquipment(string search = "")
    {
        try
        {
            dataGridView1.Rows.Clear();
            foreach (Equipment item in equipment.List(search))
            {
                int row = dataGridView1.Rows.Add(item.Name, item.AssetId, item.Category,
                    item.Lab, item.TotalQuantity, item.AvailableQuantity, item.Status);
                dataGridView1.Rows[row].Tag = item.Id;
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Equipment could not be loaded from the database.", "LabLedger",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private int? SelectedEquipmentId()
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select an equipment row first.", "LabLedger",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        return (int)dataGridView1.SelectedRows[0].Tag!;
    }

    private void Borrow(object? sender, EventArgs e)
    {
        int? id = SelectedEquipmentId();
        if (id is null) return;
        OperationResult result = loans.Borrow(id.Value, textBox2.Text, textBox3.Text);
        MessageBox.Show(result.Message, "LabLedger", MessageBoxButtons.OK,
            result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (result.Success) LoadEquipment(txtSearch.Text);
    }

    private void Return(object? sender, EventArgs e)
    {
        int? id = SelectedEquipmentId();
        if (id is null) return;
        OperationResult result = loans.Return(id.Value, textBox2.Text, textBox3.Text);
        MessageBox.Show(result.Message, "LabLedger", MessageBoxButtons.OK,
            result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (result.Success) LoadEquipment(txtSearch.Text);
    }

    private void Delete(object? sender, EventArgs e)
    {
        int? id = SelectedEquipmentId();
        if (id is null) return;
        if (MessageBox.Show("Delete the selected equipment?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        OperationResult result = equipment.Delete(id.Value);
        MessageBox.Show(result.Message, "LabLedger", MessageBoxButtons.OK,
            result.Success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        if (result.Success) LoadEquipment(txtSearch.Text);
    }
}
