using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IDB<T, K>
    {
        void Create(T item);

        T Read(K key, bool useNavigationProperties = false);

        IEnumerable<T> ReadAll(bool useNavigationProperties = false);

        IEnumerable<T> Read(int skip, int take, bool useNavigationProperties = false);

        void Update(T item, bool useNavigationProperties = false);

        void Delete(K key);

    }
}
