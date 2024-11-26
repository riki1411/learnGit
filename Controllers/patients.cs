using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class patients : ControllerBase
    {
        private static List<patient> Patients = new List<patient> {
            new patient{Name="ruti sasson",Id=123456789,Phone_number=058423166,Email=",mnbv@gmail.com",Adress="bagno 15,bnei brak",Preferred_area=4},
            new patient{Name="naama nougershal",Id=987654321,Phone_number=054253998,Email="safza@gmail.com",Adress="miron 16,bnei brak",Preferred_area=3},
            new patient{Name="riki rozental",Id=147852369,Phone_number=052635874,Email="recac254@gmail.com",Adress="harv kok 8 bnei brak",Preferred_area=4},
            new patient{Name="ayala sasson",Id=123654478,Phone_number=058695812,Email="NULL",Adress="bagno 18,bnei brak",Preferred_area=2}

            };

        // GET: api/<patients>
        [HttpGet]

        public IEnumerable<patient> Get()
        {
            return Patients;
        }

        // GET api/<patients>/5
        [HttpGet("{id}")]
        public int GetId(int id)
        {
            return id;
        }

        // POST api/<patients>
        [HttpPost]
        public patient Post([FromBody] patient value)
        {
            Patients.Add(value);
            return value;
        }

        // PUT api/<patients>/5
        [HttpPut("{id}")]
        public patient Put(int id, [FromBody] patient value)
        {
            var index = Patients.FindIndex(e => e.Id == id);
            Patients[index].Name = value.Name;
            Patients[index].Phone_number = value.Phone_number;
            Patients[index].Email = value.Email;
            Patients[index].Adress = value.Adress;
            Patients[index].Preferred_area = value.Preferred_area;

            return Patients[index];
        }

        // DELETE api/<patients>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
