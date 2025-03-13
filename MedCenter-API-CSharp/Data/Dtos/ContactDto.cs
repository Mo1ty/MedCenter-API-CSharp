namespace MedCenter_API_CSharp.Data.Dtos
{
    public record ContactDto(
        long Id, 
        string FirstName, 
        string LastName, 
        DateOnly BirthDate, 
        string PhoneNumber, 
        long AddressId);
    
}
