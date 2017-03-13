using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class AirplaneRepository
    {
        private List<Airplane> _airplanes;

        public AirplaneRepository()
        {
            _airplanes = new List<Airplane>();
        }

        public AirplaneRepository(List<Airplane> airplanes)
        {
            _airplanes = airplanes;
        }

        public AirplaneRepository(string filename)
        {
            _airplanes = new List<Airplane>();
            ReadFromFileCsv(filename);
        }

        public void RemoveAll()
        {
            _airplanes.Clear();
        }

        public bool ReadFromFileCsv(string filename)
        {
            try
            {
                using (TextReader textReader = File.OpenText(filename))
                {
                    var csv = new CsvReader(textReader);
                    _airplanes = csv.GetRecords<Airplane>().ToList();
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
