﻿using GGM.Context.Attribute;

namespace UnitTest.Dummy.Entity
{
    public class ConstructorClass
    {
        [AutoWired]
        public ConstructorClass(int first, string second)
        {

        }
    }
}
