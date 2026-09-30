using Payrix.Core.Models;

namespace Payrix.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public Environment2Options Environment2 { get; set; } = new();
    public Environment3Options Environment3 { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(
            () => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Environment2.BaseUrl, path, []),
            () => new UrlTemplate(
                Environment3.BaseUrl,
                path,
                [TemplateParam.ForServer("serverUrl", Environment3.ServerUrl)]));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://test-api.payrix.com";
    }

    public class Environment2Options
    {
        public string BaseUrl { get; set; } = "https://test-api.payrixcanada.com";
    }

    public class Environment3Options
    {
        public string BaseUrl { get; set; } = "{serverUrl}";
        public string ServerUrl { get; set; } = "https://custom.payrix.com";
    }
}
