using System.Globalization;
using Castle.Core.Logging;

namespace Logging;

public class CastleCoreExample
{
    public void Logging(ILogger logger, Exception e)
    {
        logger.Error("Message");
        logger.Error("Message", e);
        logger.ErrorFormat("Message");
        logger.ErrorFormat(e, "Message");
        logger.ErrorFormat(CultureInfo.CurrentCulture, "Message");
        logger.ErrorFormat(e, CultureInfo.CurrentCulture, "Message");

        logger.Debug("Message");
        logger.Debug("Message", e);

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