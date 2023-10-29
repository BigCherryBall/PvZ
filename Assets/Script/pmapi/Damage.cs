using Enum;
using Organisms;

namespace Pmapi
{
	///<summary>
	///�˺��ṹ��
	///</summary>
	public struct Damage
	{
        
        //�˺���ֵ,��Ҫ
        public int damage;
		//�˺���Դ����Ҫ
		public Organism origin;
		//�˺���Դ�������࣬�Ǳ�Ҫ
		public Atkbale atk_obj;
		//�Ƿ���ɱ���Ǳ�Ҫ
		public bool seckill;
		//�˺�Ŀ�꣬�Ǳ�Ҫ
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