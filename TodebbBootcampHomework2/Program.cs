using System;
using TodebbBootcampHomework2.Concrete;

namespace TodebbBootcampHomework2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var HumanoidRobot = new HumanoidRobot("HumanoidRobot");
            HumanoidRobot.Id = 123456789;
            HumanoidRobot.MachineSurname = "HumanoidSurname";
            HumanoidRobot.MachineTell("Hello World");
            HumanoidRobot.MachineName();


            var FakeRobot = new FakeRobot("FakeRobot");
            FakeRobot.Id = 987654321;
            FakeRobot.MachineSurname = "FakeSurname";
            FakeRobot.MachineTell("Fake Hello");
            FakeRobot.MachineName();

        }
    }
}