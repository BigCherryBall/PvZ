using System;
using System.Collections.Generic;
using UnityEngine;
using Framework;

/// <summary>
/// UI框架。
/// 核心类:①.UI 窗口类UIWindow: 所有UI窗口的基类，可以代表所有窗口(概念继承，以层次化方式管理类); 定义所有窗口共有行为(显隐)。。
///       ②.UI 管理类UIManager: 管理(记录、禁用、查找)窗口；定义所有窗口的共有行为(获取监听器)。。
///       ③.UI事件监听器UlEventListener: 提供当前UI所有事件(带事件参数类)。。
///使用方法:
///①.定义UIXXXWindow类，继承自UIWindow， 负责处理该窗口逻辑。通过GetUlEventListener 方法获取需要交互的UI元素。。
///②.如何访问面板的成员----UIManager.Instance.GetWindow<窗口类型>().方法();。
///</summary>
namespace UITool
{
	///<summary>
	///管理(记录、禁用、查找)窗口；定义所有窗口的共有行为(获取监听器)。。
	///</summary>
	public class UIManager : MonoSingleton<UIManager>
	{
		private Dictionary<string, UI_WindowBase> window;

        public override void Init()
        {
			window = new Dictionary<string, UI_WindowBase>();
			UI_WindowBase[] windows = FindObjectsOfType<UI_WindowBase>();
			for(int i = 0; i < windows.Length; i++)
            {
				window.Add(windows[i].GetType().Name, windows[i]);
				windows[i].SetVisible(false);
            }
		}

		/// <summary>
		/// 根据变换组件查找当前物体身上的UIEventListener组件
		/// </summary>
		/// <param name="childTf">变换组件</param>
		/// <returns>当前物体身上的UIEventListener组件/null</returns>
		public static UIEventListener GetUIEventListener(Transform childTf)
        {
			if(childTf == null) return null;
			UIEventListener listener = childTf.GetComponent<UIEventListener>();
			if(listener == null)
            {
				listener= childTf.gameObject.AddComponent<UIEventListener>();
            }
			return listener;
        }
		/// <summary>
		/// 添加子窗口
		/// </summary>
		/// <param name="UI_Window">成功return 0，不成功返回-1</param>
		public int Add(UI_WindowBase UI_Window)
        {
			if (UI_Window == null) return -1;
			window.Add(UI_Window.GetType().Name, UI_Window);
			return 0;
        }
        public T GetWindow<T>() where T : UI_WindowBase
        {
			Type type = typeof(T);
			if(window.ContainsKey(type.Name))
            {
				return window[type.Name] as T;
            }
            else
            {
				return null;
            }
        }
    }
}