namespace CSCore.Ifs.Eventos.Repository
{
    public interface IGerarTree
    {
        Task<string?> CriarDocTree(int tenant, string docID, string docProtocolo, int docTIpo, string? docParentID);
    }
}
