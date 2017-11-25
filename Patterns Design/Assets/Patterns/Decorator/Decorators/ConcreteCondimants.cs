using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class MilkCondiment : CondimentsDecoratorBase
	{
		double cost = 50;
		BeverageBase beverage;

		public MilkCondiment(BeverageBase beverage)
		{
			this.beverage = beverage;
			description = beverage.GetDescription() + " +Milk";
		}

		public override double GetCost ()
		{
			return beverage.GetCost () + cost;
		}
	}

	public class SugarCondiment : CondimentsDecoratorBase
	{
		double cost = 10;
		BeverageBase beverage;

		public SugarCondiment(BeverageBase beverage)
		{
			this.beverage = beverage;
			description = beverage.GetDescription() + " +Sugar";
		}

		public override double GetCost ()
		{
			return beverage.GetCost () + cost;
		}
	}

	public class ChocolateCondiment : CondimentsDecoratorBase
	{
		double cost = 70;
		BeverageBase beverage;

		public ChocolateCondiment(BeverageBase beverage)
		{
			this.beverage = beverage;
			description = beverage.GetDescription() + " +Chocolate";
		}

		public override double GetCost ()
		{
			return beverage.GetCost () + cost;
		}
	}
