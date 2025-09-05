namespace CSLB900.MSTools.CalculoAdicaoDataStrategy
{
    public interface IIncrementarDataStrategy
    {
        DateTime IncrementarData(DateTime Data, int intervaloParaAdicao);
    }
}
