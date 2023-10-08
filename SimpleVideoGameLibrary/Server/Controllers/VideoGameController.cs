using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleVideoGameLibrary.Server.Data;
using SimpleVideoGameLibrary.Shared;

namespace SimpleVideoGameLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {

        private readonly DataContext _context;

        public VideoGameController(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGames()
        {

            #region Dummy Data Commented By TharakaMadushan-20231008
            //following data consider as dummy data
            //var list = new List<VideoGame>
            //{
            //    new VideoGame{Id = 1, Title = "Super Mario", Publisher = "Disney", ReleaseYear = 1999},
            //    new VideoGame{Id = 2, Title = "NFS", Publisher = "EA Games", ReleaseYear = 2000},
            //}; 
            #endregion

            var list = await _context.VideoGames.ToListAsync();
            return Ok(list);
        }


    }

}
