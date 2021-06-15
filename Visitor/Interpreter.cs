using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{

    class Context
    {
    }

    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        AbstractExpression expression1;
        AbstractExpression expression2;
        public override void Interpret(Context context)
        {

        }
    }
}
