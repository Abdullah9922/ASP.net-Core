using Enum;

Member member = new Member
{
    Name = "Asif",
    Age = 18,
    Email = "example@gmail.com",
    Status = MemberShipStatus.Active
};

if (member.Status == MemberShipStatus.Active)
{
    Console.WriteLine("Member is active.");
}
else if (member.Status == MemberShipStatus.Inactive)
{
    Console.WriteLine("Member is inactive.");
}
else if (member.Status == MemberShipStatus.Blocked)
{
    Console.WriteLine("Member is blocked.");
}

int x = (int)member.Status;
Console.WriteLine(x);

MemberShipStatus status = (MemberShipStatus)x;
Console.WriteLine(status);
