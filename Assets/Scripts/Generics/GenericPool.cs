using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Generics
{
    public class GenericPool<T> : GenericSingleton<GenericPool<T>> where T : class
    {
        private List<PooledItem<T>> poolList = new List<PooledItem<T>>();
        public T GetItem()
        {
            if (poolList.Count > 0)
            {
                PooledItem<T> item = poolList.Find(i => i.isUsed == false);
                if (item != null)
                {
                    item.isUsed = true;
                    return item.item;
                }
            }
            
            PooledItem<T> pooledItem = new PooledItem<T>();
            pooledItem.isUsed = true;
            pooledItem.item = CreatePooledItem();
            poolList.Add(pooledItem);
            return pooledItem.item;
        }

        public void ReturnItem(T item)
        {
            PooledItem<T> pooledItem = poolList.Find(i => i.item.Equals(item));
            if (pooledItem != null)
            {
                pooledItem.isUsed = false;
            }
        }

        public virtual T CreatePooledItem()
        {
            return (T) null;
        }
    }

    public class PooledItem<T>
    {
        public bool isUsed;
        public T item; 
    }
}
