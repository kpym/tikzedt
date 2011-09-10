using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TikzEdt.Parser
{
    /// <summary>
    /// This class contains some static auxiliary functions that otherwise would just clutter the code.
    /// </summary>
    public static class TikzParseTreeHelper
    {

        /// <summary>
        /// The method returns a list of TikzParseItems that together form the "code block" of the argument.
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static List<TikzParseItem> GetCodeBlock(IEnumerable<TikzParseItem> ItemList)
        {
            List<TikzParseItem> ret = new List<TikzParseItem>();
            if (ItemList == null || ItemList.Count() == 0)
                return ret;
          
            // find all ancestors for each Item
            var AncestorList = ItemList.Select( l => FindAncestors(l) ).ToList();

            // as long as the highest ancestor is common, remove this ancestor from the lists
            while (AncestorList.AllEqual(l => l.Last()) && AncestorList.All(l => l.Count >= 2))
                foreach (var l in AncestorList)
                    l.RemoveAt(l.Count - 1);

            // Now the last elements of all lists are ancestors on one "level" of the tree. Find the smallest and largest in the horizontal ordering
            var elements = AncestorList.Select(l => l.Last());
            TikzContainerParseItem commonparent = elements.First().parent;

            int firstind = elements.Min(t => commonparent.Children.IndexOf(t));
            int lastind = elements.Max(t => commonparent.Children.IndexOf(t));

            // Handle a special case: if the items are all coordinates in a single Tikz_Path, 
            // that (other than those items) contains only Tikz_Somethings, then return the whole path
            if (commonparent is Tikz_Path)
            {
                if (commonparent.Children.FindIndex(tpi => !(tpi is Tikz_Something)) >= firstind
                    && commonparent.Children.FindLastIndex(tpi => !(tpi is Tikz_Something)) <= lastind)
                {
                    ret.Add(commonparent);
                    return ret;
                }
            }

            return commonparent.Children.GetRange(firstind, lastind-firstind +1).ToList();            
        }

        /// <summary>
        /// Finds a list of ancestors (in ascending order) of the ParseItem.
        /// The returned list includes t as first element.
        /// </summary>
        /// <param name="t">The node. Must not be null.</param>
        /// <returns></returns>
        public static List<TikzParseItem> FindAncestors(TikzParseItem t)
        {
            List<TikzParseItem> ret = new List<TikzParseItem>();

            TikzParseItem cur = t;
            do
            {
                ret.Add(cur);
                cur = cur.parent;
            } while (cur != null);
            
            return ret;
        }

        public static bool AllEqual<T>(this IEnumerable<T> values) 
        {
            if (!values.Any()) return true;
            T first = values.First();
            return values.Skip(1).All(v => first.Equals(v));
        }
        public static bool AllEqual<T, S>(this IEnumerable<T> values, Func<T, S> f)
        {
            return values.Select(f).AllEqual();
        }

    }
}
