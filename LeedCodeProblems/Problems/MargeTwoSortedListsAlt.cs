using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeProblems.Problems
{
    internal class MargeTwoSortedListsAlt
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            var list3 = new ListNode();
            var root=new ListNode();
            if(list1.val<=list2.val) 
            {
                root.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                root.val = list2.val;
                list2 = list2.next;
            }
            list3 = root;
            if (list1!=null&&list2!=null)
            {
                for (; ; )
                {
                    if (list1.val <= list2.val)
                    {
                        var node = new ListNode()
                        {
                            val = list1.val
                        };
                        list3.next = node;
                        list3 = node;
                        list1 = list1.next;
                    }
                    else
                    {
                        var node = new ListNode()
                        {
                            val = list2.val
                        };
                        list3.next = node;
                        list3 = node;
                        list2 = list2.next;
                    }
                    if (list1 == null || list2 == null)
                    {
                        break;
                    }
                }
            }
            if (list1 == null)
            {
                for(; ;)
                {
                    if (list2 == null) break; 
                    var node = new ListNode()
                    {
                        val = list2.val
                    };
                    list3.next = node;
                    list3 = node;
                    list2 = list2.next;
                }
            }
            if (list2 == null)
            {
                for (; ; )
                {
                    if (list1 == null) break;
                    var node = new ListNode()
                    {
                        val = list1.val
                    };
                    list3.next = node;
                    list3 = node;
                    list1 = list1.next;
                }
            }
            list3 = root;
            return list3;
        }
        public static void TestMergeTwoLists()
        {
            var mas = new[] {2};
            var root = new ListNode()
            {
                val = mas[0]
            };
            var list1 = root;
            for (var i=1;i<mas.Length;i++)
            {
                var node = new ListNode()
                {
                    val = mas[i]
                };
                list1.next = node;
                list1 = node;
            }
            list1 = root;
            mas = new[] { 1};
            root = new ListNode()
            {
                val = mas[0]
            };
            var list2 = root;
            for(var i = 1; i < mas.Length; i++)
            {
                var node = new ListNode()
                {
                    val = mas[i]
                };
                list2.next = node;
                list2 = node;
            }
            list2 = root;
            var res = MergeTwoLists(list1, list2);
 /*           for (; ; )
            {
                if (res == null)
                {
                    break;
                }
                Console.WriteLine(res.val);
                res = res.next;
            }*/
            mas = new[] { 1,2,3 };
            root = new ListNode()
            {
                val = mas[0]
            };
            list1 = root;
            for (var i = 1; i < mas.Length; i++)
            {
                var node = new ListNode()
                {
                    val = mas[i]
                };
                list1.next = node;
                list1 = node;
            }
            list1 = root;
            mas = new[] { 1,2,4 };
            root = new ListNode()
            {
                val = mas[0]
            };
            list2 = root;
            for (var i = 1; i < mas.Length; i++)
            {
                var node = new ListNode()
                {
                    val = mas[i]
                };
                list2.next = node;
                list2 = node;
            }
            list2 = root;
            res = MergeTwoLists(list1, list2);
/*          for (; ; )
            {
                if (res == null)
                {
                    break;
                }
                Console.WriteLine(res.val);
                res = res.next;
            }*/
        }
    }
}
