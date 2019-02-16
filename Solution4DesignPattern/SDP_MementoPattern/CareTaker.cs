using System;
using System.Collections.Generic;

namespace SDP_MementoPattern
{
    class CareTaker
    {
        private Stack<Memento> state = new Stack<Memento>();
        public void SaveMemento(Memento m)
        {
            state.Push(m);
        }

        public Memento RestoreMemento()
        {
            return state.Pop();
        }

    }
}