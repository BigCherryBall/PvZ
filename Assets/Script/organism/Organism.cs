using Pmapi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enum;

namespace Organisms
{
    ///<summary>
    ///��������
    ///</summary>
    public abstract class Organism : MonoBehaviour
    {
        //��Ӫ
        public Team team;
        //���Ѫ��
        public int max_hp = 0;
        //��ǰѪ��
        private int hp = 0;
        //��ݱ���
        public Identity identity = Identity.none;

        /// <summary>
        /// ����
        /// </summary>
        /// <returns>�Ƿ�ɹ�</returns>
        public abstract bool Die();
        /// <summary>
        /// ����˺�
        /// </summary>
        /// <param name="damage">�˺��ṹ��</param>
        /// <returns></returns>
        public abstract int GetHurt(Damage damage);
    }
}
