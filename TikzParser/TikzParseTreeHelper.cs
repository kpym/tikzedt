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

        public static List<TikzParseItem> GetFullSelection(IEnumerable<TikzParseItem> ItemList)
        {
            List<TikzParseItem> ret = new List<TikzParseItem>();
            if (ItemList == null || ItemList.Count() == 0)
                return ret;

            //  ** Find the least common ancestor **
            // find all ancestors for each Item
            var AncestorList = ItemList.Select(l => FindAncestors(l)).ToList();

            // as long as the highest ancestor is common, remove this ancestor from the lists
            while (AncestorList.AllEqual(l => l.Last()) && AncestorList.All(l => l.Count >= 2))
                foreach (var l in AncestorList)
                    l.RemoveAt(l.Count - 1);

            // Now the last elements of all lists are ancestors on one "level" of the tree.
            // Remove duplicates and sort
            var elements = AncestorList.Select(l => l.Last())
                                       .Distinct()
                                       .OrderBy(tpi => tpi.StartPosition())
                                       .ToList();

           
            // Handle a special case: if the items are all coordinates in a single Tikz_Path, 
            // that (other than those items) contains only Tikz_Somethings, then return the whole path
            TikzContainerParseItem commonparent = elements.First().parent;
            if (commonparent is Tikz_Path)
            {
                if (commonparent.Children.All(tpi => (tpi is Tikz_Something) || elements.Contains(tpi) ) )
                {
                    ret.Add(commonparent);
                    return ret;
                }
            }

            // otherwise just return the elements found so far
            return elements;
        }

        /// <summary>
        /// The method returns a list of TikzParseItems all of whose coordinates objects are contained in the selection.
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public static List<TikzParseItem> GetFullSelection2(IEnumerable<TikzParseItem> ItemList)
        {
            List<TikzParseItem> ret = new List<TikzParseItem>();
            if (ItemList == null || ItemList.Count() == 0)
                return ret;

            // find all ancestors for each Item. Theese are candidates to be selected (or not)
            var AncestorList = ItemList.Select(l => FindAncestorsInPicture(l)).ToList();
            HashSet<TikzParseItem> candidates = new HashSet<TikzParseItem>();
            foreach (var l in AncestorList)
                foreach (var ll in l)
                    candidates.Add(ll);

            // add all items contained in selected container items
            HashSet<TikzParseItem> selWithDesc = new HashSet<TikzParseItem>(ItemList);
            foreach (var tpi in ItemList)            
                foreach (var ll in SelectDescendants(tpi, t => !(t is Tikz_Something)))
                    selWithDesc.Add(ll);
            
            // scan through all elements in the candidate lists and determine wheter all its node descendants are selected
            HashSet<TikzParseItem> ret2 = new HashSet<TikzParseItem>();
            foreach (var tpi in candidates)
            {
                var mustbeselected = SelectDescendants(tpi, t => !(t is Tikz_Something));
                if (selWithDesc.IsSupersetOf(mustbeselected))
                    ret2.Add(tpi);
            }

            // remove descendants from the list of selected items
            foreach (var tpi in ret2)
                if (!ret2.Any(t => IsAncestorOf(t, tpi)))
                    ret.Add(tpi);

            // sort items
            ret.Sort((a,b) => a.StartPosition() - b.StartPosition() );

            return ret;

            // Now the last elements of all lists are ancestors on one "level" of the tree. Find the smallest and largest in the horizontal ordering
  /*          var elements = AncestorList.Select(l => l.Last());
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

            return commonparent.Children.GetRange(firstind, lastind - firstind + 1).ToList(); */
            
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

        /// <summary>
        /// Same as FindAncestors, but stops at the Tikz_Picture.
        /// I.e., the last node in the list is the one below the Tikz_Picture
        /// </summary>
        /// <param name="t">The node. Must not be null.</param>
        /// <returns></returns>
        public static List<TikzParseItem> FindAncestorsInPicture(TikzParseItem t)
        {
            List<TikzParseItem> ret = new List<TikzParseItem>();

            TikzParseItem cur = t;
            do
            {
                ret.Add(cur);
                cur = cur.parent;
            } while (cur != null && !(cur is Tikz_Picture) );

            return ret;
        }

        /// <summary>
        /// Selects all descendants of a node fulfilling a certain criterion.
        /// </summary>
        /// <param name="tpi"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public static HashSet<TikzParseItem> SelectDescendants(TikzParseItem tpi, Predicate<TikzParseItem> criterion)
        {
            HashSet<TikzParseItem> ret = new HashSet<TikzParseItem>();
            if (! (tpi is TikzContainerParseItem))
                return ret;

            foreach (var t in (tpi as TikzContainerParseItem).Children)                
            {
                if (criterion(t))
                    ret.Add(t);
                foreach (var ll in SelectDescendants(t, criterion))
                    ret.Add(ll);
            }
            return ret;
        }

        /// <summary>
        /// Checks if tp1 is an ancestor of tp2
        /// </summary>
        /// <param name="tp1"></param>
        /// <param name="tp2"></param>
        /// <returns></returns>
        public static bool IsAncestorOf(TikzParseItem tp1, TikzParseItem tp2)
        {
            // Note that first item returned by findancestors is the node itself -> skip it
            return FindAncestors(tp2).Skip(1).Contains(tp1);
        }

        /// <summary>
        /// Scans for duplicate node names in the parse tree and changes them to make them unique.
        /// Also updates references.
        /// </summary>
        /// <param name="tp"></param>
        public static void UniquefyNodeNames(Tikz_ParseTree tpt)
        {
            if (tpt == null)
                return;

            Dictionary<string, Tikz_Node> nodelist = new Dictionary<string, Tikz_Node>();
            
            Tikz_Picture tp = tpt.GetTikzPicture();
            if (tp == null)
                return;

            tpt.BeginModify();
            // clear current node refs
            tp.nodelist.Clear();
            // scan for nodes, rename and re-register noderefs
            ScanTree(tp, nodelist, tp);
            tpt.EndModify();
        }
        /// <summary>
        /// Recursive function to scan the parsetree in a depth first manner.
        /// nodelist contains the current map from _old_ nodenames to nodes. it is used to update node references
        /// </summary>
        private static void ScanTree(TikzContainerParseItem tc, Dictionary<string, Tikz_Node> nodelist, Tikz_Picture tp)
        {
            foreach (var tpi in tc.Children)
                if (tpi is Tikz_Node)
                {
                    Tikz_Node tn = tpi as Tikz_Node;
                    if (tn.name != null && tn.name.Trim() != "")
                    {
                        string name = CleanName(tn.name.Trim());
                        // remember the node with its old name (all coordinates referring to this name henceforth will be changed to the new name
                        nodelist[name] = tn;

                        if (tp.nodelist.ContainsKey(name))
                        {
                            // we have to change the name
                            tn.name = UniquefyName(name, tp);
                            tn.UpdateText();
                        }
                        tn.RegisterNodeAndStyleRefs();
                    }
                }
                else if (tpi is Tikz_Coord)
                {
                    Tikz_Coord tco = tpi as Tikz_Coord;
                    if (tco.type == Tikz_CoordType.Named)
                    {
                        string nameref = CleanName(tco.nameref);
                        if (nodelist.ContainsKey(nameref))
                            if (CleanName(nodelist[nameref].name) != nameref)
                            {
                                tco.nameref = CleanName(nodelist[nameref].name);
                                tco.UpdateText();
                            }
                    }

                }
                else if (tpi is TikzContainerParseItem)
                {
                    ScanTree(tpi as TikzContainerParseItem, nodelist, tp);
                }
        }
        private static string UniquefyName(string oldname, Tikz_Picture tp)
        {
            int postfix = 1;
            while (tp.nodelist.ContainsKey(oldname + "_" + postfix)) 
                postfix++;
            return oldname + "_" + postfix;
        }



        /// <summary>
        /// Tries to find the referencable node (with a name) corresponding to a given coordinate.
        /// If no such node exists, null is returned.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Tikz_Node GetReferenceableNode(Tikz_XYItem item, Tikz_Picture tpict)
        {            
            if (item == null || tpict == null)
                return null;

            if (item is Tikz_Node)
            {
                Tikz_Node n = item as Tikz_Node;
                if (n.name==null || n.name.Trim() == "")
                    return null;
                else
                    return n;
            }
            else if (item is Tikz_Coord || item is Tikz_Arc)
            {
                // find the next node
                for (int i = item.parent.Children.IndexOf(item) + 1; i < item.parent.Children.Count; i++)
                {
                    if (item.parent.Children[i] is Tikz_Node)
                    {
                        Tikz_Node n = item.parent.Children[i] as Tikz_Node;
                        // check if the node is really at the same position as the coordinate item
                        if (n.coord == null)
                        {
                            if (n.name != null && n.name.Trim() != "")
                                return n;
                            continue;
                        }
                        else
                            return null;
                    }

                    if (!(item.parent.Children[i] is Tikz_Something))
                        break;
                }

                // if we get here, nothing was found
                return null;
            }
            else
            {
                return null;
                //throw new NotImplementedException("MakeReferenceableNode not implemented for this type");
            }
        }


   /*     /// <summary>
        /// Takes an XYItem (like (2,2) or a node) and tries to make it into a referenceable node
        /// (i.e, one with a name)
        /// 
        /// Concretely, the routine does the following:
        ///     - if item is a named node, return item.
        ///     - if item is an unnamed node, give it a unique name and return item.
        ///     - if item is a coordinate, see if there is a node at this coordinate
        ///         (algorithm: see if next non-tikz_something item is a node)
        ///         - if yes, start anew with item=this node
        ///         - if no, add a named node at the specified coordinate
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected Tikz_Node MakeReferenceableNode(Tikz_XYItem item, Tikz_Picture tpict)
        {
            if (item == null || tpict == null)
                return null;

            if (item is Tikz_Node)
            {
                Tikz_Node n = item as Tikz_Node;
                if (n.name == "")
                {
                    n.SetName(tpict.GetUniqueName());
                    n.UpdateText();
                }
                return n;
            }
            else if (item is Tikz_Coord)
            {
                // find the next node
                for (int i = item.parent.Children.IndexOf(item) + 1; i < item.parent.Children.Count; i++)
                {
                    if (item.parent.Children[i] is Tikz_Node)
                    {
                        // check if the node is really at the same position as the coordinate item
                        if ((item.parent.Children[i] as Tikz_Node).coord == null)
                            return MakeReferenceableNode(item.parent.Children[i] as Tikz_Node, tpict);
                        else
                            break;
                    }

                    if (!(item.parent.Children[i] is Tikz_Something))
                        break;
                }

                // if we get here, nothing was found => add a new node
                Tikz_Something ws = new Tikz_Something(" ");
                Tikz_Node n = new Tikz_Node();
                n.coord = null;

                item.parent.InsertChildAt(ws, item.parent.Children.IndexOf(item) + 1);
                item.parent.InsertChildAt(n, item.parent.Children.IndexOf(item) + 2);
                n.SetName(tpict.GetUniqueName());
                n.UpdateText();

                return n;
            }
            else
                return null; // throw new NotImplementedException("MakeReferenceableNode not implemented for this type");
        }*/

        /// <summary>
        /// Removes whitespace from name. Note that multiple whitespace chars can also occur inside the string.
        /// E.g. " bla    bla   " is mapped to "bla bla"        
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CleanName(string name)
        {
            string[] s = name.Split(new char[] {' ','\t','\n','\r' }, StringSplitOptions.RemoveEmptyEntries);
            return String.Join(" ",s);
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
