using Inqola.Models;

namespace Inqola.Interface;

public interface IMember
{

    //Adding the member here
    public bool AddMember(Member member);

    //Get members by list of memberID, age, branch, gender, role and the unfilterd list
    List<Member> GetMemberList(); //Done
    List<Member> GetMemberByGender(char memberGender);//Done
    List<Member> GetMemberByID(int id);//Done
    List<Member> GetMemberByStatus(int id);//Done
    List<Member> GetMemberByBranch(int id);//Done
    List<Member> GetMemberByRole(int id);//Done
    List<Member> GetMemberByYouth();// Done
    List<Member> GetMemberBySundaySchool();// done
    List<Member> GetMemberByAdult(); // done

    // UPDATE MEMBER SURNAME         UpdateMemberSurname
    // UPDATE MEMBER PASSWORD        UpdateMemberPassword
    // UPDATE MEMBER BRANCH          UpdateMemberBranch
    // UPDATE MEMBER STATUS          UpdateMemberStatus
    // UPDATE MEMBER ROLE            UpdateMemberRole
    // UPDATE MEMBER MARITAL STATUS  UpdateMemberMaritalStatus

    bool UpdateMemberSurname(string Surname, int Id);
    bool UpdateMemberPassword(string Password, int Id);
    bool UpdateMemberBranch(int BranchId, int Id);
    bool UpdateMemberStatus(int StatusId, int Id);



















    /*
    
    bool DeleteMember(int id);
    

    // Activity for the current member
    List<MemberActivity> GetMemberActivities(int memberId);
    bool AddMemberActivity(MemberActivity activity);
    bool DeleteMemberActivity(int memberId);
    bool UpdateMemberActivity(MemberActivity activity);

    // Statuse for current member

    List<MemberStatus> GetMemberStatuses(int memberId);
    bool AddMemberStatus(MemberStatus status);

    */
}
