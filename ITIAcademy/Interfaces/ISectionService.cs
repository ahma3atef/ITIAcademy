using ITIAcademy.Models;

namespace ITIAcademy.Interfaces
{
    public interface ISectionService
    {
        public List<Section> GetAll();

        public Section GetById(int id);

        public void Add(Section section);

        public void Edit(Section section);

        public void Delete(int id);
    }
}
