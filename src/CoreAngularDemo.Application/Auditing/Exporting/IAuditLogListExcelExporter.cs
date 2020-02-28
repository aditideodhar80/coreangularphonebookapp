using System.Collections.Generic;
using CoreAngularDemo.Auditing.Dto;
using CoreAngularDemo.Dto;

namespace CoreAngularDemo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
