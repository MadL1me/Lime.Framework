namespace Lime.Framework.Core;

/// <summary>
/// Used to make objects thread-safe and mutable/immutable by calling ChangeMutability() method
/// </summary>
public interface IMutabilityChangable
{
    bool isMutable { get; set; }

    void ChangeMutability(bool isMutable);
}