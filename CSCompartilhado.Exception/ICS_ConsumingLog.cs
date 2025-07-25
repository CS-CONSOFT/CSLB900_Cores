namespace CSCore.Ex
{
    public interface ICS_ConsumingLog
    {
        void CreateLogAsync(Dto_CreateLog dto, int tenant);
    }
}
