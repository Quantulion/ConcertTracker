using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;

namespace BusinessLayer
{
    public class DataManager
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IConcertHallRepository _concertHallRepository;
        private readonly IConcertRepository _concertRepository;
        private readonly IGenreRepository _genreRepository;
        
        public DataManager(IAdminRepository adminRepository,
            IArtistRepository artistRepository,
            IUserRepository userRepository,
            ICommentRepository commentRepository,
            IConcertHallRepository concertHallRepository,
            IConcertRepository concertRepository,
            IGenreRepository genreRepository)
        {
            _adminRepository = adminRepository;
            _artistRepository = artistRepository;
            _userRepository = userRepository;
            _commentRepository = commentRepository;
            _concertHallRepository = concertHallRepository;
            _concertRepository = concertRepository;
            _genreRepository = genreRepository;
        }
        
        public IAdminRepository Admins => _adminRepository;
        public IArtistRepository Artists => _artistRepository;
        public IUserRepository Users => _userRepository;
        public ICommentRepository Comments => _commentRepository;
        public IConcertHallRepository ConcertHalls => _concertHallRepository;
        public IConcertRepository Concerts => _concertRepository;
        public IGenreRepository Genres => _genreRepository;
    }
}
