namespace SIGHotelKupang.Domain.Abstracts;

public abstract class Entity : IEquatable<Entity>
{
    public int Id { get; set; }

    public bool Equals(Entity? other) => other is not null && other.GetType() == GetType() && Id == other.Id;

    public override bool Equals(object? obj) => obj is not null && obj is Entity entity && obj.GetType() == GetType() && entity.Id == Id;

    public override int GetHashCode() => Id.GetHashCode();
}
