using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IInsertData
    {
        public Task InsertAllData();
        public Task InsertUsers();
        public Task InsertArtists();
        public Task InsertConcertHalls();
        public Task InsertConcerts();
        public Task InsertComments();
    }
}