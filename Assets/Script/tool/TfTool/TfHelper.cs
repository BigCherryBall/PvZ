using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TfTool
{
	///<summary>
	///基于变换组件的工具类
	///</summary>
	public static class TfHelper
	{
		/// <summary>
		/// 未知层级，根据名字查找子物体
		/// </summary>
		/// <param name="current">当前物体变换组件</param>
		/// <param name="childName">子物体名字</param>
		/// <returns>子物体变换组件/null</returns>
		public static Transform FindChildByName(this Transform current,string childName)
        {
			if(current == null) return null;
            Transform child = current.Find(childName);
            if (child != null) return child;
            for (int i = 0; i < current.childCount; i++)
            {
                child = FindChildByName(current.GetChild(i), childName);
                if (child != null) return child;
            }
            return null;
        }

		public static IEnumerator SingleMove(this Transform tf, AnimationCurve curve, Vector2 dir, float time, float meter)
		{
			dir.Normalize();
			Vector3 begin = tf.position;
			Vector3 targetPos = begin + meter * (Vector3)dir;
			for (float i = 0; i <= 1; i += Time.deltaTime / time)
			{
				tf.position = Vector3.Lerp(begin, targetPos, curve.Evaluate(i));
				yield return null;
			}
			tf.position = targetPos;
		}
		public static IEnumerator RepeatMove(this Transform tf, AnimationCurve curve, Vector2 dir, float time, float meter)
		{
			dir.Normalize();
			Vector2 begin = tf.position;
			Vector2 targetPos = begin + meter * dir;
			float timer = 0;
			Vector2 exchange;
			while (true)
			{
				timer += Time.deltaTime / time;
				tf.position = Vector2.Lerp(begin, targetPos, curve.Evaluate(timer));
				if (timer > 1)
				{
					timer = 0;
					exchange = begin;
					begin = targetPos;
					targetPos = exchange;
				}
				yield return null;
			}
		}

		public static void MoveBySpeed(this Transform tf,Vector3 target, Vector3 dirNormaliae,float speed)
        {
			if (Vector3.Dot(target - tf.position, dirNormaliae) <= 0) return;
			tf.position= Time.deltaTime*speed*dirNormaliae + tf.position;
        }
        public static IEnumerator MoveBySpeedIEnumrator(this Transform tf, Vector3 target, Vector3 dirNormaliae, float speed)
        {
            while (Vector3.Dot(target - tf.position, dirNormaliae) > 0)
            {
                tf.position = Time.deltaTime * speed * dirNormaliae + tf.position;
                yield return null;
            }
        }
    }
}