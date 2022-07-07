using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public Document(string nummber)
        {
            Number = number;
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
