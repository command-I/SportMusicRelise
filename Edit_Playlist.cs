//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportMusic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Edit_Playlist
    {
        public int id { get; set; }
        public int author { get; set; }
        public int playlist_id { get; set; }
        public string action { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Playlist Playlist { get; set; }
        public virtual SysUser SysUser { get; set; }
    }
}
