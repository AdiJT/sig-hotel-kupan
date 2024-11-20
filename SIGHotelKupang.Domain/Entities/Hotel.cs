using NetTopologySuite.Geometries;
using SIGHotelKupang.Domain.Abstracts;
using SIGHotelKupang.Domain.Enums;

namespace SIGHotelKupang.Domain.Entities;

public class Hotel : Entity
{
    public string Nama { get; set; } = string.Empty;
    public Point TitikKoordinat { get; set; } = Point.Empty;
    public KlasifikasiHotel KlasifikasiHotel { get; set; }
    public TimeOnly? BatasBawahJamCheckIn { get; set; }
    public TimeOnly? BatasAtasJamCheckIn { get; set; }
    public TimeOnly? BatasBawahJamCheckOut { get; set; }
    public TimeOnly? BatasAtasJamCheckOut { get; set; }
    public string NomorTelepon { get; set; } = string.Empty;
    public Uri Website { get; set; }
    public string Email { get; set; } = string.Empty;
    public Uri FotoHotel { get; set; }
    public int JumlahKamar { get; set; }
    public double Rating { get; set; }

    public Alamat Alamat { get; set; }
    public List<Fasilitas> DaftarFasilitas { get; set; } = [];
    public List<HargaKamarHotel> DaftarHargaKamarHotel { get; set; } = [];
}