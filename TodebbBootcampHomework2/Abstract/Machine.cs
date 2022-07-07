using System;

namespace TodebbBootcampHomework2.Abstract
{
    public abstract class Machine
    {
        protected string _name;

        protected Machine(string name)
        {
            _name = name;
        }

        public string MachineSurname;
        
        public virtual void MachineTell(string sentence)
        {
            Console.WriteLine(sentence);
        }
        
        public virtual void MachineName()
        {
            Console.WriteLine(_name);
        }
        
    }
}