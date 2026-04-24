using Domain;

namespace Infrastructure;

public class GroupRepository : IGroupRepository
{
    private readonly List<Group> groups = new();

    public bool CreateGroup(Group group)
    {
        if (groups.Any(g => g.Id == group.Id))
        {
            return false;
        }

        groups.Add(group);
        return true;
    }

    public Group? GetGroup(int id)
    {
        return groups.FirstOrDefault(g => g.Id == id);
    }

    public bool UpdateGroup(int id, string name, string description)
    {
        Group? group = groups.FirstOrDefault(g => g.Id == id);

        if (group == null)
        {
            return false;
        }

        group.Name = name;
        group.Description = description;
        return true;
    }

    public bool DeleteGroup(int id)
    {
        Group? group = groups.FirstOrDefault(g => g.Id == id);

        if (group == null)
        {
            return false;
        }

        groups.Remove(group);
        return true;
    }
}
