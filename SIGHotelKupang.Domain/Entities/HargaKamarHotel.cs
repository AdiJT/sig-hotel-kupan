namespace SIGHotelKupang.Domain.Entities;

public class HargaKamarHotel
{
    public int IdHotel { get; set; }
    public int IdTipeKamar { get; set; }

    public double HargaKamar { get; set; }

    public Hotel Hotel { get; set; }
    public TipeKamar TipeKamar { get; set; }
}
