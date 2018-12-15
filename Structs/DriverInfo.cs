using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksBroadcastingNetwork.Structs
{
    public struct DriverInfo
    {
        public ushort DriverIndex { get; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Nickname { get; internal set; }
        public string ShortName { get; internal set; }
        public DriverCategory Category { get; internal set; }

        public DriverInfo(ushort driverIndex) : this()
        {
            DriverIndex = driverIndex;
        }
    }
}
