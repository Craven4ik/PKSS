using Microsoft.AspNetCore.Mvc;

namespace PKSS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        [HttpPost("Task11")]
        public List<int> Task11(List<int> list)
        {
            list.Sort();
            return list;
        }

        [HttpPost("Task12")]
        public bool Task12(int ax, int ay, int bx, int by, int cx, int cy)
        {
            double ab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
            double bc = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
            double ac = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));

            if (ab <= (bc + ac) && bc <= (ab + ac) && ac <= (ab + bc))
                return true;

            return false;
        }

        [HttpPost("Task13")]
        public bool Task13(double s1, double s2)
        {
            double a = Math.Sqrt(s1);
            double d = Math.Sqrt(s2 / Math.PI) * 2;

            if (d <= a)
                return true;

            return false;
        }

        [HttpPost("Task14")]
        public bool Task14(double a, double b, double c, double d)
        {
            if ((a < c && b < d) || (a < d && b < c))
                return true;

            return false;
        }

        [HttpPost("Task15")]
        public List<int> Task15(int a, int b, int c, int d)
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
        public List<int> Task21(int n)
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

        //[HttpPost("Task22")]
    }
}
