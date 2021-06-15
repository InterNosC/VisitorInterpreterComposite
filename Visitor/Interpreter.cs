using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{

    /// <summary>
    /// будує речення мови з даної граматикою
    /// </summary>
    class ClientI
    {
    }

    /// <summary>
    /// містить загальну для інтерпретатора інформацію. 
    /// Може використовуватися об'єктами термінальних і нетермінальних виразів для 
    /// збереження стану операцій і подальшого доступу до збереженого стану
    /// </summary>
    class Context
    {
    }

    /// <summary>
    /// визначає інтерфейс виразу, оголошує метод Interpret ()
    /// </summary>
    abstract class AbstractExpression 
    {
        public abstract void Interpret(Context context);
    }


    /// <summary>
    /// термінальний вираз, реалізує метод Interpret() 
    /// для термінальних символів граматики.
    /// Для кожного символу граматики створюється свій об'єкт TerminalExpression
    /// </summary>
    class TerminalExpression : AbstractExpression 
    {
        public override void Interpret(Context context)
        {
        }
    }



    /// <summary>
    /// нетермінальних вираз, представляє правило граматики. 
    /// Для кожного окремого правила граматики створюється 
    /// свій об'єкт NonterminalExpression.
    /// </summary>
    class NonterminalExpression : AbstractExpression
    {
        AbstractExpression expression1;
        AbstractExpression expression2;
        public override void Interpret(Context context)
        {

        }
    }
}
