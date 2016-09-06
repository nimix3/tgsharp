namespace HoopoeTelegram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management;

    internal class HardWare
    {
        private string GetBiosSerial()
        {
            using (IEnumerator<ManagementObject> enumerator = (from wmi in new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_BIOS").Get().Cast<ManagementObject>()
                where !string.IsNullOrEmpty(wmi.GetPropertyValue("SerialNumber").ToString())
                select wmi).GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    return enumerator.Current.GetPropertyValue("SerialNumber").ToString().Replace(" ", "");
                }
            }
            return "None";
        }

        private string GetBoardMaker()
        {
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_BaseBoard").Get().GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    ManagementObject current = (ManagementObject) enumerator.Current;
                    try
                    {
                        return current.GetPropertyValue("SerialNumber").ToString();
                    }
                    catch
                    {
                        return "None";
                    }
                }
            }
            return "None";
        }

        internal string GetProcessId()
        {
            string str = string.Empty;
            foreach (ManagementObject obj2 in new ManagementClass("win32_processor").GetInstances())
            {
                if (!(str != ""))
                {
                    return obj2.Properties["processorID"].Value.ToString();
                }
            }
            return str;
        }
    }
}

