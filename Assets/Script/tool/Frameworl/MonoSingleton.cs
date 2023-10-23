using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
	///<summary>
	///脚本单例类：用作管理类的父，方便查找管理类，无论在哪都直接可以用类名.Instance访问成员。
    ///适用性：场景中存在唯一对象，即可让该对象继承当前类。
    ///如何使用：①继承时必须传递子类类型；②在脚本任意生命周期中，通过类名.Instance即可访问该唯一对象的成员。
	///</summary>
	public class MonoSingleton<T> : MonoBehaviour where T :MonoSingleton<T>
	{
		private static T instance;
        /// <summary>
        /// 单一对象的引用，可以通过类名直接获得此，然后访问其他成员
        /// </summary>
		public static T Instance
        {
			get
            {
				if (instance == null)
                {
                    instance = FindObjectOfType<T>();
					if(instance == null)
                    {
                        //如果没有该物体，则创建一个，并立即执行一次Awake()
                        new GameObject("single of "+typeof(T).Name).AddComponent<T>();
                    }
                    else
                    {
                        instance.Init();
                    }
                }
				return instance;
            }
        }
        protected void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                Init();
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void Init()
        {
        }
    }
}