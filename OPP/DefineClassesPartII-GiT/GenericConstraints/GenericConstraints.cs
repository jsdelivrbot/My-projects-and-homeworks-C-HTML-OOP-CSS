﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    class TestClass1 : BaseClass, IInterface
    {
    }

    class TestClass2 : BaseClass    
    {
    }

    class TestClass3 : BaseClass, IInterface
    {
        public TestClass3(int param)
        {
        }
    }

    class BaseClass
    {
    }

    interface IInterface
    {
    }

    class GenericConstraintsClass<T>
        where T :BaseClass,IInterface, new()
    {
        public T Method1(T param)
        {
            return param;
        }
    }

    class GenericConstraints
    {
        static void Main()
        {
            GenericConstraintsClass<TestClass1> test1 = new GenericConstraintsClass<TestClass1>();
            //Inherits BaseClass and IInterfaceble and has the suitable constructor

            // This will not compile
            //GenericConstraintClass<TestClass2> test2 = new GenericConstraintClass<TestClass2>();
            //Has the suitable constructor but inherits only BaseClass

            // This will not compile
            //GenericConstraintClass<TestClass3> test2 = new GenericConstraintClass<TestClass3>();
            //Inherits BaseClass and IInterfaceble, but does not support no param constructor
        }
    }
}
