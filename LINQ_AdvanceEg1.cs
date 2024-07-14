// Learning join operation in LINQ expressions

using System;

class Program
{
    public class JobSummary
    {
        public string Throughtput { get; set; } = string.Empty;
        public string Collector { get; set; }  = string.Empty;
        public double ADCInValue { get; set; } = 0;
        public double ADCOutValue { get; set;} = 0;

        public JobSummary() { 
        }

    }

    static void Main()
    {
        List<JobSummary> adcInData = new List<JobSummary>();

        adcInData = new List<JobSummary>
        {
            new JobSummary{ Throughtput = "HS", Collector = "W1", ADCInValue = 324.34, ADCOutValue = 434.4},
            new JobSummary{ Throughtput = "HS", Collector = "W2", ADCInValue = 424.34, ADCOutValue = 434.4},
            new JobSummary{ Throughtput = "HS", Collector = "N", ADCInValue = 344.36, ADCOutValue = 436.4},
            new JobSummary{ Throughtput = "HT", Collector = "W1", ADCInValue = 624.34, ADCOutValue = 444.4},
            new JobSummary{ Throughtput = "HT", Collector = "W2", ADCInValue = 724.54, ADCOutValue = 754.4},
            new JobSummary{ Throughtput = "HT", Collector = "N", ADCInValue = 344.34, ADCOutValue = 347.4}
        };



        List<JobSummary> adcHazeData = new List<JobSummary>
        {
            new JobSummary{ Throughtput = "HS", Collector = "W1", ADCInValue = 324.34, ADCOutValue = 343.65},
            new JobSummary{ Throughtput = "HS", Collector = "W2", ADCInValue = 424.34, ADCOutValue = 434.4},
            new JobSummary{ Throughtput = "HS", Collector = "N", ADCInValue = 454.3, ADCOutValue = 436.4},
            new JobSummary{ Throughtput = "HT", Collector = "W1", ADCInValue = 624.34, ADCOutValue = 34.3},
            new JobSummary{ Throughtput = "HT", Collector = "W2", ADCInValue = 43.6, ADCOutValue = 754.4},
            new JobSummary{ Throughtput = "HT", Collector = "N", ADCInValue = 344.34, ADCOutValue = 347.4}
        };


        // Join the two list and get a new list with ADCoutvalue in adcInData is divided by ADCOutValueof adcHazeData

        var adcInDataDivadcHazeData = from adcNorm in adcInData
                                      //holding elements from both the lists
                                      join adcHaze in adcHazeData
                                      //Tell linking condition
                                      on new { adcNorm.Collector, adcNorm.Throughtput} equals new { adcHaze.Collector, adcHaze.Throughtput }
                                      // Tell how your output list should be like
                                      select new {  adcNorm.Throughtput, 
                                                    adcNorm.Collector, 
                                                        adcNorm.ADCInValue,
                                                    adcRPPMValue = adcNorm.ADCOutValue / adcHaze.ADCOutValue }; 


        foreach ( var adc in  adcInDataDivadcHazeData )
        {
            Console.WriteLine(adc.ToString() );
        }



    }
}
