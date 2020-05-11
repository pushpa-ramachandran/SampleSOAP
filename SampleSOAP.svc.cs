using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace MathService
{
    public class MathService : SampleSOAP
    {
        public string passwordCreate(string firstName, string lastName, int age)
        {
            return lastName.Substring(0, 2) + firstName.Substring(firstName.Length - 2) + age % 5;
        }

        public int loginId(int age)
        {

            return (age * new Random().Next(100, 200));
        }
    }
}
