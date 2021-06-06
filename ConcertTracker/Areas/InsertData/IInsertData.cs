using System.Threading.Tasks;

namespace ConcertTracker.Areas.InsertData
{
    public interface IInsertData
    {
        public Task InsertAllData(int number);
        public Task InsertUsers(int number);
        public Task InsertArtists(int number);
        public Task InsertConcertHalls(int number);
        public Task InsertConcerts(int number);
        public Task InsertComments(int number);
    }
}