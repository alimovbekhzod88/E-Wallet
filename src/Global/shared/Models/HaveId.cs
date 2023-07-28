﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.shared
{
    public abstract class HaveId
    {
        public static HaveId<TId> Create<TId>(TId id)
        {
            return new HaveId<TId>(id);
        }
    }
    public interface IHaveId
    {
        object GetId();
    }
    public interface IHaveId<TId> : IHaveId, IHaveIdProp<TId>
    { }
    public interface IHaveIdProp<TId>
    {
        TId Id { get; set; }
    }
    public class HaveId<TId> : IHaveId<TId>
    {
        public HaveId(TId id)
        {
            Id = id;
        }
        public TId Id { get; set; }
        public object GetId() => Id;
    }
    public class HaveIdEqualityComparer<TId, T> : IEqualityComparer<T>
        where T : class, IHaveIdProp<TId>
    {
        public bool Equals(T x, T y) => x.Equals(y.Id);

        public int GetHashCode([DisallowNull] T obj) => obj.Id.GetHashCode();
    }
}
