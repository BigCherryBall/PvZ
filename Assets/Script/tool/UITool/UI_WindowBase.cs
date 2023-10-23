using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TfTool;

namespace UITool
{
	[RequireComponent(typeof(CanvasGroup))]
    ///<summary>
    ///UI 窗口类UI_WindowBase: 所有UI窗口的基类，可以代表所有窗口(概念继承，以层次化方式管理类); 定义所有窗口共有行为(显隐)。
    ///</summary>
    public class UI_WindowBase : MonoBehaviour
	{
		protected CanvasGroup group;
        private Dictionary<string, UIEventListener> listenerDic;
        protected void Awake()
        {
            group = GetComponent<CanvasGroup>();
            listenerDic = new Dictionary<string, UIEventListener>();
        }
        /// <summary>
        /// 层级未知，根据名字查找子代的UIEventListener组件
        /// </summary>
        /// <param name="childName">子代名字</param>
        /// <returns>子代组件</returns>
        public UIEventListener GetUIEventListener(string childName)
        {
            Transform tf= transform.FindChildByName(childName);
            if (! listenerDic.ContainsKey(childName))
            {
                UIEventListener listener = UIManager.GetUIEventListener(tf);
                listenerDic.Add(childName, listener);
                return listener;
            }
            return listenerDic[childName];
        }
        /// <summary>
        /// 设置UI显隐
        /// </summary>
        /// <param name="state">显：True；隐：False。</param>
        public void SetVisible(bool state)
        {
			group.alpha =state ? 1 : 0;
        }
		/// <summary>
		/// 一定时间延迟后再执行显隐
		/// </summary>
		/// <param name="state">显：True；隐：False。</param>
		/// <param name="delay">延迟时间</param>
		public void SetVisible(bool state,float delay)
        {
			StartCoroutine(Set_Visible(state,delay));
        }
		private IEnumerator Set_Visible(bool state,float delay)
        {
			yield return new WaitForSeconds(delay);
			SetVisible(state);
        }
        private void OnDisable()
        {
            group.enabled = false;
        }
        private void OnEnable()
        {
            group.enabled=true;
        }
        private void OnDestroy()
        {
            Destroy(group);
        }
    }
}