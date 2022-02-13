namespace JWT_CQRS.Core.Application.DTO
{
    public class CheckUserResponseDto
    {
        public int Id { get; set; }
        public string Role { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsExist { get; set; } 
    }
}
