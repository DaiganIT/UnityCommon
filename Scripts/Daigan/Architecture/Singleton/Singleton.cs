using UnityEngine;

namespace Daigan.Architecture
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        protected static T instance;
        public static T Instance { get
            {
                if (instance == null)
                {
                    instance = FindAnyObjectByType<T>();
                    if (instance == null)
                    {
                        var go = new GameObject(typeof(T).Name + " -- AutoGen --");
                        instance = go.AddComponent<T>();
                    }
                }

                return instance;
            } 
        }

        /// <summary>
        /// If you need Awake in your extension, make sure to call base.Awake() and override Awake
        /// </summary>
        protected virtual void Awake()
        {
            InitSingleton();
        }

        protected virtual void InitSingleton()
        {
            instance = this as T;
        }
    }
}