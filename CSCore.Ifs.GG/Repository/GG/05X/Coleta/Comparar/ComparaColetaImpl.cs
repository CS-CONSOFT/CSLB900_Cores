using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Ifs.CS_Context;
using CSCore.Ifs.GG.Repository.GG._05X.Coleta.Comparar;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Ifs.GG.Repository.GG._05X
{


    public partial class ComparaColetaImpl : IComparaColeta
    {
        private readonly AppDbContext _appDbContext;
        public ComparaColetaImpl(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public async Task<(List<CSICP_GG055> ProdutosSoNaColeta01,
                   List<CSICP_GG055> ProdutosSoNaColeta02,
                   List<CSICP_GG055> ProdutosComQuantidadeDiferente,
                   List<CSICP_GG055> TodosOsProdutos)> CompararColeta(ParametrosCompararColeta prm)
        {
            CSICP_GG054? coletaGG054_01 = await GetQueryColeta(prm.NumeroProtocoloColeta01, prm.IdCC081_CD_Criar)
                .FirstOrDefaultAsync();

            CSICP_GG054? coletaGG054_02 = await GetQueryColeta(prm.NumeroProtocoloColeta02, prm.IdCC081_CD_Criar)
                .FirstOrDefaultAsync();

            VerificaSeAsColetaSaoNulasELancaExcecaoSeFor(coletaGG054_01, coletaGG054_02);
            VerificaSeAsColetasEstaoAbertasELancaExcecaoSeTiver(prm.IdCC081_CD_Criar, coletaGG054_01, coletaGG054_02);

            List<CSICP_GG055> listaProdutosColeta_01 = await GetQueryProdutosColeta(prm, coletaGG054_01).ToListAsync();
            List<CSICP_GG055> listaProdutosColeta_02 = await GetQueryProdutosColeta(prm, coletaGG054_02).ToListAsync();



            List<CSICP_GG055> produtosColeta01QueNaoEstaoNa02
                = listaProdutosColeta_01.Except(listaProdutosColeta_02).ToList();

            List<CSICP_GG055> produtosColeta02QueNaoEstaoNa01
               = listaProdutosColeta_02.Except(listaProdutosColeta_01).ToList();


            List<CSICP_GG055> listaTodosProdutos
                = listaProdutosColeta_01.Concat(listaProdutosColeta_02)
                .DistinctBy(e => e.Gg055ProdutoId).ToList();


            List<CSICP_GG055> listaProdutosQuantidadeDivergente = ObterProdutosComDivergenciaDeQuantidade(
                listaProdutosColeta_01,
                listaProdutosColeta_02,
                listaTodosProdutos
                );


            return (produtosColeta01QueNaoEstaoNa02,
            produtosColeta02QueNaoEstaoNa01,
            listaProdutosQuantidadeDivergente,
            listaTodosProdutos
            );
        }


        public List<CSICP_GG055> ObterProdutosComDivergenciaDeQuantidade(
            List<CSICP_GG055> coleta1,
            List<CSICP_GG055> coleta2,
            List<CSICP_GG055> listaTodosProdutos)
        {
            //key == produtoID
            //value == soma-qtd

            // Soma das quantidades dos produtos na Coleta 1, agrupados por ProdutoId
            Dictionary<string, decimal?> somaPorProdutoColeta1 = coleta1
                .GroupBy(p => p.Gg055ProdutoId!)
                .ToDictionary(g => g.Key, g => g.Sum(p => p.Gg055Quantidade));

            // Soma das quantidades dos produtos na Coleta 2, agrupados por ProdutoId
            Dictionary<string, decimal?> somaPorProdutoColeta2 = coleta2
                .GroupBy(p => p.Gg055ProdutoId!)
                .ToDictionary(g => g.Key, g => g.Sum(p => p.Gg055Quantidade));

            // Identifica os IDs dos produtos que têm divergência nas quantidades entre as duas coletas
            List<string> produtoIdsComDivergencia = somaPorProdutoColeta1

                .Where(produtoColeta1 => somaPorProdutoColeta2.TryGetValue(produtoColeta1.Key, out var quantidadeColeta2)
                        && produtoColeta1.Value != quantidadeColeta2)
                .Select(p => p.Key)
                .ToList();


            List<CSICP_GG055> produtosComDivergenciaQuantidade = listaTodosProdutos
                 .Where(produto => produtoIdsComDivergencia.Contains(produto.Gg055ProdutoId!))
                 .ToList();

            return produtosComDivergenciaQuantidade;

        }



        private static void VerificaSeAsColetasEstaoAbertasELancaExcecaoSeTiver(
           long IdGG054Sta_Aberto,
           CSICP_GG054? coleta01,
           CSICP_GG054? coleta02)
        {
            if (ColetaEstaAberta(IdGG054Sta_Aberto, coleta01!) == false) throw new Exception("Coleta 01 precisa está aberta");
            if (ColetaEstaAberta(IdGG054Sta_Aberto, coleta02!) == false) throw new Exception("Coleta 02 precisa está aberta");
        }

        private static bool ColetaEstaAberta(long IdGG054Sta_Aberto, CSICP_GG054 coleta01)
        {
            return coleta01!.Gg054Status == IdGG054Sta_Aberto;
        }

        private IQueryable<CSICP_GG055> GetQueryProdutosColeta(ParametrosCompararColeta prm, CSICP_GG054? coletaGG054_01)
        {
            return from _CSICP_GG055 in _appDbContext.OsusrE9aCsicpGg055s
                   where _CSICP_GG055.Gg054Id == coletaGG054_01!.Gg054Id
                   where _CSICP_GG055.Gg055Criarexcid == prm.IdCC081_CD_Criar
                   select new CSICP_GG055
                   {
                       Gg055Id = _CSICP_GG055.Gg055Id,
                       Gg054Id = _CSICP_GG055.Gg054Id,
                       Gg055Codgproduto = _CSICP_GG055.Gg055Codgproduto,
                       Gg055Codgbarras = _CSICP_GG055.Gg055Codgbarras,
                       Gg055Saldoid = _CSICP_GG055.Gg055Saldoid,
                       Gg055Unidade = _CSICP_GG055.Gg055Unidade,
                       Gg055Quantidade = _CSICP_GG055.Gg055Quantidade,
                       Gg055ProdutoId = _CSICP_GG055.Gg055ProdutoId,
                       Gg055UsuarioId = _CSICP_GG055.Gg055UsuarioId,
                   };
        }

        private IQueryable<CSICP_GG054> GetQueryColeta(string NumeroColeta, long IdCC081_CD_Criar)
        {
            var query = from _CSICP_GG054 in _appDbContext.OsusrE9aCsicpGg054s
                        join _CSICP_GG055 in _appDbContext.OsusrE9aCsicpGg055s
                        on _CSICP_GG054.Gg054Id equals _CSICP_GG055.Gg054Id

                        where _CSICP_GG054.Gg054Protocolnumber == NumeroColeta

                        select new CSICP_GG054
                        {
                            Gg054Id = _CSICP_GG054.Gg054Id,
                            Gg054Status = _CSICP_GG054.Gg054Status
                        };
            return query;
        }


        private static void VerificaSeAsColetaSaoNulasELancaExcecaoSeFor(CSICP_GG054? coleta01, CSICP_GG054? coleta02)
        {
            if (coleta01 == null)
                throw new KeyNotFoundException("Coleta 01 não encontrada");
            if (coleta02 == null)
                throw new KeyNotFoundException("Coleta 02 não encontrada");
        }

    }
}

