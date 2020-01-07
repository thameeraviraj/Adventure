using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.Model
{
    public class DecisionNode
    {
        public string Value { get; set; }
        public bool IsQuestion { get; set; }
        public bool IsSelected { get; set; }
        public List<DecisionNode> LinkedNodes { get; set; }

        public DecisionNode(string value, bool isQuestion, bool isSelected)
        {
            this.Value = value;
            this.IsQuestion = isQuestion;
            this.IsSelected = IsSelected;
        }

        public DecisionNode() { }
    }
}
