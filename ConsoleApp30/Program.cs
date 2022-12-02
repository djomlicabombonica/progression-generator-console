using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleApp30
{
    
    internal class Program
    {   
        public static string[] chromaticScale = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#",
                                                  "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#",
                                                  "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"};
        static void Main(string[] args)
        {
           string note = Console.ReadLine();
           
            Console.WriteLine(findNote(note));
           
           
            

        }
        static int findNote(string note)
        {
            int index = Array.IndexOf( chromaticScale, note);
            return index;
            
        
        }
        static string[] majorScale(int index)
        {

           string[] majorScale = {  chromaticScale[index],  chromaticScale[index+2],chromaticScale[index+4], chromaticScale[index+5], 
                                    chromaticScale[index+7],chromaticScale[index+9],chromaticScale[index+11],chromaticScale[index]  };
           return majorScale;
        }
        static string[] minorScale(int index)
        {
        string[] minorScale = {  chromaticScale[index],  chromaticScale[index+2],chromaticScale[index+3], chromaticScale[index+5],
                                 chromaticScale[index+6],chromaticScale[index+8],chromaticScale[index+10],chromaticScale[index]  };
                  return minorScale; 
        }
        static string[] dimScale(int index) 
        {
            
            string[] dimScale =   {  chromaticScale[index],  chromaticScale[index+2],chromaticScale[index+3], chromaticScale[index+5],
                                     chromaticScale[index+6],chromaticScale[index+8],chromaticScale[index+9], chromaticScale[index]  }; 
                   return dimScale; }
        static string[] majorChord(string[] majorScale)
        {
          string[] majorChord = {  majorScale[0], majorScale[2], majorScale[4]  };
            return majorChord;
        }
        static string[] minorChord(string[] minorScale)
        {
        string[] minorChord = {  minorScale[0], minorScale[2], minorScale[4]  };
            return minorChord;
        }
        static string[] dimChord(string[] dimScale)
        {
            string[] dimChord =   {  dimScale[0], dimScale[2], dimScale[4]  };
            return dimScale;
        }
        static string[] majorProgression(string[] majorScale)
        {
                string[] majorProgression = { majorScale[0]+"major",majorScale[1]+"minor",majorScale[2]+"minor",
                                              majorScale[3]+"major",majorScale[4]+"major",majorScale[5]+"minor",
                                              majorScale[6]+"diminished" };
                return majorProgression;
        }
        static string[] minorProgression(string[] minorScale)
        {

                string[] minorProgression = { minorScale[0]+"minor", minorScale[1]+"diminished",minorScale[2]+"major", 
                                              minorScale[3]+"minor", minorScale[4]+"minor",minorScale[5]+"major",
                                              minorScale[6]+"major"};
                return minorProgression;   
        }









        /*


         */



    }
}
