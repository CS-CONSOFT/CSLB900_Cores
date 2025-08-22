namespace CSLB900.MSTools.GenerateId
{
    public class SCS_GenerateId : ICS_GenerateId
    {
        public string GenerateUuId()
        {
            var uuid = Guid.CreateVersion7().ToString("N");
            return "zzz" + uuid;
        }
    }
}
