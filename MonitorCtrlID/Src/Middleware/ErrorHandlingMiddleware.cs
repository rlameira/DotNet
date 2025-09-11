using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MonitorCtrlID.Src.Middleware
{
  public class ErrorHandlingMiddleware
  {
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
      _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
      try
      {
        await _next(context);
      }
      catch (Exception ex)
      {
        LogError(ex);
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("Ocorreu um erro interno.");
      }
    }

    public void LogError(Exception ex)
    {
      string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
      File.AppendAllText(logPath, $"[{DateTime.Now}] {ex}\n");
    }
  }

  // Registrar no pipeline
  public static class ErrorHandlingMiddlewareExtensions
  {
    public static IApplicationBuilder UseErrorHandling(this IApplicationBuilder builder)
    {
      return builder.UseMiddleware<ErrorHandlingMiddleware>();
    }
  }
}

