using log4net;

namespace Logging;

public class Log4NetExample
{
    public void Logging(ILog logger, Exception e)
    {
        logger.Debug("Message");
        logger.Debug("Message", e);
        logger.DebugFormat("Message"); // Format overloads do not take an exception.

        logger.Error("Message");
        logger.Error("Message", e);
        logger.ErrorFormat("Message"); // Format overloads do not take an exception.

        logger.Fatal("Message");
        logger.Fatal("Message", e);
        logger.FatalFormat("Message"); // Format overloads do not take an exception.

        logger.Info("Message");
        logger.Info("Message", e);
        logger.Info("Message"); // Format overloads do not take an exception.

        logger.Warn("Message");
        logger.Warn("Message", e);
        logger.WarnFormat("Message"); // Format overloads do not take an exception.
    }
}