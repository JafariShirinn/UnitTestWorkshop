using StreamingService.Services;

namespace StreamingServiceUnitTests
{
    public class ExampleTests
    {
        private readonly MovieService _testee;

        public ExampleTests()
        {
            _testee = new MovieService();
        }
    }
}