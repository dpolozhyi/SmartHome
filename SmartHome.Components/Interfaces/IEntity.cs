using MongoDB.Bson;

namespace SmartHome.Components.Interfaces
{
    public interface IEntity
    {
        ObjectId Id { get; set; }
    }
}