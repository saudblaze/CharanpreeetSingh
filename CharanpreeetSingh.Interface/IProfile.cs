using CharanpreeetSingh.Entities;

namespace CharanpreeetSingh.Interface
{
    public interface IProfile
    {
        IEnumerable<Profile> GetAllProfile { get; }
        Profile GeProfileById(int id);

        Profile GetProfileByName(string name);
        void Add(Profile profile);
        void Update(Profile profile);

        void Remove(int id);
    }
}