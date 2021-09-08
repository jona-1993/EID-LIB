using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EIDLib
{
    public static class Settings
    {
        public enum Language
        {
            nl,
            fr,
            de,
            en
        };

        public static void SetLanguage(Language language)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                System.Reflection.Assembly assembly;
                Type typeRegistry;

                try
                {
                    assembly = System.Reflection.Assembly.Load("Microsoft.Win32.Registry");

                    typeRegistry = assembly.GetTypes().Where(t => t.IsClass && t.IsSealed && t.IsAbstract && t.Name == "Registry").First();
                }
                catch(Exception)
                {
                    assembly = System.Reflection.Assembly.Load("mscorlib");

                    typeRegistry = assembly.GetTypes().Where(t => t.IsClass && t.IsSealed && t.IsAbstract && t.Name == "Registry").First();
                }

                dynamic CurrentUser = typeRegistry.GetField("CurrentUser", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).GetValue(null);

                dynamic key = CurrentUser.OpenSubKey(@"SOFTWARE\BEID\general", true);


                if (key != null)  // Must check for null key
                {
                    key.SetValue("language", Enum.GetName(typeof(Language), language));

                    key.Close();
                }
                else
                {
                    key = CurrentUser.CreateSubKey(@"SOFTWARE\BEID\general");
                    key.SetValue("language", Enum.GetName(typeof(Language), language));
                    key.Close();
                }
                
            }
            else
            {
                try
                {
                    if (File.Exists("/usr/local/etc/BEID.conf"))
                    {
                        var config = File.ReadAllText("/usr/local/etc/BEID.conf");

                        Regex reg = new Regex(@"language ?= ?((en)|(fr)|(de)|(nl))");

                        config = reg.Replace(config, $"language={Enum.GetName(typeof(Language), language)}");

                        File.Delete("/usr/local/etc/BEID.conf");

                        File.WriteAllText("/usr/local/etc/BEID.conf", config);
                    }
                    else
                    {
                        string config = $"[general]\r\nlanguage={Enum.GetName(typeof(Language), language)}\r\n";

                        File.WriteAllText("/usr/local/etc/BEID.conf", config);
                    }
                }
                catch(Exception ex)
                {
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/Library/Preferences/BEID.conf"))
                        {
                            var config = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/Library/Preferences/BEID.conf");

                            Regex reg = new Regex(@"language ?= ?((en)|(fr)|(de)|(nl))");

                            config = reg.Replace(config, $"language={Enum.GetName(typeof(Language), language)}");

                            File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/Library/Preferences/BEID.conf");

                            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/Library/Preferences/BEID.conf", config);
                        }
                        else
                        {
                            string config = $"[general]\r\nlanguage={Enum.GetName(typeof(Language), language)}\r\n";

                            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/Library/Preferences/BEID.conf", config);
                        }
                    }
                    else
                    {
                        if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/.config/BEID.conf"))
                        {
                            var config = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/.config/BEID.conf");

                            Regex reg = new Regex(@"language ?= ?((en)|(fr)|(de)|(nl))");

                            config = reg.Replace(config, $"language={Enum.GetName(typeof(Language), language)}");

                            File.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/.config/BEID.conf");

                            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/.config/BEID.conf", config);
                        }
                        else
                        {
                            string config = $"[general]\r\nlanguage={Enum.GetName(typeof(Language), language)}\r\n";

                            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/.config/BEID.conf", config);
                        }
                    }
                }
            }
        }
    }
}
