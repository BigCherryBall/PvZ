using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enum
{
	///<summary>
	///
	///</summary>
	public enum Atkbale
	{
		none,

	}

	public enum Identity
	{
        none,
        /************************植物分区************************/
        /**************夜间植物**************/
        doom_shroom,            //毁灭菇
        fume_shroom,            //大喷菇
        puff_shroom,            //小喷菇
        scaredy_shroom,         //胆小菇


        /**************白天植物**************/
        sunflower,				//向日葵
		twin_sunflower,			//双头向日葵
		pea,					//豌豆射手
		double_pea,				//双管豌豆
		triple_pea,             //三管豌豆
        gatling_pea,			//机枪射手
        ice_pea,                //寒冰射手
		cabbage,				//卷心菜
		cactus,                 //仙人掌
        cattail,                //香蒲
        cornpult,               //玉米投手
        garlic,                 //大蒜
        gloom_shroom,           //忧郁菇
        gold_magnet,            //黄金磁力菇
        hypno_shroom,           //魅惑菇
        lilypad,                //荷叶
        magnet_shroom,          //磁力菇
        marigold,               //金盏花
        melon,                  //西瓜投手
        ice_melon,              //冰西瓜
        pumpkin,                //南瓜头
        spike_rock,             //地刺王
        squash,                 //窝瓜
        starfruit,              //杨桃
        sun_shroom,             //阳光菇
        nut,                    //坚果
        tallnut,                //高坚果
        firewood,               //火炬树桩
        umbrellaleaf,           //叶子保护伞

        /*****水性植物*****/
        sea_shroom,              //海菇


        /******一次性******/
        cherry_bomb,			//樱桃炸弹
		chomper,                //大嘴花
        blover,                 //四叶草
        coffeebean,				//咖啡豆
        gravebuster,            //墓碑吞噬者
        ice_shroom,             //冰镇菇
        copy_bean,              //复制豆
        jalapeno,               //火爆辣椒



        /************************僵尸分区************************/


    }

    public enum Team
	{
		none,
		plant,
		zombie
	}
    public enum BlockType
    {
        wastage,
        lawn,
        pool,
        roof,
    }
}