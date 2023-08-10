using Microsoft.AspNetCore.Mvc;
using System.ServiceModel;

// Provide main
Console.WriteLine();

[ServiceContract]
public interface IService
{
    [OperationContract]
    void Operation();
}

public partial class Service : IService
{
    public void Operation([FromServices] HttpContext hc)
    {
    }
}