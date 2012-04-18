using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt.Snippets;

namespace TEApplicationLogic.Snippets
{
    public class Snippet
    {
        public string Code, Dependencies, NodeStyle, EdgeStyle, Example, Remark, Category, Name;
        public int Key;
        public SnippetsDataSet.SnippetsTableRow Row;
    }
}
