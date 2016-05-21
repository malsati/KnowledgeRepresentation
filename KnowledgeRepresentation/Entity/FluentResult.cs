using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
   public class FluentResult
    {
        public Fluent FluentR { get; set; }
        public Utility.FluentStatus Status { get; set; }
        public string Label { get { return ToString(); } }
        public FluentResult()
        {

        }

        public FluentResult(Fluent fluentR, Utility.FluentStatus status)
        {
            this.FluentR = fluentR;
            this.Status = status;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Status == Utility.FluentStatus.Positive ? "" : "¬", FluentR.ToString());
        }
    }
}
