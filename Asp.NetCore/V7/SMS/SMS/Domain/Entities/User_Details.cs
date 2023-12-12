using Domain.Primitives;

namespace Domain.Entities;


public sealed class User_Details : BaseEntity
{
    public string? user_create_id { get; init; }
    public string? first_nm { get; init; } = string.Empty;
    public string? middle_nm { get; init; }
    public string? last_nm { get; init; }
    public string? address1 { get; init; }
    public string? address2 { get; init; }
    public string? address3 { get; init; }
    public string? email1 { get; init; }
    public string? email2 { get; init; }
    public string? email3 { get; init; }
    public string? phone1 { get; init; }
    public string? phone2 { get; init; }
    public string? phone3 { get; init; }
}

//What is sealed Class ?
/*
 */