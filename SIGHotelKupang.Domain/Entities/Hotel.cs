using NetTopologySuite.Geometries;
using SIGHotelKupang.Domain.Abstracts;
using SIGHotelKupang.Domain.Enums;

namespace SIGHotelKupang.Domain.Entities;

public class Hotel : Entity
{
    public string Nama { get; set; } = string.Empty;
    public Point TitikKoordinat { get; set; } = Point.Empty;
    public KlasifikasiHotel KlasifikasiHotel { get; set; }
    public int? BatasBawahJamCheckIn { get; set; }
    public int? BatasAtasJamCheckIn { get; set; }
    public int? BatasBawahJamCheckOut { get; set; }
    public int? BatasAtasJamCheckOut { get; set; }
    public string NomorTelepon { get; set; } = string.Empty;
    public required Uri FotoHotel { get; set; }
    public int JumlahKamar { get; set; }

    public Alamat Alamat { get; set; }
    public List<Fasilitas> DaftarFasilitas { get; set; } = [];
    public List<HargaKamarHotel> DaftarHargaKamarHotel { get; set; } = [];
}