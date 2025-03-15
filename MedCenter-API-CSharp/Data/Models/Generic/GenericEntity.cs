using System.ComponentModel.DataAnnotations;

namespace MedCenter_API_CSharp.Models.Generic;

public abstract class GenericEntity
{
    [Key] public long Id { get; set; }
}