using Pmapi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enum;

namespace Organisms
{
    ///<summary>
    ///生命体类
    ///</summary>
    public abstract class Organism : MonoBehaviour
    {
        //阵营
        public Team team;
        //最大血量
        public int max_hp = 0;
        //当前血量
        private int hp = 0;
        //身份编码
        public Identity identity = Identity.none;

        /// <summary>
        /// 死亡
        /// </summary>
        /// <returns>是否成功</returns>
        public abstract bool Die();
        /// <summary>
        /// 造成伤害
        /// </summary>
        /// <param name="damage">伤害结构体</param>
        /// <returns></returns>
        public abstract int GetHurt(Damage damage);
    }
}
