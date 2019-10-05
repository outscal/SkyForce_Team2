using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkyForce.Generics
{
    public class GenericSingleton<T> where T : GenericSingleton<T>, new()
    {
        private static T instance = null;
        public static T Instance{
            get{
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
        protected GenericSingleton()
        {
            
        }
    }
}
