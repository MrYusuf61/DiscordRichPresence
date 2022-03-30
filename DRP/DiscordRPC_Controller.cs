using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DRP.Properties.Settings;

namespace DRP
{
    public static class DiscordRPC_Controller
    {
        private static bool active = false;
        private static bool started = false;
        private static DiscordRpcClient discordClient;
        private static Action tickAction;
        private static DateTime time = DateTime.Now;
        private static int currentPresenceIndex = -1;

        public static bool Active
        {
            get => active;
            set
            {
                if (value != active)
                {
                    active = value;
                    Refresh();
                    ActiveChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        public static RichPresence CurrentPresence { get; set; } = null;
        public static event EventHandler<string> PresenceChanged;
        public static event EventHandler<EventArgs> ActiveChanged;

        public static void Stop()
        {
            if (!started) return;
            Active = false;
        }

        public static void Start()
        {
            if (!IsID(Default.ClientID) || started) return;

            START_STEP:
            try
            {
                started = true;
                discordClient = new DiscordRpcClient(Default.ClientID);

                try
                {
                    if (discordClient.IsDisposed) discordClient = new DiscordRpcClient(Default.ClientID);
                    if (!discordClient.IsDisposed && !discordClient.IsInitialized) discordClient.Initialize();

                    tickAction = delegate ()
                    {
                        try
                        {
                            Refresh();
                            if (CurrentPresence != null && discordClient.CurrentPresence != CurrentPresence)
                                discordClient.SetPresence(CurrentPresence);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Logger.Error(ex);
                        }
                    };

                    TickManager.Ticks.Add(tickAction);
                    Active = true;
                }
                catch (Exception ex)
                {
                    if (Debugger.IsAttached)
                        Debugger.Break();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Error(ex);
                    Thread.Sleep(5000);
                }

                Refresh();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                goto START_STEP;
            }
        }


        public static void Refresh()
        {
            if (!active)
            {
                try
                {
                    TickManager.Ticks.Remove(tickAction);
                    tickAction = null;
                    discordClient.Dispose();
                    started = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Error(ex);
                }
            }

            if (!started) return;

            if (Default.ChangingPresences)
            {
                if (time >= DateTime.Now) return;
                if (XML.settings != null && XML.settings.items != null && XML.settings.items.Count != 0)
                {
                    if (XML.settings.items.Count <= (++currentPresenceIndex))
                        currentPresenceIndex = 0;

                    var temp = XML.GetItem(XML.settings.items[currentPresenceIndex].Name);
                    time = DateTime.Now.AddMilliseconds(temp.timeout);
                    CurrentPresence = temp.presence;
                    PresenceChanged?.Invoke(temp, XML.settings.items[currentPresenceIndex].Name);
                }
            }
            else
            {
                CurrentPresence = XML.GetCheckedItem().presence;
            }

        }






        public static bool IsID(string Id)
        {
            if (string.IsNullOrEmpty(Id) || Id.Length < 17) return false;
            return true;
        }
    }
}
