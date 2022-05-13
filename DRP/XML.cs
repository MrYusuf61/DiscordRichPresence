using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DRP
{
    public static class XML
    {
        public static Settings settings = new Settings();
        private static string fileName = ".\\settings.xml";
        public static void Save()
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                FileStream fs = new FileStream(fileName, FileMode.CreateNew);
                XmlSerializer xmlWriter = new XmlSerializer(typeof(Settings));
                xmlWriter.Serialize(fs, settings);
                fs.Flush();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        public static void Read()
        {
            try
            {
                if (!File.Exists(fileName))
                    Save();
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer xmlReader = new XmlSerializer(typeof(Settings));
                settings = (Settings)xmlReader.Deserialize(fs);
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

        }

        public static void SetChechked(string name)
        {
            settingsCheckAndRead();
            for (int i = 0; i < settings.items.ToList().Count; i++)
            {
                settings.items[i].Checked = false;
                if (settings.items[i].Name == name)
                    settings.items[i].Checked = true;
            }
        }

        public static (int index, RichPresence presence, SettingItem settingItem, bool p_checked, int timeout) GetItem(string name)
        {
            settingsCheckAndRead();
            for (int i = 0; i < settings.items.ToList().Count; i++)
            {
                if (settings.items[i].Name == name)
                {
                    var tempItem = settings.items[i];

                    var tempAssets = new Assets();
                    var tempButtons = new List<DiscordRPC.Button>();

                    if (string.IsNullOrEmpty(tempItem.AssetLargeImageKey) &&
                        string.IsNullOrEmpty(tempItem.AssetLargeImageText) &&
                        string.IsNullOrEmpty(tempItem.AssetSmallImageKey) &&
                        string.IsNullOrEmpty(tempItem.AssetSmallImageText))
                        tempAssets = null;
                    else
                        tempAssets = new Assets()
                        {
                            LargeImageKey = tempItem.AssetLargeImageKey,
                            LargeImageText = tempItem.AssetLargeImageText,
                            SmallImageKey = tempItem.AssetSmallImageKey,
                            SmallImageText = tempItem.AssetSmallImageText
                        };

                    if (!string.IsNullOrEmpty(tempItem.Button1Label) &&
                        !string.IsNullOrEmpty(tempItem.Button1Url))
                        tempButtons.Add(new DiscordRPC.Button() { Label = tempItem.Button1Label, Url = tempItem.Button1Url });

                    if (!string.IsNullOrEmpty(tempItem.Button2Label) &&
                        !string.IsNullOrEmpty(tempItem.Button2Url))
                        tempButtons.Add(new DiscordRPC.Button() { Label = tempItem.Button2Label, Url = tempItem.Button2Url });

                    Timestamps timestamps = new Timestamps();
                    if (settings.AutoTime) timestamps.Start = Process.GetCurrentProcess().StartTime.ToUniversalTime();
                    else
                    {
                        timestamps.Start = (settings.StartTime.HasValue ? Convert.ToDateTime(new TimeSpan(settings.StartTime.Value).ToString()) : (DateTime?)null);
                        timestamps.End = (settings.EndTime.HasValue ? Convert.ToDateTime(new TimeSpan(settings.EndTime.Value).ToString()) : (DateTime?)null);
                    }

                    var tempPresence = new RichPresence()
                    {
                        Details = tempItem.Details,
                        State = tempItem.State,
                        Assets = tempAssets,
                        Buttons = tempButtons.ToArray(),
                        Timestamps = timestamps
                    };

                    return (i, tempPresence, tempItem, tempItem.Checked, tempItem.Timeout);
                }

            }
            return (-1, null, null, false, 1);
        }

        public static (int index, RichPresence presence, SettingItem settingItem, bool p_checked, int timeout) GetCheckedItem()
        {
            settingsCheckAndRead();
            foreach (var item in settings.items)
                if (item.Checked)
                    return GetItem(item.Name);

            return (-1, null, null, false, 1);
        }

        public static string[] GetNames()
        {
            settingsCheckAndRead();
            if (settings.items.Count > 0)
            {
                settings.items.Sort((left, right) => left.Name.CompareTo(right.Name));
                Save();
                return settings.items.Select((item) => item.Name).ToArray();
            }
            return new string[0];
        }

        public static bool Add(SettingItem item)
        {
            if (HasPresence(item.Name))
                return false;
            else
            {
                try
                {
                    settings.items.Add(item);
                    Save();
                    Read();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Error(ex);
                }
            }

            return true;
        }

        public static void Update(SettingItem item)
        {
            var tempIndex = GetItem(item.Name).index;
            try
            {
                if (tempIndex >= 0)
                {
                    settings.items[tempIndex] = item;
                    Save();
                    Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(ex);
            }
        }

        public static void Remove(string Name)
        {
            var tempIndex = GetItem(Name).index;
            try
            {
                if (tempIndex >= 0)
                {
                    settings.items.Remove(settings.items[tempIndex]);
                    Save();
                    Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(ex);
            }
        }

        public static void SetTime(Timestamps time,bool auto = false)
        {
            try
            {
                settings.AutoTime = auto;
                if(time == null)
                {
                    settings.StartTime = null;
                    settings.EndTime = null;
                }
                else
                {
                    settings.StartTime = (time.Start == null ? (long?)null : time.Start.Value.TimeOfDay.Ticks);
                    settings.EndTime = (time.End == null ? (long?)null : time.End.Value.TimeOfDay.Ticks);
                }
                Save();
                Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(ex);
            }
        }



        private static void settingsCheckAndRead()
        {
            if (settings == null || settings.items == null)
                Read();
        }
        private static bool HasPresence(string Name)
        {
            settingsCheckAndRead();
            foreach (var item in settings.items)
                if (item.Name == Name)
                    return true;
            return false;
        }
    }


    [XmlRoot("CustomRichPresences")]
    public class Settings
    {
        [XmlArray("RichPresences")]
        [XmlArrayItem("RichPresence")]
        public List<SettingItem> items { get; } = new List<SettingItem>();


        [XmlAttribute("PresenceStartTime")]
        public string StartTimeXml { get; set; } = null;

        public long? StartTime 
        {
            get
            {
                try
                {
                    return long.Parse(StartTimeXml);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue) StartTimeXml = value.Value.ToString();
                else StartTimeXml = null;
            } 
        }


        [XmlAttribute("PresenceEndTime")]
        public string EndTimeXml { get; set; } = null;


        public long? EndTime
        {
            get
            {
                try
                {
                    return long.Parse(EndTimeXml);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue) EndTimeXml = value.Value.ToString();
                else EndTimeXml = null;
            }
        }


        [XmlAttribute("PresenceAutoTime")]
        public bool AutoTime { get; set; } = false;
    }

    public class SettingItem
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }


        [XmlAttribute("Timeout")]
        public int Timeout { get; set; } = 1000;


        [XmlAttribute("Checked")]
        public bool Checked { get; set; } = false;


        [XmlAttribute("Details")]
        public string Details { get; set; }


        [XmlAttribute("State")]
        public string State { get; set; }


        [XmlAttribute("AssetSmallImageKey")]
        public string AssetSmallImageKey { get; set; }


        [XmlAttribute("AssetSmallImageText")]
        public string AssetSmallImageText { get; set; }


        [XmlAttribute("AssetLargeImageKey")]
        public string AssetLargeImageKey { get; set; }


        [XmlAttribute("AssetLargeImageText")]
        public string AssetLargeImageText { get; set; }


        [XmlAttribute("Button1Label")]
        public string Button1Label { get; set; }


        [XmlAttribute("Button2Label")]
        public string Button2Label { get; set; }


        [XmlAttribute("Button1Url")]
        public string Button1Url { get; set; }


        [XmlAttribute("Button2Url")]
        public string Button2Url { get; set; }
    }
}
