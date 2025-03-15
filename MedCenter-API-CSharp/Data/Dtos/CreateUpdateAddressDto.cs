namespace MedCenter_API_CSharp.Data.Dtos
{
    public record CreateUpdateAddressDto(
        string City, 
        string PostalCode, 
        string Street, 
        int HouseNumber);
    
}
