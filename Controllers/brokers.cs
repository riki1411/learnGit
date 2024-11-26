using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class brokers : ControllerBase
    {
        private static List<Broker> Brokers = new List<Broker>
      
        {
            new Broker{Name="nati levi",Id=625412368,Phone_number=0523698541,Email="rfcvb@gmail.com",Adress="rabi akiva 64"},
            new Broker{Name="kobi choen",Id=625412371,Phone_number=0523698543,Email="cghjcc@gmail.com",Adress="hashomer 135"},
            new Broker{Name="dani kaz",Id=128888773,Phone_number=0523698545,Email="nlho@gmail.com",Adress="chazon eish 26"},
            new Broker{Name="yron shapira",Id=854123652,Phone_number=0523698548,Email="nlho@gmail.com",Adress="hevron 35"}
        };

    // GET: api/<brokers>
    [HttpGet]
        public IEnumerable<Broker> Get()
        {
        return Brokers;
        }

        // GET api/<brokers>/5
        [HttpGet("{id}")]
        public int Getid(int id)
        {
            return id;
        }

        // POST api/<brokers>
        [HttpPost]
        public Broker Post([FromBody] Broker value)
        {
            Brokers.Add(value);
            return value;
        }

        // PUT api/<brokers>/5
        [HttpPut("{id}")]
        public Broker Put(int id, [FromBody] Broker value)
        {
            var index = Brokers.FindIndex(e => e.Id == id);
            Brokers[index].Name = value.Name;
            Brokers[index].Phone_number = value.Phone_number;
            Brokers[index].Email = value.Email;
            Brokers[index].Adress = value.Adress;
            return Brokers[index];

        }

        // DELETE api/<brokers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
