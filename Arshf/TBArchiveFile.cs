//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arshf
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBArchiveFile
    {
        public int ID { get; set; }
        public Nullable<int> IDArchive { get; set; }
        public string ArchDep { get; set; }
        public string ArchTitle { get; set; }
        public string ArchNumber { get; set; }
        public Nullable<System.DateTime> ArchDate { get; set; }
        public string ArchSender { get; set; }
        public string ArchReciver { get; set; }
        public string ArchDetails { get; set; }
        public string FileName1 { get; set; }
        public byte[] FileFile1 { get; set; }
        public string FileExt1 { get; set; }
        public Nullable<double> FileSize1 { get; set; }
        public string FileName2 { get; set; }
        public byte[] FileFile2 { get; set; }
        public string FileExt2 { get; set; }
        public Nullable<double> FileSize2 { get; set; }
        public string FileName3 { get; set; }
        public byte[] FileFile3 { get; set; }
        public string FileExt3 { get; set; }
        public Nullable<double> FileSize3 { get; set; }
        public string FileName4 { get; set; }
        public byte[] FileFile4 { get; set; }
        public string FileExt4 { get; set; }
        public Nullable<double> FileSize4 { get; set; }
        public string FileName5 { get; set; }
        public byte[] FileFile5 { get; set; }
        public string FileExt5 { get; set; }
        public Nullable<double> FileSize5 { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
    
        public virtual TBArchiveCategory TBArchiveCategory { get; set; }
    }
}
