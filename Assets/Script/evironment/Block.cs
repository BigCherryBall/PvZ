using Organisms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enum;

namespace Scene
{
	///<summary>
	///С���飬��ͼ��6x9���������
	///</summary>
	public class Block : MonoBehaviour
	{
		//��������
		public BlockType type = BlockType.wastage;
		//�Ƿ������ֲֲ��
		public bool useable = false;
		//�����꣬��0��ʼ������0-8
        public int x = 0;
		//�����꣬��0��ʼ������0-5
        public int y = 0;
		//��������ֲ�Ķ���
        LinkedList<Organism> objs = new LinkedList<Organism>();

		public Block(int x, int y, BlockType type,bool useable = false)
		{
			if (-1 < x && x < 6)
			{
                this.x = x;
            }
			if (-1 < y && y < 9)
			{
                this.y = y;
            }
			this.type = type;
			this.useable = useable;
		}
		


	}
}