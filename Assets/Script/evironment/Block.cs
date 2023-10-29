using Organisms;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enum;

namespace Scene
{
	///<summary>
	///小区块，地图由6x9的区块组成
	///</summary>
	public class Block : MonoBehaviour
	{
		//区块类型
		public BlockType type = BlockType.wastage;
		//是否可以种植植物
		public bool useable = false;
		//横坐标，从0开始计数，0-8
        public int x = 0;
		//纵坐标，从0开始计数，0-5
        public int y = 0;
		//区块上种植的东西
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