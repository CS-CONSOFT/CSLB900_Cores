using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.InterfaceBase;
using CSLB900.MSTools.Enumeradores;
using static CSLB900.MSTools.Enumeradores.EnumTipoRegistroGG008c;

namespace GG104Materiais.C82Application.Dto.GG00X.GG008.GG008c
{
    public class DtoCreateUpdateGG008c
    {
        public string? Gg008cFilialid { get; set; }

        public string? Gg008cProdutoid { get; set; }

        public int? Gg008cFilial { get; set; }

        public int? Gg008cCodgproduto { get; set; }

        public string? Gg008cDescricao { get; set; }

        public int? Gg008cOrdem { get; set; }

        public byte[]? Gg008cObjeto { get; set; }

        public string? Gg008cFiletype { get; set; }

        public string? Gg008cTexto { get; set; }

        public string? Filename { get; set; }

        public bool? Gg008cIspadrao { get; set; }

        public string? Gg008cPath { get; set; }

        public int? Gg008cSize { get; set; }

        public int? Gg008cCdnid { get; set; }

        public CSICP_GG008c ToEntity(int tenant, string? id, TIPO_REGISTRO_GG008c tipoRegistro)
        {
            string _tipoRegistro = VerificaTipoRegistroGG008c.RetornaStringDoTipoRegistroCorrepondente(tipoRegistro);
            return new CSICP_GG008c
            {
                TenantId = tenant,
                Id = id!,
                Gg008cFilialid = this.Gg008cFilialid,
                Gg008cProdutoid = this.Gg008cProdutoid,
                Gg008cFilial = this.Gg008cFilial,
                Gg008cCodgproduto = this.Gg008cCodgproduto,
                Gg008cDescricao = this.Gg008cDescricao,
                Gg008cOrdem = this.Gg008cOrdem,
                Gg008cTiporegistro = _tipoRegistro,
                Gg008cObjeto = this.Gg008cObjeto,
                Gg008cFiletype = this.Gg008cFiletype,
                Gg008cTexto = this.Gg008cTexto,
                Filename = this.Filename,
                Gg008cIspadrao = this.Gg008cIspadrao,
                Gg008cPath = this.Gg008cPath,
                Gg008cSize = this.Gg008cSize,
                Gg008cCdnid = this.Gg008cCdnid,

            };
        }
    }
}
