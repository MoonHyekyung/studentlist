using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlist
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string major;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "문혜경", major = "뉴미디어소프트웨어과" });
            list.Add(new Teacher() { name = "이예진", major = "뉴미디어소프트웨어과" });
            list.Add(new Teacher() { name = "곽가연", major = "뉴미디어웹솔루션과" });
            list.Add(new Teacher() { name = "정유경", major = "뉴미디어웹솔루션과" });
            list.Add(new Teacher() { name = "하나랑", major = "뉴미디어디자인과" });
            list.Add(new Teacher() { name = "고가은", major = "뉴미디어디자인과" });

            foreach(var item in list){
                Console.WriteLine(item.name + " : " + item.major);
            }
        }
    }
}
