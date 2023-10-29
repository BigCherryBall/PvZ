using Enum;
using Organisms;

namespace Pmapi
{
	///<summary>
	///伤害结构体
	///</summary>
	public struct Damage
	{
        
        //伤害数值,必要
        public int damage;
		//伤害来源，必要
		public Organism origin;
		//伤害来源名的种类，非必要
		public Atkbale atk_obj;
		//是否秒杀，非必要
		public bool seckill;
		//伤害目标，非必要
		public Organism target;
        public Damage(int damage, Organism origin, Atkbale atk_obj = Atkbale.none,
            bool seckill = false, Organism target = null)
        {
            this.damage = damage;
            this.origin = origin;
            this.atk_obj = atk_obj;
            this.target = target;
            this.seckill = seckill;
        }
        public Damage(int damage, Organism origin)
        {

            this.damage = damage;
            this.origin = origin;
            this.atk_obj = Atkbale.none;
            this.target = null;
            this.seckill = false;
        }

    }
}