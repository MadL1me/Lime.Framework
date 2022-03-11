namespace Lime.Framework.Core;

/// <summary>
/// Domain Driven Design Entity, must have Id of some type
/// </summary>
public interface IEntity<TId> 
{
    TId Id { get; set; }
}

/// <summary>
/// Domain Driven Design Entity with integer ID
/// </summary>
public interface IEntity : IEntity<int>
{
    
}