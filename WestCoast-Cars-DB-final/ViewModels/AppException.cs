namespace WestCoast_Cars.ViewModels;

public class AppException(string message, string details) : Exception(message)
{
  public string Details { get; set; } = details;
}
