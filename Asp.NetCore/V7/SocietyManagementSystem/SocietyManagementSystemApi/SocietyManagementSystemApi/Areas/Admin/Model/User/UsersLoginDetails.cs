namespace SocietyManagementSystemApi.Model;

public class UsersLoginDetails : BaseEntity
{
    public string? user_create_id { get; set; }
    public string? access_token { get; set; }
    public string? refresh_token { get; set; }
    public DateTime start_date { get; set; }
    public DateTime end_date { get; set; }
    public string? source_system { get; set; }
}

