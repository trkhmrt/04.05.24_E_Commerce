using E_Commerce.DataAccess.Entities;

namespace E_Commerce.BusinessLayer.Dto.ResponseDto;

public class BasketDetailDto
{
    public int basketStatusId { get; set; }
    public List<BasketDetail> BasketDetails { get; set; }
}