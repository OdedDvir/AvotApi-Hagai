using System;
using System.Collections.Generic;

#nullable disable

namespace PuzzlesoftApi.Model
{
    public partial class TblFieldsList
    {
        public string FieldName { get; set; }
        public string FieldCaption { get; set; }
        public short? AppId { get; set; }
        public string ThemeKey { get; set; }
        public short? Id { get; set; }
        public string QueryName { get; set; }
    }
}
