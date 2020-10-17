using System.IO;


namespace otus_architecture_lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CmdParser cmdParser = new CmdParser().Init(args);
            string inPath = cmdParser.GetValue("-ip");
            string outPath = cmdParser.GetValue("-op");

            SimpleServiceLocator.Instance.RegisterService<ILogger>(new FileLogger(outPath));
            IHandler handler = ComposeHandlers();

            Run(inPath, handler);

            SimpleServiceLocator.Instance.Dispose();
        }


        static void Run(string inPath, IHandler handler)
        {
            using (StreamReader file = File.OpenText(inPath))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    handler.Handle(line);
                }
            }
        }


        static IHandler ComposeHandlers()
        {
            IHandler xml = new FileParserXml();

            IHandler txt = new FileParserTxt();
            txt.SetParrent(xml);

            IHandler csv = new FileParserCsv();
            csv.SetParrent(txt);

            IHandler json = new FileParserJson();
            json.SetParrent(csv);
            
            return json;
        }
    }
}
