using SIGHotelKupang.Domain.Abstracts;

namespace SIGHotelKupang.Domain.Entities;

public class TipeKamar : Entity
{
    public string Nama { get; set; } = string.Empty;

    public List<HargaKamarHotel> DaftarHargaKamarHotel { get; set; } = [];
}
