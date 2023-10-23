using UnityEngine;
using UnityEngine.EventSystems;

namespace UITool

{
    public delegate void UIEvent(PointerEventData eventData);
    ///<summary>
    ///用于UI的事件监听，比button的onClick更好用，而且事件更多，还带参数
    ///</summary>
    public class UIEventListener : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler,
                                   IPointerEnterHandler,IPointerExitHandler,IDragHandler,IBeginDragHandler
    {
        /// <summary>
        /// 添加鼠标单击事件
        /// </summary>
        public event UIEvent PointerClick;
        /// <summary>
        /// 添加鼠标按下事件
        /// </summary>
        public event UIEvent PointerDown;
        /// <summary>
        /// 添加鼠标抬起事件
        /// </summary>
        public event UIEvent PointerUp;
        /// <summary>
        /// 添加鼠标进入事件
        /// </summary>
        public event UIEvent PointerEnter;
        /// <summary>
        /// 添加鼠标离开事件
        /// </summary>
        public event UIEvent PointerExit;
        /// <summary>
        /// 添加开始拖拽时的事件
        /// </summary>
        public event UIEvent DragBegin;
        /// <summary>
        /// 添加拖拽时每帧调用的事件
        /// </summary>
        public event UIEvent Dragging;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if(DragBegin != null) DragBegin(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {
            if(Dragging != null) Dragging(eventData);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (PointerClick != null) PointerClick(eventData);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (PointerDown != null) PointerDown(eventData);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if(PointerEnter != null) PointerEnter(eventData);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if( PointerExit != null) PointerExit(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (PointerUp != null) PointerUp(eventData);
        }
    }
}