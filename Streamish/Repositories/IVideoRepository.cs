using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Streamish.Models;
using Streamish.Utils;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {

        List<Video> GetAll();
        Video GetById(int id);
        void Add(Video video);
        void Update(Video video);
        void Delete(int id);
        List<Video> GetAllWithComments();
        Video GetVideoByIdWithComments(int id);

    }
}
