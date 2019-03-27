using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CDLChallenge
{
    public class Application
    {
        static void Main(string[] args)
        {
            String input = null;
            if (args.Length >= 1)
            {
                input = args[0].ToString();
            }

            List<PianoAccordion> fullList = null;

            // parse and read json file
            try
            {
                fullList = parseAndRead();

                if(fullList == null)
                {
                    Console.WriteLine("Reading and parsing the JSON file failed.");
                    Console.ReadKey();
                    return;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadKey();
            }

            List<PianoAccordion> result = new List<PianoAccordion>();

            // filter according to user input
            if (input != null)
            {
                result = filterUserInput(input, fullList);
            }
            else
            {
                result = fullList;
            }

            // print the list
            try
            {
                printList(result);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadKey();
            }
        }

        // method to parse and read for specific file
        static List<PianoAccordion> parseAndRead()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = string.Format("{0}resources\\inventory.json", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("Given file path does not exist!");
                Console.ReadKey();
                return null;
            }
            using (StreamReader sr = File.OpenText(fullPath))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<PianoAccordion>>(json);
            }
        }

        //method to filter user input
        //FUTURE DEV -> ALLOW USER TO FILTER BY A CATEGORY (I.E. MAKE), OR SPECIFY MULTIPLE CRITERION (PASS LIST OF INPUTS)
        static List<PianoAccordion> filterUserInput(string input, List<PianoAccordion> theList)
        {
            List<PianoAccordion> outputList = new List<PianoAccordion>();

            foreach (PianoAccordion p in theList)
            {
                if (p.getMake() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getTuning() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getModel() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getTrebleKeys().ToString() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getBassKeys().ToString() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getTrebleReeds().ToString() == input)
                {
                    outputList.Add(p);
                }
                else if (p.getStatus() == input)
                {
                    outputList.Add(p);
                }
            }

            return outputList;
        }

        // method to print PianoAccordion list
        static void printList(List<PianoAccordion> aList)
        {
            foreach (PianoAccordion p in aList)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
