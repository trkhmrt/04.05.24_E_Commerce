namespace E_Commerce.BusinessLayer.Dto.RequestDto;

public class CheckOutDto
{
    public int paymentAmount { get; set; }
    public int customerId { get; set; }
    public int basketId { get; set; }
    public int cardNumber { get; set; }
}