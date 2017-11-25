using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
	public interface IFlyable
	{
		void Fly();
	}

	public interface IQuackable
	{
		void Quack();
	}

	public interface IEatable
	{
		void Eat();
	}
}
