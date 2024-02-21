using System.Globalization;
using Common.Logging;

namespace Logging;

public class CommonLoggingCoreExample
{
    public void Logging(ILog logger, Exception e)
    {
        logger.Debug("Message");
        logger.Debug("Message", e);
        logger.Debug(_ => { });
        logger.Debug(_ => { }, e);
        logger.Debug(CultureInfo.CurrentCulture, _ => { });
        logger.Debug(CultureInfo.CurrentCulture, _ => { }, e);
        logger.DebugFormat("Message");
        logger.DebugFormat("Message", e);
        logger.DebugFormat(CultureInfo.CurrentCulture, "Message");
        logger.DebugFormat(CultureInfo.CurrentCulture, "Message", e);

        logger.Error("Message");
        logger.Error("Message", e);

        logger.Fatal("Message");
        logger.Fatal("Message", e);

        logger.Info("Message");
        logger.Info("Message", e);

        logger.Trace("Message");
        logger.Trace("Message", e);

        logger.Warn("Message");
        logger.Warn("Message", e);
    }
}