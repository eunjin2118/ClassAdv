﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            //소멸자 예시
            Product product1 = new Product("과자", 1000);
            Product product2 = new Product("아이스크림", 1000);
            Product product3 = new Product("케이크", 1000);
            // 객체 생성의 역순으로 소멸됨
        }
    }
}
