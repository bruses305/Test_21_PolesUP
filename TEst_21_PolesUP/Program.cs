using System;

namespace TEst_21_PolesUP
{
    class Program
    {
        static void More(int a1, int a2, out int b1,out int b2)
        {
            b1 = a1;
            b2 = a2;
            if(a1>a2)
            {
                b1 = a2;
                b2 = a1;
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("ax1 = ");
            int ax1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ay1 = ");
            int ay1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ax2 = ");
            int ax2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ay2 = ");
            int ay2 = Convert.ToInt32(Console.ReadLine());

            More(ax1, ax2, out ax1, out ax2);
            More(ay1, ay2, out ay1, out ay2);

            Console.Write("bx1 = ");
            int bx1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("by1 = ");
            int by1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bx2 = ");
            int bx2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("by2 = ");
            int by2 = Convert.ToInt32(Console.ReadLine());

            More(bx1, bx2, out bx1, out bx2);
            More(by1, by2, out by1, out by2);

            int S_Two = Math.Abs((ax1 - ax2) * (ay1 - ay2)) + Math.Abs((bx1 - bx2) * (by1 - by2));
            int cx1;
            int cx2;
            int cy1;
            int cy2;
            if (ax1 <= bx1) {  cx1 = bx1; }
            else {  cx1 = ax1; }

            if (ax2 <= bx2) {  cx2 = ax2; }
            else {  cx2 = bx2; }

            if (ay1 <= by1) {  cy1 = by1; }
            else {  cy1 = ay1; }

            if (ay2 <= by2) {  cy2 = ay2; }
            else {  cy2 = by2; }


            int S_Inner = Math.Abs((cx1 - cx2) * (cy1 - cy2));

            int S = S_Two - S_Inner;
            Console.WriteLine(S);

        }
    }
}
