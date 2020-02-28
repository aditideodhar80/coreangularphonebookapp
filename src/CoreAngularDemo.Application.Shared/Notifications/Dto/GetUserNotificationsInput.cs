using Abp.Notifications;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}