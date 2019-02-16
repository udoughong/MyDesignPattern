namespace SDP_InterpreterPattern
{
    class AdditionExpression : Expression
    {
        Expression expr1;
        Expression expr2;

        public AdditionExpression(Expression e1, Expression e2)
        {
            expr1 = e1;
            expr2 = e2;
        }
        public override int Evaluate()
        {
            return expr1.Evaluate() + expr2.Evaluate();
        }
    }
}