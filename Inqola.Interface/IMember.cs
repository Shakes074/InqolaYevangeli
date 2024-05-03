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
    List<Member> GetMemberByEmploymentStatus(int id); // done

    //Updating members details surname, marriage status, email, phone number, password, branchID, statusId, roleId and employment status.
    bool UpdateMemberSurname(string Surname, int Id); // done
    bool UpdateMemberMaritalStatus(int MarStatus, int Id); // done
    bool UpdateMemberEmail(string Email, int Id); // done
    bool UpdateMemberPhone(string Phone, int Id); // done
    bool UpdateMemberPassword(string Password, int Id); // done
    bool UpdateMemberBranch(int BranchId, int Id); // done
    bool UpdateMemberStatus(int StatusId, int Id); // done
    bool UpdateMemberRole(int RoleId, int Id); // done
    bool UpdateEmploymentStatus(int StatusId, int Id); // done
    
    //Disabling members by  deleting
    bool DisableMember(int Id); // done
    
}
