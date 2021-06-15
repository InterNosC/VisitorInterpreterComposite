using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// клієнт, який використовує компоненти
    /// </summary>
    class ClientC
    {
    }
    /// <summary>
    /// визначає інтерфейс для всіх компонентів в структурі
    /// </summary>
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
    }
    /// <summary>
    /// представляє компонент, який може містити інші компоненти і 
    /// реалізує механізм для їх додавання і видалення
    /// </summary>
    class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in children)
            {
                component.Display();
            }
        }
    }

    /// <summary>
    /// представляє окремий компонент, який не може містити інші компоненти
    /// </summary>
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
