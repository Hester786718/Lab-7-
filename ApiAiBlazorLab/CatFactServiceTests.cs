using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiBlazorLab.Services;
using Xunit;

namespace ApiAiBlazorLab
{
    public class CatFactServiceTests

    {

        [Fact]

        public async Task GetRandomFact_ReturnsFact()

        {

            var json = "{\"fact\":\"Cats sleep 16 hours a day.\",\"length\":32}";

            var client = new HttpClient(new FakeHandler(json));


            var service = new CatFactService(client);


            var result = await service.GetRandomFactAsync();


            Assert.Equal("Cats sleep 16 hours a day.", result);

        }

    }
}
