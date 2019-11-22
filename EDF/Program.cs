using System;

namespace EDF
{
    class Program
    {
        static void process_time(int[] execution_time, int time, int[] deadline, int[] process, int[] arrival_time)
        {
            int sum = 0;
            int temp;
            int ll;
           
            
            while( (time -= 1) > 0 )
            {
                for (int i = 0; i < deadline.Length; i++)
                {
                    for (int j = i + 1; j < deadline.Length; j++)
                    {


                        if (arrival_time[i] > arrival_time[j])
                        {
                            if (deadline[i] > deadline[j])
                            {
                                temp = deadline[i];
                                deadline[i] = deadline[j];
                                deadline[j] = temp;

                                ll = process[i];
                                process[i] = process[j];
                                process[j] = ll;
                            }

                        }
                        
                    }

                   
                }
                Console.WriteLine(time);
            }
            

            for (int i = 0; i < execution_time.Length; i++)
            {
                sum += execution_time[i];
            }
            

            Console.WriteLine("Total execution time = " + sum);

        }
        public static void Main(string[] args)
        {
            int[] process = { 1, 2, 3 };
            int[] arrival_time = { 0, 3, 2 };
            int[] execution_time = { 3, 2, 4 };
            int[] deadline = { 4, 20, 15};
            int upper_bound = deadline.GetUpperBound(0);
            int time = deadline[upper_bound];


            Console.WriteLine(upper_bound);
            Console.WriteLine(time);

            Console.Write("\n");


            process_time(execution_time, time, deadline, process, arrival_time);

        }
    }
}