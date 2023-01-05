// See https://aka.ms/new-console-template for more information
using MassTransit;
using MassTransitConsumer;

var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
{
    cfg.ReceiveEndpoint("address-created-event", e =>
        e.Consumer<AddressCreatedConsumer>());
});

await busControl.StartAsync(new CancellationToken());
try
{
    Console.WriteLine("Press enter to exit");
    await Task.Run(() => Console.ReadLine());
}
finally
{
    await busControl.StopAsync();
}