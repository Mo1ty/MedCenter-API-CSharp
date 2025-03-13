namespace MedCenter_API_CSharp.Data.Dtos
{
    public record AddressDto(
        long Id, 
        string City, 
        string PostalCode, 
        string Street, 
        int HouseNumber);
    
}
