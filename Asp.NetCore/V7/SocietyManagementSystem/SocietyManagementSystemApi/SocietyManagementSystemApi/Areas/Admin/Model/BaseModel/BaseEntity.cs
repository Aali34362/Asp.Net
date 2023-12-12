namespace SocietyManagementSystemApi.Model;

public class BaseEntity
{
    public long id { get; set; }
    public long crtd_user { get; set; }
    public DateTime crtd_date { get; set; }
    public string? crtd_ip_add { get; set; }
    public long lst_crtd_user { get; set; }
    public DateTime lst_crtd_date { get; set; }
    public string? lst_crtd_ip_add { get; set; }
    public int act_ind { get; set; }
}
