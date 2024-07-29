namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }//如果取名Id EFCore默認將是主鑑 型別為int默認為識別種子1開始遞增
        public required string UserName { get; set; }
    }
}