using Inqola.Models;

namespace Inqola.Interface;

public interface IMember
{
    Member AddMember(Member member);
    Member GetMember(int id);
    bool UpdateMember(Member member);   
    bool DeleteMember(int id);
    List<Member> GetMemberList();

    // Activity for the current member
    List<MemberActivity> GetMemberActivities(int memberId);
    bool AddMemberActivity(MemberActivity activity);
    bool DeleteMemberActivity(int memberId);
    bool UpdateMemberActivity(MemberActivity activity);

    List<MemberStatus> GetMemberStatuses(int memberId);
    bool AddMemberStatus(MemberStatus status);
}
