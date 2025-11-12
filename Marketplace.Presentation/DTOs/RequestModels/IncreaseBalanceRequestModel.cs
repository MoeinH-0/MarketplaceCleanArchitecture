namespace Mraketplace.Presention.DTOs.RequestModels;

public class IncreaseBalanceRequestModel(double amount)
{
    public double Amount { get; set; } = amount;
}
