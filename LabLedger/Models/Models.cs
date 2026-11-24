namespace LabLedger.Models;
// Plain application data objects used by controllers and views.
public class User { public int Id { get; set; } public string Username { get; set; } = ""; public string PasswordHash { get; set; } = ""; public string Salt { get; set; } = ""; }
public class Equipment
{
    public int Id { get; set; } public string Name { get; set; } = ""; public string AssetId { get; set; } = ""; public string Category { get; set; } = ""; public string Lab { get; set; } = ""; public int TotalQuantity { get; set; } public int AvailableQuantity { get; set; }
    public string Status => AvailableQuantity == 0 ? "Out of Stock" : AvailableQuantity < 3 ? "Low Stock" : "Available";
}
public class Loan { public int Id { get; set; } public int EquipmentId { get; set; } public string StudentId { get; set; } = ""; public int QuantityBorrowed { get; set; } public int QuantityReturned { get; set; } public string BorrowedAt { get; set; } = ""; }
public class EquipmentStatistics { public int TotalItems { get; set; } public int TotalUnits { get; set; } public int OnLoan { get; set; } public string MostBorrowed { get; set; } = "None"; public int OutOfStock { get; set; } }
public class OperationResult { public bool Success { get; set; } public string Message { get; set; } = ""; public static OperationResult Ok(string message) => new() { Success = true, Message = message }; public static OperationResult Fail(string message) => new() { Message = message }; }
public static class Session { public static string Username { get; set; } = ""; }
