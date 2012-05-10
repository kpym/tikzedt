using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TikzEdt
{
    public static class CommonExtensions
    {
        public static System.Windows.Point Center(this System.Windows.Rect r)
        {
            return new System.Windows.Point(r.X + r.Width / 2, r.Y + r.Height / 2);
        }

        public static System.Windows.Point ScalarMult(this System.Windows.Point p, double Factor)
        {
            return new System.Windows.Point(p.X*Factor, p.Y*Factor);
        }

        public static void AddRange(this IList list, IEnumerable items)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (items == null) throw new ArgumentNullException("items");
            foreach (var item in items) list.Add(item);
        }

        public static void RemoveRange(this IList list, IEnumerable items)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (items == null) throw new ArgumentNullException("items");
            foreach (var item in items) list.Remove(item);
        }

        public static void InsertRange(this IList list, int pos, IEnumerable items)
        {
            if (list == null) throw new ArgumentNullException("list");
            if (items == null) throw new ArgumentNullException("items");
            if (pos < 0 || pos > list.Count) throw new ArgumentNullException("pos");

            int p = pos;
            foreach (var item in items) 
            {
                list.Insert(p, item);
                p++;
            }
        }


      /*  public static void ForEach<T>(this IEnumerable<T> L, Action<T> A)
        {
            foreach (var o in L)
                A(o);
        }*/

        /// <summary>
        /// Foreach with an index
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ie"></param>
        /// <param name="action"></param>
        public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in ie) action(e, i++);
        }
    }
}
