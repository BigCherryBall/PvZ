using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Framework;

namespace Scene
{
	///<summary>
	///
	///</summary>
	public abstract class Environment : MonoSingleton<Environment>
	{
		public Block[,] field = new Block[6, 9];

	}
}