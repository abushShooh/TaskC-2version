namespace Domain;

public interface IGroupRepository
{
    bool CreateGroup(Group group);
    Group? GetGroup(int id);
    bool UpdateGroup(int id, string name, string description);
    bool DeleteGroup(int id);
}
