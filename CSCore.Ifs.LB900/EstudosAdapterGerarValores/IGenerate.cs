namespace CSCore.Ifs.LB900.AdapterGerarValores
{
    public interface IGenerate
    {
        public Task<string> Generate(string empresaID, string arquivo, string textName, int InTenantID);
    }
}
