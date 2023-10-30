using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeSum:Visitor
    {
        private int TotalAge=0;

        public int GetSum()
        {
            return TotalAge;
        }
        public override void Visit(Person person)
        {
            TotalAge+= person.Age;
        }
        public override void Visit(Node node)
        {

        }




    }




}