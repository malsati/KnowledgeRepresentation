using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
  public  class SystemItem
    {
      private static int counter;
      public int Id { get; set; }
      public string Name { get; set; }
     
      public bool IsUsed { get; set; }
      public SystemItem()
      {
          counter++;
          IsUsed = false;
          Id = counter;
      }

      public SystemItem(string name):this()
      {
          Name = name;
      }
      public override string ToString()
      {
          return Name;
      }

    }
}
