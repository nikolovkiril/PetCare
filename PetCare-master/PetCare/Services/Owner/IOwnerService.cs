namespace PetCare.Services.Owner
{
    public interface IOwnerService
    {
        bool IsOwnerExist(string userId);

        bool IsUserOwner(string userId, string petId);

        void AddOwner(string userId);

        int GetOwnerId(string userId);

    }
}
