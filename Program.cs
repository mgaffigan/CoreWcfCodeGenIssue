using Microsoft.AspNetCore.Mvc;
using System.ServiceModel;

// Provide main
Console.WriteLine();

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
sealed class ExampleAttribute : Attribute
{
    public ExampleAttribute(params string[] args)
    {
    }
}

[ServiceContract]
public interface IService
{
    [OperationContract]
    void Operation();
}

public partial class Service : IService
{
    //[Example("A")]
    public void Operation([FromServices] HttpContext hc)
    {
    }
}