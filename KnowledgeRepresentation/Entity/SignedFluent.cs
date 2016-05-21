using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class SignedFluent
    {
        public Fluent FluentValue { get; set; }
        public bool FluentSign { get; set; }

        public SignedFluent(Fluent FluentValue, bool FluentSign)
        {
            this.FluentSign = FluentSign; 
            this.FluentValue = FluentValue;
        }
    }
}
