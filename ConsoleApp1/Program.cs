using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 
        {
            //string str = "fasdfasdf192.168.0.2asdfasdf";
            //Match m = Regex.Match(str, @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}");
            //Console.WriteLine(m);
            BaseClass bc = new BaseClass();    //基类
            DerivedClass dc = new DerivedClass();//派生类

            BaseClass[] bca = new BaseClass[] { bc, dc };

            foreach (var v in bca)
            {
                Type type = v.GetType();
                //Type type = typeof(BaseClass);
                Console.WriteLine("Type:{0}", type.Name);//输出类名称

                FieldInfo[] fields = type.GetFields();//获取所有公用字段
                foreach (var f in fields)
                    Console.WriteLine("Field:{0}", f.Name);//输出公用字段名称
            }
        }
        class BaseClass //基类
        {
            public int a = 0;
        }

        class DerivedClass : BaseClass //派生类
        {
            public int b = 0;
        }
    }


}

