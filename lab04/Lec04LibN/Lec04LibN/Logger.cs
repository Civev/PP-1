using System.Text;

namespace Lec04LibN
{
    public class Logger : ILogger
    {
        private Logger() { }

        private static int indexes = 1;
        
        

        private static string _logFormatTemplate = string.Format("-{0} {1}-", DateTime.Now.ToString("dd.MM.yyyy"), DateTime.Now.ToString("HH:mm:ss"));
        private static Logger _instance;
            static string _logFileName = string.Format(@"{0}/LOG{1}.txt", Directory.GetCurrentDirectory(), DateTime.Now.ToString("yyyyMMdd-HH-mm-ss"));
        private List<string> _titles = new List<string>();
        


        public void log(string message)
        {
        

            
                indexes++;
                string infoLog = string.Format("{0:d6}-{1}INFO ", indexes, _logFormatTemplate);
                foreach (var item in _titles)
                {
                    infoLog += item;
                }
                Console.WriteLine($"{infoLog} {message}");
            File.AppendAllText(_logFileName, $"{infoLog} {message}\n");


        }
        public static ILogger createLogger()
        {
            
            
                
                if (_instance == null)
                {
                    _instance = new Logger();
                    Console.WriteLine(string.Format("{0:d6}-{1}INIT", indexes, _logFormatTemplate));
                File.AppendAllText(_logFileName, $"{string.Format("{0:d6}-{1}INIT", indexes, _logFormatTemplate)}\n");


            }


            return _instance;
        }

        public void start(string title)

        {
            
             
            
            indexes++;
            _titles.Add(title + ":");
            string startLog = string.Format("{0:d6}{1}STRT ",indexes, _logFormatTemplate);
            foreach (var item in _titles)
            {
                startLog += item;
            }
            File.AppendAllText(_logFileName, $"{startLog}\n");



        }

        public void stop()
        {
                
            
            indexes++;
            if(_titles.Count != 1)
                { 
                _titles.RemoveAt(_titles.Count - 1); 
                 }
            string stopLog = string.Format("{0:d6}{1}STOP ", indexes, _logFormatTemplate);
            foreach(var item in _titles)
            {

            stopLog += item; 
            }
            File.AppendAllText(_logFileName, $"{stopLog}\n");

        }
        
     
    }
}
