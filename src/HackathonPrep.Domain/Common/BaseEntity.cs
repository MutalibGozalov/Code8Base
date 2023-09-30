using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonPrep.Domain.Common;
/// <summary>
/// Base entity class that serves as the foundation for other classes with a unique identifier (Id).
/// </summary>
/// <typeparam name="TKey">The type of the identifier.</typeparam>
public class BaseEntity<TKey> where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    [Key]
    public TKey Id { get; set; } = default!;
}