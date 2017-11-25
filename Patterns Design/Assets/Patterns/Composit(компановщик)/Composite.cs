using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Composite : MonoBehaviour { // Матрешка (ложим компоненты(фигуры) в сумки а эти сумки(композит) в другую сумку(композит) и при вызове метода Draw() он вызывается на всех компонентах все распечатывается)

	// Use this for initialization
	void Start () {
		Square square1 = new Square ();
		Square square2 = new Square ();

		Triangle triangle1 = new Triangle ();
		Triangle triangle2 = new Triangle ();

		Circle circle1 = new Circle ();
		Circle circle2 = new Circle ();

		Composites composite = new Composites ();
		Composites composite1 = new Composites ();
		Composites composite2 = new Composites ();

		composite1.AddComponent (square1);
		composite1.AddComponent (square2);
		composite1.AddComponent (circle1);

		composite2.AddComponent (triangle1);
		composite2.AddComponent (triangle2);
		composite2.AddComponent (circle2);

		composite.AddComponent (composite1);
		composite.AddComponent (composite2);
		composite.Draw ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
public interface IShape{
	 void Draw();
}

public class Square : MonoBehaviour, IShape{
	#region Shape implementation
	public void Draw ()
	{
		Debug.Log ("Квадратик");
	}
	#endregion
}
public class Triangle : MonoBehaviour, IShape{
	#region Shape implementation
	public void Draw ()
	{
		Debug.Log ("Треугольничек");
	}
	#endregion
}
public class Circle : MonoBehaviour, IShape{
	#region Shape implementation
	public void Draw ()
	{
		Debug.Log ("Кругляшка");
	}
	#endregion
}
public class Composites : MonoBehaviour,IShape{
	public List<IShape> components = new List<IShape>();
	public void AddComponent(IShape component)
	{
		components.Add (component);
	}
	public void RemoveComponent(IShape component)
	{
		components.Remove (component);
	}

	#region IShape implementation
	public void Draw ()
	{
		foreach (IShape component in components)
			component.Draw ();
	}
	#endregion
}