using NumericSequenceCalculator.Models;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Services
{
    public class NumericSequenceCalculatorService : INumericSequenceCalculatorService
    {
        public void CalculateSequence(CalculatorModel cm)
        {
            List<int> listAll = new List<int>();
            List<int> listOdd = new List<int>();
            List<int> listEven = new List<int>();
            List<string> listCondition = new List<string>();
            for (int i = 1; i <= cm.Input; i++)
            {
                listAll.Add(i);
                if (i % 2 == 0)
                {
                    listEven.Add(i);
                }
                if (i % 2 != 0)
                {
                    listOdd.Add(i);
                }
                if (i % 15 == 0)
                {
                    listCondition.Add("Z");
                }
                else if (i % 3 == 0)
                {
                    listCondition.Add("C");
                }
                else if (i % 5 == 0)
                {
                    listCondition.Add("E");
                }
                else
                {
                    listCondition.Add(i.ToString());
                }
                cm.OutputAll = string.Join(",", listAll.ToArray());
                cm.OutputEven = string.Join(",", listEven.ToArray());
                cm.OutputOdd = string.Join(",", listOdd.ToArray());
                cm.OutputCondition = string.Join(",", listCondition.ToArray());
            }
        }
    }
}
