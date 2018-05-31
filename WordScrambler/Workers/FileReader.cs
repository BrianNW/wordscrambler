using System;

using System.IO

namespace WordScrambler.Workers
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            try
            {
                string[] fileContent = File.ReadAllLines(filename);

            } catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
            return fileContent;
        }
    }
}
