using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using DataAccessLayer.Entities;

namespace DataAccessLayer
{
    public class AirportRepository
    {

        private List<Airport> _airports;

        public AirportRepository()
        {
            _airports = new List<Airport>();
        }

        public AirportRepository(List<Airport> airports)
        {
            _airports = airports;
        }

        public AirportRepository(string filename)
        {
            _airports = new List<Airport>();
            ReadFromFileCsv(filename);
        }

        public void RemoveAll()
        {
            _airports.Clear();
        }

        public bool ReadFromFileCsv(string filename)
        {
            try
            {
                using (TextReader textReader = File.OpenText(filename))
                {
                    var csv = new CsvReader(textReader);
                    _airports = csv.GetRecords<Airport>().ToList();
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
