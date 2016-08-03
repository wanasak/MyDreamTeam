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
    public interface IFootballerService
    {
        IEnumerable<Footballer> GetFootballers();
        IEnumerable<Footballer> GetPositionFootballers(string positionName, string footballerName);
        Footballer GetFootballer(int id);
        void CreateFootballer(Footballer footballer);
        void Save();
    }

    public class FootballerService : IFootballerService
    {
        private readonly IFootballerRepository footballerRepository;
        private readonly IPositionRepository positionRepository;
        private readonly IUnitOfWork unitOfWork;

        public FootballerService(IFootballerRepository footballerRepository,
            IPositionRepository positionRepository,
            IUnitOfWork unitOfWork)
        {
            this.footballerRepository = footballerRepository;
            this.positionRepository = positionRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Footballer> GetFootballers()
        {
            var footballers = footballerRepository.GetAll();
            return footballers;
        }

        public IEnumerable<Footballer> GetPositionFootballers(string positionName, string footballerName)
        {
            var position = positionRepository.GetPositionByName(positionName);
            return position.Footballers.Where(p => p.LastName.ToLower().Contains(footballerName.ToLower()));
        }

        public Footballer GetFootballer(int id)
        {
            var footballer = footballerRepository.GetById(id);
            return footballer;
        }

        public void CreateFootballer(Footballer footballer)
        {
            footballerRepository.Add(footballer);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
