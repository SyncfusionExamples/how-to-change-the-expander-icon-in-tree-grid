using Syncfusion.Data;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfRelationalCollection
{
    // public class CustomComparer : IComparer<TreeNode>, ISortDirection
    public class CustomComparer : IComparer<object>, ISortDirection
    {
       public int Compare(object x, object y)
         //public int Compare(TreeNode x, TreeNode y)
       {
            //int namX;
            //int namY;

            ////For OrderInfo Type data
            //if (x.GetType() == typeof(OrderInfo))
            //{
            //    //Calculating the length of CustomerName if the object type is OrderInfo
            //    namX = ((OrderInfo)x).CustomerName.Length;
            //    namY = ((OrderInfo)y).CustomerName.Length;
            //}

            ////For Group type Data                                   
            //else if (x.GetType() == typeof(Group))
            //{
            //    //Calculating the group key length
            //    namX = ((Group)x).Key.ToString().Length;
            //    namY = ((Group)y).Key.ToString().Length;
            //}

            //else
            //{
            //    namX = x.ToString().Length;
            //    namY = y.ToString().Length;
            //}

            //// Objects are compared and return the SortDirection
            //if (namX.CompareTo(namY) > 0)
            //    return SortDirection == ListSortDirection.Ascending ? 1 : -1;
            //else if (namX.CompareTo(namY) == -1)
            //    return SortDirection == ListSortDirection.Ascending ? -1 : 1;
            //else
           //TreeNode node1 = x as TreeNode;
           //TreeNode node2 = y as TreeNode;
           //var item1 = node1.Item as PersonInfo;
           //var item2 = node2.Item as PersonInfo;
           //var value1 = item1.FirstName;
           //var value2 = item2.FirstName;


           var item1 = x as PersonInfo;
           var item2 = y as PersonInfo;
           var value1 = item1.FirstName;
           var value2 = item2.FirstName;
           int c = 0;
           if (value1 != null && value2 == null)
           {
               c = 1;
           }
           else if (value1 == null && value2 != null)
           {
               c = -1;
           }
           else if (value1 != null && value2 != null)
           {
               c = value1.Length.CompareTo(value2.Length);
               //if (c == 0)
               //{
               //    c = x.GetHashCode().CompareTo(y.GetHashCode());
               //}
           }

           if (SortDirection == ListSortDirection.Descending)
               c = -c;

           return c;
           //var namX = value1.Length;
           //var namY = value2.Length;


           //if (namX.CompareTo(namY) > 0)
           //    return SortDirection == ListSortDirection.Ascending ? 1 : -1;
           //else if (namX.CompareTo(namY) == -1)
           //    return SortDirection == ListSortDirection.Ascending ? -1 : 1;
           //else
           //    return 0;

            
        }

        //Get or Set the SortDirection value
        private ListSortDirection _SortDirection;
        public ListSortDirection SortDirection
        {
            get { return _SortDirection; }
            set { _SortDirection = value; }
        }
    }
}
