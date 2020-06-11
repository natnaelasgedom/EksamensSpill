namespace EksamenSpill
{
    public interface IBrukergrensesnitt
    {
        void GiStatus(string status);
        int BeOmKommando(string spørsmål, string[] alternativet);
    }
}
