using Microsoft.AspNetCore.Mvc.Filters;

namespace ExampleService.Middleware;

public class GlobalErrorHandler : IExceptionFilter
{
  
    /// <summary>
    /// Глобальный обработчик ошибок
    /// </summary>
    private readonly ILogger _logger;

    /// <summary>
    /// Глобальный обработчик ошибок
    /// </summary>
    /// <param name="logger"></param>
    public GlobalErrorHandler(ILogger logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Логирование неотловленной ошибки
    /// </summary>
    /// <param name="context"></param>
    public void OnException(ExceptionContext context)
    {
        _logger.LogError(context.Exception.GetBaseException(), "Обнаружено неотловленное исключение: ");
    }
}