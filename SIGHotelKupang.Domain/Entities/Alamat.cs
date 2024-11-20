using SIGHotelKupang.Domain.Abstracts;

namespace SIGHotelKupang.Domain.Entities;

public class Alamat : Entity
{
    public string Jalan { get; set; } = string.Empty;
    public string KodePos { get; set; }
    public string Kelurahan { get; set; } = string.Empty;
    public string Kecamatan { get; set; } = string.Empty;

    public Hotel Hotel { get; set; }
}
