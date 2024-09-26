using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Services
{
    public interface testinterface
    {
        int Add(int x, int y);
    }

    public class testclass : testinterface
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class testclassB : testinterface
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    public class MainClass
    {
        public void MyFunction()
        {
            testinterface t1 = new testclass();
            t1.Add(10, 20);

            testinterface t2 = new testclassB();
            t2.Add(10, 20);
        }

        
    }
}
