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
    public interface IPositionService
    {
        IEnumerable<Position> GetPositions(string name = null);
        Position GetPosition(int id);
        Position GetPosition(string name);
        void CreatePosition(Position position);
        void Save();
    }

    public class PositionService : IPositionService
    {
        private readonly IPositionRepository positionRepository;
        private readonly IUnitOfWork unitOfWork;

        public PositionService(IPositionRepository positionRepository, IUnitOfWork unitOfWork)
        {
            this.positionRepository = positionRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Position> GetPositions(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return positionRepository.GetAll();
            else
                return positionRepository.GetAll().Where(p => p.Name.ToLower() == name.ToLower());
        }

        public Position GetPosition(int id)
        {
            var position = positionRepository.GetById(id);
            return position;
        }

        public Position GetPosition(string name)
        {
            var position = positionRepository.GetPositionByName(name);
            return position;
        }

        public void CreatePosition(Position position)
        {
            positionRepository.Add(position);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
    }
}
