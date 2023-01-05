using MassTransit;
using Newtonsoft.Json;
using SharedLibrary.DTO.Interfaces;

namespace MassTransitConsumer
{
    public class AddressCreatedConsumer : IConsumer<IAddressDto>
    {
        public async Task Consume(ConsumeContext<IAddressDto> context)
        {
            var jsonMessage = JsonConvert.SerializeObject(context.Message);
            Console.WriteLine($"AddressCreated message: {jsonMessage}");
        }
    }
}