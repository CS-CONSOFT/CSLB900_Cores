//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace CSCore.Domain.CS_Models.CSICP_SYS
//{
//    [Table("CSICP_SY001_BIO")]
//    public class CSICP_SY001_BIO
//    {
//        [Column("TENANT_ID", TypeName = "int")]
//        public int TENANT_ID { get; set; }

//        [Key]
//        [Column("ID", TypeName = "nvarchar(72)")]
//        public string ID { get; set; } = null!;

//        [Column("USUARIO_ID", TypeName = "nvarchar(72)")]
//        public string? USUARIO_ID { get; set; }

//        [Column("NOME", TypeName = "nvarchar(100)")]
//        public string? NOME { get; set; }

//        [Column("TIPO", TypeName = "nvarchar(100)")]
//        public string? TIPO { get; set; }

//        [Column("BIOMETRIA", TypeName = "varbinary(max)")]
//        public byte[]? BIOMETRIA { get; set; }

//        [Column("ISACTIVE", TypeName = "bit")]
//        public bool? ISACTIVE { get; set; }

//        [Column("BIOMETRIA_TEXTO", TypeName = "nvarchar(max)")]
//        public string? BIOMETRIA_TEXTO { get; set; }
//    }
//}
