using UnityEngine;

namespace Daigan.Extensions
{
    public static class GameObjectExtensions
    {
        public static T GetOrAdd<T>(this GameObject monoBehaviour) where T : Component
        {
            if(monoBehaviour.TryGetComponent(out T component))
            {
                return component;
            }

            return monoBehaviour.AddComponent<T>();
        }
    }
}