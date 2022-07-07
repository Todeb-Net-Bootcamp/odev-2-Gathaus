using System;
using TodebbBootcampHomework2.Abstract;

namespace TodebbBootcampHomework2.Concrete
{
    public class FakeRobot : Machine
    {
        public int Id { get; set; }

        public FakeRobot(string name) : base(name)
        {
            
        }
        
        public override void MachineTell(string sentence)
        {
            Console.WriteLine("I am a fake robot");
            Console.WriteLine(sentence);
        }

        public override void MachineName()
        {
            Console.WriteLine($"My Id is {this.Id} and my name is {_name} and I'm a fake robot");
        }
    }
}