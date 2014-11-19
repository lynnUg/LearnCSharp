using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class DocumentProcessor
    {
        public delegate void DocumentProcess(Document doc);
        private readonly List<DocumentProcess> processes =
            new List<DocumentProcess>();
        public List<DocumentProcess> Processes
        {
            get
            {
                return processes;
            }
        }
        public void Process(Document doc)
        {
            foreach(DocumentProcess process in Processes)
            {
                process(doc);
            }
        }
        public static DocumentProcessor Configure()
        {
            DocumentProcessor rc = new DocumentProcessor();
            rc.Processes.Add(DocumentProcessor.TranslateIntoFrench);
            rc.Processes.Add(DocumentProcessor.TranslateIntoLuganda);
            return rc;
        }

        private static void TranslateIntoFrench(Document doc)
        {
           
            Console.WriteLine("converting to french");
        }
        private static void TranslateIntoLuganda(Document doc)
        {
            
            Console.WriteLine("converting to luganda");
        }

    }
}
