namespace Todo_List.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //Log request 
            _logger.LogInformation($"[REQUEST] {context.Request.Method} {context.Request.Path}");


            //Copy reponse body để loging ra
            var originalBodyStream = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;
            await _next(context);


            context.Response.Body.Seek(0, SeekOrigin.Begin);
            string responseText = await new StreamReader(context.Response.Body).ReadToEndAsync();
            context.Response.Body.Seek(0, SeekOrigin.Begin);


            _logger.LogInformation($"[RESPONSE] {context.Response.StatusCode} {responseText}");

            await responseBody.CopyToAsync(originalBodyStream);

        }
    }
}
