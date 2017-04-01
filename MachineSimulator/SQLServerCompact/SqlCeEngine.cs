using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineSimulator.Interfaces;

namespace MachineSimulator.SQLServerCompact
{
    public class SqlCeEngine : IDatabaseEngine
    {
        // Private variables
        private string _extension = "sdf";


        // Public properties
        public string Extension
        {
            get
            {
                return _extension;
            }
        }

        // Methods
        public void Connect(string dbName)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void TruncateDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
