namespace E_Commerce.BusinessLayer.Dto.ResponseDto;

public class CustomerDto
{
    public int customerId  { get; set; }
    public string customerMail { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }

    public int customerActiveBasketId { get; set; }
}