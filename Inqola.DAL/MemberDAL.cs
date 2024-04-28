using Inqola.Interface;
using Inqola.Models;

namespace Inqola.DAL;

public class MemberDAL : IMember
{
    public Member AddMember(Member member)
    {
        if(member == null)
        {
            throw new ArgumentNullException("member");
        }

        return member;
    }

    public bool AddMemberActivity(MemberActivity activity)
    {
        return activity != null;
    }

    public bool AddMemberStatus(MemberStatus status)
    {
        return status != null;
    }

    public bool DeleteMember(int id)
    {
        return true;
    }

    public bool DeleteMemberActivity(int memberId)
    {
        return true;
    }

    public Member GetMember(int id)
    {
        throw new NotImplementedException();
    }

    public List<MemberActivity> GetMemberActivities(int memberId)
    {
        throw new NotImplementedException();
    }

    public List<Member> GetMemberList()
    {
        return  new List<Member>
        {
            new Member {ID = 1, FirstName = "Test"},
            new Member {ID = 2, FirstName = "Name"},
            new Member {ID = 3, FirstName = "Last"},
            new Member {ID = 4, FirstName = "Set"},
        };
    }

    public List<MemberStatus> GetMemberStatuses(int memberId)
    {
        throw new NotImplementedException();
    }

    public bool UpdateMember(Member member)
    {
        throw new NotImplementedException();
    }

    public bool UpdateMemberActivity(MemberActivity activity)
    {
        throw new NotImplementedException();
    }
}
