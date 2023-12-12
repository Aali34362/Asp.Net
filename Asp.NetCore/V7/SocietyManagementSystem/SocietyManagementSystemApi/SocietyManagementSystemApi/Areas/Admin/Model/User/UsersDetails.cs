namespace SocietyManagementSystemApi.Model;

public class UsersDetails : BaseEntity
{
    public string? user_create_id { get; set; }
    public string? first_nm { get; set; }
    public string? middle_nm { get; set; }
    public string? last_nm { get; set; }
    public string? address1 { get; set; }
    public string? address2 { get; set; }
    public string? address3 { get; set; }
    public string? email1 { get; set; }
    public string? email2 { get; set; }
    public string? email3 { get; set; }
    public string? phone1 { get; set; }
    public string? phone2 { get; set; }
    public string? phone3 { get; set; }
}