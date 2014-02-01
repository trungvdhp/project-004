using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Library
{
    public class MachineInfo
    {
        public static Dictionary<string, object> GetMachineInfo()
        {
            var result = new Dictionary<string, object>();

            result.Add("UserDomainName", string.Format("{0}", Environment.UserDomainName));
            result.Add("UserName", string.Format("{0}", Environment.UserName));
            
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (var ip in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            result.Add("PhysicalAddress", string.Format("{0}", networkInterface.GetPhysicalAddress()));

                            return result;
                        }
                    }
                }
            }

            return result;
        }

        public static string PhysicalAddress
        {
            get
            {
                foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (networkInterface.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (var ip in networkInterface.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                return networkInterface.GetPhysicalAddress().ToString();
                            }
                        }
                    }
                }
                return string.Empty;
            }
        }

        public static string Caption
        {
            get
            {
                return GetSystemInfo("Caption");
            }
        }
        public static string CSName
        {
            get
            {
                return GetSystemInfo("CSName");
            }
        }
        public static string OSArchitecture
        {
            get
            {
                return GetSystemInfo("OSArchitecture");
            }
        }
        public static string RegisteredUser
        {
            get
            {
                return GetSystemInfo("RegisteredUser");
            }
        }
        public static string SerialNumber
        {
            get
            {
                return GetSystemInfo("SerialNumber");
            }
        }

        public static string SystemInformation
        {
            get
            {
                return string.Format("{0}|{1}|{2}|{3} {4}|{5}", CSName, PhysicalAddress, RegisteredUser, Caption, OSArchitecture, SerialNumber);
            }
        }

        public static string GetSystemInfo(string properties)
        {
            ManagementObjectSearcher objSearch = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject obj in objSearch.Get())
            {
                return obj[properties].ToString().Trim();
            }

            return string.Empty;
        }
    }
}
