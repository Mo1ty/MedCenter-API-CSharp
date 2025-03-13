namespace MedCenter_API_CSharp.Data.Dtos
{
    public record CreateUpdateContactDto( 
        string FirstName, 
        string LastName, 
        DateOnly BirthDate, 
        string PhoneNumber, 
        long AddressId);
    
}
