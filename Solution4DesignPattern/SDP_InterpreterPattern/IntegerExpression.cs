namespace SDP_InterpreterPattern
{
    class IntegerExpression : Expression
    {
        private int value;
        public override int Evaluate()
        {
            return value;
        }

        public IntegerExpression(int value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}