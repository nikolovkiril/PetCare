namespace PetCare.Services.Owner
{
    using System.Linq;
    using PetCare.Data;
    using PetCare.Data.Models.Pet;

    public class OwnerService : IOwnerService
    {
        private readonly PetCareDbContext data;

        public OwnerService(PetCareDbContext data) 
            => this.data = data;

        public void AddOwner(string userId)
        {
            var owner = new Owner
            {
                UserId = userId
            };
            this.data.Owners.Add(owner);
            this.data.SaveChanges();
        }

        public int GetOwnerId(string userId)
            => this.data
                 .Owners
                 .Where(o => o.UserId == userId)
                 .Select(u => u.Id)
                 .FirstOrDefault();

        public bool IsOwnerExist(string userId)
            => this.data
                .Owners
                .Any(o => o.UserId == userId);

        public bool IsUserOwner(string userId, string petId)
            => this.data
                .Pets
                .Any(p => p.Id == petId && p.Owner.UserId == userId);
    }
}
