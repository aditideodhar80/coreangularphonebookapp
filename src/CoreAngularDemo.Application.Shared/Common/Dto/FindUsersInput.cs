using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}