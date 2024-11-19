using NetTopologySuite.Geometries;
using SIGHotelKupang.Domain.Abstracts;
using SIGHotelKupang.Domain.Enums;

namespace SIGHotelKupang.Domain.Entities;

public class LokasiPenting : Entity
{
    public string Nama { get; set; } = string.Empty;
    public Point TitikKoordinat { get; set; } = Point.Empty;
    public KategoriLokasiPenting KategoriLokasiPenting { get; set; }
}