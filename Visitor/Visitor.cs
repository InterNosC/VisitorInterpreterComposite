using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// клієнт, який використовує відвідувачів
    /// </summary>
    class ClientV
    {
    }

    /// <summary>
    /// інтерфейс користувача, який визначає метод 
    /// Visit() для кожного об'єкта Element
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elemA);
        public abstract void VisitElementB(ElementB elemB);
    }

    /// <summary>
    /// конкретний клас відвідувача, реалізує інтерфейс, визначений в Visitor.
    /// </summary>
    class ConcreteVisitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }

    /// <summary>
    /// конкретний клас відвідувача, реалізує інтерфейс, визначений в Visitor.
    /// </summary>
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }

    /// <summary>
    /// деяка структура, яка зберігає об'єкти Element і 
    /// надає до них доступ. Це можуть бути і прості списки,
    /// і складні складові структури у вигляді дерев
    /// </summary>
    class ObjectStructure
    {
        List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
                element.Accept(visitor);
        }
    }

    /// <summary>
    /// визначає метод Accept(), в якому в якості 
    /// параметра приймається об'єкт Visitor
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        public string SomeState { get; set; }
    }

    /// <summary>
    /// конкретний елемент, який реалізуэ метод Accept()
    /// </summary>
    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        { }
    }

    /// <summary>
    /// конкретний елемент, який реалізуэ метод Accept()
    /// </summary>
    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB()
        { }
    }
}
