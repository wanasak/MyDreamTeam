using MyDreamTeam.Data.Infrastructure;
using MyDreamTeam.Data.Repositories;
using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Service
{
    public interface IClubService
    {
        IEnumerable<Club> GetClubs();

        void Save();
    }
    public class ClubService : IClubService
    {
        private readonly IClubRepository clubRepository;
        private readonly IUnitOfWork unitOfWork;

        public ClubService(IClubRepository clubRepository, IUnitOfWork unitOfWork)
        {
            this.clubRepository = clubRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Club> GetClubs()
        {
            var clubs = clubRepository.GetAll();
            return clubs;
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
