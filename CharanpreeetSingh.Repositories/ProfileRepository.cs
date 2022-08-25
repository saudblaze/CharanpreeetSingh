using CharanpreeetSingh.Entities;
using CharanpreeetSingh.Interface;
using CharanpreetSingh.DataBaseContext;

namespace CharanpreeetSingh.Repositories
{
    public class ProfileRepository : IProfile
    {
        private CharanPreetDBContext db;

        public ProfileRepository(CharanPreetDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Profile> GetAllProfile => from u in db.Profile
                                                     select new Profile
                                                     {
                                                         Id = u.Id,
                                                         Name = u.Name,
                                                         AddedOn = u.AddedOn,
                                                         AddedBy = u.AddedBy,
                                                         ListExperience = u.ListExperience,
                                                     };

        public Profile GeProfileById(int Id)
        {
            return db.Profile.Where(x => x.Id == Id).FirstOrDefault();
        }

        public Profile GetProfileByName(string name)
        {

            return db.Profile.Where(x => x.Name == name).FirstOrDefault();
        }

        public void Add(Profile profile)
        {
            db.Profile.Add(profile);
            db.SaveChanges();
        }

        public void Update(Profile profile)
        {
            db.Profile.Update(profile);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            Profile? profile = db.Profile.Find(id);
            db.Profile.Remove(profile);
            db.SaveChanges();
        }

    }
}