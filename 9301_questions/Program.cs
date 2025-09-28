using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9301_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //1
        // Array to Queue
        // param : int[] arr
        // return : Queue<int>
        // example: param: {1,2,3} , return: [1,2,3]
        static Queue<int> Arr2Q(int[] arr)
        {
            Queue<int> q = new Queue<int>();
            foreach (int value in arr)
                q.Insert(value);
            return q;
        }

        //בכל התרגילים - מיחקו את שורת ההחזרה וממשו את הקוד כנדרש

        // 2
        // number of elements in Q
        // param : Queue<int>
        // return : int
        // example: param: [1,4,8], return: 3
        // note - no need to preserve Q. print Q in main to check it's []
        static int CountQueueModify(Queue<int> q)
        {
            return 0;

        }

        //בכל השאלות מעכשיו והלאה יש צורך לשמר את התור
        //לא רק בקובץ הזה

        // 3
        // number of elements in Q
        // param : Queue<int>
        // return : int
        // example: param: [1,2,3], return: 3
        // note - print Q in main to check it's not modified
        static int CountQueue(Queue<int> q)
        {
            return 0;


        }

        // 4
        // Clone Q
        // param : Queue<int>
        // return : Queue<int>
        // example: param: [1,2,3], return new Q: [1,2,3]

        static Queue<int> Clone(Queue<int> q)
        {
            return null;

        }

        // 5
        // IsValueInQ
        // param : Queue<int>, int
        // return : bool
        // example: param: [1,2,3], 2, return: true
        // note: שימו לב שלא ניתן להחזיר אמת באמצע הפעולה

        // מה הסיבוכיות

        static bool IsValueInQ(Queue<int> q, int val)
        {
            return false;

        }

        // 5
        // RemoveFromIndex
        // param : Queue<int>, int
        // return : int
        // example: param: q=[3,5,8], 1; return: 5, after: q=[3,8]
        // note: assume queue is not empty and index>=0 
        static int RemoveFromIndex(Queue<int> q, int index)
        {
            return 0;

        }

        // 6
        // number of elements in Q, *all elements positive*
        // param : Queue<int>
        // return : int
        // example: param: [1,2,3], return: 3
        // note - CANNOT use another queue

        static int CountQueueNoTemp(Queue<int> q)
        {
            return 0;

        }

        // 7
        // RemoveAndReturnLast
        // param : Queue<int>
        // return : int
        // example: param: q=[3,5,8], return: 8, after: q=[3,5]
        // note: assume queue is not empty
        // tip: tricky...

        static int RemoveAndReturnLast(Queue<int> q)
        {
            return 0;

        }

        // 8
        // RemoveAndReturnLastNoTemp
        // param : Queue<int>
        // return : int
        // example: param: q=[3,5,8], return: 8, after: q=[3,5]
        // note: assume queue is not empty
        // note2: CANNOT use temp

        static int RemoveAndReturnLastNoTemp(Queue<int> q)
        {
            return 0;

        }

        // 9
        // InsertToSortedQ
        // param : Queue<int> sorted ascending, int
        // return : void
        // example: param: q=[3,5,8], 4, after: q=[3,4,5,8]
        // example2: param: q=[3,4,5,8], 9, after: q=[3,4,5,8,9]

        static void InsertToSortedQ(Queue<int> q, int num)
        {


        }

        // 10
        // Merge2Queues
        // param : Queue<int>, Queue<int>
        // return : Queue<int>
        // example: param: q1=[1,3,5,7], q2=[0,2], return: [1,0,3,2,5,7]
        // אין צורך לשמר את 2 הרשימות המתקבלות
        static Queue<int> Merge2Queues(Queue<int> q1, Queue<int> q2)
        {
            return null;

        }

    }
}
