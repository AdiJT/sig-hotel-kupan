using SIGHotelKupang.Domain.Abstracts;

namespace SIGHotelKupang.Domain.Entities;

public class Fasilitas : Entity
{
    public string Nama { get; set; } = string.Empty;

    public List<Hotel> DaftarHotel { get; set; } = [];
}
