using System;

using NLog;
using NLog.Targets;
using DojoNorthSoftware.Pushover;

namespace NLog.Targets
{
    [NLog.Targets.Target("PushoverNotify")]
    public class PushoverNotify : NLog.Targets.TargetWithLayout
    {
 
        public PushoverNotify(){}

        public string ApplicationKey{ get; set; }
        public string UserKey { get; set; }
        public string NotificationTitlePrefix { get; set; }
        

        protected override void Write(LogEventInfo logEvent)
        {
           

            try
            { 
                bool notify = false;
                string NotificationTitle = "";


                //verify that application key has been set
                if (String.IsNullOrEmpty(ApplicationKey))
                {
                    NLog.Common.InternalLogger.Log(LogLevel.Error, "PushoverNotify: ApplicationKey is missing");
                    return;
                }

                //verify that user key has been set
                if (String.IsNullOrEmpty(UserKey))
                {
                    NLog.Common.InternalLogger.Log(LogLevel.Error, "PushoverNotify: UserKey (or GroupKey) is missing");
                    return;
                }


                //default NotificationTitle
                if (string.IsNullOrEmpty(NotificationTitlePrefix))
                    NotificationTitlePrefix = "NLog";

                //renders Notificationtitle
                NotificationTitle = NotificationTitlePrefix + ": [" + logEvent.Level + "] " + logEvent.TimeStamp;


                //Render layout as message
                string logMessage = this.Layout.Render(logEvent);

                if (string.IsNullOrEmpty(logMessage))
                    logMessage = logEvent.LoggerName + ": " + logEvent.Message;


                //make message max 512 chars 
                if (logMessage.Length > 512)                
                    logMessage = logMessage.Substring(0, 512);

                //make Title max 50 chars
                if (NotificationTitle.Length > 512)   
                    NotificationTitle = NotificationTitle.PadRight(50).Substring(0, 50);

                //send notification to Pushover
                Exception except;
                notify = Pushover.SendNotification(ApplicationKey, UserKey, NotificationTitle, logMessage, out except);


                //log errors using Nlog internal logs
                if (!notify)
                {
                    NLog.Common.InternalLogger.Log(LogLevel.Error, "Pushover: " + except.ToString());
                }

            }
            //log errors using Nlog internal logs
            catch(Exception ex) {

                NLog.Common.InternalLogger.Log(LogLevel.Error, "PushoverNotify: " + ex.ToString());
            
            }
           
        }

       
    }
}