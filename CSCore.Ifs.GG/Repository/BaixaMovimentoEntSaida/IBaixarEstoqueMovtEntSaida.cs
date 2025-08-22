using CSCore.Application.Dto;

namespace CSCore.Ifs.GG.Repository.Baixa
{
    public interface IBaixarEstoqueMovtEntSaida
    {
        Task CS001_Baixa_Movto_ENTSAI(ParametrosBaixaSaldo parametrosBaixaEstoque, int tenant, string in_usuarioID);
    }
}
