using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    public class FileWorker : IDisposable
    {
        private string _filepath = null;
        private FileStream _fs = null;
        private bool _disposed = false;

        protected void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _fs.Close();
                _fs.Dispose();
                // free managed resources
            }
            //free unmanaged resources
        
        }

        public FileWorker( string path)
        {
            

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            _fs = File.Create(path);
            _filepath = path;

        }


        public void WriteToFile(string text)
        {
            Byte[] byteArray = new UTF8Encoding(true).GetBytes(text);
            _fs.Write(byteArray, 0, byteArray.Length);
            _fs.Close();

        }

        public void ReadFromFile()
        {
            _fs = File.Open(_filepath, FileMode.Open, FileAccess.Read);

            byte[] byteArray = new byte[1024];

            UTF8Encoding tmp = new UTF8Encoding(true);

            while (_fs.Read(byteArray, 0, byteArray.Length) > 0)
            {
                Console.WriteLine(tmp.GetString(byteArray));
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    class Program
    {
        

        static void Main(string[] args)
        {
            
            using (FileWorker fw = new FileWorker(@"C://temp//123.txt"))
            {
                fw.WriteToFile("Lalalala");
                fw.ReadFromFile();
            }

            Console.WriteLine("End program");

        }
    }
}
