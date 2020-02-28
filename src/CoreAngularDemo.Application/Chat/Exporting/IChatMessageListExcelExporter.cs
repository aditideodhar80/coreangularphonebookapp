using System.Collections.Generic;
using CoreAngularDemo.Chat.Dto;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
