using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class HelicopterRepository
    {
        private List<Helicopter> _helicopters;

        public HelicopterRepository()
        {
            _helicopters = new List<Helicopter>();
        }

        public HelicopterRepository(List<Helicopter> helicopters)
        {
            _helicopters = helicopters;
        }

        public HelicopterRepository(string filename)
        {
            _helicopters = new List<Helicopter>();
            ReadFromFileCsv(filename);
        }

        public void RemoveAll()
        {
            _helicopters.Clear();
        }

        public bool ReadFromFileCsv(string filename)
        {
            try
            {
                using (TextReader textReader = File.OpenText(filename))
                {
                    var csv = new CsvReader(textReader);
                    _helicopters = csv.GetRecords<Helicopter>().ToList();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
