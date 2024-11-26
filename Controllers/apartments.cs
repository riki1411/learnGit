using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apartments : ControllerBase
    {
        private static List<apartment> Apartment = new List<apartment>

        {
            new apartment{City="bnei brak",ApartmentNum=126,NumRooms=3,Size=120,Floor=1,Type="for sale",Amount=250000000},
            new apartment{City="Jerusalem",ApartmentNum=421,NumRooms=5,Size=110,Floor=2,Type="for rent",Amount=350000000},
            new apartment{City="modien elit",ApartmentNum=236,NumRooms=2,Size=90,Floor=5,Type="for sale",Amount=25000000},
            new apartment{City="ramat gan",ApartmentNum=154,NumRooms=4,Size=105,Floor=6,Type="for rent",Amount=27000000},

        };

    // GET: api/<apartments>
    [HttpGet]
        public IEnumerable<apartment> Get()
        {
            return Apartment;
        }

        // GET api/<apartments>/5
        [HttpGet("{id}")]
        public int Getid(int apartmentNum)
        {
            return apartmentNum;
        }

        // POST api/<apartments>
        [HttpPost]
        public apartment Post([FromBody] apartment value)
        {
            Apartment.Add(value);
            return value;
        }

        // PUT api/<apartments>/5
        [HttpPut("{id}")]
        public apartment Put(int apartmentNum, [FromBody] apartment value)
        {
            var index = Apartment.FindIndex(e => e.ApartmentNum == apartmentNum);
            Apartment[index].City = value.City;
            Apartment[index].NumRooms = value.NumRooms;
            Apartment[index].Size = value.Size;
            Apartment[index].Floor = value.Floor;
            Apartment[index].Type = value.Type;
            Apartment[index].Amount = value.Amount;
            return Apartment[index];

        }

        // DELETE api/<apartments>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
