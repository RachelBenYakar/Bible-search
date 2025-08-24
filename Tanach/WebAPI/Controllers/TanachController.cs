using Bll;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanachController : ControllerBase
    {
        [HttpGet("{word}")]
        public List<Place> FindWord(string word)
        {
            return ParashahService.FindWord(word);
        }

        [HttpGet]
        public List<string> getPsookim()
        {
            return ParashahService.getPsookim();
        }
    }
}
