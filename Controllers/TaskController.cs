using Microsoft.AspNetCore.Mvc;

namespace PKSS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        [HttpPost("Task11")]
        public List<int> Task11(List<int> list) // 1.10
        {
            list.Sort();
            return list;
        }

        [HttpPost("Task12")]
        public bool Task12(int ax, int ay, int bx, int by, int cx, int cy) // 1.13
        {
            double ab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
            double bc = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
            double ac = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));

            if (ab <= (bc + ac) && bc <= (ab + ac) && ac <= (ab + bc))
                return true;

            return false;
        }

        [HttpPost("Task13")]
        public bool Task13(double s1, double s2) // 1.16
        {
            double a = Math.Sqrt(s1);
            double d = Math.Sqrt(s2 / Math.PI) * 2;

            if (d <= a)
                return true;

            return false;
        }

        [HttpPost("Task14")]
        public bool Task14(double a, double b, double c, double d) // 1.19
        {
            if ((a < c && b < d) || (a < d && b < c))
                return true;

            return false;
        }

        [HttpPost("Task15")]
        public List<int> Task15(int a, int b, int c, int d) // 1.22
        {
            List<int> list = new List<int>();
            
            if (a <= 3 || a >= 15)
                list.Add(a);

            if (b <= 3 || b >= 15)
                list.Add(b);

            if (c <= 3 || c >= 15)
                list.Add(c);

            if (d <= 3 || d >= 15)
                list.Add(d);

            return list;
        }

        [HttpPost("Task21")]
        public List<int> Task21(int n) // 2.10
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= n; i++)
                if (Subtask21(i))
                    list.Add(i);

            return list;
        }

        private bool Subtask21(int i)
        {
            while (i > 0)
            {
                if (i % 10 != 0)
                    if (i % (i % 10) != 0)
                        return false;
                i = i / 10;
            }

            return true;
        }

        [HttpPost("Task22")]
        public List<int> Task22(int a, int b, int c, int d, int e, int f) // 2.16
        {
            List<int > list = new List<int>();

            list.Add(Subtask22(a, b));
            list.Add(Subtask22(c, d));
            list.Add(Subtask22(e, f));

            return list;
        }

        private int Subtask22(int x, int y)
            => x > y ? x : y;

        [HttpPost("Task23")]
        public int Task23(int a, int b, int c) => // 2.19
            Subtask23(a, b, c);

        private int Subtask23(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            else if (b <= a && b <= c)
                return b;
            else return c;
        }

        [HttpPost("Task24")]
        public List<int> Task24(int a, int b, int c, int d) // 2.22
        {
            List<int> list = new List<int>();

            if (Subtask24(a))
                list.Add(a);
            if (Subtask24(b))
                list.Add(b);
            if (Subtask24(c))
                list.Add(c);
            if (Subtask24(d))
                list.Add(d);

            return list;
        }

        private bool Subtask24(int x) =>
            x % 2 == 0 ? true : false;

        [HttpPost("Task25")]
        public int Task25(int x) // 2.25
        {
            if (x < 1) return -1;

            int counter = 0;

            while (x > 1)
            {
                if (x % 2 == 0)
                {
                    x = x / 2;
                    counter++;
                }
                else return -1;
            }

            return counter;
        }

        [HttpPost("Task31")]
        public int Task31(int n) // 3.10
        {
            int k = 1;

            while (k < n)
                k *= 4;

            return k;
        }

        [HttpPost("Task32")]
        public bool Task32(int n) // 3.13
        {
            while (n > 1)
            {
                if ((n % 3) != 0)
                    return false;
                n = n / 3;
            }

            return true;
        }

        [HttpPost("Task33")]
        public List<double> Task33() // 3.16
        {
            List<double> list = new List<double>();
            double x = 1;

            while (x < 12)
            {
                double z = Math.Tan(x) + 5 * Math.Cos(x - 2);

                if (z < 0)
                    list.Add(z);

                x += 1.2;
            }

            return list;
        }

        [HttpPost("Task34")]
        public double Task34() // 3.19
        {
            int n = 1;

            while (true)
            {
                double f = Math.Sin(Math.Tan(n / 2));

                if (f < 0)
                    return f;

                n++;
            }
        }

        [HttpPost("Task35")]
        public int Task35(int n) // 3.22
        {
            int k = 1;

            while (3 * k < n)
                k *= 3;

            return k;
        }
    }
}
